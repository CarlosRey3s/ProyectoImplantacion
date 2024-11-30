using Principal.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Principal.GUI
{
    public partial class Login : Form
    {
       private Boolean _Autorizado = false;

        public Login()
        {
            InitializeComponent();
        }
        public bool Autorizado { get => _Autorizado; set => _Autorizado = value; }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            /// Crear instancia de SesionLogin para verificar credenciales
            SesionLogin sesion = new SesionLogin
            {
                Username = txtUsuario.Text,   // Establecer directamente usando las propiedades
                Password = txtClave.Text
            };

            if (sesion.Verificar())
            {
                // Si las credenciales son correctas
                _Autorizado = true;
                this.Close();  // Cerrar el formulario de login
            }
            else
            {
                // Mostrar mensaje de error en caso de credenciales inválidas
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
