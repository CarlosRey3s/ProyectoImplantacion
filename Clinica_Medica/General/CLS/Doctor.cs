using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Doctor
    {
<<<<<<< HEAD
        // Propiedades de la clase
        private Int32 _ID_Doctor;
        private Int32 _ID_Especialidad;
        private Int32 _ID_Empleado;
        private Int32 _NumeroLicencia;
        private string _Especialidad;
        private string _Estado; // Nueva propiedad para Doc_Estado

        // Getters y Setters
        public Int32 ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public Int32 ID_Especialidad { get => _ID_Especialidad; set => _ID_Especialidad = value; }
        public Int32 ID_Empleado { get => _ID_Empleado; set => _ID_Empleado = value; }
        public Int32 NumeroLicencia { get => _NumeroLicencia; set => _NumeroLicencia = value; }
        public string Especialidad { get => _Especialidad; set => _Especialidad = value; }
        public string Estado { get => _Estado; set => _Estado = value; } // Propiedad para manejar el estado

        // Método para obtener todos los doctores
        public static DataTable ObtenerDoctores()
        {
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            DataTable Resultado = new DataTable();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("SELECT ");
            Sentencia.Append("CM_Doctores.ID_Doctor, ");
            Sentencia.Append("CONCAT(CM_Empleados.Emp_Nombre, ' ', CM_Empleados.Emp_Apellido) AS NombreCompleto, ");
            Sentencia.Append("CM_Doctores.Doc_Estado ");
            Sentencia.Append("FROM CM_Doctores ");
            Sentencia.Append("INNER JOIN CM_Empleados ");
            Sentencia.Append("ON CM_Doctores.Empleados_ID_Empleado = CM_Empleados.ID_Empleado;");

            try
            {
                Resultado = Operacion.Consultar(Sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener doctores: " + ex.Message);
            }

            return Resultado;
        }

        // Método para obtener solo los doctores disponibles
        public static DataTable ObtenerDoctoresDisponibles()
        {
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            DataTable Resultado = new DataTable();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("SELECT ");
            Sentencia.Append("CM_Doctores.ID_Doctor, ");
            Sentencia.Append("CONCAT(CM_Empleados.Emp_Nombre, ' ', CM_Empleados.Emp_Apellido) AS NombreCompleto ");
            Sentencia.Append("FROM CM_Doctores ");
            Sentencia.Append("INNER JOIN CM_Empleados ");
            Sentencia.Append("ON CM_Doctores.Empleados_ID_Empleado = CM_Empleados.ID_Empleado ");
            Sentencia.Append("WHERE CM_Doctores.Doc_Estado = 'Disponible';");

            try
            {
                Resultado = Operacion.Consultar(Sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener doctores disponibles: " + ex.Message);
            }

            return Resultado;
        }

        // Método para cambiar el estado de un doctor
        public static Boolean CambiarEstadoDoctor(int doctorID, string nuevoEstado)
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE CM_Doctores SET Doc_Estado = '" + nuevoEstado + "' ");
            Sentencia.Append("WHERE ID_Doctor = " + doctorID + ";");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cambiar el estado del doctor: " + ex.Message);
            }

            return Resultado;
        }

        // Método Insertar
=======
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
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL InsertarDoctor(");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "');");

<<<<<<< HEAD
            Sentencia.Append("INSERT INTO `CM_Doctores` (`Doc_NumeroLicencia`, `Especialidades_ID_Especialidad`, `Empleados_ID_Empleado`, `Doc_Estado`) VALUES (");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "', ");
            Sentencia.Append("'" + Estado + "');");

=======
            // Ejecutar la sentencia en la base de datos usando el objeto Operaciones
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }
<<<<<<< HEAD

=======
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
<<<<<<< HEAD

            Sentencia.Append("UPDATE `CM_Doctores` SET ");
            Sentencia.Append("`Doc_NumeroLicencia` = '" + NumeroLicencia + "', ");
            Sentencia.Append("`Especialidades_ID_Especialidad` = '" + ID_Especialidad + "', ");
            Sentencia.Append("`Empleados_ID_Empleado` = '" + ID_Empleado + "', ");
            Sentencia.Append("`Doc_Estado` = '" + Estado + "' ");
            Sentencia.Append("WHERE `ID_Doctor` = " + ID_Doctor + ";");

=======
            Sentencia.Append("CALL ActualizarDoctor(");
            Sentencia.Append("'" + ID_Doctor + "', ");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "');");
            // Ejecutar la sentencia en la base de datos usando el objeto Operaciones
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }
<<<<<<< HEAD


        // Método Eliminar
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("DELETE FROM `CM_Doctores` ");
            Sentencia.Append("WHERE `ID_Doctor` = " + ID_Doctor + ";");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
=======
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
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el doctor: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }
    }
}