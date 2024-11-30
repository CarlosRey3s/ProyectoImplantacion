using General.CLS;
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
                // Obtener los datos de los medicamentos
                DataTable dtMedicamentos = DataLayer.Consulta.Medicamentos();

                // Configurar el origen de datos del DataGridView
                dgvMedicamentos.AutoGenerateColumns = false;
                dgvMedicamentos.DataSource = dtMedicamentos;

                // Asignar la columna ImagenMedicamento del DataTable como origen de datos para la columna correspondiente en el DataGridView
                dgvMedicamentos.Columns["ImagenMedicamento"].DataPropertyName = "ImagenMedicamento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MedicamentoGestion()
        {
            InitializeComponent();
            Cargar();
            dgvMedicamentos.CellClick += dgvUsuarios_CellContentClick;

        }
        private void dgvMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMedicamentos.CurrentRow;
            if (dgvMedicamentos.CurrentRow != null)
            {

                string base64Image = dgvMedicamentos.CurrentRow.Cells["ImagenMedicamento"].Value.ToString();
                if (!string.IsNullOrEmpty(base64Image))
                {
                    pcMedicamento.Image = Base64ToImage(base64Image);
                }
                else
                {
                    pcMedicamento.Image = null;
                }
            }
        }

        private Image Base64ToImage(string base64String)
        {
            // Convert Base64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            return Image.FromStream(ms, true);
        }
        private void MedicamentoGestion_Load(object sender, EventArgs e)
        {
            
        }
 

        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Medicamento oMedicamento = new Medicamento();
                    oMedicamento.NombreInsumo = txtNombreInsumo.Text;
                    oMedicamento.Descripcion = txtDescripcion.Text;
                    oMedicamento.CantidadDisponible = Convert.ToInt32(txtCantidadDiponible.Text);
                    oMedicamento.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                    oMedicamento.Proveedor = txtProveedor.Text;
                    oMedicamento.FechaVencimiento = dtpFechaNac.Value;

                    // Convertir la imagen a Base64
                    if (pcMedicamento.Image != null)
                    {
                        oMedicamento.ImagenMedicamento = ImageToBase64(pcMedicamento.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        oMedicamento.ImagenMedicamento = null;
                    }

                    if (oMedicamento.Insertar())
                    {
                        MessageBox.Show("Medicamento guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El medicamento no pudo ser guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombreInsumo.Clear();
            txtDescripcion.Clear();
            txtCantidadDiponible.Clear();
            txtPrecioUnitario.Clear();
            txtProveedor.Clear();
            dtpFechaNac.Value = DateTime.Now;
            pcMedicamento.Image = null;
        }
        private bool Validar()
        {
            // Implementar validaciones necesarias para los campos
            if (string.IsNullOrEmpty(txtNombreInsumo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtCantidadDiponible.Text) || string.IsNullOrEmpty(txtPrecioUnitario.Text) ||
                string.IsNullOrEmpty(txtProveedor.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar otros campos si es necesario

            return true;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedicamentoSeleccionado > 0) // Verificar si se ha seleccionado un medicamento
                {
                    // Verificar si se han ingresado todos los datos necesarios
                    if (Validar())
                    {
                        // Actualizar los datos del medicamento seleccionado
                        ActualizarMedicamento(idMedicamentoSeleccionado);
                        MessageBox.Show("Medicamento actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar(); // Recargar los datos en el DataGridView
                        LimpiarCampos(); // Limpiar los campos del formulario
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un medicamento para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarMedicamento(int idMedicamento)
        {
            // Crear una instancia del objeto Medicamento con los datos modificados
            Medicamento oMedicamento = new Medicamento();
            oMedicamento.ID_Insumo = idMedicamento;
            oMedicamento.NombreInsumo = txtNombreInsumo.Text;
            oMedicamento.Descripcion = txtDescripcion.Text;
            oMedicamento.CantidadDisponible = Convert.ToInt32(txtCantidadDiponible.Text);
            oMedicamento.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
            oMedicamento.Proveedor = txtProveedor.Text;
            oMedicamento.FechaVencimiento = dtpFechaNac.Value;

            // Convertir la imagen a Base64
            if (pcMedicamento.Image != null)
            {
                oMedicamento.ImagenMedicamento = ImageToBase64(pcMedicamento.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                oMedicamento.ImagenMedicamento = null;
            }

            // Actualizar el medicamento en la base de datos
            oMedicamento.Actualizar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del medicamento seleccionado en el DataGridView
                int idMedicamento = Convert.ToInt32(dgvMedicamentos.CurrentRow.Cells["ID_Insumo"].Value);

                // Crear una instancia del objeto Medicamento
                Medicamento oMedicamento = new Medicamento();

                // Establecer el ID del medicamento a eliminar
                oMedicamento.ID_Insumo = idMedicamento;

                // Intentar eliminar el medicamento
                if (oMedicamento.Eliminar())
                {
                    MessageBox.Show("Medicamento eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar(); // Volver a cargar los datos en el DataGridView
                    LimpiarCampos(); // Limpiar los campos del formulario si es necesario
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int idMedicamentoSeleccionado = -1;
        

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Seleccione una imagen de medicamento";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcMedicamento.Image = new Bitmap(openFileDialog.FileName);
            }
        }


        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                // Cargar los datos del medicamento seleccionado en los campos de texto y en el PictureBox
                txtID_Insumo.Text = row.Cells["ID_Insumo"].Value.ToString();
                txtNombreInsumo.Text = row.Cells["NombreInsumo"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtCantidadDiponible.Text = row.Cells["CantidadDisponible"].Value.ToString();
                txtPrecioUnitario.Text = row.Cells["PrecioUnitario"].Value.ToString();
                txtProveedor.Text = row.Cells["Proveedor"].Value.ToString();
                dtpFechaNac.Value = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value);

                string base64Image = row.Cells["ImagenMedicamento"].Value.ToString();
                if (!string.IsNullOrEmpty(base64Image))
                {
                    pcMedicamento.Image = Base64ToImage(base64Image);
                }
                else
                {
                    pcMedicamento.Image = null;
                }

                // Almacenar el ID del medicamento seleccionado
                idMedicamentoSeleccionado = Convert.ToInt32(row.Cells["ID_Insumo"].Value);

                // Habilitar los botones de edición
                Modificar.Enabled = true;
                Eliminar.Enabled = true;
            }
            else
            {
                // Si no hay fila seleccionada, deshabilitar los botones de edición
                Modificar.Enabled = false;
                Eliminar.Enabled = false;

                // Limpiar los campos de texto y el PictureBox
                LimpiarCampos();
            }
        }
    }
}
