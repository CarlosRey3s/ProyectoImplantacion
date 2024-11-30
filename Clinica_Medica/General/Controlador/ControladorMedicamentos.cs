using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.CLS; // Incluye este espacio de nombres si Medicamento está aquí


namespace General.Controlador
{
    internal class ControladorMedicamentos
    {
        /*INSERTAR*/
        public bool InsertarMedicamento(
            string nombreMedicamento,
            string descripcion,
            int cantidad,
            int cantidadVendida,
            decimal precioUnitario,
            DateTime fechaVencimiento)
        {
            var medicamento = new Medicamento()
            {
                Med_Nombre = nombreMedicamento,
                Med_Descripcion = descripcion,
                Med_Cantidad = cantidad,
                Med_CantidadVendida = cantidadVendida,
                Med_PrecioUnitario = precioUnitario,
                Med_FechaVen = fechaVencimiento,
                
            };
            return medicamento.Insertar();
        }

        /*ACTUALIZAR*/
        public bool ActualizarMedicamento(
            int id,
            string nombreMedicamento,
            string descripcion,
            int cantidad,
            int cantidadVendida,
            decimal precioUnitario,
            DateTime fechaVencimiento)
        {
            var medicamento = new Medicamento()
            {
                ID_Medicamento = id,
                Med_Nombre = nombreMedicamento,
                Med_Descripcion = descripcion,
                Med_Cantidad = cantidad,
                Med_CantidadVendida = cantidadVendida,
                Med_PrecioUnitario = precioUnitario,
                Med_FechaVen = fechaVencimiento,
               
            };
            return medicamento.Actualizar();
        }

        /*ELIMINAR*/
        public bool EliminarMedicamento(int idMedicamento)
        {
            var medicamento = new Medicamento { ID_Medicamento = idMedicamento };
            return medicamento.Eliminar();
        }

        /*LISTAR*/
        public DataTable ListarMedicamentos()
        {
            return Medicamento.Medicamentos();
        }
    }
}
