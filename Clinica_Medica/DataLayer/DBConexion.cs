using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DBConexion
    {

        protected MySqlConnection _CONEXION = new MySqlConnection();

        protected Boolean Conectar()
        {
            Boolean Resultado = false;
            try
            {
                //Cadena - PC DeAsis
<<<<<<< HEAD
                _CONEXION.ConnectionString = "Server=localhost;Port=3306;Database=bdclinicamedica;Uid=root;Pwd=12345;SSL Mode=None";
=======
                _CONEXION.ConnectionString = "Server=localhost;Port = 3306;Database=bdclinicamedica;Uid = root; Pwd = 1234;SSL Mode = None";
>>>>>>> 68e680a36ae6aba734ebe49cb536f68d80d8fd83
                _CONEXION.Open();
                Resultado = true;
            }
            catch (Exception ex)
            {
                Resultado = false;
            }
            return Resultado;
        }
        protected void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
