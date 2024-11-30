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
    public partial class UsuariosEdicion : Form
    {
        BindingSource _Datos = new BindingSource();


        private void LlenarComboBoxRoles()
        {
            try
            {
                ControladorRoles controladorRoles = new ControladorRoles();
                DataTable dtRoles = controladorRoles.ListarRoles();  // Llamada al método ListarRoles

                // Verificamos que el DataTable no sea null y tenga filas
                if (dtRoles != null && dtRoles.Rows.Count > 0)
                {
                    // Vinculamos el DataTable directamente al ComboBox
                    cbxRoles.DataSource = dtRoles;
                    cbxRoles.DisplayMember = "Rol_NombreRol";  // Muestra el nombre del rol
                    cbxRoles.ValueMember = "ID_Rol";           // El valor será el ID del rol

                    // Opcional: Si quieres depurar los valores, puedes hacerlo así
                    foreach (DataRow row in dtRoles.Rows)
                    {
                        Console.WriteLine($"ID_Rol: {row["ID_Rol"]}, Rol_NombreRol: {row["Rol_NombreRol"]}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron roles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        private void LlenarComboBoxEmpleados()
        {
            try
            {
                // Llamamos al controlador de empleados para obtener la lista de empleados
                ControladorUsuarios controladorEmpleados = new ControladorUsuarios();
                DataTable dtEmpleados = ControladorUsuarios.ListarEmpleados();

                // Vinculamos el DataTable a un BindingSource
                _Datos.DataSource = dtEmpleados;

                // Llenamos el ComboBox con los empleados
                cbxNombre.DataSource = _Datos;
                cbxNombre.DisplayMember = "Emp_Nombre";  // Mostrar el nombre del empleado
                cbxNombre.ValueMember = "ID_Empleado";   // El valor será el ID del empleado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }

       



        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtUsuario, "Este campo no puede quedar vacío");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public UsuariosEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    //CREAR UN OBJETO A PARTIR DE LA CLASE ENTIDAD
                    CLS.Usuario oUsuario = new CLS.Usuario();
                    //SINCRONIZAMOS EL OBJETO CON LA GUI

                    try
                    {
                        oUsuario.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    }
                    catch (Exception)
                    {
                        oUsuario.IdUsuario = 0;
                    }
                    oUsuario.NombreUsuario = txtUsuario.Text;
                    oUsuario.Clave = txtClave.Text;

                    oUsuario.EmpleadoId = Convert.ToInt32(txtUsuarioIDEmpleado.Text);
                    oUsuario.RolId = Convert.ToInt32(txtusuarioIDRol.Text);

                    //PROCEDER
                    if (oUsuario.IdUsuario == 0)
                    {
                        //GUARDAR NUEVO REGISTROS
                        if (oUsuario.Insertar())
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
                        //ACTUALIZAR REGISTRO
                        if (oUsuario.Actualizar())
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
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }

        private void UsuariosEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxRoles();
            LlenarComboBoxEmpleados();


            // Si quieres asegurarte de que el primer item se seleccione correctamente, puedes hacerlo manualmente
            if (cbxRoles.Items.Count > 0)
            {
                cbxRoles.SelectedIndex = 0;  // Selecciona el primer item del ComboBox de roles
                txtusuarioIDRol.Text = cbxRoles.SelectedValue.ToString();  // Asigna el ID del rol al TextBox
            }

            if (cbxNombre.Items.Count > 0)
            {
                cbxNombre.SelectedIndex = 0;  // Selecciona el primer item del ComboBox de empleados
                DataRowView rowView = (DataRowView)cbxNombre.SelectedItem;
                txtUsuarioIDEmpleado.Text = rowView["ID_Empleado"].ToString();  // Asigna el ID del empleado al TextBox
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento cuando se selecciona un item del ComboBox de empleados
        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNombre.SelectedItem != null)
            {
                // Tomamos el ID del empleado seleccionado y lo almacenamos en el TextBox correspondiente
                DataRowView rowView = (DataRowView)cbxNombre.SelectedItem;
                txtUsuarioIDEmpleado.Text = rowView["ID_Empleado"].ToString();
            }
        }

        // Evento cuando se selecciona un item del ComboBox de roles

        private void cbxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo se ejecuta cuando hay un valor seleccionado
            if (cbxRoles.SelectedItem != null)
            {
                // Utiliza SelectedValue para obtener el ID del rol seleccionado
                txtusuarioIDRol.Text = cbxRoles.SelectedValue.ToString();
            }
        }

    }
}
