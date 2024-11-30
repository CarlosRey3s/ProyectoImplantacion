using General.CLS;
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

namespace General.GUI.GUIEdicion
{
    public partial class ConsultasEdicion : Form
    {
        private ControladorConsultas controladorConsultas = new ControladorConsultas(); // Instancia del controlador

        // Método para llenar el ComboBox de citas
        private void LlenarComboBoxCitas()
        {
            try
            {
                // Crear un BindingSource para las citas
                BindingSource _DatosCitas = new BindingSource();
                _DatosCitas.DataSource = DataLayer.Consulta.Citas(); // Método para obtener las citas

                // Agregar la opción de "Sin cita asociada" al principio
                DataTable citasTable = ((BindingSource)_DatosCitas).DataSource as DataTable;

                DataRow dr = citasTable.NewRow();  // Creando una nueva fila vacía
                dr["ID_Cita"] = DBNull.Value;      // Asignando DBNull para "Sin cita"
                //dr["NombresPaciente"] = "Sin cita asociada";  // Texto representativo para sin cita
                citasTable.Rows.InsertAt(dr, 0);  // Insertar en la primera posición

                // Asignar el BindingSource al ComboBox
                cbbCAsociada.DataSource = citasTable;
                //cbbCAsociada.DisplayMember = "NombresPaciente";
                cbbCAsociada.ValueMember = "ID_Cita";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para habilitar o deshabilitar el campo Citas_ID_Cita según PoseeCita
        private void cbbPoseeCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPoseeCita.SelectedItem.ToString() == "NO")
            {
                cbbCAsociada.Enabled = false;  // Deshabilitar ComboBox de Citas_ID_Cita
                cbbCAsociada.SelectedIndex = 0;  // Seleccionar "Sin cita asociada"
            }
            else
            {
                cbbCAsociada.Enabled = true;  // Habilitar ComboBox de Citas_ID_Cita
            }
        }

        // Método de validación de campos
        private Boolean Validar()
        {
            Boolean Valido = true;

            try
            {
                if (string.IsNullOrWhiteSpace(txtDignostico.Text))
                {
                    Notificador.SetError(txtDignostico, "El diagnóstico no puede estar vacío.");
                    Valido = false;
                }
                if (string.IsNullOrWhiteSpace(txtPConsulta.Text) || !float.TryParse(txtPConsulta.Text, out _))
                {
                    Notificador.SetError(txtPConsulta, "El precio debe ser un número válido.");
                    Valido = false;
                }

                // Si "PoseeCita" es "NO", no debe haber cita seleccionada
                if (cbPoseeCita.SelectedItem.ToString() == "NO")
                {
                    if (cbbCAsociada.SelectedValue != null)
                    {
                        Notificador.SetError(cbbCAsociada, "No debe seleccionarse una cita si PoseeCita es 'NO'.");
                        Valido = false;
                    }
                }
                else
                {
                    // Si PoseeCita es "SI", debe seleccionarse una cita
                    if (cbbCAsociada.SelectedValue == null || Convert.ToInt32(cbbCAsociada.SelectedValue) == 0)
                    {
                        Notificador.SetError(cbbCAsociada, "Debe seleccionar una cita asociada.");
                        Valido = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Valido = false;
            }

            return Valido;
        }
        // Constructor
        public ConsultasEdicion()
        {
            InitializeComponent();
        }

        // Al cargar el formulario
        private void ConsultasEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCitas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (Validar())
                {
                    // Crear un objeto de la clase Consulta
                    CLS.Consulta oConsulta = new CLS.Consulta();

                    // Asignamos los valores a los atributos de la clase Consulta
                    oConsulta.ID_Consulta = string.IsNullOrWhiteSpace(txtID_Consulta.Text) ? 0 : Convert.ToInt32(txtID_Consulta.Text);
                    oConsulta.Cons_Diganostico = txtDignostico.Text.Trim();
                    oConsulta.Cons_Tratamiento = txtPConsulta.Text.Trim();
                    oConsulta.Cons_PrecioConsulta = float.Parse(txtPConsulta.Text);
                    oConsulta.Cons_FechaConsulta = dtpFechayHora.Value;

                    // Asignamos el valor de PoseeCita
                    oConsulta.Cons_PoseeCita = cbPoseeCita.SelectedItem.ToString();

                    // Asignamos Citas_ID_Cita según PoseeCita
                    if (oConsulta.Cons_PoseeCita == "NO")
                    {
                        oConsulta.Citas_ID_Cita = 0;  // No hay cita asociada
                    }
                    else
                    {
                        oConsulta.Citas_ID_Cita = Convert.ToInt32(cbbCAsociada.SelectedValue);  // Cita seleccionada
                    }

                    // Si el ID de la consulta es 0, significa que es una nueva inserción
                    if (oConsulta.ID_Consulta == 0)
                    {
                        if (controladorConsultas.InsertarConsulta(oConsulta))
                        {
                            MessageBox.Show("Consulta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar la consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si el ID de la consulta no es 0, es una actualización
                        if (controladorConsultas.ActualizarConsulta(oConsulta))
                        {
                            MessageBox.Show("Consulta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Cancelar y cerrar el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPoseeCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPoseeCita.SelectedItem.ToString() == "NO")
            {
                // Si PoseeCita es "NO", deshabilitamos el ComboBox de Citas_ID_Cita
                cbbCAsociada.Enabled = false;
                cbbCAsociada.SelectedIndex = -1;  // Limpiamos la selección para evitar confusión
            }
            else
            {
                // Si PoseeCita es "SI", habilitamos el ComboBox de Citas_ID_Cita
                cbbCAsociada.Enabled = true;
            }
        }
    }
}