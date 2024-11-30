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
    public partial class CosultasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {

            try
            {
                _DATOS.DataSource = DataLayer.Consulta.ConsultaMedicas();
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
                    _DATOS.Filter = "NombresPaciente like '%" + txtFiltrar.Text + "%'";
                }
                dgvConsultas.AutoGenerateColumns = false;
                dgvConsultas.DataSource = _DATOS;
            }
            catch (Exception)
            {


            }
        }
        public CosultasGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultasEdicion f = new ConsultasEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception) { }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar este Registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConsultasEdicion f = new ConsultasEdicion();


                    f.txtID_Consulta.Text = dgvConsultas.CurrentRow.Cells["ID_Consulta"].Value.ToString();
                    f.cbbID_Receta.Text = dgvConsultas.CurrentRow.Cells["ID_Receta"].Value.ToString();
                    f.cbbIdcita.Text = dgvConsultas.CurrentRow.Cells["ID_Cita"].Value.ToString();
                    f.cbbID_doctor.Text = dgvConsultas.CurrentRow.Cells["ID_Doctor"].Value.ToString();
                    f.cbbConsultorio.Text = dgvConsultas.CurrentRow.Cells["ID_Consultorio"].Value.ToString();
                    f.txtDignostico.Text = dgvConsultas.CurrentRow.Cells["Diagnostico"].Value.ToString();
                    f.txtIndicaciones.Text = dgvConsultas.CurrentRow.Cells["Indicaciones"].Value.ToString();


                    f.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CosultasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Citas_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Consulta f = new Consulta();
                    f.ID_Consulta = Convert.ToInt32(dgvConsultas.CurrentRow.Cells["ID_Consulto"].Value.ToString());
                    if (f.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cargar();
                }
            }
            catch { }
        }
    }
}
