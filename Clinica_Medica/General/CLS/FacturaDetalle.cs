using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class FacturaDetalle
    {
        Int32 _ID_FacturaDetalle;
        Int32 _ID_Factura;
        Int32 _ID_Insumo;
        Int32 _Cantidad;
        decimal _PrecioUnitario;

        public int ID_FacturaDetalle { get => _ID_FacturaDetalle; set => _ID_FacturaDetalle = value; }
        public int ID_Factura { get => _ID_Factura; set => _ID_Factura = value; }
        public int ID_Insumo { get => _ID_Insumo; set => _ID_Insumo = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO Factura_Detalle (ID_Factura, ID_Insumo, Cantidad, PrecioUnitario) VALUES (");
            Sentencia.Append("'" + _ID_Factura + "', '" + _ID_Insumo + "', '" + _Cantidad + "', '" + _PrecioUnitario + "');");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }

            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE Factura_Detalle SET ");
            Sentencia.Append("ID_Factura='" + _ID_Factura + "', ");
            Sentencia.Append("ID_Insumo='" + _ID_Insumo + "', ");
            Sentencia.Append("Cantidad='" + _Cantidad + "', ");
            Sentencia.Append("PrecioUnitario='" + _PrecioUnitario + "' ");
            Sentencia.Append("WHERE ID_FacturaDetalle='" + _ID_FacturaDetalle + "';");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
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
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("DELETE FROM Factura_Detalle ");
            Sentencia.Append("WHERE ID_FacturaDetalle='" + _ID_FacturaDetalle + "';");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
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
