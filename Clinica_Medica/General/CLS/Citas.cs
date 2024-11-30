using DataLayer;
using System;
using General.CLS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    public class Citas
    {
        Int32 _ID_Cita;
        DateTime _FechaHora;
        string _Motivo;
        string _Estado;
        Int32? _Doctores_ID_Doctor; // Nullable
        Int32? _Consultorios_ID_Consultorio; // Nullable
        Int32? _Pacientes_ID_Paciente;

        // Propiedades
        public int ID_Cita { get => _ID_Cita; set => _ID_Cita = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public string Motivo { get => _Motivo; set => _Motivo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public int? Doctores_ID_Doctor { get => _Doctores_ID_Doctor; set => _Doctores_ID_Doctor = value; }
        public int? Consultorios_ID_Consultorio { get => _Consultorios_ID_Consultorio; set => _Consultorios_ID_Consultorio = value; }
        public int? Pacientes_ID_Paciente { get => _Pacientes_ID_Paciente; set => _Pacientes_ID_Paciente = value; }
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO cm_citas (Cit_FechaHora, Cit_Motivo, Cit_Estado, Pacientes_ID_Paciente, Doctores_ID_Doctor, Consultorios_ID_Consultorio) VALUES (");
            Sentencia.Append("'" + _FechaHora.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("'" + _Motivo + "', ");
            Sentencia.Append("'" + _Estado + "', ");
            Sentencia.Append((_Pacientes_ID_Paciente.HasValue ? _Pacientes_ID_Paciente.Value.ToString() : "NULL") + ", ");
            Sentencia.Append((_Doctores_ID_Doctor.HasValue ? _Doctores_ID_Doctor.Value.ToString() : "NULL") + ", ");
            Sentencia.Append((_Consultorios_ID_Consultorio.HasValue ? _Consultorios_ID_Consultorio.Value.ToString() : "NULL") + ");");

            try
            {
                Console.WriteLine("Consulta SQL Generada: " + Sentencia.ToString());
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    // Cambiar el estado del doctor a 'Ocupado'
                    if (_Doctores_ID_Doctor.HasValue)
                    {
                        Doctor.CambiarEstadoDoctor(_Doctores_ID_Doctor.Value, "Ocupado");
                    }
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta SQL: " + ex.Message);
                MessageBox.Show("Error al guardar la cita. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            try
            {
                // Obtener el doctor actual antes de actualizar
                int doctorActual = _Doctores_ID_Doctor ?? -1;

                StringBuilder Sentencia = new StringBuilder();
                Sentencia.Append("UPDATE cm_citas SET ");
                Sentencia.Append("Cit_FechaHora = '" + _FechaHora.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
                Sentencia.Append("Cit_Motivo = '" + _Motivo + "', ");
                Sentencia.Append("Cit_Estado = '" + _Estado + "', ");
                Sentencia.Append("Doctores_ID_Doctor = " + (_Doctores_ID_Doctor.HasValue ? _Doctores_ID_Doctor.Value.ToString() : "NULL") + ", ");
                Sentencia.Append("Consultorios_ID_Consultorio = " + (_Consultorios_ID_Consultorio.HasValue ? _Consultorios_ID_Consultorio.Value.ToString() : "NULL"));
                Sentencia.Append(" WHERE ID_Cita = " + _ID_Cita + ";");

                Console.WriteLine("Consulta SQL Generada para Actualizar: " + Sentencia.ToString());

                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    // Si el doctor cambió, actualizar los estados
                    if (_Doctores_ID_Doctor.HasValue && doctorActual != _Doctores_ID_Doctor.Value)
                    {
                        // Liberar el estado del doctor anterior
                        if (doctorActual != -1)
                        {
                            Doctor.CambiarEstadoDoctor(doctorActual, "Disponible");
                        }

                        // Asignar el nuevo estado al doctor actual
                        Doctor.CambiarEstadoDoctor(_Doctores_ID_Doctor.Value, "Ocupado");
                    }

                    Resultado = true;
                }
                else
                {
                    Console.WriteLine("Error al ejecutar la consulta de actualización.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la cita: " + ex.Message);
            }

            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            try
            {
                // Obtener el ID del doctor antes de eliminar la cita
                int doctorID = _Doctores_ID_Doctor.HasValue ? _Doctores_ID_Doctor.Value : -1;

                // Eliminar la cita
                Sentencia.Append("DELETE FROM `CM_Citas` ");
                Sentencia.Append("WHERE `ID_Cita` = " + _ID_Cita + ";");

                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    // Cambiar el estado del doctor a 'Disponible'
                    if (doctorID != -1)
                    {
                        Doctor.CambiarEstadoDoctor(doctorID, "Disponible");
                    }
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }

            return Resultado;
        }

    }
}
