using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Doctor
    {
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
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO `CM_Doctores` (`Doc_NumeroLicencia`, `Especialidades_ID_Especialidad`, `Empleados_ID_Empleado`, `Doc_Estado`) VALUES (");
            Sentencia.Append("'" + NumeroLicencia + "', ");
            Sentencia.Append("'" + ID_Especialidad + "', ");
            Sentencia.Append("'" + ID_Empleado + "', ");
            Sentencia.Append("'" + Estado + "');");

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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE `CM_Doctores` SET ");
            Sentencia.Append("`Doc_NumeroLicencia` = '" + NumeroLicencia + "', ");
            Sentencia.Append("`Especialidades_ID_Especialidad` = '" + ID_Especialidad + "', ");
            Sentencia.Append("`Empleados_ID_Empleado` = '" + ID_Empleado + "', ");
            Sentencia.Append("`Doc_Estado` = '" + Estado + "' ");
            Sentencia.Append("WHERE `ID_Doctor` = " + ID_Doctor + ";");

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