using System;
using System.Data;
using System.Text;
using System.Collections.Generic;


namespace General.CLS
{
    public class Usuario
    {
        // Propiedades
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int? EmpleadoId { get; set; } // Puede ser null
        public int RolId { get; set; }

        // Método para insertar un nuevo usuario
        public bool Insertar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                INSERT INTO `cm_usuarios` (`Usu_Usuario`, `Usu_Clave`, `Empleados_ID_Empleado`, `Roles_ID_Rol`) 
                VALUES (@NombreUsuario, @Clave, @EmpleadoId, @RolId);";

            var parametros = new Dictionary<string, object>
            {
                { "@NombreUsuario", NombreUsuario },
                { "@Clave", Clave },
                { "@EmpleadoId", EmpleadoId.HasValue ? (object)EmpleadoId.Value : DBNull.Value },
                { "@RolId", RolId }
            };

            try
            {
                if (operacion.EjecutarSentencia(query, parametros) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar usuario: {ex.Message}");
            }

            return resultado;
        }

        // Método para actualizar un usuario
        public bool Actualizar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                UPDATE `cm_usuarios` 
                SET `Usu_Usuario` = @NombreUsuario, 
                    `Usu_Clave` = @Clave, 
                    `Empleados_ID_Empleado` = @EmpleadoId, 
                    `Roles_ID_Rol` = @RolId 
                WHERE `ID_Usuario` = @IdUsuario;";

            var parametros = new Dictionary<string, object>
            {
                { "@NombreUsuario", NombreUsuario },
                { "@Clave", Clave },
                { "@EmpleadoId", EmpleadoId.HasValue ? (object)EmpleadoId.Value : DBNull.Value },
                { "@RolId", RolId },
                { "@IdUsuario", IdUsuario }
            };

            try
            {
                if (operacion.EjecutarSentencia(query, parametros) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar usuario: {ex.Message}");
            }

            return resultado;
        }

        // Método para eliminar un usuario
        public bool Eliminar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = "DELETE FROM `cm_usuarios` WHERE `ID_Usuario` = @IdUsuario;";

            var parametros = new Dictionary<string, object>
            {
                { "@IdUsuario", IdUsuario }
            };

            try
            {
                if (operacion.EjecutarSentencia(query, parametros) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
            }

            return resultado;
        }

        // Método para listar los usuarios
        public static DataTable ListarUsuario()
        {
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            string query = @"
                SELECT 
                    u.ID_Usuario, 
                    u.Usu_Usuario, 
                    u.Usu_Clave, 
                    u.Empleados_ID_Empleado, 
                    COALESCE(e.Emp_Nombre, 'Sin asignar') AS NombreEmpleado, 
                    u.Roles_ID_Rol, 
                    COALESCE(r.Rol_NombreRol, 'Sin rol') AS NombreRol
                FROM cm_usuarios u
                LEFT JOIN cm_empleados e ON u.Empleados_ID_Empleado = e.ID_Empleado
                LEFT JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol;";

            try
            {
                return operacion.Consultar(query);
            }
            catch (Exception ex)
            {
                //nsole.WriteLine($"Error al listar usuarios: {ex.Message}");
                return null;
            }
        }
    }
}
