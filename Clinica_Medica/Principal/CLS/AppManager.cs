using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.CLS
{
   
        class AppManager : ApplicationContext
        {
            private void SplahScreen()
            {
                try
                {
                    GUI.Splash F = new GUI.Splash();
                    F.ShowDialog();
                }
                catch (Exception)
                {

                }
            }

            private Boolean LoginScreen()
            {
                bool resultado = false;

                try
                {GUI.Login F = new GUI.Login();
                    F.ShowDialog();

                    resultado = F.Autorizado;
                }
                catch (Exception ex)
                {
                    resultado = false;
                }

                return resultado;
            }

            public AppManager()
            {
            // Muestra la pantalla de splash si es necesario
            SplahScreen();

            // Verifica si el login fue exitoso
            if (LoginScreen())
            {
                // Si el login es exitoso, muestra la pantalla principal
                AbrirFormularioPrincipal();
            }
            else
            {
                // Si el login falla, termina la aplicación
                Application.Exit();
            }
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario principal, vuelve a mostrar el login
            if (LoginScreen())
            {
                // Si el login es exitoso nuevamente, abrir el formulario principal otra vez
                AbrirFormularioPrincipal();
            }
            else
            {
                // Si el login falla, termina la aplicación
                Application.Exit();
            }

        }

        // Método que abre el formulario principal
        private void AbrirFormularioPrincipal()
        {// Mostrar el formulario principal una vez que el login sea exitoso
            Principal mainForm = new Principal();
            mainForm.FormClosed += (s, e) => Application.Exit();  // Cerrar la aplicación cuando el formulario principal se cierra
            mainForm.Show();
        }
        public void SesionLogin()
            {
            if (LoginScreen())
            {
                AbrirFormularioPrincipal();
            }
        }

        }



}
