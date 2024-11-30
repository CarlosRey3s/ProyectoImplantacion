using General.CLS;
using General.GUI.GUIEdicion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIGestiones
{
    public partial class PacientesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Paciente();
                FiltrarLocalmente();
            }
            catch (Exception)
            {
                
            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.Text.Trim().Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    string filtro = txtFiltro.Text.Trim();
                    _DATOS.Filter = $"[Pac_Nombre] LIKE '%{filtro}%'";

                }
                dgvPacientes.AutoGenerateColumns = false;
                dgvPacientes.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public PacientesGestion()
        {
            InitializeComponent();
        }
        private void PacientesGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = dgvPacientes.Rows.Count.ToString();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesEdicion f = new PacientesEdicion();
                f.ShowDialog();
                Cargar();
                lblRegistros.Text = dgvPacientes.Rows.Count.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea eliminar esta cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Obtener el ID del paciente seleccionado
                    Paciente paciente = new Paciente();
                    paciente.ID_Paciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["ID_Paciente"].Value.ToString());

                    // Intentar eliminar
                    if (paciente.Eliminar())
                    {
                        MessageBox.Show("Cuenta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar(); // Recargar los datos en el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("La cuenta no pudo ser eliminada. Revisa si tiene dependencias en otras tablas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea modificar esta cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PacientesEdicion pacientesEdicion = new PacientesEdicion();

                    // Sincronizamos la información del DataGridView con el formulario de edición
                    pacientesEdicion.txtIdPaciente.Text = dgvPacientes.CurrentRow.Cells["ID_Paciente"].Value.ToString();
                    pacientesEdicion.txtNombresPaciente.Text = dgvPacientes.CurrentRow.Cells["Pac_Nombre"].Value.ToString();
                    pacientesEdicion.txtApellidosPaciente.Text = dgvPacientes.CurrentRow.Cells["Pac_Apellido"].Value.ToString();
                    pacientesEdicion.dtpFechaNac.Value = DateTime.Parse(dgvPacientes.CurrentRow.Cells["Pac_FechaNacimiento"].Value.ToString());
                    pacientesEdicion.cbGenero.Text = dgvPacientes.CurrentRow.Cells["Pac_Genero"].Value.ToString();
                    pacientesEdicion.txtTelefono.Text = dgvPacientes.CurrentRow.Cells["Pac_Telefono"].Value.ToString();
                    pacientesEdicion.txtCorreoElectronico.Text = dgvPacientes.CurrentRow.Cells["Pac_CorreoElectronico"].Value.ToString();
                    pacientesEdicion.txtDireccion.Text = dgvPacientes.CurrentRow.Cells["Pac_Direccion"].Value.ToString();

                    pacientesEdicion.ShowDialog(); // Mostrar el formulario de edición

                    // Recargar los datos después de cerrar el formulario de edición
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            // Implementación del evento Click del filtro
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TotalEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CosultasGestion c = new CosultasGestion();
            c.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CitasGestion c = new CitasGestion();
            c.ShowDialog();
        }

        private void dgvPacientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
