using General.CLS;
using General.Controlador;
using General.GUI.VistaPrevia;
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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _Datos = new BindingSource();
        private void FiltrarLocalmente()
        {
            try
            {
                // Obtener el texto ingresado en el cuadro de texto de filtro
                string filtro = txtFiltro.Text.Trim();
                // Filtrar los datos en función del texto ingresado
                if (filtro.Length <= 0)
                {
                    _Datos.RemoveFilter();
                }
                else
                {
                    // Construir la expresión de filtro para filtrar por nombre de usuario
                    string filtroExpresion = $"NombresEmpleado LIKE '%{filtro}%'";
                    // Aplicar el filtro
                    _Datos.Filter = filtroExpresion;
                }
                dtbEmpleado.AutoGenerateColumns = false;
                dtbEmpleado.DataSource = _Datos;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar()
        {
            try
            {
                _Datos.DataSource = Empleados.MostrarEmpleados();
                dtbEmpleado.DataSource = _Datos;
                dtbEmpleado.AutoGenerateColumns = false;
               
            }
            catch (Exception ex)
            {}
        }
        public EmpleadosGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosEdicion E = new EmpleadosEdicion();
                E.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {}
        }
        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            FiltrarLocalmente();
            ContarEmpleados();
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar el empleado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EmpleadosEdicion empleados = new EmpleadosEdicion();
                    
                    empleados.txtIDEmpleado.Text = dtbEmpleado.CurrentRow.Cells["ID_empleado"].Value.ToString();
                    empleados.txtNombreEmpleado.Text = dtbEmpleado.CurrentRow.Cells["Emp_Nombre"].Value.ToString();
                    empleados.txtApellidoEmpleado.Text = dtbEmpleado.CurrentRow.Cells["Emp_Apellido"].Value.ToString();
                    empleados.dTFechaNac.Text = dtbEmpleado.CurrentRow.Cells["Emp_FechaNacimiento"].Value.ToString();
                    empleados.txtTelefono.Text = dtbEmpleado.CurrentRow.Cells["Emp_Telefono"].Value.ToString();
                    empleados.txtDUI.Text = dtbEmpleado.CurrentRow.Cells["Emp_DUI"].Value.ToString();
                    empleados.txtISSS.Text = dtbEmpleado.CurrentRow.Cells["Emp_ISSS"].Value.ToString();
                    empleados.txtCorreo.Text = dtbEmpleado.CurrentRow.Cells["Emp_Correo"].Value.ToString();
                    empleados.cbxCargo.Text = dtbEmpleado.CurrentRow.Cells["Cargos_ID_Cargo"].Value.ToString();
                    empleados.txtDireccion.Text = dtbEmpleado.CurrentRow.Cells["Emp_Direccion"].Value.ToString();
                    empleados.Show();
                    empleados.DatosActualizados += Cargar;
                  
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int ID_empleados = Convert.ToInt32(dtbEmpleado.CurrentRow.Cells["ID_empleado"].Value.ToString());
                    var controller = new ControladorEmpleados();
                    bool eliminado = controller.EliminarEmpleado(ID_empleados);
                    if (eliminado)
                    {
                        MessageBox.Show("Empleado eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El empleado no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VistaPrevia_Click(object sender, EventArgs e)
        {
            VistaPreviaEmpleado f = new VistaPreviaEmpleado();  
                if (dtbEmpleado.CurrentRow != null)
                {
                f.ID_Empleado.Text = dtbEmpleado.CurrentRow.Cells["ID_empleado"].Value.ToString();
                f.NombresEmpleado.Text = dtbEmpleado.CurrentRow.Cells["Nombre"].Value.ToString();
                f.ApellidosEmpleado.Text = dtbEmpleado.CurrentRow.Cells["Apellido"].Value.ToString();
                f.TelefonoEmpleado.Text = dtbEmpleado.CurrentRow.Cells["Telefono"].Value.ToString();
                f.FechaNacEmpleado.Text = dtbEmpleado.CurrentRow.Cells["FechaNacminiento"].Value.ToString();
                f.ISSS_Empleado.Text = dtbEmpleado.CurrentRow.Cells["ISSS"].Value.ToString();
                f.DUI_Empleado.Text = dtbEmpleado.CurrentRow.Cells["DUI"].Value.ToString();
                f.Correo.Text = dtbEmpleado.CurrentRow.Cells["Correo"].Value.ToString();
                f.ID_Cargo.Text = dtbEmpleado.CurrentRow.Cells["Cargo"].Value.ToString();
                f.ID_Direccion.Text = dtbEmpleado.CurrentRow.Cells["Direccion"].Value.ToString();
            }
            f.ShowDialog();
        }
        private void txtFiltro_Click(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {        }
        private void ContarEmpleados()
        {
            int totalEmpleados = dtbEmpleado.RowCount;
            TotalEmpleados.Text = totalEmpleados.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {}
    }
}
