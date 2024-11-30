using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace General.CLS
{
    public  class Empleados
    {
        Int32 ID_empleado;
        string NombresEmpleado;
        string ApellidosEmpleado;
        DateTime FechaNacEmpleado;
        string TelefonoEmpleado;
        string DUI_Empleado;
        string ISSS_Empleado;
        string Correo;
        string Direccion;
        Int32 ID_Cargo;
       
        public Int32 ID_empleados { get => ID_empleado; set => ID_empleado = value; }
        public string NombresEmpleados { get => NombresEmpleado; set => NombresEmpleado = value; }
        public string ApellidosEmpleados { get => ApellidosEmpleado; set => ApellidosEmpleado = value; }
        public DateTime FechaNacEmpleados { get => FechaNacEmpleado; set => FechaNacEmpleado = value; }
        public string TelefonoEmpleados { get => TelefonoEmpleado; set => TelefonoEmpleado = value; }
        public string DUI_Empleados { get => DUI_Empleado; set => DUI_Empleado = value; }
        public string ISSS_Empleados { get => ISSS_Empleado; set => ISSS_Empleado = value; }
        public string Correos { get => Correo; set => Correo = value; }
        public string Direcciones { get => Direccion; set => Direccion = value; }
        public int ID_Cargos { get => ID_Cargo; set => ID_Cargo = value; }
       

        public static DataTable MostrarEmpleados()
        {
            DataTable dt = new DataTable();
            String consulta = "CALL MostrarEmpleados();";
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();

            try
            {
                dt = operaciones.Consultar(consulta);
            }catch(Exception ex)
            { }
            return dt;
        }
        public static DataTable MostrarCargos()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM cm_cargos;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL InsertarEmpleados(");
            Sentencia.Append("'" + NombresEmpleado + "', ");
            Sentencia.Append("'" + ApellidosEmpleado + "', ");
            Sentencia.Append("'" + FechaNacEmpleado.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("'" + TelefonoEmpleado + "', ");
            Sentencia.Append("'" + DUI_Empleado + "', ");
            Sentencia.Append("'" + ISSS_Empleado + "', ");
            Sentencia.Append("'" + Direccion + "', ");
            Sentencia.Append("'" + Correo + "', ");
            Sentencia.Append("'" + ID_Cargo + "');");
            try
            {
                if(Operaciones.EjecutarSentencia(Sentencia.ToString()) >=0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }catch(Exception ex)
            {
                Resultado = false;
                Console.WriteLine("Error al insertar el empleado: " + ex.Message);
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL ActualizarEmpleado(");
            Sentencia.Append("'" + ID_empleado + "', ");
            Sentencia.Append("'" + NombresEmpleado + "', ");
            Sentencia.Append("'" + ApellidosEmpleado + "', ");
            Sentencia.Append("'" + FechaNacEmpleado.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("'" + TelefonoEmpleado + "', ");
            Sentencia.Append("'" + DUI_Empleado + "', ");
            Sentencia.Append("'" + ISSS_Empleado + "', ");
            Sentencia.Append("'" + Correo + "', ");
            Sentencia.Append("'" + Direccion + "', ");
            Sentencia.Append(ID_Cargo + ");"); // Sin comillas porque es numérico

            try
            {
                if (operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
                Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("CALL EliminarEmpleado(");
            Setencia.Append(ID_empleado + ");");
            try
            {
                if (Operacion.EjecutarSentencia(Setencia.ToString()) >= 0)
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
                Resultado = false;
            }
            return Resultado;
        }
    }
}
