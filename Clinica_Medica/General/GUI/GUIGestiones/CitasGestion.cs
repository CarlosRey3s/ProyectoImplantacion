using General.CLS;
using General.GUI.GUIEdicion;
using General.Controlador;
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
    public partial class CitasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        private ControladorCitas controladorCitas = new ControladorCitas(); // Instancia del controlador

        private void Cargar()
        {

            try
            {
                // Usamos el controlador para obtener las citas
                _DATOS.DataSource = controladorCitas.ObtenerCitas();
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
                if (txtFiltrar.Text.Trim().Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    _DATOS.Filter = "Pac_Nombre like'%" + txtFiltrar.Text + "%'";
                }
                dgvCitas.AutoGenerateColumns = false;
                dgvCitas.DataSource = _DATOS;
            }
            catch (Exception)
            {


            }

        }
        public CitasGestion()
        {
            InitializeComponent();
            Cargar();
            //ContarEmpleados();

        }

        private void CitasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            Registro.Text = dgvCitas.Rows.Count.ToString();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una cita para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea modificar esta Cita?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CitasEdicion f = new CitasEdicion();

                    // Sincronizar datos del DataGridView con el formulario
                    f.txtdCita.Text = dgvCitas.CurrentRow.Cells["ID_Cita"].Value.ToString();
                    f.dtpFecha_Hora.Value = DateTime.Parse(dgvCitas.CurrentRow.Cells["Cit_FechaHora"].Value.ToString());
                    f.txtMotivo.Text = dgvCitas.CurrentRow.Cells["Cit_Motivo"].Value.ToString();
                    f.txtEstado.Text = dgvCitas.CurrentRow.Cells["Cit_Estado"].Value.ToString();

                    f.cbDoctores.SelectedValue = dgvCitas.CurrentRow.Cells["Doctores_ID_Doctor"].Value;
                    f.cbConsultorios.SelectedValue = dgvCitas.CurrentRow.Cells["Consultorios_ID_Consultorio"].Value;

                    f.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar modificar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar una cita
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cita?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Citas cita = new Citas();
                    cita.ID_Cita = Convert.ToInt32(dgvCitas.CurrentRow.Cells["ID_Cita"].Value.ToString());

                    if (controladorCitas.EliminarCita(cita)) // Usamos el controlador para eliminar la cita
                    {
                        MessageBox.Show("Cita eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La cita no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insertar una nueva cita
        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                CitasEdicion f = new CitasEdicion();
                f.ShowDialog();
                Cargar();
                MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento al hacer clic en una celda del DataGridView
        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Consultar citas
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            CosultasGestion c = new CosultasGestion();
            c.ShowDialog();
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
           
        }
        private void ContarEmpleados()
        {
            int totalEmpleados = dgvCitas.RowCount;
            Registro.Text = totalEmpleados.ToString();
        }
    }
}