using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.Controlador; // Asegúrate de importar el controlador de roles
using General.CLS; // Importar las clases necesarias

namespace General.GUI.GUIEdicion
{
    public partial class RolesEdicion : Form
    {
        private ControladorRoles controladorRoles = new ControladorRoles(); // Instanciamos el controlador de roles

        // Método de validación para asegurarnos de que el nombre del rol no esté vacío
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombreRol.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtNombreRol, "Este campo no puede quedar vacío");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }

        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void RolesEdicion_Load(object sender, EventArgs e)
        {
            // Si estamos editando un rol, cargamos la información
            if (!string.IsNullOrEmpty(txtID_Rol.Text))
            {
                int idRol = Convert.ToInt32(txtID_Rol.Text);
                DataTable rolesData = controladorRoles.ListarRoles();

                // Usamos LINQ para obtener el rol por su ID
                var rol = rolesData.AsEnumerable()
                                   .FirstOrDefault(r => r.Field<int>("ID_Rol") == idRol);

                if (rol != null)
                {
                    txtNombreRol.Text = rol["Rol_NombreRol"].ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    string nombreRol = txtNombreRol.Text;

                    // Si el ID del rol está vacío, estamos insertando un nuevo rol
                    if (string.IsNullOrEmpty(txtID_Rol.Text))
                    {
                        if (controladorRoles.InsertarRol(nombreRol))
                        {
                            MessageBox.Show("Rol guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡ERROR! No se pudo guardar el rol. Verifique la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si ya tiene un ID, estamos actualizando el rol
                        int idRol = Convert.ToInt32(txtID_Rol.Text);
                        if (controladorRoles.ActualizarRol(idRol, nombreRol))
                        {
                            MessageBox.Show("Rol actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡ERROR! No se pudo actualizar el rol. Verifique la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
