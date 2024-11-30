using General.CLS;
using General.Controlador;
using General.GUI.GUIEdicion;
using System;
using System.Data;
using System.Windows.Forms;

namespace General.GUI.GUIGestiones
{
    public partial class UsuariosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();



        // Método para validar permisos del usuario actual
        private bool TienePermiso(string permiso)
        {
            // Aquí debemos verificar si el usuario tiene el permiso que se pasa como parámetro.
            // Este es solo un ejemplo. Necesitarías tener un servicio de permisos para validar.
            int idUsuario = 1; // Reemplazar con el ID del usuario actual
            PermisosService permisosService = new PermisosService(idUsuario);
            return permisosService.ValidarPermiso(permiso);
        }

        private void Cargar()
        {
            try
            {
                // Usamos ListarUsuario() para obtener los datos de los usuarios.
                DataTable datos = Usuario.ListarUsuario();

                // Verifica si los datos fueron recuperados correctamente.
                if (datos == null || datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se recuperaron datos para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Depuración: Muestra los datos recuperados en la consola.
                foreach (DataRow row in datos.Rows)
                {
                    Console.WriteLine(string.Join(", ", row.ItemArray));
                }

                // Configura el DataGridView.
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para validar permisos y habilitar/deshabilitar botones
        private void ValidarPermisos()
        {
            // Verificar permisos para insertar, modificar y eliminar
            Insertar.Enabled = TienePermiso("InsertarUsuario");
            Modificar.Enabled = TienePermiso("ModificarUsuario");
            Eliminar.Enabled = TienePermiso("EliminarUsuario");
        }

        private void FiltrarLocalmente()
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();

                if (filtro.Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    string filtroExpresion = $"Usu_Usuario LIKE '%{filtro}%'"; // Filtrar por nombre de usuario
                    _DATOS.Filter = filtroExpresion;
                }
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
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
            ValidarPermisos();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el usuario tiene permiso para insertar
                if (!Insertar.Enabled)
                {
                    MessageBox.Show("No tiene permisos para insertar usuarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuariosEdicion f = new UsuariosEdicion(); // Abrir formulario de edición para insertar
                f.ShowDialog();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el usuario tiene permiso para modificar
                if (!Modificar.Enabled)
                {
                    MessageBox.Show("No tiene permisos para modificar usuarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvUsuarios.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Desea modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UsuariosEdicion f = new UsuariosEdicion();

                        // Asignar valores a los controles del formulario de edición, verificando nulos
                        f.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["ID_Usuario"].Value?.ToString() ?? string.Empty;
                        f.txtUsuarioIDEmpleado.Text = dgvUsuarios.CurrentRow.Cells["Empleados_ID_Empleado"].Value?.ToString() ?? string.Empty;
                        f.txtusuarioIDRol.Text = dgvUsuarios.CurrentRow.Cells["Roles_ID_Rol"].Value?.ToString() ?? string.Empty;
                        f.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usu_Usuario"].Value?.ToString() ?? string.Empty;
                        f.txtClave.Text = dgvUsuarios.CurrentRow.Cells["Usu_Clave"].Value?.ToString() ?? string.Empty;

                        f.ShowDialog();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el usuario tiene permiso para eliminar
                if (!Eliminar.Enabled)
                {
                    MessageBox.Show("No tiene permisos para eliminar usuarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvUsuarios.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Usuario f = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID_Usuario"].Value)
                        };

                        if (f.Eliminar())
                        {
                            MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                RolesGestion roles = new RolesGestion();
                roles.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al gestionar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerPermisos_Click(object sender, EventArgs e)
        {
            // El evento no realiza ninguna acción aquí, ya que se solicitó el código original sin integración.
        }

        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la fila seleccionada no sea null
                if (dgvUsuarios.CurrentRow != null)
                {
                    // Obtener el ID del usuario seleccionado
                    int idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID_Usuario"].Value);

                    // Crear una instancia de VerPermisos pasando el ID del usuario
                    VerPermisos verPermisosForm = new VerPermisos(idUsuarioSeleccionado);

                    // Mostrar el formulario
                    verPermisosForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para ver sus permisos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al gestionar permisos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
