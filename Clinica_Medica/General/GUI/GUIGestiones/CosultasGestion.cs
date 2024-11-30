using General.CLS;
using General.GUI.GUIEdicion;
using General.Controlador;
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
    public partial class CosultasGestion : Form
    {
        // BindingSource para gestionar los datos de las consultas
        BindingSource _DATOS = new BindingSource();

        // Instancia del controlador
        private ControladorConsultas controladorConsultas = new ControladorConsultas();

        // Método para cargar los datos de las consultas
        private void Cargar()
        {
            try
            {
                // Cargar datos de las consultas médicas usando el controlador
                _DATOS.DataSource = controladorConsultas.ObtenerConsultas();
                FiltrarLocalmente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para filtrar las consultas localmente según el texto de búsqueda
        private void FiltrarLocalmente()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFiltrar.Text))
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    _DATOS.Filter = $"Cons_Diganostico LIKE '%{txtFiltrar.Text}%' OR Cons_Tratamiento LIKE '%{txtFiltrar.Text}%'";
                }

                dgvConsultas.AutoGenerateColumns = false;
                dgvConsultas.DataSource = _DATOS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Constructor
        public CosultasGestion()
        {
            InitializeComponent();
            Cargar();
        }

        // Evento de clic en el botón Insertar para abrir el formulario de edición
        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultasEdicion f = new ConsultasEdicion();
                f.ShowDialog();
                Cargar(); // Recargar los datos después de insertar
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar la consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de clic en el botón Modificar para abrir el formulario de edición con datos seleccionados
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultas.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea modificar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConsultasEdicion f = new ConsultasEdicion();

                    // Transferir los datos seleccionados al formulario de edición
                    f.txtID_Consulta.Text = dgvConsultas.CurrentRow.Cells["ID_Consulta"].Value.ToString();
                    f.dtpFechayHora.Value = DateTime.Parse(dgvConsultas.CurrentRow.Cells["Cons_FechaConsulta"].Value.ToString());
                    f.txtDignostico.Text = dgvConsultas.CurrentRow.Cells["Cons_Diganostico"].Value.ToString();
                    f.txtPConsulta.Text = dgvConsultas.CurrentRow.Cells["Cons_PrecioConsulta"].Value.ToString();
                    f.cbbCAsociada.SelectedValue = dgvConsultas.CurrentRow.Cells["Citas_ID_Cita"].Value;
                    f.cbPoseeCita.SelectedItem = dgvConsultas.CurrentRow.Cells["Cons_PoseeCita"].Value.ToString();

                    f.ShowDialog(); // Mostrar el formulario para modificar
                    Cargar(); // Recargar los datos después de modificar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de clic en el botón Eliminar para eliminar una consulta seleccionada
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultas.CurrentRow != null)
                {
                    if (MessageBox.Show("¿Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Consulta f = new Consulta();
                        f.ID_Consulta = Convert.ToInt32(dgvConsultas.CurrentRow.Cells["ID_Consulta"].Value.ToString());

                        if (controladorConsultas.EliminarConsulta(f)) // Usamos el controlador para eliminar la consulta
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar(); // Recargar la lista después de la eliminación
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el registro. Verifique si tiene dependencias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de cambio de texto en el campo de filtro
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        // Al cargar el formulario
        private void CosultasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}