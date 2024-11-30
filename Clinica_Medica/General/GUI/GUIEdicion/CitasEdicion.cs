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
    public partial class CitasEdicion : Form
    {
        BindingSource _DatosConsultorios = new BindingSource();
        BindingSource _DatosPacientes = new BindingSource();

        private void LlenarComboBoxPacientes()
        {
            try
            {
                BindingSource _DatosPacientes = new BindingSource();
                _DatosPacientes.DataSource = CLS.Paciente.ObtenerPacientes(); // Método que devuelve la lista de pacientes
                cbPacientes.DataSource = _DatosPacientes;
                cbPacientes.DisplayMember = "NombreCompleto"; // Asegúrate de que "NombreCompleto" es una columna calculada en tu consulta SQL o DataTable
                cbPacientes.ValueMember = "ID_Paciente"; // El campo que contiene el ID del paciente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarComboBoxPacientes()
        {
            if (cbPacientes.Items.Count == 0)
            {
                MessageBox.Show("El ComboBox de pacientes está vacío. Verifica los datos en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LlenarComboBoxDoctores()
        {
            try
            {
                BindingSource _DatosDoctores = new BindingSource();
                DataTable doctoresDisponibles = Doctor.ObtenerDoctoresDisponibles();

                if (doctoresDisponibles.Rows.Count > 0)
                {
                    _DatosDoctores.DataSource = doctoresDisponibles;
                    cbDoctores.DataSource = _DatosDoctores;
                    cbDoctores.DisplayMember = "NombreCompleto";
                    cbDoctores.ValueMember = "ID_Doctor";
                }
                else
                {
                    MessageBox.Show("No hay doctores disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de doctores: " + ex.Message);
            }
        }
        private void LlenarComboBoxConsultorios()
        {
            try
            {
                BindingSource _DatosConsultorios = new BindingSource();
                DataTable consultorios = Consultorio.ObtenerConsultoriosDisponibles();

                if (consultorios.Rows.Count > 0)
                {
                    foreach (DataRow row in consultorios.Rows)
                    {
                        Console.WriteLine($"ID_Consultorio: {row["ID_Consultorio"]}, Con_Numero: {row["Con_Numero"]}");
                    }

                    _DatosConsultorios.DataSource = consultorios;
                    cbConsultorios.DataSource = _DatosConsultorios;
                    cbConsultorios.DisplayMember = "Con_Numero";
                    cbConsultorios.ValueMember = "ID_Consultorio";
                }
                else
                {
                    MessageBox.Show("No hay consultorios disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de consultorios: " + ex.Message);
            }
        }
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (cbDoctores.SelectedValue == null || string.IsNullOrWhiteSpace(cbDoctores.Text))
                {
                    Notificador.SetError(cbDoctores, "Debe seleccionar un doctor.");
                    Valido = false;
                }

                if (cbConsultorios.SelectedValue == null || string.IsNullOrWhiteSpace(cbConsultorios.Text))
                {
                    Notificador.SetError(cbConsultorios, "Debe seleccionar un consultorio.");
                    Valido = false;
                }

                if (txtMotivo.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtMotivo, "Este campo no puede quedar vacío.");
                    Valido = false;
                }

                if (txtEstado.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtEstado, "Este campo no puede quedar vacío.");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Valido = false;
            }
            return Valido;
        }


        public CitasEdicion()
        {
            InitializeComponent();
        }

        private void CitasEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxDoctores();
            LlenarComboBoxConsultorios();
            LlenarComboBoxPacientes();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.Citas oCita = new CLS.Citas();

                    // Sincronizamos los datos del formulario con el objeto de la clase
                    oCita.ID_Cita = string.IsNullOrWhiteSpace(txtdCita.Text) ? 0 : Convert.ToInt32(txtdCita.Text); // Asignar ID de la cita si existe
                    oCita.FechaHora = dtpFecha_Hora.Value;
                    oCita.Motivo = txtMotivo.Text.Trim();
                    oCita.Estado = txtEstado.Text.Trim();
                    oCita.Pacientes_ID_Paciente = cbPacientes.SelectedValue != null ? Convert.ToInt32(cbPacientes.SelectedValue) : (int?)null; // Asignar ID del paciente
                    oCita.Doctores_ID_Doctor = cbDoctores.SelectedValue != null ? Convert.ToInt32(cbDoctores.SelectedValue) : (int?)null; // Asignar ID del doctor
                    oCita.Consultorios_ID_Consultorio = cbConsultorios.SelectedValue != null ? Convert.ToInt32(cbConsultorios.SelectedValue) : (int?)null; // Asignar ID del consultorio

                    // Determinamos si es una inserción o una actualización
                    if (oCita.ID_Cita == 0) // Si ID es 0, se trata de una inserción
                    {
                        if (oCita.Insertar())
                        {
                            MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar la cita. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Si ID es diferente de 0, se trata de una actualización
                    {
                        if (oCita.Actualizar())
                        {
                            MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la cita. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
