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
    public partial class DetallesFactura : Form
    {
        BindingSource _Datos = new BindingSource();

        private void Cargar()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.DetallesFactura();
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
                    _Datos.RemoveFilter();
                }
                else
                {
                    _Datos.Filter = "Concepto like '%" + txtFiltro.Text + "%'";
                }
                dgvDetallesFactura.AutoGenerateColumns = false;
                dgvDetallesFactura.DataSource = _Datos;
            }
            catch (Exception)
            { }
        }
        public DetallesFactura()
        {
            InitializeComponent();
            Cargar();
        }

        private void DetallesFactura_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
