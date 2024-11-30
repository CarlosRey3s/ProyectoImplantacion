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
    public partial class ConsultasEdicion : Form
    {
        BindingSource _Datos = new BindingSource();
        BindingSource _Datos2 = new BindingSource();
        BindingSource _Datos3 = new BindingSource();
        BindingSource _Datos4 = new BindingSource();


        private void LlenarComboBoxCargos()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.RecetasMedicas();
                cbbID_Receta.DataSource = _Datos;
                cbbID_Receta.DisplayMember = "NombreInsumo";
                cbbID_Receta.ValueMember = "ID_Insumo";

                _Datos2.DataSource = DataLayer.Consulta.Citas();
                cbbIdcita.DataSource = _Datos2;
                cbbIdcita.DisplayMember = "NombresPaciente";
                cbbIdcita.ValueMember = "ID_Cita";

                _Datos3.DataSource = DataLayer.Consulta.Doctor();
                cbbID_doctor.DataSource = _Datos3;
                cbbID_doctor.DisplayMember = "NombresEmpleado";
                cbbID_doctor.ValueMember = "ID_Doctor";

                _Datos4.DataSource = DataLayer.Consulta.Consultorio();
                cbbConsultorio.DataSource = _Datos4;
                cbbConsultorio.DisplayMember = "NumeroConsultorio";
                cbbConsultorio.ValueMember = "ID_Consultorio";
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
                if (cbbIdcita.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbbIdcita, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
            }
            return Valido;
        }
        public ConsultasEdicion()
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
                    CLS.Consulta oConsulta = new CLS.Consulta();
                    //SINCRONIZAMOS EL OBJETO CON LA GUI

                    try
                    {
                        oConsulta.ID_Consulta = Convert.ToInt32(cbbIdcita.Text);
                    }
                    catch (Exception)
                    {

                        oConsulta.ID_Consulta = 0;
                    }
                    int SelectedIdInsumo = (int)cbbID_Receta.SelectedValue;
                    oConsulta.ID_Receta = SelectedIdInsumo;
                    int SelectedIdcita = (int)cbbIdcita.SelectedValue;
                    oConsulta.ID_Cita = SelectedIdcita;
                    int SelectedIdDoc = (int)cbbID_doctor.SelectedValue;
                    oConsulta.ID_Doctor = SelectedIdDoc;
                    int SelectedIdConsul = (int)cbbConsultorio.SelectedValue;
                    oConsulta.ID_Consultorio = SelectedIdConsul;
                    oConsulta.Dianostico = txtDignostico.Text;
                    oConsulta.Indicaciones = txtIndicaciones.Text;



                    //PROCEDER
                    if (txtID_Consulta.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO REGISTROS
                        if (oConsulta.Insertar())
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
                        if (oConsulta.Actualizar())
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

        private void ConsultasEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
