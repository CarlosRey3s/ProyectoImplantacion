using General.CLS;
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
    public partial class ListaPaciente : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = Factura.Paciente_vw();
                dgvPacientes.DataSource = _DATOS;
                dgvPacientes.AutoGenerateColumns = false;
                FiltrarLocalmente();
            }
            catch (Exception)
            { }
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
                    _DATOS.Filter = "Pac_Nombre like '%" + txtFiltro.Text + "%'";
                }
                dgvPacientes.AutoGenerateColumns = false;
                dgvPacientes.DataSource = _DATOS;
            }
            catch (Exception)
            { }
        }
        public ListaPaciente()
        {
            InitializeComponent();
            Cargar();

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int ID_PacienteSeleccionado { get; private set; }
        public String NombrePacienteSeleccionado { get; private set; }



        private void ListaPaciente_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            string nombrepaciente;
            string Apellidopaciente;
            // Suponiendo que se ha seleccionado un paciente en la lista
            ID_PacienteSeleccionado = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["ID_Paciente"].Value);
            nombrepaciente = dgvPacientes.CurrentRow.Cells["Pac_Nombre"].Value.ToString();
            Apellidopaciente = dgvPacientes.CurrentRow.Cells["Pac_Apellido"].Value.ToString();
            NombrePacienteSeleccionado = nombrepaciente + " " + Apellidopaciente;
            DialogResult = DialogResult.OK; // Confirmar selección
            Close();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
