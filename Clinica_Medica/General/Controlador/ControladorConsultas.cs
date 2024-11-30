using System;
using General.CLS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Controlador
{
    public class ControladorConsultas
    {
        // Método para insertar una nueva consulta
        public bool InsertarConsulta(Consulta consulta)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("INSERT INTO cm_consultas (Cons_Diganostico, Cons_Tratamiento, Cons_PrecioConsulta, Cons_FechaConsulta, Citas_ID_Cita, Cons_PoseeCita) ");
            sentencia.Append("VALUES (");
            sentencia.Append("'" + consulta.Cons_Diganostico + "', ");
            sentencia.Append("'" + consulta.Cons_Tratamiento + "', ");
            sentencia.Append(consulta.Cons_PrecioConsulta + ", ");
            sentencia.Append("'" + consulta.Cons_FechaConsulta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");

            // Si PoseeCita es "NO", asignamos NULL a Citas_ID_Cita
            if (consulta.Cons_PoseeCita == "NO")
            {
                sentencia.Append("NULL, ");  // Para que Citas_ID_Cita sea NULL si PoseeCita es "NO"
            }
            else
            {
                sentencia.Append(consulta.Citas_ID_Cita + ", ");
            }

            sentencia.Append("'" + consulta.Cons_PoseeCita + "');");

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
                Console.WriteLine("Error al insertar la consulta: " + ex.Message);
            }

            return false;
        }
        // Método para actualizar una consulta existente
        public bool ActualizarConsulta(Consulta consulta)
        {
            // Construir la sentencia SQL de actualización
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE cm_consultas SET ");
            sentencia.Append("Cons_Diganostico = '" + consulta.Cons_Diganostico + "', ");
            sentencia.Append("Cons_Tratamiento = '" + consulta.Cons_Tratamiento + "', ");
            sentencia.Append("Cons_PrecioConsulta = " + consulta.Cons_PrecioConsulta + ", ");
            sentencia.Append("Cons_FechaConsulta = '" + consulta.Cons_FechaConsulta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            sentencia.Append("Citas_ID_Cita = " + consulta.Citas_ID_Cita + " ");
            sentencia.Append("WHERE ID_Consulta = " + consulta.ID_Consulta + ";");

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
                Console.WriteLine("Error al actualizar la consulta: " + ex.Message);
            }

            return false;
        }

        // Método para eliminar una consulta
        public bool EliminarConsulta(Consulta consulta)
        {
            // Construir la sentencia SQL de eliminación
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("DELETE FROM cm_consultas ");
            sentencia.Append("WHERE ID_Consulta = " + consulta.ID_Consulta + ";");

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
                Console.WriteLine("Error al eliminar la consulta: " + ex.Message);
            }

            return false;
        }

        // Método para obtener todas las consultas
        public DataTable ObtenerConsultas()
        {
            string consulta = "SELECT * FROM cm_consultas;";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                return operacion.Consultar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las consultas: " + ex.Message);
            }

            return new DataTable();
        }

        // Método para obtener una consulta por ID
        public Consulta ObtenerConsultaPorId(int idConsulta)
        {
            string consulta = $"SELECT * FROM cm_consultas WHERE ID_Consulta = {idConsulta};";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                DataTable dt = operacion.Consultar(consulta);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Consulta consultaObj = new Consulta
                    {
                        ID_Consulta = Convert.ToInt32(row["ID_Consulta"]),
                        Cons_Diganostico = row["Cons_Diganostico"].ToString(),
                        Cons_Tratamiento = row["Cons_Tratamiento"].ToString(),
                        Cons_PrecioConsulta = Convert.ToSingle(row["Cons_PrecioConsulta"]),
                        Cons_FechaConsulta = Convert.ToDateTime(row["Cons_FechaConsulta"]),
                        Citas_ID_Cita = Convert.ToInt32(row["Citas_ID_Cita"])
                    };
                    return consultaObj;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la consulta: " + ex.Message);
            }

            return null;
        }
    }
}
