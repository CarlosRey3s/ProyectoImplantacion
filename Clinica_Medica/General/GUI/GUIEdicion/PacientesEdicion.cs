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
    public partial class PacientesEdicion : Form
    {
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombresPaciente.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtNombresPaciente, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public PacientesEdicion()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try { 
                if(Validar())
                {
                    CLS.Paciente opaciente = new CLS.Paciente();
                    try
                    {
                        opaciente.ID_Paciente = Convert.ToInt32(txtIdPaciente.Text);
                    }catch(Exception) { 
                        opaciente.ID_Paciente=0;
                    }
                    //asignacion de los textbox a las variables de clase        
                    opaciente.Nombre = txtNombresPaciente.Text;
                    opaciente.Apellido = txtApellidosPaciente.Text;
                    opaciente.FechaNacimiento = dtpFechaNac.Value;
                    opaciente.Genero = cbGenero.Text;
                    opaciente.Telefono = txtTelefono.Text;
                    opaciente.CorreoElectronico = txtCorreoElectronico.Text;
                    opaciente.Direccion = txtDireccion.Text;
                    if(txtIdPaciente.Text.Trim().Length == 0)
                    {
                        //Guardar los datos ingresados
                        if(opaciente.Insertar())
                        {
                            MessageBox.Show("Paciente Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("!ERROR¡: El paciente no se puede registrar verifique la informacion");
                        }
                    }
                    else
                    {
                        if (opaciente.Actualizar())
                        {
                            MessageBox.Show("Datos del Paciente Actualizados");
                            Close();
                        }
                    }
                }
            }catch (Exception) {
            }
        }
        private void PacientesEdicion_Load(object sender, EventArgs e)
        {}
        private void txtNombresPaciente_TextChanged(object sender, EventArgs e)
        {}
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
