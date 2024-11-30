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
    public partial class PacientesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
               _DATOS.DataSource = DataLayer.Consulta.Paciente();
                dgvPacientes.DataSource = _DATOS;
                dgvPacientes.AutoGenerateColumns = false;
            }
            catch (Exception)
            {}
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
                    string filtroExpresion = $"Nombre LIKE '%{filtro}%'";
                    // Aplicar el filtro
                    _DATOS.Filter = filtroExpresion;
                }
                dgvPacientes.AutoGenerateColumns = false;
                dgvPacientes.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public PacientesGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {}
        private void PacientesGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            FiltrarLocalmente();
            ContarEmpleados();
        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            PacientesEdicion P = new PacientesEdicion();
            P.ShowDialog();
            Cargar();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Paciente f = new Paciente();
                    f.ID_Paciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["ID_Paciente"].Value.ToString());
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
            }catch { }
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar esta Cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PacientesEdicion pacientesEdicion = new PacientesEdicion();
                    pacientesEdicion.txtIdPaciente.Text = dgvPacientes.CurrentRow.Cells["ID_Paciente"].Value.ToString();
                    pacientesEdicion.txtNombresPaciente.Text = dgvPacientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    pacientesEdicion.txtApellidosPaciente.Text = dgvPacientes.CurrentRow.Cells["Apellido"].Value.ToString();
                    pacientesEdicion.dtpFechaNac.Text = dgvPacientes.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                    pacientesEdicion.cbGenero.Text = dgvPacientes.CurrentRow.Cells["Genero"].Value.ToString();
                    pacientesEdicion.txtTelefono.Text = dgvPacientes.CurrentRow.Cells["Telefono"].Value.ToString();
                    pacientesEdicion.txtCorreoElectronico.Text = dgvPacientes.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                    pacientesEdicion.txtDireccion.Text = dgvPacientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    pacientesEdicion.Show();
                    Cargar();
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void txtFiltro_Click(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
        private void ContarEmpleados()
        {
            int totalEmpleados = dgvPacientes.RowCount;
            TotalEmpleados.Text = totalEmpleados.ToString();
        }
        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        private void TotalEmpleados_Click(object sender, EventArgs e)
        {}
    }
}
