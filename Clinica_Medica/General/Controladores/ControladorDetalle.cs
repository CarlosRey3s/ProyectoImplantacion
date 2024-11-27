using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.CLS;

namespace General.Controladores
{
    public class ControladorDetalle
    { 
        CLS.FacturaDetalle Detalle = new CLS.FacturaDetalle();

        public Boolean Insertar(CLS.FacturaDetalle factura)
        {
            Boolean resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            // Construir la sentencia SQL utilizando los valores del objeto factura
            sentencia.Append("CALL sp_InsertarDetalleFactura(");
            sentencia.Append(factura.Cantidad1 + ", "); // Sin comillas para números
            sentencia.Append("'" + factura.Descuento1 + "', ");
            sentencia.Append("'" + factura.SubTotal1 + "', ");
            sentencia.Append("'" + factura.Total1 + "', ");
            sentencia.Append(factura.Facturas_ID_Factura1 + ", "); // Sin comillas para números
            sentencia.Append(factura.Medicamentos_ID_Medicamento1 + ");"); // Sin comillas para números

            try
            {
                // Ejecutar la sentencia SQL y verificar el resultado
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la factura: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }

        public bool EliminarDetalleFactura(int idDetalle)
        {
            var facturaDetalle = new FacturaDetalle { ID_FacturaDetalle = idDetalle };
            return facturaDetalle.Eliminar();
        }


    }
}
