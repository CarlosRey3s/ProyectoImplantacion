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
    public partial class VerPermisos : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.VerPermisos();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                // Obtener el texto ingresado en el cuadro de texto de filtro
                string filtro = txtFiltro.Text.Trim();

                // Filtrar los datos en función del texto ingresado
                if (filtro.Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    // Construir la expresión de filtro para filtrar por nombre de usuario
                    string filtroExpresion = $"NombreRol LIKE '%{filtro}%'";

                    // Aplicar el filtro
                    _DATOS.Filter = filtroExpresion;
                }
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public VerPermisos()
        {
            InitializeComponent();
            Cargar();

        }

        private void VerPermisos_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
