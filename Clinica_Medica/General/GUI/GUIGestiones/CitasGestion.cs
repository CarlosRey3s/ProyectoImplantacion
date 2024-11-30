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
    public partial class CitasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {

            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Citas();
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
            ContarEmpleados();

        }

        private void CitasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar esta Cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CitasEdicion f = new CitasEdicion();


                    f.txtID_Cita.Text = dgvCitas.CurrentRow.Cells["ID_Cita"].Value.ToString();
                    f.cbbNombresPacientes.Text = dgvCitas.CurrentRow.Cells["ID_Paciente"].Value.ToString();
                    f.dtpFecha_Hora.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["Fecha_Hora"].Value);


                    f.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Citas f = new Citas();
                    f.ID_Cita = Convert.ToInt32(dgvCitas.CurrentRow.Cells["ID_Cita"].Value.ToString());

                    if (f.Eliminar())
                    {
                        MessageBox.Show("Cuenta eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La cuenta no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                CitasEdicion f = new CitasEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            CosultasGestion c = new CosultasGestion();
            c.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FacturaGestion c = new FacturaGestion();
            c.ShowDialog();
        }

        private void ContarEmpleados()
        {
            int totalEmpleados = dgvCitas.RowCount;
            Registro.Text = totalEmpleados.ToString();
        }

    }
}
