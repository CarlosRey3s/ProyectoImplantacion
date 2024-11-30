using System.Collections.Generic;
using System.Data;
using System;

namespace General.Controlador
{
    public class PermisosService
    {
        private int idUsuario;

        public PermisosService(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        // Método para verificar si el usuario tiene el rol de administrador
        public bool EsAdministrador()
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                SELECT COUNT(*)
                FROM cm_usuarios u
                JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol
                WHERE u.ID_Usuario = @idUsuario
                AND r.Rol_Nombre = 'admin';";  // Suponiendo que el nombre del rol de administrador es 'admin'

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@idUsuario", idUsuario }
            };

            try
            {
                var result = operacion.Consultar(query, parametros);
                return Convert.ToInt32(result.Rows[0][0]) > 0; // Si el usuario tiene el rol 'admin', devuelve true
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar si el usuario es administrador: {ex.Message}");
                return false;
            }
        }

        // Método para verificar si el usuario tiene un permiso específico
        public bool ValidarPermiso(string permiso)
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
        SELECT COUNT(*) 
        FROM cm_usuarios u
        JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol
        JOIN cm_roles_opciones ro ON r.ID_Rol = ro.Roles_ID_Rol
        JOIN cm_opciones o ON ro.Opciones_ID_Opcion = o.ID_Opcion
        WHERE u.ID_Usuario = @idUsuario
        AND o.Opc_NombreOpcion = @permiso;";

            Dictionary<string, object> parametros = new Dictionary<string, object>()
    {
        { "@idUsuario", idUsuario },
        { "@permiso", permiso }
    };

            try
            {
                var result = operacion.Consultar(query, parametros);
                return Convert.ToInt32(result.Rows[0][0]) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar el permiso: {ex.Message}");
                return false;
            }
        }


        // Método para obtener todas las opciones de un usuario
        public DataTable ObtenerOpcionesDelUsuario()
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                SELECT o.Opc_NombreOpcion
                FROM cm_usuarios u
                JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol
                JOIN cm_roles_opciones ro ON r.ID_Rol = ro.Roles_ID_Rol
                JOIN cm_opciones o ON ro.Opciones_ID_Opcion = o.ID_Opcion
                WHERE u.ID_Usuario = @idUsuario;";

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@idUsuario", idUsuario }
            };

            try
            {
                return operacion.Consultar(query, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las opciones del usuario: {ex.Message}");
                return null;
            }
        }
    }
}
