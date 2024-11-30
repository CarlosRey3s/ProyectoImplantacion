using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Doctor
    {
        Int32 ID_Doctor;
        Int32 ID_Especialidad; 
        Int32 ID_Empleado;
        Int32 NumeroLicencia;
        string Especialidad;

        public Int32 ID_Doctor1 { get => ID_Doctor; set => ID_Doctor = value; }
        public int ID_Especialidad1 { get => ID_Especialidad; set => ID_Especialidad = value; }
        public int ID_Empleado1 { get => ID_Empleado; set => ID_Empleado = value; }
        public int NumeroLicencia1 { get => NumeroLicencia; set => NumeroLicencia = value; }
        public string Especialidads { get => Especialidad; set => Especialidad = value; }
        public Boolean Insertar()
        {
            Boolean Resultado = false;

            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();

            StringBuilder Sentencia = new StringBuilder();


            Sentencia.Append("INSERT INTO `clinica_medica`.`doctor` (`ID_Doctor`, `ID_Especialidad`, `ID_Empleado`, `NumeroLicencia`) VALUES (");
            Sentencia.Append("'" + ID_Doctor + "', '" + ID_Especialidad + "', '" + ID_Empleado + "', '" + NumeroLicencia + "');");

            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
        }//Finaliza metodo insertar
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE doctor SET ");
            Sentencia.Append("`ID_Especialidad` = " + ID_Especialidad + ", ");
            Sentencia.Append("`ID_Empleado` = " + ID_Empleado + ", ");
            Sentencia.Append("`NumeroLicencia` = '" + NumeroLicencia + "' ");
            Sentencia.Append("WHERE `ID_Doctor` = " + ID_Doctor + ";");

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

        }//finaliza el metodo actualizar

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder

            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("DELETE FROM doctor ");
            Setencia.Append("WHERE ID_Doctor =" + ID_Doctor + ";");
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
