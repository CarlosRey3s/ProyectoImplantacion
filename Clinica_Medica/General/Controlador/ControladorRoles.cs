using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using General.CLS;  // Asumiendo que tienes una clase CLS de Empleados y Roles

namespace General.Controlador
{
    internal class ControladorRoles
    {
        /*INSERTAR*/
        public bool InsertarRol(string nombreRol)
        {
            var rol = new Roles()
            {
                Rol_NombreRol = nombreRol
            };
            return rol.Insertar();
        }

        /*ACTUALIZAR*/
        public bool ActualizarRol(int idRol, string nombreRol)
        {
            var rol = new Roles()
            {
                ID_Rol = idRol,
                Rol_NombreRol = nombreRol
            };
            return rol.Actualizar();
        }

        /*ELIMINAR*/
        public bool EliminarRol(int idRol)
        {
            var rol = new Roles { ID_Rol = idRol };
            return rol.Eliminar();
        }

        /*LISTAR ROLES*/
        public DataTable ListarRoles()
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
            SELECT 
                ID_Rol, 
                Rol_NombreRol 
            FROM cm_roles;";

            try
            {
                return operacion.Consultar(query);  // Devuelve un DataTable con los roles
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar roles: {ex.Message}");
                return null;  // Si ocurre un error, devuelve null
            }
        }


    }
}
