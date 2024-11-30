using General.CLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Controlador
{
    internal class ControladorEmpleados
    {
        /*INSERTAR*/
        public bool InsertEmpleados (
            string nombreEmpleado,
            string apellidoEmpleado,
            DateTime fechaNacEmpleados,
            string telefonoEmpleados,
            string correos,
            string  DUI_Empleados,
            string ISSS_Empleados,
            int ID_Cargos, string direcciones )

            {
            var empleado = new Empleados()
            {
                NombresEmpleados = nombreEmpleado,
                ApellidosEmpleados = apellidoEmpleado,
                FechaNacEmpleados = fechaNacEmpleados,
                TelefonoEmpleados = telefonoEmpleados,
                Correos = correos,
                DUI_Empleados = DUI_Empleados,
                ISSS_Empleados = ISSS_Empleados,
                ID_Cargos = ID_Cargos,
                Direcciones = direcciones
            };
            return empleado.Insertar();
        }
        /*ACTUALIZAR*/
        public bool ActualizarEmpleado
            (
            int id,
            string nombreEmpleado,
            string apellidoEmpleado,
            DateTime fechaNacEmpleados,
            string telefonoEmpleados,
            string correos,
            string DUI_Empleados,
            string ISSS_Empleados,
            int ID_Cargos, string direcciones

            )
        {
            var empleado = new Empleados()
            {
                ID_empleados = id,
                NombresEmpleados = nombreEmpleado,
                ApellidosEmpleados = apellidoEmpleado,
                FechaNacEmpleados = fechaNacEmpleados,
                TelefonoEmpleados = telefonoEmpleados,
                Correos = correos,
                DUI_Empleados = DUI_Empleados,
                ISSS_Empleados = ISSS_Empleados,
                ID_Cargos = ID_Cargos,
                Direcciones = direcciones

            };
            return empleado.Actualizar();
        }
        /*ELIMINAR*/
        public bool EliminarEmpleado(int idEmpleado)
        {
            var empleado = new Empleados { ID_empleados = idEmpleado };
            return empleado.Eliminar();
        }

    }
}
