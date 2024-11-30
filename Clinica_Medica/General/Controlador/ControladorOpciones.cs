using System;
using System.Data;
using DataLayer;

namespace General.Controlador
{
    public class ControladorOpciones
    {
        // Método para listar las opciones disponibles
        public static DataTable Opciones()
        {
            DataTable resultado = new DataTable();
            string consulta = @"SELECT ID_Opcion, Opc_NombreOpcion FROM cm_opciones"; // Consulta SQL para obtener las opciones

            DBOperaciones operacion = new DBOperaciones();
            try
            {
                // Ejecutar la consulta y devolver los resultados
                resultado = operacion.Consultar(consulta);
            }
            catch (Exception ex)
            {
                // En caso de error, mostramos el error y devolvemos un DataTable vacío
                Console.WriteLine($"Error al listar las opciones: {ex.Message}");
                resultado = new DataTable();
            }

            return resultado;
        }
    }
}
