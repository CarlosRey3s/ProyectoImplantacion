using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Factura
    {
        Int32 _ID_Factura;
        Decimal _NumeroFactura;
        DateTime _Fecha;
        String _MetodoPago;
        Int32 _ID_Paciente;
        Int32 _ID_Consulta;

        public int ID_Factura { get => _ID_Factura; set => _ID_Factura = value; }
        public decimal NumeroFactura { get => _NumeroFactura; set => _NumeroFactura = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string MetodoPago { get => _MetodoPago; set => _MetodoPago = value; }
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public int ID_Consulta { get => _ID_Consulta; set => _ID_Consulta = value; }


        public static DataTable vw_Factura()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "SELECT * FROM vw_Facturas ORDER BY ID_Factura ASC;";

            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error en la consulta de facturas: " + ex.Message);
            }

            return Resultado;
        }

        public static DataTable Paciente_vw()
        {

            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM vw_Pacientes";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la consulta de los pacientes: " + ex.Message);
            }
            return Resultado;
        }

        public static DataTable spConsulta()
        {
            DataTable Resultado = new DataTable();
            string Consulta = "CALL sp_ObtenerDatosConsulta();";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la consulta de los pacientes: " + ex.Message);
            }
            return Resultado;
        }

        public static DataTable ListaMedicamentos()
        {
            DataTable Resultado = new DataTable();
            string Consulta = "CALL ListaMedicamentos() ";
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine("Error en la consulta de facturas: " + ex.Message);
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL `ActualizarFactura`(" +
                ID_Factura + ", " +
                NumeroFactura + ", '" +
                Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                MetodoPago + "', " +
                ID_Paciente + ", " +
                ID_Consulta + ");");
            try
            {
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



        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            // Crear el objeto de operación
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            // Construir la sentencia SQL}
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL EliminarFactura(" + ID_Factura + ");");

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
