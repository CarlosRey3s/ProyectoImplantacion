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
    public partial class FacturaGestion : Form
    {
        BindingSource _DATOS = new BindingSource();


        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Factura();
                FiltrarLocalmente();
            }
            catch (Exception)
            {            }
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
                    _DATOS.Filter = "Concepto like '%" + txtFiltrar.Text + "%'";
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

        private void Insertar_Click(object sender, EventArgs e)
        {
            FacturaEdicion f = new FacturaEdicion();
            f.ShowDialog();
            Cargar();
        }

        private void FacturaGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar este Registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FacturaEdicion f = new FacturaEdicion();

                    f.txtID_Factura.Text = dgvFactura.CurrentRow.Cells["ID_Factura"].Value.ToString();
                    f.cbbIDConsulta.Text = dgvFactura.CurrentRow.Cells["ID_Consulta"].Value.ToString();
                    f.txtConcepto.Text = dgvFactura.CurrentRow.Cells["Concepto"].Value.ToString();
                    f.txtMonto.Text = dgvFactura.CurrentRow.Cells["Monto"].Value.ToString();
                    f.dtpFechaEmision.Value = Convert.ToDateTime(dgvFactura.CurrentRow.Cells["FechaEmision"].Value);
                    f.dtpFechaPago.Value = Convert.ToDateTime(dgvFactura.CurrentRow.Cells["FechaPago"].Value);
                    f.cbbMetodoPago.Text = dgvFactura.CurrentRow.Cells["MetodoPago"].Value.ToString();
                    //f.txtSubTotal.Text = dgvFactura.CurrentRow.Cells["SubTotal"].Value.ToString();
                    //f.txtTotal.Text = dgvFactura.CurrentRow.Cells["Total"].Value.ToString();
                    //f.txtCantidad.Text = dgvFactura.CurrentRow.Cells["Cantidad"].Value.ToString();
                    //f.txtPrecio.Text = dgvFactura.CurrentRow.Cells["PrecioUnitario"].Value.ToString();




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
                    Factura f = new Factura();
                    f.ID_Factura = Convert.ToInt32(dgvFactura.CurrentRow.Cells["ID_Factura"].Value.ToString());
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

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
