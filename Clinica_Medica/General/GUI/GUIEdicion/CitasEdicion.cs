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
    public partial class CitasEdicion : Form
    {
        BindingSource _Datos = new BindingSource();

        private void LlenarComboBoxCargos()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.Paciente();
                cbbNombresPacientes.DataSource = _Datos;
                cbbNombresPacientes.DisplayMember = "NombresPaciente";
                cbbNombresPacientes.ValueMember = "ID_Paciente";
            }
            catch (Exception ex)
            {

            }

        }

        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (cbbNombresPacientes.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbbNombresPacientes, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public CitasEdicion()
        {
            InitializeComponent();
        }

        private void CitasEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    //CREAR UN OBJETO A PARTIR DE LA CLASE ENTIDAD
                    CLS.Citas oCita = new CLS.Citas();
                    //SINCRONIZAMOS EL OBJETO CON LA GUI

                    try
                    {
                        oCita.ID_Cita = Convert.ToInt32(txtID_Cita.Text);
                    }
                    catch (Exception)
                    {

                        oCita.ID_Cita = 0;
                    }
                    int SelectedIdPaciente = (int)cbbNombresPacientes.SelectedValue;
                    oCita.ID_Paciente = SelectedIdPaciente;
                    oCita.Fecha_Hora = dtpFecha_Hora.Value;


                    //PROCEDER
                    if (txtID_Cita.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO REGISTROS
                        if (oCita.Insertar())
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
                    {
                        //ACTUALIZAR REGISTRO
                        if (oCita.Actualizar())
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
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
