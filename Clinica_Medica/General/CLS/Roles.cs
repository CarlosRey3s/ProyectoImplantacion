using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Roles
    {
        // Campos privados
        private int _ID_Rol;
        private string _Rol_NombreRol;

        // Propiedades públicas
        public int ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }
        public string Rol_NombreRol { get => _Rol_NombreRol; set => _Rol_NombreRol = value; }

        // Método para obtener la lista de roles
        public static DataTable Rol()
        {
            DataTable resultado = new DataTable();
            string consulta = @"
            SELECT 
                ID_Rol, 
                Rol_NombreRol 
            FROM cm_roles;";

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                resultado = operacion.Consultar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la consulta de roles: {ex.Message}");
            }

            return resultado;
        }

        // Método para insertar un nuevo rol
        public bool Insertar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO cm_roles (Rol_NombreRol) VALUES (");
            sentencia.Append($"'{_Rol_NombreRol}');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar rol: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }

        // Método para actualizar un rol existente
        public bool Actualizar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("UPDATE cm_roles SET ");
            sentencia.Append($"Rol_NombreRol = '{_Rol_NombreRol}' ");
            sentencia.Append($"WHERE ID_Rol = {_ID_Rol};");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar rol: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }

        // Método para eliminar un rol existente
        public bool Eliminar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append($"DELETE FROM cm_roles WHERE ID_Rol = {_ID_Rol};");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar rol: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }

        // Método para asignar una opción al rol
        public bool AsignarOpcion(int idOpcion)
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            // Comprobamos si el rol ya tiene la opción asignada antes de intentar insertarla
            if (TieneOpcionAsignada(idOpcion))
            {
                Console.WriteLine("El rol ya tiene esta opción asignada.");
                return false;  // Si ya tiene la opción, no se asigna de nuevo
            }

            // Insertamos la relación entre el rol y la opción en la tabla cm_roles_opciones
            sentencia.Append("INSERT INTO cm_roles_opciones (Roles_ID_Rol, Opciones_ID_Opcion) VALUES (");
            sentencia.Append($"'{_ID_Rol}', '{idOpcion}');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                    Console.WriteLine("Opción asignada correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al asignar opción: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }


        /// Método para quitar una opción del rol
        public bool QuitarOpcion(int idOpcion)
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            // Verificamos si la opción está asignada al rol antes de intentar eliminarla
            if (!TieneOpcionAsignada(idOpcion))
            {
                Console.WriteLine("El rol no tiene esta opción asignada.");
                return false;  // Si el rol no tiene la opción asignada, no se hace nada
            }

            // Eliminamos la relación entre el rol y la opción en la tabla cm_roles_opciones
            sentencia.Append("DELETE FROM cm_roles_opciones ");
            sentencia.Append($"WHERE Roles_ID_Rol = {_ID_Rol} AND Opciones_ID_Opcion = {idOpcion};");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                    Console.WriteLine("Opción eliminada correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al quitar opción: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }


        // Método para verificar si un rol tiene una opción asignada
        public bool TieneOpcionAsignada(int idOpcion)
        {
            bool tieneAsignada = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder consulta = new StringBuilder();

            consulta.Append("SELECT COUNT(*) FROM cm_roles_opciones ");
            consulta.Append($"WHERE Roles_ID_Rol = {_ID_Rol} AND Opciones_ID_Opcion = {idOpcion};");

            try
            {
                int count = Convert.ToInt32(operacion.Consultar(consulta.ToString()).Rows[0][0]);
                tieneAsignada = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar asignación: {ex.Message}");
                tieneAsignada = false;
            }

            return tieneAsignada;
        }

    }
}
