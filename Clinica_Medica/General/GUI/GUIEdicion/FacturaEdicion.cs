using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIEdicion
{
    public partial class FacturaEdicion : Form
    {
        BindingSource _Datos = new BindingSource();

        List<FacturaDetalle> detallesFactura = new List<FacturaDetalle>();
        private void LlenarComboBoxCargos()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.ConsultaMedicas();
                cbbIDConsulta.DataSource = _Datos;
                cbbIDConsulta.DisplayMember = "ApellidosPaciente";
                cbbIDConsulta.ValueMember = "ID_Consulta";
            }
            catch (Exception ex)
            {

            }                // Manejo de excepciones
            
        }

        private Boolean Validar()
        {
            BindingSource _Datos = new BindingSource();

            Boolean Valido = true;
            try
            {
                if (cbbIDConsulta.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbbIDConsulta, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public FacturaEdicion()
        {
            InitializeComponent();
            LlenarComboBoxCargos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // CREAR UN OBJETO A PARTIR DE LA CLASE ENTIDAD
                    CLS.Factura oFactura = new CLS.Factura();
                    // SINCRONIZAMOS EL OBJETO CON LA GUI

                    try
                    {
                        oFactura.ID_Factura = Convert.ToInt32(txtID_Factura.Text);
                    }
                    catch (Exception)
                    {
                        oFactura.ID_Factura = 0;
                    }

                    // Obtener el ID del medicamento desde el TextBox
                    int selecdIDMedicamento = 0;
                    if (!string.IsNullOrEmpty(txtMedicamento.Text))
                    {
                        selecdIDMedicamento = Convert.ToInt32(txtMedicamento.Text);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese el ID del medicamento.");
                        return;
                    }

                    oFactura.ID_Consulta = (int)cbbIDConsulta.SelectedValue;
                    oFactura.Concepto = txtConcepto.Text;
                    oFactura.Monto = Convert.ToDecimal(txtMonto.Text);

                    // Calcular el subtotal
                    decimal monto = oFactura.Monto;
                    decimal subtotal = monto * 0.13m;
                    oFactura.Subtotal = subtotal;

                    oFactura.FechaEmision = dtpFechaEmision.Value;
                    oFactura.FechaPago = dtpFechaPago.Value;
                    oFactura.MetodoPago = cbbMetodoPago.Text;

                    // PROCEDER
                    if (txtID_Factura.Text.Trim().Length == 0)
                    {
                        // GUARDAR NUEVO REGISTRO
                        if (oFactura.Insertar())
                        {
                            // INSERTAR LOS DETALLES DE LA FACTURA
                            foreach (var detalle in detallesFactura)
                            {
                                bool detalleInsertado = false;

                                // Verificar si el detalle pertenece al medicamento seleccionado
                                if (detalle.ID_Insumo == selecdIDMedicamento)
                                {
                                    CLS.FacturaDetalle oDetalle = new CLS.FacturaDetalle();
                                    oDetalle.ID_Factura = oFactura.ID_Factura;
                                    oDetalle.ID_Insumo = detalle.ID_Insumo;
                                    oDetalle.Cantidad = detalle.Cantidad;
                                    oDetalle.PrecioUnitario = detalle.PrecioUnitario;

                                    if (!oDetalle.Insertar())
                                    {
                                        MessageBox.Show("El detalle de la factura no pudo ser almacenado");
                                        return;
                                    }

                                    // Actualizar la cantidad vendida en la tabla de medicamentos
                                    if (!ActualizarCantidadVendida(detalle.ID_Insumo, detalle.Cantidad))
                                    {
                                        MessageBox.Show("Error al actualizar la cantidad vendida en la tabla de medicamentos");
                                        return;
                                    }

                                    // No es necesario verificar si el detalle ya ha sido insertado, simplemente marcarlo como insertado
                                    detalleInsertado = true;
                                }
                            }
                            MessageBox.Show("Registro Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser almacenado");
                        }
                    }
                    else
                    {
                        // ACTUALIZAR REGISTRO
                        if (oFactura.Actualizar())
                        {
                            // ACTUALIZAR LOS DETALLES DE LA FACTURA
                            // Primero eliminar los detalles existentes
                            foreach (var detalle in detallesFactura)
                            {
                                CLS.FacturaDetalle oDetalle = new CLS.FacturaDetalle();
                                oDetalle.ID_Factura = oFactura.ID_Factura;

                                if (!oDetalle.Eliminar())
                                {
                                    MessageBox.Show("El detalle de la factura no pudo ser eliminado");
                                    return;
                                }
                            }

                            // Luego insertar los nuevos detalles
                            bool detalleInsertado = false;
                            foreach (var detalle in detallesFactura)
                            {
                                // Verificar si el detalle pertenece al medicamento seleccionado
                                if (detalle.ID_Insumo == selecdIDMedicamento)
                                {
                                    // Verificar si ya se ha insertado un detalle para este medicamento
                                    if (!detalleInsertado)
                                    {
                                        CLS.FacturaDetalle oDetalle = new CLS.FacturaDetalle();
                                        oDetalle.ID_Factura = oFactura.ID_Factura;
                                        oDetalle.ID_Insumo = detalle.ID_Insumo;
                                        oDetalle.Cantidad = detalle.Cantidad;
                                        oDetalle.PrecioUnitario = detalle.PrecioUnitario;

                                        if (!oDetalle.Insertar())
                                        {
                                            MessageBox.Show("El detalle de la factura no pudo ser almacenado");
                                            return;
                                        }

                                        // Actualizar la cantidad vendida en la tabla de medicamentos
                                        if (!ActualizarCantidadVendida(detalle.ID_Insumo, detalle.Cantidad))
                                        {
                                            MessageBox.Show("Error al actualizar la cantidad vendida en la tabla de medicamentos");
                                            return;
                                        }

                                        // Marcar que se ha insertado el detalle para evitar inserciones adicionales
                                        detalleInsertado = true;
                                    }
                                }
                            }
                            MessageBox.Show("Registro Actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private bool ActualizarCantidadVendida(int idInsumo, int cantidadVendida)
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            // Construir la sentencia SQL para actualizar la cantidad vendida en la tabla de medicamentos
            sentencia.Append("UPDATE Medicamentos SET ");
            sentencia.Append("CantidadVendida = CantidadVendida + " + cantidadVendida + ", "); // Sumar la cantidad vendida actual
            sentencia.Append("CantidadDisponible = CantidadDisponible - " + cantidadVendida + " "); // Restar la cantidad vendida a la cantidad disponible
            sentencia.Append("WHERE ID_Insumo = " + idInsumo + ";");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FacturaEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
