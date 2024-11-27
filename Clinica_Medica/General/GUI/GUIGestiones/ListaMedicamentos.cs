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
    public partial class ListaMedicamentos : Form
    {
        BindingSource _DATOS = new BindingSource();
        private int _IDConsulta;

        private void Cargar()
        {

            try
            {
                _DATOS.DataSource = Factura.ListaMedicamentos();
                dgvPacientes.DataSource = _DATOS;
                dgvPacientes.AutoGenerateColumns = false;
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
                    _DATOS.Filter = "Med_Nombre like '%" + txtFiltro.Text + "%'";
                }
                dgvPacientes.AutoGenerateColumns = false;
                dgvPacientes.DataSource = _DATOS;
            }
            catch (Exception)
            { }
        }
        public ListaMedicamentos(int IDConsulta)
        {
            InitializeComponent();
            _IDConsulta = IDConsulta;
            Cargar();
        }
        //Para seleccionar el idMediamento
        public int ID_MedicamentoSeleccionado { get; private set; }
        public String NombreMedicamentoSeleccionado { get; private set; }
        public Decimal PrecioUnitarioSeleccionado { get; private set; }



        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el DataGridView tiene datos
                if (dgvPacientes.Rows.Count == 0 || dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("No hay datos para seleccionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close(); // Cerrar la ventana
                    return;
                }

                // Validar si la cantidad del medicamento es mayor a 0
                int cantidadMedicamento = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Med_Cantidad"].Value);
                if (cantidadMedicamento <= 0)
                {
                    MessageBox.Show("El medicamento seleccionado no tiene existencias disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // No cerrar la ventana para permitir otra selección
                }

                // Suponiendo que se ha seleccionado un medicamento en la lista
                ID_MedicamentoSeleccionado = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["ID_Medicamento"].Value);
                NombreMedicamentoSeleccionado = Convert.ToString(dgvPacientes.CurrentRow.Cells["Med_Nombre"].Value);
                PrecioUnitarioSeleccionado = Convert.ToDecimal(dgvPacientes.CurrentRow.Cells["Med_PrecioUnitario"].Value);

                DialogResult = DialogResult.OK; // Confirmar selección
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ListaMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
