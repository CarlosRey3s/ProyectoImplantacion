using DataLayer;

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
    public partial class EmpleadosEdicion : Form
    {
        BindingSource _Datos = new BindingSource();
        private void LlenarComboBoxCargos() //el metodo se ejcutara para llenar el combobox Cargo
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.Cargos();
                cbxCargo.DataSource = _Datos;
                cbxCargo.DisplayMember = "Cargo"; //Mostrara los cargos de la tabla cargo 
                cbxCargo.ValueMember = "ID_Cargo"; // recojera el id del cargo seleccionado
            }
            catch (Exception ex)
            {}
        }
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombreEmpleado.Text.Trim().Length == 0)
                {
                    //valida que los campos no queden vacios
                    notificador.SetError(txtNombreEmpleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
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
                    CLS.Empleados oEmpleados = new CLS.Empleados();
                    try
                    {
                        oEmpleados.ID_empleados = Convert.ToInt32(txtIDEmpleado.Text);
                    }
                    catch (Exception)
                    {
                        oEmpleados.ID_empleados = 0;
                    }
                    //asinga los datos que estan en las cajas de texto a la variable de la clase empleados creda
                        oEmpleados.NombresEmpleados = txtNombreEmpleado.Text;
                        oEmpleados.ApellidosEmpleados = txtApellidoEmpleado.Text;
                        oEmpleados.FechaNacEmpleados = dTFechaNac.Value;
                        oEmpleados.TelefonoEmpleados = txtTelefono.Text;
                        oEmpleados.Correos = txtCorreo.Text;
                        oEmpleados.DUI_Empleados = txtDUI.Text;
                        oEmpleados.ISSS_Empleados = Convert.ToInt32(txtISSS.Text);
                        oEmpleados.Cargos = cbxCargo.Text;
                        int selectedCargoId = (int)cbxCargo.SelectedValue;
                        oEmpleados.ID_Cargos = selectedCargoId;
                        oEmpleados.Direcciones  = txtDireccion.Text;
                    if (txtIDEmpleado.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO 
                            if (oEmpleados.Insertar()) // llama al metodo insertar empleado
                            {
                                Close();
                                MessageBox.Show("Registro Guardado");
                            }
                            else
                            {
                                MessageBox.Show("El registro no pude ser almacenado");
                            }                         
                    }
                    else
                    { //ACTUALIZAR REGISTRO
                        if (oEmpleados.Actualizar())
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
            }catch(Exception ex)
            { }
        }
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
