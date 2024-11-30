using System;
using System.Data;
using System.Text;
using DataLayer;

namespace General.CLS
{
    internal class Medicamento
    {
        // Campos privados
        private int _ID_Medicamento;
        private string _Med_Nombre;
        private string _Med_Descripcion;
        private int _Med_Cantidad;
        private int _Med_CantidadVendida;
        private decimal _Med_PrecioUnitario;
        private DateTime _Med_FechaVen;

        // Propiedades públicas
        public int ID_Medicamento { get => _ID_Medicamento; set => _ID_Medicamento = value; }
        public string Med_Nombre { get => _Med_Nombre; set => _Med_Nombre = value; }
        public string Med_Descripcion { get => _Med_Descripcion; set => _Med_Descripcion = value; }
        public int Med_Cantidad { get => _Med_Cantidad; set => _Med_Cantidad = value; }
        public int Med_CantidadVendida { get => _Med_CantidadVendida; set => _Med_CantidadVendida = value; }
        public decimal Med_PrecioUnitario { get => _Med_PrecioUnitario; set => _Med_PrecioUnitario = value; }
        public DateTime Med_FechaVen { get => _Med_FechaVen; set => _Med_FechaVen = value; }

        // Método para obtener la lista de medicamentos
        public static DataTable Medicamentos()
        {
            DataTable resultado = new DataTable();
            string consulta = @"
            SELECT 
                ID_Medicamento, 
                Med_Nombre, 
                Med_Descripcion, 
                Med_Cantidad, 
                Med_CantidadVendida, 
                Med_PrecioUnitario, 
                Med_FechaVen
            FROM cm_medicamentos;";

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                resultado = operacion.Consultar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la consulta de medicamentos: {ex.Message}");
            }

            return resultado;
        }

        // Método para insertar un nuevo medicamento
        public bool Insertar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO cm_medicamentos (Med_Nombre, Med_Descripcion, Med_Cantidad, Med_CantidadVendida, Med_PrecioUnitario, Med_FechaVen) VALUES (");
            sentencia.Append($"'{_Med_Nombre}', '{_Med_Descripcion}', {_Med_Cantidad}, {_Med_CantidadVendida}, {_Med_PrecioUnitario}, '{_Med_FechaVen:yyyy-MM-dd}');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar medicamento: {ex.Message}");
            }

            return resultado;
        }

        // Método para actualizar un medicamento existente
        public bool Actualizar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("UPDATE cm_medicamentos SET ");
            sentencia.Append($"Med_Nombre = '{_Med_Nombre}', ");
            sentencia.Append($"Med_Descripcion = '{_Med_Descripcion}', ");
            sentencia.Append($"Med_Cantidad = {_Med_Cantidad}, ");
            sentencia.Append($"Med_CantidadVendida = {_Med_CantidadVendida}, ");
            sentencia.Append($"Med_PrecioUnitario = {_Med_PrecioUnitario}, ");
            sentencia.Append($"Med_FechaVen = '{_Med_FechaVen:yyyy-MM-dd}' ");
            sentencia.Append($"WHERE ID_Medicamento = {_ID_Medicamento};");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar medicamento: {ex.Message}");
            }

            return resultado;
        }

        // Método para eliminar un medicamento existente
        public bool Eliminar()
        {
            bool resultado = false;
            DBOperaciones operacion = new DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append($"DELETE FROM cm_medicamentos WHERE ID_Medicamento = {_ID_Medicamento};");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar medicamento: {ex.Message}");
            }

            return resultado;
        }
    }
}
