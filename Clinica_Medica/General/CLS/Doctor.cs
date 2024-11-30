using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Doctor
    {
        Int32 ID_Doctor;
        Int32 ID_Especialidad; 
        Int32 ID_Empleado;
        Int32 NumeroLicencia;
        string Especialidad;
        public Int32 ID_Doctor1 { get => ID_Doctor; set => ID_Doctor = value; }
        public int ID_Especialidad1 { get => ID_Especialidad; set => ID_Especialidad = value; }
        public int ID_Empleado1 { get => ID_Empleado; set => ID_Empleado = value; }
        public int NumeroLicencia1 { get => NumeroLicencia; set => NumeroLicencia = value; }
        public string Especialidads { get => Especialidad; set => Especialidad = value; }

        public static int ObtenerCantidadCitas()
        {
            int totalCitas = 0; // Valor por defecto

            DateTime hoy = DateTime.Now.Date;  // Obtienes solo la fecha actual sin la hora
            string Consulta = $"CALL ObtenerCantidadCitas('{hoy.ToString("yyyy-MM-dd")}')";  // Formato adecuado sin espacio extra

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                // Ejecutar la consulta y obtener el DataTable con los resultados
                DataTable resultado = operacion.Consultar(Consulta);

                // Verificamos si el DataTable tiene filas (resultados)
                if (resultado.Rows.Count > 0)
                {
                    // Extraemos el valor de la primera fila y la columna "TotalCitas" (asumiendo que la columna tiene ese nombre)
                    totalCitas = Convert.ToInt32(resultado.Rows[0]["TotalCitas"]);
                }

                Console.WriteLine("La cantidad de consultas son " + totalCitas);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error: " + ex.Message);
            }

            return totalCitas;
        }






        public static DataTable MostrarEspecialidades()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "CALL MostrarEspecialidades()";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable MostrarDoctores()
        {
            DataTable dt = new DataTable();
            String consulta = "CALL MostrarDoctores();";
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();
            try
            { dt = operaciones.Consultar(consulta);  }
            catch (Exception ex)
            { }
            return dt;
        }
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL InsertarDoctor(");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "');");

            // Ejecutar la sentencia en la base de datos usando el objeto Operaciones
            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL ActualizarDoctor(");
            Sentencia.Append("'" + ID_Doctor + "', ");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "');");
            // Ejecutar la sentencia en la base de datos usando el objeto Operaciones
            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            // Construir la sentencia SQL para ejecutar el procedimiento EliminarDoctor
            Sentencia.Append("CALL EliminarDoctor(");
            Sentencia.Append("'" + ID_Doctor + "');");
            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
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
