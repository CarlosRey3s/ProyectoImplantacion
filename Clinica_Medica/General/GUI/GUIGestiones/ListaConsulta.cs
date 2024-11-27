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
    public partial class ListaConsulta : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = Factura.spConsulta();
                dgvPacientes.DataSource = _DATOS;
                dgvPacientes.AutoGenerateColumns = false;
            }
            catch (Exception)
            { }
        }
        public ListaConsulta()
        {
            InitializeComponent();
            Cargar();
        }

        private void ListaConsulta_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public int ID_ConsultaSeleccionado { get; private set; }
        public int Cons_PrecioConsultaSeleccionado { get; private set; }
        public string DoctoNombreSeleccionado { get; private set;}




        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            // Suponiendo que se ha seleccionado un paciente en la lista
            ID_ConsultaSeleccionado = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["ID_Consulta"].Value);
            Cons_PrecioConsultaSeleccionado = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Cons_PrecioConsulta"].Value);
            DoctoNombreSeleccionado = Convert.ToString(dgvPacientes.CurrentRow.Cells["Doctor_NombreCompleto"].Value);
            DialogResult = DialogResult.OK; // Confirmar selección
            Close();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
