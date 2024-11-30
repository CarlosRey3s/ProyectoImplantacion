using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Int32 ISSS_Empleado;
        string Correo;
        string Direccion;
        Int32 ID_Cargo;
        string Cargo;
        public int ID_empleados { get => ID_empleado; set => ID_empleado = value; }
        public string NombresEmpleados { get => NombresEmpleado; set => NombresEmpleado = value; }
        public string ApellidosEmpleados { get => ApellidosEmpleado; set => ApellidosEmpleado = value; }
        public DateTime FechaNacEmpleados { get => FechaNacEmpleado; set => FechaNacEmpleado = value; }
        public string TelefonoEmpleados { get => TelefonoEmpleado; set => TelefonoEmpleado = value; }

        public string DUI_Empleados { get => DUI_Empleado; set => DUI_Empleado = value; }
        public int ISSS_Empleados { get => ISSS_Empleado; set => ISSS_Empleado = value; }
        public string Correos { get => Correo; set => Correo = value; }
        public string Direcciones { get => Direccion; set => Direccion = value; }
        public int ID_Cargos { get => ID_Cargo; set => ID_Cargo = value; }
        public string Cargos { get => Cargo; set => Cargo = value; }
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO `clinicamedica`.`empleados` (`Nombre`, `Apellido`, `FechaNacminiento`, `telefono`, `DUI`, `ISSS`, `Correo`, `Direccion`, `Cargos_ID_Cargo`) VALUES (");
            Sentencia.Append("'" + NombresEmpleado + "', '" + ApellidosEmpleado + "', '" + FechaNacEmpleado.ToString("yyyy-MM-dd") + "', '" + TelefonoEmpleado + "', '" + DUI_Empleado + "', '" + ISSS_Empleado + "', '" + Correo + "', '" + Direccion + "', '" + ID_Cargo + "');");
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
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE empleados SET ");
            Sentencia.Append("`Nombre` = '" + NombresEmpleado + "', ");
            Sentencia.Append("`Apellido` = '" + ApellidosEmpleado + "', ");
            Sentencia.Append("`FechaNacminiento` = '" + FechaNacEmpleado.ToString("yyyy-MM-dd") + "', ");
            Sentencia.Append("`Telefono` = '" + TelefonoEmpleado + "', ");
            Sentencia.Append("`DUI` = '" + DUI_Empleado + "', ");
            Sentencia.Append("`ISSS` = '" + ISSS_Empleado + "', ");
            Sentencia.Append("`Correo` = '" + Correo + "', ");
            Sentencia.Append("`Direccion` = '" + Direccion + "', ");
            Sentencia.Append("`Cargos_ID_Cargo` = '" + ID_Cargo + "' ");
            Sentencia.Append("WHERE `ID_Empleado` = '" + ID_empleado + "';");
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
            Setencia.Append("DELETE FROM empleados ");
            Setencia.Append("WHERE ID_empleado =" + ID_empleado + ";");
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
