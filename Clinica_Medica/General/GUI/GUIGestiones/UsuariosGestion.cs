using General.CLS;
using General.GUI.GUIEdicion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIGestiones
{
    public partial class UsuariosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Usuario();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = _DATOS;
            }
            catch (Exception ex)
            {

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
                    string filtroExpresion = $"Usuario LIKE '%{filtro}%'";

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
        public UsuariosGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void UsuariosGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosEdicion f = new UsuariosEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
                // Manejo de excepciones
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar esta Cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvUsuarios.CurrentRow != null)
                    {
                        UsuariosEdicion f = new UsuariosEdicion();

                        f.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString();
                        f.txtUsuarioIDEmpleado.Text = dgvUsuarios.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                        f.txtusuarioIDRol.Text = dgvUsuarios.CurrentRow.Cells["ID_Rol"].Value.ToString();
                        f.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                        f.txtClave.Text = dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString();

                        f.ShowDialog();
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario f = new Usuario();
                    f.ID_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString());

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

        private void GestionarRoles_Click(object sender, EventArgs e)
        {
            RolesGestion pacientes = new RolesGestion();
            pacientes.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VerPermisos permisos = new VerPermisos();
            permisos.Show();
        }
    }
}
