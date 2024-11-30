using System;
using General.CLS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Controlador
{
    public class ControladorCitas
    {
        // Método para insertar una nueva cita
        public bool InsertarCita(Citas cita)
        {
            // Construir la sentencia SQL de inserción
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("INSERT INTO cm_citas (Cit_FechaHora, Cit_Motivo, Cit_Estado, Pacientes_ID_Paciente, Doctores_ID_Doctor, Consultorios_ID_Consultorio) ");
            sentencia.Append("VALUES (");
            sentencia.Append("'" + cita.FechaHora.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            sentencia.Append("'" + cita.Motivo + "', ");
            sentencia.Append("'" + cita.Estado + "', ");
            sentencia.Append((cita.Pacientes_ID_Paciente.HasValue ? cita.Pacientes_ID_Paciente.Value.ToString() : "NULL") + ", ");
            sentencia.Append((cita.Doctores_ID_Doctor.HasValue ? cita.Doctores_ID_Doctor.Value.ToString() : "NULL") + ", ");
            sentencia.Append((cita.Consultorios_ID_Consultorio.HasValue ? cita.Consultorios_ID_Consultorio.Value.ToString() : "NULL") + ");");

            try
            {
                DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la cita: " + ex.Message);
            }

            return false;
        }

        // Método para actualizar una cita existente
        public bool ActualizarCita(Citas cita)
        {
            // Construir la sentencia SQL de actualización
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE cm_citas SET ");
            sentencia.Append("Cit_FechaHora = '" + cita.FechaHora.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            sentencia.Append("Cit_Motivo = '" + cita.Motivo + "', ");
            sentencia.Append("Cit_Estado = '" + cita.Estado + "', ");
            sentencia.Append("Doctores_ID_Doctor = " + (cita.Doctores_ID_Doctor.HasValue ? cita.Doctores_ID_Doctor.Value.ToString() : "NULL") + ", ");
            sentencia.Append("Consultorios_ID_Consultorio = " + (cita.Consultorios_ID_Consultorio.HasValue ? cita.Consultorios_ID_Consultorio.Value.ToString() : "NULL"));
            sentencia.Append(" WHERE ID_Cita = " + cita.ID_Cita + ";");

            try
            {
                DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la cita: " + ex.Message);
            }

            return false;
        }

        // Método para eliminar una cita
        public bool EliminarCita(Citas cita)
        {
            // Construir la sentencia SQL de eliminación
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("DELETE FROM cm_citas ");
            sentencia.Append("WHERE ID_Cita = " + cita.ID_Cita + ";");

            try
            {
                DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la cita: " + ex.Message);
            }

            return false;
        }

        // Método para obtener todas las citas
        public DataTable ObtenerCitas()
        {
            String consulta = "SELECT * FROM cm_citas;";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                return operacion.Consultar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las citas: " + ex.Message);
            }

            return new DataTable();
        }

        // Método para obtener una cita por ID
        public Citas ObtenerCitaPorId(int idCita)
        {
            string consulta = $"SELECT * FROM cm_citas WHERE ID_Cita = {idCita};";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                DataTable dt = operacion.Consultar(consulta);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Citas cita = new Citas
                    {
                        ID_Cita = Convert.ToInt32(row["ID_Cita"]),
                        FechaHora = Convert.ToDateTime(row["Cit_FechaHora"]),
                        Motivo = row["Cit_Motivo"].ToString(),
                        Estado = row["Cit_Estado"].ToString(),
                        Pacientes_ID_Paciente = row["Pacientes_ID_Paciente"] as int?,
                        Doctores_ID_Doctor = row["Doctores_ID_Doctor"] as int?,
                        Consultorios_ID_Consultorio = row["Consultorios_ID_Consultorio"] as int?
                    };
                    return cita;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la cita: " + ex.Message);
            }

            return null;
        }
    }
}
