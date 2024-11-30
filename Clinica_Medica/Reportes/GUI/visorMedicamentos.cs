using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class visorMedicamentos : Form
    {
        private ReportDocument reporte;
        public visorMedicamentos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            if (reporte != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                saveFileDialog.Title = "Guardar Reporte como Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        reporte.ExportToDisk(ExportFormatType.Excel, saveFileDialog.FileName);
                        MessageBox.Show("Reporte exportado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún reporte cargado para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
