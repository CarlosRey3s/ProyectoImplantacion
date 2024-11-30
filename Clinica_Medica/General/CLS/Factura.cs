using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Factura
    {
        Int32 _ID_Factura;
        Int32 _ID_Consulta;
        string _Concepto;
        decimal _Monto;
        DateTime _FechaEmision;
        DateTime _FechaPago;
        string _MetodoPago;
        decimal _Subtotal;
        decimal _Total;

        public int ID_Factura { get => _ID_Factura; set => _ID_Factura = value; }
        public int ID_Consulta { get => _ID_Consulta; set => _ID_Consulta = value; }
        public string Concepto { get => _Concepto; set => _Concepto = value; }
        public decimal Monto { get => _Monto; set => _Monto = value; }
        public DateTime FechaEmision { get => _FechaEmision; set => _FechaEmision = value; }
        public DateTime FechaPago { get => _FechaPago; set => _FechaPago = value; }
        public string MetodoPago { get => _MetodoPago; set => _MetodoPago = value; }
        public decimal Subtotal { get => _Subtotal; set => _Subtotal = value; }
        public decimal Total { get => _Total; set => _Total = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;

            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            _Total = _Subtotal + _Monto;
            Sentencia.Append("INSERT INTO Factura (ID_Consulta, Concepto, Monto, FechaEmision, FechaPago, MetodoPago, Subtotal, Total) VALUES (");
            Sentencia.Append("'" + _ID_Consulta + "', '" + _Concepto + "', '" + _Monto + "', '" + _FechaEmision.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + _FechaPago.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + _MetodoPago + "', '" + _Subtotal + "', '" + _Total + "');");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;

        }
        public Boolean Actualizar(){
            Boolean Resultado = false;

            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            _Total = _Subtotal + _Monto;
            Sentencia.Append("UPDATE Factura SET ");
            Sentencia.Append("ID_Consulta='" + _ID_Consulta + "', ");
            Sentencia.Append("Concepto='" + _Concepto + "', ");
            Sentencia.Append("Monto='" + _Monto + "', ");
            Sentencia.Append("FechaEmision='" + _FechaEmision.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("FechaPago='" + _FechaPago.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("MetodoPago='" + _MetodoPago + "', ");
            Sentencia.Append("Subtotal='" + _Subtotal + "', ");
            Sentencia.Append("Total='" + _Total + "' ");
            Sentencia.Append("WHERE ID_Factura='" + _ID_Factura + "';");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            } catch (Exception)
            {
                Resultado = false;
            }

            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;

            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("DELETE FROM Factura ");
            Sentencia.Append("WHERE ID_Factura='" + _ID_Factura + "';");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }catch (Exception)
            {
                Resultado = false;
            }

            return Resultado;
        }
    }
}
