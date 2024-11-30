using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Citas
    {
        Int32 _ID_Cita;
        Int32 _ID_Paciente;
        DateTime _Fecha_Hora;

        public int ID_Cita { get => _ID_Cita; set => _ID_Cita = value; }
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public DateTime Fecha_Hora { get => _Fecha_Hora; set => _Fecha_Hora = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();

            Setencia.Append("INSERT INTO `Citas` (`ID_Paciente`, `Fecha_Hora`) VALUES(");
            Setencia.Append("'" + _ID_Paciente + "','" + _Fecha_Hora.ToString("yyyy-MM-dd HH:mm:ss") + "');");
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
            Setencia.Append("UPDATE Citas SET ");
            Setencia.Append("`ID_Paciente`='" + _ID_Paciente + "',");
            Setencia.Append("`Fecha_Hora` = '" + _Fecha_Hora.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            Setencia.Append("WHERE `ID_Cita` ='" + _ID_Cita + "';");

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
            Setencia.Append("DELETE FROM Citas ");
            Setencia.Append("WHERE ID_Cita =" + _ID_Cita + ";");

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
