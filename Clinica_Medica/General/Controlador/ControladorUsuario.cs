using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using General.CLS;

namespace General.Controlador
{
    internal class ControladorUsuarios
    {



        // Método para insertar un nuevo usuario
        public bool InsertarUsuario(string nombreUsuario, string clave, int? empleadoId, int rolId)
        {
            var usuario = new Usuario()
            {
                NombreUsuario = nombreUsuario,
                Clave = clave,
                EmpleadoId = empleadoId,
                RolId = rolId
            };

            return usuario.Insertar();
        }

        // Método para actualizar un usuario
        public bool ActualizarUsuario(int idUsuario, string nombreUsuario, string clave, int? empleadoId, int rolId)
        {
            var usuario = new Usuario()
            {
                IdUsuario = idUsuario,
                NombreUsuario = nombreUsuario,
                Clave = clave,
                EmpleadoId = empleadoId,
                RolId = rolId
            };

            return usuario.Actualizar();
        }

        // Método para eliminar un usuario
        public bool EliminarUsuario(int idUsuario)
        {
            var usuario = new Usuario() { IdUsuario = idUsuario };
            return usuario.Eliminar();
        }

        // Método para listar usuarios
        public DataTable ListarUsuarios()
        {
            return Usuario.ListarUsuario();
        }


        public static DataTable ListarEmpleados()
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
            SELECT 
                ID_Empleado, 
                Emp_Nombre 
            FROM cm_empleados;";

            try
            {
                return operacion.Consultar(query);  // Devuelve el DataTable con la lista de empleados
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar empleados: {ex.Message}");
                return null;  // Si ocurre un error, devuelve null
            }
        }


        // Método para obtener las opciones del rol asignado a un usuario
        public DataTable ObtenerOpcionesDelRol(int idUsuario)
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                    SELECT o.Opc_NombreOpcion
                    FROM cm_usuarios u
                    JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol
                    JOIN cm_roles_opciones ro ON r.ID_Rol = ro.Roles_ID_Rol
                    JOIN cm_opciones o ON ro.Opciones_ID_Opcion = o.ID_Opcion
                    WHERE u.ID_Usuario = @idUsuario;";

            try
            {
                // Usamos un Dictionary<string, object> para pasar los parámetros
                var parametros = new Dictionary<string, object>
                {
                    { "@idUsuario", idUsuario }
                };

                return operacion.Consultar(query, parametros);  // Devuelve el DataTable con las opciones del rol
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las opciones del rol: {ex.Message}");
                return null;  // Si ocurre un error, devolvemos null
            }
        }

        // Método para validar si un usuario tiene un permiso específico
        public bool ValidarPermiso(int idUsuario, string nombreOpcion)
        {
            DataTable opcionesDelRol = ObtenerOpcionesDelRol(idUsuario);
            if (opcionesDelRol != null)
            {
                foreach (DataRow row in opcionesDelRol.Rows)
                {
                    // Compara el nombre de la opción con el permiso que estamos buscando
                    if (row["Opc_NombreOpcion"].ToString().Equals(nombreOpcion, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;  // El usuario tiene el permiso
                    }
                }
            }
            return false;  // El usuario no tiene el permiso
        }

    }
}
