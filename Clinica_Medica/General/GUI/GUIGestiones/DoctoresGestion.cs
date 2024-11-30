using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.CLS;
using General.Controlador;
using General.GUI;

namespace General.GUI
{
    public partial class DoctoresGestion : Form
    {
        BindingSource _Datos = new BindingSource();
        private void Cargar()// Muestra la informacion en el datagripview
        { 
            try
            {
                _Datos.DataSource = Doctor.MostrarDoctores();
                dtbDoctor.DataSource = _Datos;
                dtbDoctor.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
            }
        }
            public DoctoresGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void Doctor_Load(object sender, EventArgs e)
        { Cargar(); }
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar esta el doctor?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoctoresEdicion f = new DoctoresEdicion();

                    f.txtID_Doctor.Text = dtbDoctor.CurrentRow.Cells["ID_Doctor"].Value.ToString();
                    f.txtID_Empleado.Text = dtbDoctor.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                    f.txtNumeroLicencia.Text = dtbDoctor.CurrentRow.Cells["NumeroLIcencia"].Value.ToString();
                    f.cbxEspecialidad.Text = dtbDoctor.CurrentRow.Cells["Especialidad"].Value.ToString();
                    f.Show();
                    Cargar();
                    f.DatosActualizado += Cargar;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DoctoresEdicion doc = new DoctoresEdicion();
                doc.ShowDialog();

            }
            catch (Exception) { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           DoctoresEdicion f = new DoctoresEdicion();
            f.txtID_Doctor.Text = dtbDoctor.CurrentRow.Cells["ID_Doctor"].Value.ToString();
            f.txtID_Empleado.Text = dtbDoctor.CurrentRow.Cells["Empleados_ID_Empleado"].Value.ToString();
            f.txtNumeroLicencia.Text = dtbDoctor.CurrentRow.Cells["Doc_NumeroLicencia"].Value.ToString();
            f.cbxEspecialidad.Text = dtbDoctor.CurrentRow.Cells["Especialidades_ID_Especialidad"].Value.ToString();
            f.Show();
            f.DatosActualizado += Cargar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el doctor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int ID_Doctor = Convert.ToInt32(dtbDoctor.CurrentRow.Cells["ID_Doctor"].Value.ToString());
                    var controller = new ControladorDoctores();
                    bool eliminado = controller.EliminarDoctor(ID_Doctor);

                    if (eliminado)
                    {
                        MessageBox.Show("Doctor eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El doctor no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
