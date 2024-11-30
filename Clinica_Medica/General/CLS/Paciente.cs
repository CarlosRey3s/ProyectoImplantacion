using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Paciente
    {
        Int32 _ID_Paciente;
        string _Nombre;
        string _Apellido;
        DateTime _FechaNacimiento;
        string _Genero;
        string _Telefono;
        string _CorreoElectronico;
        string _Direccion;
        // CTRL + R + E
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

        public static DataTable ObtenerPacientes()
        {
            DataTable Resultado = new DataTable();
            try
            {
                // Consulta que trae todos los pacientes
                string consultaSQL = "SELECT ID_Paciente, CONCAT(Pac_Nombre, ' ', Pac_Apellido) AS NombreCompleto FROM cm_pacientes";
                Resultado = new DataLayer.DBOperaciones().Consultar(consultaSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los pacientes: " + ex.Message);
            }
            return Resultado;
        }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            // Permiten construir cadenas los StringBuilder
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO cm_pacientes(Pac_Nombre, Pac_Apellido, Pac_FechaNacimiento, Pac_Genero, Pac_Telefono, Pac_CorreoElectronico, Pac_Direccion) VALUES (");
            Sentencia.Append("'" + _Nombre + "', ");
            Sentencia.Append("'" + _Apellido + "', ");
            Sentencia.Append("'" + _FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("'" + _Genero + "', ");
            Sentencia.Append("'" + _Telefono + "', ");
            Sentencia.Append("'" + _CorreoElectronico + "', ");
            Sentencia.Append("'" + _Direccion + "');");

            // Aquí podrías ejecutar la sentencia SQL usando tu objeto Operacion
            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
                Resultado |= false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE cm_pacientes SET ");
            Sentencia.Append("Pac_Nombre = '" + _Nombre + "', ");
            Sentencia.Append("Pac_Apellido = '" + _Apellido + "', ");
            Sentencia.Append("Pac_FechaNacimiento = '" + _FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("Pac_Genero = '" + _Genero + "', ");
            Sentencia.Append("Pac_Telefono = '" + _Telefono + "', ");
            Sentencia.Append("Pac_CorreoElectronico = '" + _CorreoElectronico + "', ");
            Sentencia.Append("Pac_Direccion = '" + _Direccion + "' ");
            Sentencia.Append("WHERE ID_Paciente = " + _ID_Paciente + ";");

            try
            {
                // Depuración: Imprimir la consulta SQL generada
                Console.WriteLine("Consulta SQL Generada para Actualizar: " + Sentencia.ToString());

                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM cm_pacientes ");
            Sentencia.Append("WHERE ID_Paciente = " + _ID_Paciente + ";");

            try
            {
                // Imprimir la consulta SQL para depuración
                Console.WriteLine("Consulta SQL Generada: " + Sentencia.ToString());

                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }
    }
}
