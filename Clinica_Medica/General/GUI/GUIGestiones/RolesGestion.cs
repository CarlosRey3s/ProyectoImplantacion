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
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Roles();
                dgvRoles.AutoGenerateColumns = false;  // Set once here
                dgvRoles.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                // Handle the exception by showing a message or logging it
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvRoles.AutoGenerateColumns = false;
                dgvRoles.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public RolesGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                using (RolesEdicion f = new RolesEdicion())
                {
                    f.ShowDialog();
                }
                Cargar();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error adding role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Desea modificar esta Cuenta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (RolesEdicion f = new RolesEdicion())
                        {
                            f.txtID_Rol.Text = dgvRoles.CurrentRow.Cells["ID_Rol"].Value.ToString();
                            f.txtNombreRol.Text = dgvRoles.CurrentRow.Cells["NombreRol"].Value.ToString();

                            f.ShowDialog();
                        }
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.CurrentRow != null && MessageBox.Show("¿Desea eliminar esta Cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Roles f = new Roles
                    {
                        ID_Rol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_Rol"].Value)
                    };

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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del rol seleccionado en el DataGridView
                int idRolSeleccionado = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_Rol"].Value);

                // Crear una instancia del formulario para asignar opciones al rol seleccionado
                using (var asignarOpcionForm = new AsignarOpcionARol(idRolSeleccionado))
                {
                    // Mostrar el formulario como un cuadro de diálogo modal
                    var result = asignarOpcionForm.ShowDialog();

                    // Si el usuario presiona el botón "Aceptar" en el formulario de asignación
                    if (result == DialogResult.OK)
                    {
                        // Actualizar la interfaz de usuario si es necesario
                        // Por ejemplo, puedes recargar los datos en el DataGridView
                        Cargar(); // Aquí asumo que Cargar() es un método para recargar los roles en el DataGridView
                    }
                }
            }
            catch { }
           }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AsignarOpcionARol f = new AsignarOpcionARol();
            f.ShowDialog();
        }
    }
}
