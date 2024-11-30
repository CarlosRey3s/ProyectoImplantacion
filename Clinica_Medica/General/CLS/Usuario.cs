using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Usuario
    {
        // Campos privados
        private int _ID_Usuario;
        private int _ID_Empleado;
        private int _ID_Rol;
        private string _Rol;
        private string _Usuario;
        private string _Clave;

        // Propiedades públicas
        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public int ID_Empleado { get => _ID_Empleado; set => _ID_Empleado = value; }
        public int ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }
      //  public string Rol { get => _Rol; set => _ID_Rol = value; }

        public string UsuarioNombre { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }

        // Método para insertar un nuevo usuario
        public bool Insertar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO `Usuarios` (`ID_Empleado`, `ID_Rol`, `Usuario`, `Clave`) VALUES (");
            sentencia.Append("'" + _ID_Empleado + "', '" + _ID_Rol + "', '" + _Usuario + "', '" + _Clave + "');");

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

            sentencia.Append("UPDATE `Usuarios` SET ");
            sentencia.Append("`ID_Empleado` = '" + _ID_Empleado + "', ");
            sentencia.Append("`ID_Rol` = '" + _ID_Rol + "', ");
            sentencia.Append("`Usuario` = '" + _Usuario + "', ");
            sentencia.Append("`Clave` = '" + _Clave + "' ");
            sentencia.Append("WHERE `ID_Usuario` = '" + _ID_Usuario + "';");

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

            sentencia.Append("DELETE FROM `Usuarios` ");
            sentencia.Append("WHERE `ID_Usuario` = " + _ID_Usuario + ";");

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
    }
}
