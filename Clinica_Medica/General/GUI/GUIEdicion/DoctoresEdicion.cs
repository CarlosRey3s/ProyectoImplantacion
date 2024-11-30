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

namespace General.GUI
{
    public partial class DoctoresEdicion : Form
    {
        BindingSource _Datos = new BindingSource();
        private void LlenarComboBoxEstado()
        {
            try
            {
                cbxDocEstado.Items.Clear();
                cbxDocEstado.Items.Add("Disponible");
                cbxDocEstado.Items.Add("Ocupado");
                cbxDocEstado.SelectedIndex = 0; // Seleccionar "Disponible" por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de estado: " + ex.Message);
            }
        }

        private void LlenarComboBoxCargos() //el metodo se ejcutara para llenar el combobox Cargo
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.Especialidad(); //Llama al metodo Especialida que tiene la tabla especialidad
                cbxEspecialidad.DataSource = _Datos;
                cbxEspecialidad.DisplayMember = "especialidad"; //Mostrara la especialidades de la tabla
                cbxEspecialidad.ValueMember = "ID_Especialidad"; // recojera el id cuando se escoja la especialidad
            }
            catch (Exception ex)
            { }
        }
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtID_Empleado.Text.Trim().Length == 0)
                {
                    //valida que los campos no queden vacios
                    notificador.SetError(txtID_Empleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
            }
            return Valido;
        }
        public DoctoresEdicion()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {     }
        private void DoctoresEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos(); // carga las especialidades que estan en el combobox
            LlenarComboBoxEstado();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // Crear una instancia a partir de la clase
                    CLS.Doctor oDoctor = new CLS.Doctor();

                    // Sincronizar el objeto con la interfaz
                    oDoctor.ID_Doctor = string.IsNullOrWhiteSpace(txtID_Doctor.Text) ? 0 : Convert.ToInt32(txtID_Doctor.Text);
                    oDoctor.ID_Empleado = Convert.ToInt32(txtID_Empleado.Text);
                    oDoctor.NumeroLicencia = Convert.ToInt32(txtNumeroLicencia.Text);
                    oDoctor.ID_Especialidad = (int)cbxEspecialidad.SelectedValue;
                    oDoctor.Estado = cbxDocEstado.SelectedItem.ToString(); // Obtener el estado seleccionado

                    // Determinar si es un registro nuevo o una actualización
                    if (txtID_Doctor.Text.Trim().Length == 0)
                    {
                        // GUARDAR NUEVO REGISTRO
                        if (oDoctor.Insertar())
                        {
                            MessageBox.Show("Registro Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser almacenado");
                        }
                    }
                    else
                    {
                        // ACTUALIZAR REGISTRO
                        if (oDoctor.Actualizar())
                        {
                            MessageBox.Show("Registro Actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
