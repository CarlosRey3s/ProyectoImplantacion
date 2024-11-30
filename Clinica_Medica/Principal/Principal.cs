using General.GUI;
using General.GUI.GUIGestiones;
using Principal.CLS;
using Principal.GUI;
using Reportes.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Principal
{
    public partial class Principal : Form
    {
        private Form activeForm;
        public Principal()
        {
            InitializeComponent();
            //quitar barra
           // this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        } 
        private void OpenFroms(Form from)
        {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = from;
            from.TopLevel = false;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Dock = DockStyle.Fill;
            this.PanelEscritorio.Controls.Add(from);
            this.PanelEscritorio.Tag = from;
            from.BringToFront();
            from.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            OpenFroms(home);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //creacion de objeto para llamarlo
            //nuevoMenuItem.Click += (s, ev) => OpenFroms(f);

            Reportes.GUI.visorMedicamentos f = new visorMedicamentos();
            Reportes.GUI.visorFactura factura = new visorFactura();//ESTA COMENTADO POR QUE EL REPORTE NO EXITE AQUI 
            Reportes.GUI.visorCitas cita = new visorCitas();
            //SE TIENE QUE CREAR 
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            //parte para crear el submenu que se tocara mostrar cuando seleccione el boton
            ToolStripMenuItem nuevoMenuItem = new ToolStripMenuItem("Reporte de Inventario"); //asigna un nombre para el reporte que creaste
            ToolStripMenuItem facturaITem = new ToolStripMenuItem("Reporte de Factura"); //asigna un nombre para el reporte que creaste
            ToolStripMenuItem salirMenuItem = new ToolStripMenuItem("Reporte de Citas"); //asigna un nombre para el reporte que creaste

            // Asinga los valores a boton que se creo anteriormente
            nuevoMenuItem.Click += (s, ev) => OpenFroms(f); // mostrara el primer reporte  solo ponele el objeto que crearte 
            facturaITem.Click += (s, ev) => OpenFroms(factura); // cambia la f por la variable del objeto que se creo para mostrar el reporte
            salirMenuItem.Click += (s, ev) => OpenFroms(cita);  // cambia la f por la variable del objeto que se creo para mostrar el reporte

            // No tocar nada ya que aui manda a llarmlo para mostrar y ejecuta todo si se mueve valio
            contextMenu.Items.Add(nuevoMenuItem);
            contextMenu.Items.Add(facturaITem);
            contextMenu.Items.Add(new ToolStripSeparator()); // Separador
            contextMenu.Items.Add(salirMenuItem);

            // Mostrar el ContextMenuStrip en la posición del cursor
            contextMenu.Show(Cursor.Position);
        }

        private void btnDasdoard_Click(object sender, EventArgs e)
        {
            //  pictureBox2.Image = Image.FromFile("C:\\Users\\ccerr\\Documents\\Iconos\\casa.png");

            pictureBox2.Image = btnDasdoard.Image; // selecciona la imagen que esta en el boton
            TituloBarra.Text = btnDasdoard.Text;
            prueba home = new prueba();
            OpenFroms(home);
        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = btnPacientes.Image;
            TituloBarra.Text = btnPacientes.Text;
            PacientesGestion home = new PacientesGestion();
            OpenFroms(home);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }
        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
 
            else
                WindowState = FormWindowState.Normal;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = btnDoctores.Image; // selecciona la imagen que esta en el boton
            TituloBarra.Text = btnDoctores.Text;
            DoctoresGestion doctores = new DoctoresGestion();
            OpenFroms(doctores);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = btnEmpleados.Image; // selecciona la imagen que esta en el boton
            TituloBarra.Text = btnEmpleados.Text;
            EmpleadosGestion empleados = new EmpleadosGestion();
            OpenFroms(empleados);
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = btnMedicamentos.Image; // selecciona la imagen que esta en el boton
            TituloBarra.Text = btnMedicamentos.Text;
            MedicamentoGestion medicamento = new MedicamentoGestion();
            OpenFroms(medicamento);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = btnUsuarios.Image; // selecciona la imagen que esta en el boton
            TituloBarra.Text = btnUsuarios.Text;
            UsuariosGestion usuario = new UsuariosGestion();
            OpenFroms(usuario);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
            SesionLogin login = new SesionLogin();
            login.CerrarSesion();
            
            Close();
           AppManager appManager = new AppManager();
            appManager.SesionLogin();




        }
    }

}

