using General.CLS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Controladores
{
    public class ControladorFactura
    {
        CLS.Factura Factura = new CLS.Factura();

        public Boolean Insertar(CLS.Factura factura)
        {
            Boolean resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            // Construir la sentencia SQL utilizando los valores del objeto factura
            sentencia.Append("INSERT INTO bdclinicamedica.cm_facturas (Fac_NumeroFactura, Fac_Fecha, Fac_MetodoPago,Pacientes_ID_Paciente,Consulta_ID_Consulta) VALUES(");
            sentencia.Append(factura.NumeroFactura + ", "); // Sin comillas para números
            sentencia.Append("'" + factura.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            sentencia.Append("'" + factura.MetodoPago + "', ");
            sentencia.Append(factura.ID_Paciente + ", "); // Sin comillas para números
            sentencia.Append(factura.ID_Consulta + ");"); // Sin comillas para números

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

        public bool ActualizarFactura(Decimal numerofactura, DateTime Fecha, string metodopago, int idpaciente,
            int idConsulta)
        {
            var Factura = new Factura()
            {
                NumeroFactura = numerofactura,
                Fecha = Fecha,
                MetodoPago = metodopago,
                ID_Paciente = idpaciente,
                ID_Consulta = idConsulta
            };
            return Factura.Actualizar();
        }

        public Boolean Actualizar(CLS.Factura factura)
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            // Construir la sentencia SQL
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL `ActualizarFactura`(" +
                factura.ID_Factura + ", " +
                factura.NumeroFactura + ", '" +
                factura.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                factura.MetodoPago + "', " +
                factura.ID_Paciente + ", " +
                factura.ID_Consulta + ");");

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

        public int ObtenerID(int ID)
        {
            int resultado = -1; // Valor por defecto en caso de error
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("CALL ObtenerIDFactura();");

            try
            {
                DataTable dt = operacion.Consultar(sentencia.ToString());

                if (dt.Rows.Count > 0)
                {
                    resultado = Convert.ToInt32(dt.Rows[0]["siguienteID"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return resultado;
        }
        public bool EliminarFactura(int idFactura)
        {
            var Factura = new Factura { ID_Factura = idFactura };
            return Factura.Eliminar();
        }
    }
}
