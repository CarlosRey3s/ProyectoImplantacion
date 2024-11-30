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
                    Notificador.SetError(txtNombresPaciente, "Este campo no puede quedar vacío");
                    Valido = false;
                }

                if (txtApellidosPaciente.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtApellidosPaciente, "Este campo no puede quedar vacío");
                    Valido = false;
                }

                if (dtpFechaNac.Value == null || dtpFechaNac.Value > DateTime.Now)
                {
                    Notificador.SetError(dtpFechaNac, "Fecha de nacimiento no válida");
                    Valido = false;
                }

                if (cbGenero.SelectedItem == null)
                {
                    Notificador.SetError(cbGenero, "Debe seleccionar un género");
                    Valido = false;
                }

                if (txtTelefono.Text.Trim().Length != 10 || !txtTelefono.Text.All(char.IsDigit))
                {
                    Notificador.SetError(txtTelefono, "Número de teléfono no válido. Debe contener 10 dígitos");
                    Valido = false;
                }

                if (txtCorreoElectronico.Text.Trim().Length == 0 || !txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains("."))
                {
                    Notificador.SetError(txtCorreoElectronico, "Correo electrónico no válido");
                    Valido = false;
                }

                if (txtDireccion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtDireccion, "Este campo no puede quedar vacío");
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
            try
            {
                if (Validar())
                {
                    CLS.Paciente opaciente = new CLS.Paciente();

                    // Sincronizamos los datos del formulario con el objeto de la clase
                    opaciente.ID_Paciente = string.IsNullOrWhiteSpace(txtIdPaciente.Text) ? 0 : Convert.ToInt32(txtIdPaciente.Text);
                    opaciente.Nombre = txtNombresPaciente.Text.Trim();
                    opaciente.Apellido = txtApellidosPaciente.Text.Trim();
                    opaciente.FechaNacimiento = dtpFechaNac.Value;
                    opaciente.Genero = cbGenero.Text;
                    opaciente.Telefono = txtTelefono.Text.Trim();
                    opaciente.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                    opaciente.Direccion = txtDireccion.Text.Trim();

                    // Determinamos si es una inserción o una actualización
                    if (opaciente.ID_Paciente == 0)
                    {
                        if (opaciente.Insertar())
                        {
                            MessageBox.Show("Paciente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el paciente. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (opaciente.Actualizar())
                        {
                            MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el paciente. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
