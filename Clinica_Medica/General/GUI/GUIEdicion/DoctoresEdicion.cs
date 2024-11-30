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
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               if(Validar())
                {
                    //Crear una instancia a partir de la clase
                    CLS.Doctor oDoctor = new CLS.Doctor();
                    //sincronizar el objeto con la interfaz
                    try
                    {
                        oDoctor.ID_Doctor1 = Convert.ToInt32(txtID_Doctor.Text);
                    }
                    catch (Exception)
                    {
                        oDoctor.ID_Doctor1 = 0;
                    }
                    //asinga los datos que estan en las cajas de texto a la variable de la clase empleados creda 
                    oDoctor.ID_Empleado1 = Convert.ToInt32(txtID_Empleado.Text);
                    oDoctor.NumeroLicencia1 = Convert.ToInt32(txtNumeroLicencia.Text);
                    int selectedCargoId = (int)cbxEspecialidad.SelectedValue;
                    oDoctor.ID_Especialidad1 = selectedCargoId;
                    if (txtID_Doctor.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO REGISTROS
                        if (oDoctor.Insertar())
                        {
                            MessageBox.Show("Registro Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser almacenado");
                        }
                    }
                    else
                    { //ACTUALIZAR REGISTRO
                        if (oDoctor.Actualizar())
                        {
                            MessageBox.Show("Registro Actualizado");
                            Close();
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
