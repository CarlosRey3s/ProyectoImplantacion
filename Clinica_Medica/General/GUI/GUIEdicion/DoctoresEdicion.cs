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

namespace General.GUI
{
    public partial class DoctoresEdicion : Form
    {
        public event Action DatosActualizado;
        BindingSource _Datos = new BindingSource();
        private void LlenarComboBoxCargos() //el metodo se ejcutara para llenar el combobox Cargo
        {
            try
            {
                _Datos.DataSource = Doctor.MostrarEspecialidades(); //Llama al metodo Especialida que tiene la tabla especialidad
                cbxEspecialidad.DataSource = _Datos;
                cbxEspecialidad.DisplayMember = "Esp_Especialidad"; //Mostrara la especialidades de la tabla
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
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               if(Validar())
                {
                    try
                    {
                        int ID_Doctor = Convert.ToInt32(txtID_Doctor.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                    //asinga los datos que estan en las cajas de texto a la variable de la clase empleados creda 
                    int ID_Empleado = Convert.ToInt32(txtID_Empleado.Text);
                    int NumeroLicencia = Convert.ToInt32(txtNumeroLicencia.Text);
                    int ID_Especialidad = (int)cbxEspecialidad.SelectedValue;

                    var result = new ControladorDoctores();

                    if (txtID_Doctor.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO REGISTROS

                        bool resultado = result.InsertarDoctor(ID_Empleado,NumeroLicencia, ID_Especialidad);
                        Console.WriteLine( resultado );
                        if (resultado){Close(); MessageBox.Show("Doctor insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser almacenado");
                        }
                    }
                    else
                    { //ACTUALIZAR REGISTRO
                        int ID_Doctor = Convert.ToInt32(txtID_Doctor.Text);
                        bool resultado = result.ActualizarDoctor(ID_Doctor, ID_Empleado, NumeroLicencia, ID_Especialidad);
                        if (resultado)
                        {
                            DoctoresGestion doc = new DoctoresGestion();
                            
                            Close(); MessageBox.Show("Doctor actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DatosActualizado?.Invoke();
                           

                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser actualizado");
                        }
                    }
                }
            }catch (Exception ex) { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
