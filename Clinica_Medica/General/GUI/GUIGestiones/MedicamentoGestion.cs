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
    public partial class MedicamentoGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                // Crear una instancia del controlador
                Controlador.ControladorMedicamentos controlador = new Controlador.ControladorMedicamentos();

                // Usar el controlador para obtener los datos
                DataTable medicamentos = controlador.ListarMedicamentos();

                if (medicamentos.Rows.Count > 0)
                {
                    Console.WriteLine("Datos cargados correctamente.");
                    _DATOS.DataSource = medicamentos;
                    dgvMedicamentos.DataSource = _DATOS;
                }
                else
                {
                    Console.WriteLine("No se encontraron medicamentos.");
                    MessageBox.Show("No se encontraron medicamentos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar medicamentos: {ex.Message}");
                MessageBox.Show($"Error al cargar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarLocalmente()
        {            try
            {
                string filtro = txtFiltro.Text.Trim();
                if (filtro.Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    string filtroExpresion = $"Med_Nombre LIKE '%{filtro}%'"; // Filtrar por nombre del medicamento
                    _DATOS.Filter = filtroExpresion;
                }
                dgvMedicamentos.AutoGenerateColumns = false;
                dgvMedicamentos.DataSource = _DATOS;
            }catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       }

        public MedicamentoGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void MedicamentoGestion_Load(object sender, EventArgs e)        {
            Cargar();
            FiltrarLocalmente();      }
        private void Insertar_Click(object sender, EventArgs e)
        {
            MedicamentosEdicion edicion = new MedicamentosEdicion(); // Abre el formulario de edición
            edicion.ShowDialog();
            Cargar();        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar este Medicamento?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MedicamentosEdicion edicion = new MedicamentosEdicion();

                    // Cargar los valores de la fila seleccionada en el formulario de edición
                    edicion.txtIdMedicamento.Text = dgvMedicamentos.CurrentRow.Cells["ID_Medicamento"].Value.ToString();
                    edicion.txtNombresMedicamento.Text = dgvMedicamentos.CurrentRow.Cells["Med_Nombre"].Value.ToString();
                    edicion.txtCantidad.Text = dgvMedicamentos.CurrentRow.Cells["Med_Cantidad"].Value.ToString();
                    edicion.txtDescripcion.Text = dgvMedicamentos.CurrentRow.Cells["Med_Descripcion"].Value.ToString();
                    edicion.txtPrecioUnitario.Text = dgvMedicamentos.CurrentRow.Cells["Med_PrecioUnitario"].Value.ToString();
                    edicion.dtpFechaVen.Value = DateTime.Parse(dgvMedicamentos.CurrentRow.Cells["Med_FechaVen"].Value.ToString());  
                    //edicion.txtCantidadVendida.Text = dgvMedicamentos.CurrentRow.Cells["Med_CantidadVendida"].Value.ToString();

                    edicion.ShowDialog(); // Mostrar el formulario
                    Cargar(); // Recargar los datos después de la modificación
                }           }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar: " + ex.Message);
            }        }
        private void Eliminar_Click(object sender, EventArgs e)
        {           try
            {
                if (MessageBox.Show("¿Desea eliminar este Medicamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Medicamento medicamento = new Medicamento
                    {
                        ID_Medicamento = Convert.ToInt32(dgvMedicamentos.CurrentRow.Cells["ID_Medicamento"].Value)
                    };

                    if (medicamento.Eliminar())
                    {                        MessageBox.Show("Medicamento eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("El medicamento no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               }
            }          catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí se podría manejar un clic en una celda si es necesario.
        }
    }
}
