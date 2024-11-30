using General.CLS;
using General.Controlador;
using General.GUI.GUIEdicion;
using System;

using System.Data;

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
                // Instancia del controlador
                ControladorRoles controlador = new ControladorRoles();

                // Obtén los datos desde el controlador
                DataTable datos = controlador.ListarRoles();

                // Verifica si hay datos y asigna al BindingSource
                if (datos.Rows.Count > 0)
                {
                    _DATOS.DataSource = datos;
                    dgvRoles.AutoGenerateColumns = false;
                    dgvRoles.DataSource = _DATOS;
                }
                else
                {
                    MessageBox.Show("No se encontraron roles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string filtroExpresion = $"Rol_NombreRol LIKE '%{filtro}%'";
                    _DATOS.Filter = filtroExpresion;
                }
                dgvRoles.AutoGenerateColumns = false;
                dgvRoles.DataSource = _DATOS;
            }
            catch (Exception ex) { 
 

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
 
                MessageBox.Show("Error adding role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Desea modificar este Rol?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (RolesEdicion f = new RolesEdicion())
                        {
                            f.txtID_Rol.Text = dgvRoles.CurrentRow.Cells["ID_Rol"].Value.ToString();
                            f.txtNombreRol.Text = dgvRoles.CurrentRow.Cells["Rol_NombreRol"].Value.ToString();

                            f.ShowDialog();
                        }
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.CurrentRow != null && MessageBox.Show("¿Desea eliminar este Rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Roles f = new Roles
                    {
                        ID_Rol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_Rol"].Value)
                    };

                    if (f.Eliminar())
                    {
                        MessageBox.Show("Rol eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El rol no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
  
                int idRolSeleccionado = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_Rol"].Value);


                using (var asignarOpcionForm = new AsignarOpcionARol(idRolSeleccionado))
                {
  
                    var result = asignarOpcionForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        Cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al asignar opciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AsignarOpcionARol f = new AsignarOpcionARol();
            f.ShowDialog();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
