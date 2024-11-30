using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIEdicion
{
    public partial class MedicamentosEdicion : Form
    {
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombresMedicamento.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtNombresMedicamento, "Este campo no puede quedar vacío.");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }

        public MedicamentosEdicion()
        {
            InitializeComponent();
        }

        private void MedicamentosEdicion_Load(object sender, EventArgs e)
        {

        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.Medicamento oMedicamento = new CLS.Medicamento();
                    try
                    {
                        oMedicamento.ID_Medicamento = Convert.ToInt32(txtIdMedicamento.Text);
                    }
                    catch (Exception)
                    {
                        oMedicamento.ID_Medicamento = 0;
                    }
                    //asignacion de los textbox a las variables de clase        
                    oMedicamento.Med_Nombre = txtNombresMedicamento.Text;
                    oMedicamento.Med_Cantidad = Convert.ToInt32(txtCantidad.Text);
                    oMedicamento.Med_Descripcion = txtDescripcion.Text;
                    oMedicamento.Med_PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                    oMedicamento.Med_FechaVen = dtpFechaVen.Value;

                    if (txtIdMedicamento.Text.Trim().Length == 0)
                    {
                        //Guardar los datos ingresados
                        if (oMedicamento.Insertar())
                        {
                            MessageBox.Show("Medicamento Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("!ERROR¡: El Medicamento no se puede registrar verifique la informacion");
                        }
                    }
                    else
                    {
                        if (oMedicamento.Actualizar())
                        {
                            MessageBox.Show("Datos del Medicamento Actualizados");
                            Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
