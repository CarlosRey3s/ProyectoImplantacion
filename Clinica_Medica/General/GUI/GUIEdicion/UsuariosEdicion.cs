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
        private void LlenarComboBoxRoles ()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.RolesUsuario();
                cbxRoles.DataSource = _Datos;
                cbxRoles.DisplayMember = "NombreRol"; //Mostrara los cargos de la tabla cargo 
                cbxRoles.ValueMember = "ID_Rol";
            }catch(Exception ex) { }
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
                        oUsuario.ID_Usuario = Convert.ToInt32(txtIdUsuario.Text);
                    }
                    catch (Exception)
                    {
                        oUsuario.ID_Usuario = 0;
                    }
                    oUsuario.UsuarioNombre = txtUsuario.Text;
                    oUsuario.Clave = txtClave.Text;

                    oUsuario.ID_Empleado = Convert.ToInt32(txtUsuarioIDEmpleado.Text);
                    oUsuario.ID_Rol = Convert.ToInt32(txtusuarioIDRol.Text);

                    //PROCEDER
                    if (oUsuario.ID_Usuario == 0)
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
        }
    }
}
