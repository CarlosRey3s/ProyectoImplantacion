using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Consulta
    {
        // Propiedades
        private int _ID_Consulta;
        private int _Citas_ID_Cita;
        private string _Cons_Diganostico;
        private string _Cons_Tratamiento;
        private string _Cons_PoseeCita;
        private float _Cons_PrecioConsulta;
        private DateTime _Cons_FechaConsulta;

        public int ID_Consulta { get => _ID_Consulta; set => _ID_Consulta = value; }
        public int Citas_ID_Cita { get => _Citas_ID_Cita; set => _Citas_ID_Cita = value; }
        public string Cons_Diganostico { get => _Cons_Diganostico; set => _Cons_Diganostico = value; }
        public string Cons_Tratamiento { get => _Cons_Tratamiento; set => _Cons_Tratamiento = value; }
        public float Cons_PrecioConsulta { get => _Cons_PrecioConsulta; set => _Cons_PrecioConsulta = value; }
        public DateTime Cons_FechaConsulta { get => _Cons_FechaConsulta; set => _Cons_FechaConsulta = value; }
        public string Cons_PoseeCita { get => _Cons_PoseeCita; set => _Cons_PoseeCita = value; }
        // Método Insertar
        public bool InsertarConsulta(Consulta consulta)
        {
            // Construir la sentencia SQL de inserción
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
                sentencia.Append(consulta.Citas_ID_Cita + ", ");  // Asignamos el ID de la cita si PoseeCita es "SI"
            }

            // Insertar el valor de Cons_PoseeCita
            sentencia.Append("'" + consulta.Cons_PoseeCita + "');");

            try
            {
                // Ejecutar la sentencia SQL en la base de datos
                DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, lo registramos en la consola
                Console.WriteLine("Error al insertar la consulta: " + ex.Message);
            }

            return false;
        }
        // Método Actualizar
        public bool ActualizarConsulta(Consulta consulta)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE cm_consultas SET ");
            sentencia.Append("Cons_Diganostico = '" + consulta.Cons_Diganostico + "', ");
            sentencia.Append("Cons_Tratamiento = '" + consulta.Cons_Tratamiento + "', ");
            sentencia.Append("Cons_PrecioConsulta = " + consulta.Cons_PrecioConsulta + ", ");
            sentencia.Append("Cons_FechaConsulta = '" + consulta.Cons_FechaConsulta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            sentencia.Append("Cons_PoseeCita = '" + consulta.Cons_PoseeCita + "', ");

            // Si PoseeCita es "NO", asignamos NULL a Citas_ID_Cita
            if (consulta.Cons_PoseeCita == "NO")
            {
                sentencia.Append("Citas_ID_Cita = NULL ");
            }
            else
            {
                sentencia.Append("Citas_ID_Cita = " + consulta.Citas_ID_Cita);
            }

            sentencia.Append(" WHERE ID_Consulta = " + consulta.ID_Consulta + ";");

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
    }
}