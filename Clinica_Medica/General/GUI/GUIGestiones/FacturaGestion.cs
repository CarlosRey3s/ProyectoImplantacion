using General.CLS;
using General.Controladores;
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
    public partial class FacturaGestion : Form
    {
        BindingSource _DATOS = new BindingSource();


        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = Factura.vw_Factura();
                FiltrarLocalmente();
            }
            catch (Exception)
            {            }
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
                    _DATOS.Filter = "NombrePaciente like '%" + txtFiltro.Text + "%'";
                }
                dgvFactura.AutoGenerateColumns = false;
                dgvFactura.DataSource = _DATOS;
            }
            catch (Exception)
            {            }
        }
        public FacturaGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void FacturaGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Insertar_Click_1(object sender, EventArgs e)
        {
            FacturaEdicion f = new FacturaEdicion();
        
            f.ShowDialog();
            Cargar();
        }

        

        private void Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar esta Cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FacturaEdicion f = new FacturaEdicion();
                    f.txtIdFactura.Text = dgvFactura.CurrentRow.Cells["ID_Factura"].Value.ToString();
                    f.txtNumeroFactura.Text = dgvFactura.CurrentRow.Cells["Fac_numeroFactura"].Value.ToString();
                    f.dtpFecha.Text = dgvFactura.CurrentRow.Cells["Fac_fecha"].Value.ToString();
                    f.cbbMetodoPago.Text = dgvFactura.CurrentRow.Cells["Fac_MetodoPago"].Value.ToString();
                    f.txtID_Paciente.Text = dgvFactura.CurrentRow.Cells["Pacientes_ID_Paciente"].Value.ToString();
                    f.lbNombreCliente.Text = dgvFactura.CurrentRow.Cells["NombrePaciente"].Value.ToString();
                    f.lbDoc.Text =  dgvFactura.CurrentRow.Cells["NombreDoctor"].Value.ToString();
                    f.lbPrecioConsulta.Text = "$" + dgvFactura.CurrentRow.Cells["PrecioConsulta"].Value.ToString();
                    f.txtConsulta.Text = dgvFactura.CurrentRow.Cells["Consulta_ID_Consulta"].Value.ToString();
                    f.Show();
                   
                    Cargar();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

  

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Factura f = new Factura();
                    int IDFactura = Convert.ToInt32(dgvFactura.CurrentRow.Cells["ID_Factura"].Value.ToString());

                    var Controller = new ControladorFactura();

                    bool eliminado = Controller.EliminarFactura(IDFactura);

                    if (eliminado)
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar la factura: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvFactura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
     
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
