using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Consulta
    {
        Int32 _ID_Consulta;
        Int32 _ID_Receta;
        Int32 _ID_Cita;
        Int32 _ID_Doctor;
        Int32 _ID_Consultorio;
        String _Dianostico;
        String _Indicaciones;

        public int ID_Consulta { get => _ID_Consulta; set => _ID_Consulta = value; }
        public int ID_Receta { get => _ID_Receta; set => _ID_Receta = value; }
        public int ID_Cita { get => _ID_Cita; set => _ID_Cita = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public int ID_Consultorio { get => _ID_Consultorio; set => _ID_Consultorio = value; }
        public string Dianostico { get => _Dianostico; set => _Dianostico = value; }
        public string Indicaciones { get => _Indicaciones; set => _Indicaciones = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();

            Setencia.Append("INSERT INTO `Consulta` (`ID_Receta`, `ID_Cita`, `ID_Doctor`, `ID_Consultorio`, `Diagnostico`, `Indicaciones`) VALUES(");
            Setencia.Append("'" + _ID_Receta + "','" + _ID_Cita + "','" + _ID_Doctor + "','" + _ID_Consultorio + "','" + _Dianostico + "','" + _Indicaciones + "');");
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
                Resultado |= false;
            }

            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder

            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("UPDATE Consulta SET ");
            Setencia.Append("`ID_Receta`='" + _ID_Receta + "',");
            Setencia.Append("`ID_Cita`='" + _ID_Cita + "',");
            Setencia.Append("`ID_Doctor`='" + _ID_Doctor + "',");
            Setencia.Append("`ID_Consultorio`='" + _ID_Consultorio + "',");
            Setencia.Append("`Diagnostico`='" + _Dianostico + "',");
            Setencia.Append("`Indicaciones` = '" + _Indicaciones + "'");
            Setencia.Append("WHERE `ID_Consulta` ='" + _ID_Consulta + "';");

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

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder

            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("DELETE FROM Consulta ");
            Setencia.Append("WHERE ID_Consulta =" + _ID_Consulta + ";");

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
