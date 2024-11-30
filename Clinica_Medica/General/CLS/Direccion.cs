using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Direccion
    {
        Int32 ID_Direccion;
        string Linea1;
        string Linea2;
        Int32 Direccion2;
        public int ID_Direccion1 { get => ID_Direccion; set => ID_Direccion = value; }
        public string Linea11 { get => Linea1; set => Linea1 = value; }
        public string Linea21 { get => Linea2; set => Linea2 = value; }
        public Int32 IDDIREccion { get => Direccion2; set => Direccion2 = value; }
        public int ID()
        {
            return Direccion2;
        }
        public void ID(Int32 id)
        {
             Direccion2 = id;
        }

        public Boolean Insertar()
        {
            Boolean Resultado = false;

            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO `clinica_medica`.`direcciones` (`Linea1`, `Linea2`) VALUES (");
            Sentencia.Append("'" + Linea1 + "', '" + Linea2 + "');");
            Sentencia.Append("SELECT LAST_INSERT_ID();");
            object result = Operaciones.EjecutarEscalar(Sentencia.ToString());
            ID_Direccion = Convert.ToInt32(result);

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
            Sentencia.Append("UPDATE direcciones SET ");
            Sentencia.Append("`Linea1` = '" + Linea1 + "', ");
            Sentencia.Append("`Linea2` = '" + Linea2 + "' ");
            Sentencia.Append("WHERE `ID_Direccion` = " + ID_Direccion1 + ";");


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
            Setencia.Append("DELETE FROM direcciones ");
            Setencia.Append("WHERE ID_Direccion =" + ID_Direccion + ";");

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
