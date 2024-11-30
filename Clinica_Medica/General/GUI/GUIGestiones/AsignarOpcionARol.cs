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
    public partial class AsignarOpcionARol : Form
    {
        private int _idRolSeleccionado;

        public AsignarOpcionARol(int idRolSeleccionado)
        {
            InitializeComponent();
            _idRolSeleccionado = idRolSeleccionado;
            CargarOpcionesDisponibles();
        }

        private void CargarOpcionesDisponibles()
        {
            try
            {
                // Consultar las opciones disponibles desde la base de datos
                DataTable dtOpciones = DataLayer.Consulta.Opciones();

                // Asignar los resultados al ListBox
                lstOpciones.DataSource = dtOpciones;
                lstOpciones.DisplayMember = "NombreOpcion";
                lstOpciones.ValueMember = "ID_Opcion";
            }
            catch (Exception ex)
            {
                // Manejar excepciones si ocurren
                MessageBox.Show("Error al cargar las opciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public AsignarOpcionARol()
        {
            InitializeComponent();
        }

        private void AsignarOpcionARol_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de la opción seleccionada por el usuario
                int idOpcionSeleccionada = Convert.ToInt32(lstOpciones.SelectedValue);

                // Crear una instancia de la clase Roles y asignarle el ID del rol seleccionado
                Roles rol = new Roles
                {
                    ID_Rol = _idRolSeleccionado  // Asignar el ID del rol seleccionado
                };

                // Verificar si el rol ya tiene asignada la opción seleccionada
                if (rol.TieneOpcionAsignada(idOpcionSeleccionada))
                {
                    // Si el rol ya tiene asignada la opción, mostrar un mensaje al usuario y salir del método
                    MessageBox.Show("El rol ya tiene asignado este permiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método AsignarOpcion pasando el ID de la opción seleccionada
                if (rol.AsignarOpcion(idOpcionSeleccionada))
                {
                    // Si se realiza la asignación correctamente, cerrar el formulario y devolver DialogResult.OK
                    MessageBox.Show("Permiso asignado correctamente al rol", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // Si hay un error, mostrar un mensaje al usuario
                    MessageBox.Show("Error al asignar opción al rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones si ocurren
                MessageBox.Show("Error al asignar opción al rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de la opción seleccionada por el usuario
                int idOpcionSeleccionada = Convert.ToInt32(lstOpciones.SelectedValue);

                // Crear una instancia de la clase Roles y asignarle el ID del rol seleccionado
                Roles rol = new Roles
                {
                    ID_Rol = _idRolSeleccionado  // Asignar el ID del rol seleccionado
                };

                // Llamar al método QuitarOpcion pasando el ID de la opción seleccionada
                if (rol.QuitarOpcion(idOpcionSeleccionada))
                {
                    // Si se realiza la eliminación correctamente, mostrar un mensaje de éxito
                    MessageBox.Show("Permiso eliminado correctamente del rol", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cerrar el formulario y devolver DialogResult.OK
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // Si hay un error, mostrar un mensaje al usuario
                    MessageBox.Show("Error al eliminar permiso del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones si ocurren
                MessageBox.Show("Error al eliminar permiso del rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
