using DataLayer;
using General.CLS;
using General.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EmpleadosEdicion : Form
    {
        public event Action DatosActualizados;
        BindingSource _Datos = new BindingSource();
        private void LlenarComboBoxCargos() //el metodo se ejcutara para llenar el combobox Cargo
        {
            try
            {
                _Datos.DataSource = Empleados.MostrarCargos();
                cbxCargo.DataSource = _Datos;
                cbxCargo.DisplayMember = "Car_Cargo"; //Mostrara los cargos de la tabla cargo 
                cbxCargo.ValueMember = "ID_Cargo"; // recojera el id del cargo seleccionado
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombreEmpleado.Text.Trim().Length == 0)
                {
                    notificador.SetError(txtNombreEmpleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }
                if (txtApellidoEmpleado.Text.Trim().Length == 0)
                {
                    notificador.SetError(txtApellidoEmpleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }
                if (!Regex.IsMatch(txtTelefono.Text, @"^\d{8,8}$"))
                {
                    notificador.SetError(txtTelefono, "No puede quedar vacio o limite de 8 caracteres");
                }
                if (dTFechaNac.Text.Trim().Length == 0)
                {
                    notificador.SetError(dTFechaNac, "Este campo no puede quedar vacio");
                    Valido = false;
                }
                if (!int.TryParse(txtISSS.Text, out int iss))
                {
                    notificador.SetError(txtISSS, "Este campo no puede quedar vacio");
                    Valido = false;
                }
                if (!Regex.IsMatch(txtDUI.Text, @"^\d{6}-\d{1}$"))
                {
                    notificador.SetError(txtDUI, "El formato ingresado no es valido");
                    Valido = false;
                }
                if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    notificador.SetError(txtCorreo, "El correo no tiene el estandar correcto");
                    Valido = false;
                }
                if (cbxCargo.Text.Trim().Length == 0)
                {
                    notificador.SetError(cbxCargo, "El correo no tiene el estandar correcto");
                    Valido = false;
                }
                if (txtDireccion.Text.Trim().Length == 0)
                {
                    notificador.SetError(txtDireccion, "El campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
                Console.WriteLine(ex.ToString());
            }
            return Valido;
        }
        public EmpleadosEdicion()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void EmpleadosEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    try
                    {
                        int ID_empleados = Convert.ToInt32(txtIDEmpleado.Text);
                    }
                    catch (Exception)
                    {
                     
                    }
                    //asinga los datos que estan en las cajas de texto a la variable de la clase empleados creda
                    //int idEmpleado = Convert.ToInt32(txtIDEmpleado.Text);
                    string nombre = txtNombreEmpleado.Text;
                    string apellido = txtApellidoEmpleado.Text;
                    DateTime fechaNac = dTFechaNac.Value;
                    string telefono = txtTelefono.Text;
                    string correo = txtCorreo.Text;
                    string dui = txtDUI.Text;
                    string iss = txtISSS.Text;
                    int selectedCargoId = (int)cbxCargo.SelectedValue;
                    string direccion = txtDireccion.Text;

                    var result = new ControladorEmpleados();

                    if (txtIDEmpleado.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO
                        bool resultado = result.InsertEmpleados (nombre, apellido, fechaNac, telefono, correo, dui,iss, selectedCargoId, direccion);
                        Console.WriteLine( resultado );

                        if (resultado){ Close(); MessageBox.Show("Paciente insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { MessageBox.Show("Error al insertar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        //ACTUALIZAR EL REGISTRO
                        int ID_empleados = Convert.ToInt32(txtIDEmpleado.Text);
                        bool resultado = result.ActualizarEmpleado(ID_empleados, nombre,apellido, fechaNac,telefono, correo, dui,iss, selectedCargoId,direccion);
                        if (resultado)
                        {
                            Close(); MessageBox.Show("Paciente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           EmpleadosGestion empleados = new EmpleadosGestion();
                            DatosActualizados?.Invoke();
                        }
                        else { MessageBox.Show("Error al actualizar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        CLS.Empleados oEmpleados = new CLS.Empleados();
                    }
                }
            }catch(Exception ex)
            { Console.WriteLine( ex.Message); }
        }
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {}
    }
}
