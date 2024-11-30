using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Roles
    {
        // Campos privados
        private int _ID_Rol;
        private string _NombreRol;

        // Propiedades públicas
        public int ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }
        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }

        // Método para insertar un nuevo usuario
        public bool Insertar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO `Roles` (`ID_Rol`, `NombreRol`) VALUES (");
            sentencia.Append("'" + _ID_Rol + "', '" + _NombreRol + "');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }

        // Método para actualizar un usuario existente
        public bool Actualizar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("UPDATE `Roles` SET ");
            sentencia.Append("`NombreRol` = '" + _NombreRol + "' ");
            sentencia.Append("WHERE `ID_Rol` = '" + _ID_Rol + "';");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }


        // Método para eliminar un usuario existente
        public bool Eliminar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("DELETE FROM `Roles` ");
            sentencia.Append("WHERE `ID_ROL` = " + _ID_Rol + ";");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }

        //Agrega un Permiso al Rol
        public bool AsignarOpcion(int idOpcion)
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO AsignacionRolesOpciones (ID_Rol, ID_Opcion) VALUES (");
            sentencia.Append("'" + _ID_Rol + "', '" + idOpcion + "');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }
        // Método para quitar un permiso de un rol
        public bool QuitarOpcion(int idOpcion)
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("DELETE FROM AsignacionRolesOpciones ");
            sentencia.Append("WHERE ID_Rol = '" + _ID_Rol + "' AND ID_Opcion = '" + idOpcion + "';");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }
        public bool TieneOpcionAsignada(int idOpcion)
        {
            bool tieneAsignada = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder consulta = new StringBuilder();

            // Construir la consulta para verificar si el rol tiene asignada la opción
            consulta.Append("SELECT COUNT(*) FROM AsignacionRolesOpciones ");
            consulta.Append("WHERE ID_Rol = '" + _ID_Rol + "' AND ID_Opcion = '" + idOpcion + "';");

            try
            {
                // Ejecutar la consulta y obtener el resultado
                int count = Convert.ToInt32(operacion.Consultar(consulta.ToString()).Rows[0][0]);

                // Si el resultado es mayor que cero, significa que el rol tiene asignada la opción
                tieneAsignada = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // En caso de error, se asume que el rol no tiene asignada la opción
                tieneAsignada = false;
            }

            return tieneAsignada;
        }
    }
}
