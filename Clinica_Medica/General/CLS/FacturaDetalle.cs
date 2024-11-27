using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class FacturaDetalle
    {
        Int32 _ID_FacturaDetalle;
        Int32 Cantidad;
        Decimal Descuento;
        Decimal SubTotal;
        Decimal Total;
        Int32 Facturas_ID_Factura;
        Int32 Medicamentos_ID_Medicamento;
        Int32 AsigancionMedicamento_ID_RecetaMedicamento;

        public int ID_FacturaDetalle { get => _ID_FacturaDetalle; set => _ID_FacturaDetalle = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public decimal Descuento1 { get => Descuento; set => Descuento = value; }
        public decimal SubTotal1 { get => SubTotal; set => SubTotal = value; }
        public decimal Total1 { get => Total; set => Total = value; }
        public int Facturas_ID_Factura1 { get => Facturas_ID_Factura; set => Facturas_ID_Factura = value; }
        public int Medicamentos_ID_Medicamento1 { get => Medicamentos_ID_Medicamento; set => Medicamentos_ID_Medicamento = value; }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            // Crear el objeto de operación
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            // Construir la sentencia SQL}
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL sp_EliminarDetalle(" + ID_FacturaDetalle + ");");

            try
            {
                // Ejecutar la sentencia SQL y verificar el resultado
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
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
