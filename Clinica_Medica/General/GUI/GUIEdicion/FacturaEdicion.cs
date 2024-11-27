using General.CLS;
using General.Controladores;
using General.GUI.GUIGestiones;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace General.GUI.GUIEdicion
{
    public partial class FacturaEdicion : Form
    {
        BindingSource _DATOS = new BindingSource();
        Factura factura1 = new Factura();
        int id;
        Decimal precioUnitario;
        Decimal Subtotal;
        int Cantidad;
        Decimal Total;
        Decimal descuento;
        Decimal SubTotalMed;

        private Decimal precioConsulta { set; get; } 

        private Int32 ID_Facturav2 { set; get; }


        private void Cargar()
        {
            try
            {
                // Obtener los datos de la base de datos y cargar en el DataGridView
                _DATOS.DataSource = DataLayer.Consulta.ObternerDetalleFac(ID_Facturav2);
                dgvDetallesFactura.DataSource = _DATOS;

                // Iterar sobre todas las filas del DataGridView
                foreach (DataGridViewRow row in dgvDetallesFactura.Rows)
                {
                    // Verificar si la celda "Total" tiene un valor válido
                    if (row.Cells["Det_Total"]?.Value != null && row.Cells["Det_Total"].Value != DBNull.Value)
                    {
                        // Sumar el valor de la celda "Total"
                        SubTotalMed += Convert.ToDecimal(row.Cells["Det_Total"].Value);
                    }
                    else
                    {
                        // Si no hay valor, sumar 0
                        SubTotalMed += 0;
                    }
                }

                // Extraer solo el número del Label lbPrecioConsulta (sin el signo de dólar)
                decimal precioConsulta = 0;
                if (decimal.TryParse(lbPrecioConsulta.Text.Replace("$", "").Trim(), out precioConsulta))
                {
                    // Ahora puedes usar precioConsulta para calcular el total
                    lbSubtotal.Text = "$" + SubTotalMed.ToString("0.00");
                    lbTotal.Text = "$" + (SubTotalMed + precioConsulta).ToString("0.00");
                    SubTotalMed = 0;
                    precioConsulta = 0;
                }
                else
                {
                    // Si no se puede convertir el texto en un número, mostrar un mensaje o manejar el error
                    MessageBox.Show("El precio de consulta no es válido.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles: {ex.Message}");
            }
        }

        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNumeroFactura.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtNumeroFactura, "Este campo no puede quedar vacio");
                    Valido = false;
                }
                if (cbbMetodoPago.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbbMetodoPago, "Este campo no puede quedar vacio");
                    Valido = false;
                    
                }
                if (txtID_Paciente.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtID_Paciente, "Este campo no puede quedar vacio");
                    Valido = false;
                    
                }
                if (txtConsulta.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtConsulta, "Este campo no puede quedar vacio");
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
            Cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
        
        private void FacturaEdicion_Load(object sender, EventArgs e)
        {
            Cargar();
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombresPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay detalles en el DataGridView
                if (dgvDetallesFactura.Rows.Count == 0)
                {
                    MessageBox.Show("No se han agregado detalles a la factura. Agregue al menos un detalle antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si no hay detalles
                }

                // Preguntar al usuario si desea guardar la información
                var confirmacion = MessageBox.Show("¿Está seguro de que desea guardar la información?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Lógica para guardar la información
                    // Aquí puedes incluir el código para guardar la factura y los detalles en la base de datos
                    MessageBox.Show("La información se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("La operación de guardado ha sido cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones inesperadas
                MessageBox.Show($"Ocurrió un error al intentar guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void SelecionarCliente_Click(object sender, EventArgs e)
        {
            // Instancia de ListaPaciente
            ListaPaciente listaPacienteForm = new ListaPaciente();

            // Mostrar el formulario ListaPaciente como un cuadro de diálogo
            if (listaPacienteForm.ShowDialog() == DialogResult.OK)
            {
                // Acceder al ID del paciente seleccionado
                txtID_Paciente.Text = listaPacienteForm.ID_PacienteSeleccionado.ToString();
                lbNombreCliente.Text = listaPacienteForm.NombrePacienteSeleccionado.ToString();
            }
        }


        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarConsulta_Click(object sender, EventArgs e)
        {
            // Instancia de ListaConsulta
            ListaConsulta listaConsultaForm = new ListaConsulta();

            // Mostrar el formulario ListaConsulta como un cuadro de diálogo
            if (listaConsultaForm.ShowDialog() == DialogResult.OK)
            {
                // Acceder al ID del la Consulta seleccionado
                txtConsulta.Text = listaConsultaForm.ID_ConsultaSeleccionado.ToString();
                lbDoc.Text = listaConsultaForm.DoctoNombreSeleccionado.ToString();
                precioConsulta = Convert.ToDecimal(listaConsultaForm.Cons_PrecioConsultaSeleccionado.ToString());
                lbPrecioConsulta.Text = "$" + precioConsulta.ToString();


            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecetaMedicamentos_Click(object sender, EventArgs e)
        {
            // Verificar si el campo txtConsulta no está vacío
            if (string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de consulta válido.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si el campo está vacío
            }

            int IDConsulta;
            string Medicamento;
            // Intentar convertir el valor a int
            if (int.TryParse(txtConsulta.Text, out IDConsulta))
            {
                // Instancia de ListaConsulta pasando IDConsulta como parámetro
                ListaMedicamentos listaMedicamentoForm = new ListaMedicamentos(IDConsulta);

                // Mostrar el formulario ListaConsulta como un cuadro de diálogo
                if (listaMedicamentoForm.ShowDialog() == DialogResult.OK)
                {
                    // Acceder al ID del Medicamento seleccionado
                    txtIDMedicamento.Text = listaMedicamentoForm.ID_MedicamentoSeleccionado.ToString();
                    txtMedicamento.Text = listaMedicamentoForm.NombreMedicamentoSeleccionado.ToString();
                    precioUnitario = Convert.ToDecimal(listaMedicamentoForm.PrecioUnitarioSeleccionado.ToString());
                    lbPrecioUnitario.Text = precioUnitario.ToString();
                   
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de consulta válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (0-9) y la tecla de retroceso (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
        }

        private void dgvDetallesFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar()) // Validar si los datos son correctos
                {
                    CLS.Factura oFactura = new CLS.Factura();
                    CLS.FacturaDetalle facturaDetalle = new CLS.FacturaDetalle();
                    Controladores.ControladorFactura cfactura = new Controladores.ControladorFactura();

                    // Intentar convertir el ID de la factura; asignar 0 si falla
                    oFactura.ID_Factura = string.IsNullOrWhiteSpace(txtIdFactura.Text) ? 0 : Convert.ToInt32(txtIdFactura.Text);

                    // Validar y asignar el resto de los campos

                    try
                    {
                        oFactura.NumeroFactura = Convert.ToDecimal(txtNumeroFactura.Text);
                        oFactura.Fecha = dtpFecha.Value;
                        oFactura.MetodoPago = cbbMetodoPago.Text;
                        oFactura.ID_Paciente = Convert.ToInt32(txtID_Paciente.Text);
                        oFactura.ID_Consulta = Convert.ToInt32(txtConsulta.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en los datos: {ex.Message}");
                        return;
                    }

                    // Verificar si se está guardando una nueva factura o actualizando
                    if (oFactura.ID_Factura == 0) // Si es una nueva factura
                    {
                        if (cfactura.Insertar(oFactura))
                        {
                            MessageBox.Show("Factura Generada");
                            txtIdFactura.Text = Convert.ToString(cfactura.ObtenerID(1));
                            ID_Facturav2 = Convert.ToInt32(txtIdFactura.Text);
                            //Close();
                            Cargar();
                        }
                        else
                        {
                            MessageBox.Show("¡ERROR!: La factura no se pudo Generar. Verifique la información.");
                        }
                    }
                    else // Si se está actualizando una factura
                    {
                        if (cfactura.Actualizar(oFactura))
                        {
                            MessageBox.Show("Datos de la Factura Actualizados");
                            ID_Facturav2 = Convert.ToInt32(txtIdFactura.Text);
                            Cargar();
                            // Close();
                        }
                        else
                        {
                            MessageBox.Show("¡ERROR!: La factura no se pudo actualizar. Verifique la información.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"¡ERROR inesperado! {ex.Message}");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.FacturaDetalle detalle = new CLS.FacturaDetalle();
                    Controladores.ControladorDetalle cdetalle = new Controladores.ControladorDetalle();
                    CLS.Factura factura = new CLS.Factura();

                    // Intentar convertir el ID de la factura; asignar 0 si falla
                    factura.ID_Factura = string.IsNullOrWhiteSpace(txtIdFactura.Text) ? 0 : Convert.ToInt32(txtIdFactura.Text);

                    // Realizar cálculos antes de asignar valores
                    if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                    {
                        MessageBox.Show("El campo de cantidad no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir si la cantidad está vacía
                    }

                    try
                    {
                        // Convertir valores ingresados
                        Cantidad = Convert.ToInt32(txtCantidad.Text);
                        Subtotal = Cantidad * precioUnitario; // precioUnitario debe ser una variable definida
                        lbSubtotal.Text = "$" + Subtotal.ToString(); // Mostrar el subtotal

                        // Calcular descuento y total
                        int descuentoPorcentaje = Convert.ToInt32(ccbDesc.Text);
                        Total = Subtotal - (Subtotal * descuentoPorcentaje / 100);
                        lbTotal.Text = "$" + Total.ToString(); // Mostrar el total
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir si hay un error en los cálculos
                    }

                    // Validar y asignar el resto de los campos
                    try
                    {
                        detalle.Cantidad1 = Cantidad;
                        detalle.Descuento1 = Convert.ToDecimal(ccbDesc.Text);
                        detalle.SubTotal1 = Subtotal;
                        detalle.Total1 = Total;
                        detalle.Facturas_ID_Factura1 = Convert.ToInt32(txtIdFactura.Text);
                        detalle.Medicamentos_ID_Medicamento1 = Convert.ToInt32(txtIDMedicamento.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en los datos: {ex.Message}");
                        return;
                    }

                    // Verificar si el medicamento ya está registrado en el BindingSource
                    foreach (DataGridViewRow row in dgvDetallesFactura.Rows)
                    {
                        if (row.Cells["ID_Medicamento"].Value != null &&
                            Convert.ToInt32(row.Cells["ID_Medicamento"].Value) == Convert.ToInt32(txtIDMedicamento.Text))
                        {
                            MessageBox.Show("El medicamento ya está registrado en esta factura. No se puede duplicar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (factura.ID_Factura > 0)
                    {
                        if (cdetalle.Insertar(detalle))
                        {
                            MessageBox.Show("Se ha agregado el medicamento correctamente.");

                            // Limpiar los campos después de insertar exitosamente
                            txtCantidad.Text = string.Empty;
                            txtMedicamento.Text = string.Empty;
                            txtIDMedicamento.Text = string.Empty;
                            lbPrecioUnitario.Text = "$" + 0.00;
                            Subtotal = 0; // Asegúrate de que Subtotal sea una variable accesible
                            Total = 0;    // Asegúrate de que Total sea una variable accesible
                            lbSubtotal.Text = "$" + 0.00; // Si tienes un campo de texto para Subtotal
                            lbTotal.Text = "$" + 0.00;    // Si tienes un campo de texto para Total
                            Cargar(); // Recargar el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("¡ERROR!: El detalle no se pudo registrar. Verifique la información.");
                        }
                    }
                    else // Si se está actualizando
                    {
                        MessageBox.Show("Actualizar aún no está implementado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }


        private void lbPrecioConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (dgvDetallesFactura.CurrentRow == null || dgvDetallesFactura.CurrentRow.Cells["ID_DetalleFactura"].Value == null || string.IsNullOrEmpty(dgvDetallesFactura.CurrentRow.Cells["ID_DetalleFactura"].Value.ToString()))
                    {
                        MessageBox.Show("No se ha seleccionado un detalle de factura válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int IDFactura = Convert.ToInt32(dgvDetallesFactura.CurrentRow.Cells["ID_DetalleFactura"].Value.ToString());
                    var Controller = new ControladorDetalle();

                    bool eliminado = Controller.EliminarDetalleFactura(IDFactura);

                    if (eliminado)
                    {
                        MessageBox.Show("El medicamento ha sido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El medicamento no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
