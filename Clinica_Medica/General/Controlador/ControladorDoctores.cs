using General.CLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Controlador
{
    internal class ControladorDoctores
    {
        /*INSERTAR*/
        public bool InsertarDoctor(int ID_Empleado,int NumeroLicencia1, int ID_Especialidad)
        {
            var doctor = new Doctor()
            {
               ID_Empleado1 = ID_Empleado,
               NumeroLicencia1 = NumeroLicencia1,
               ID_Especialidad1 = ID_Especialidad,
            };
            return doctor.Insertar();
        }
        public bool ActualizarDoctor(int ID_Doctor, int ID_Empleado, int NumeroLicencia, int ID_Especialidad)
        {
            var doctor = new Doctor()
            {
                ID_Doctor1 = ID_Doctor,
                ID_Empleado1 = ID_Empleado,
                NumeroLicencia1 = NumeroLicencia,
                ID_Especialidad1 = ID_Especialidad,
            };
            return doctor.Actualizar();
        }
        public bool EliminarDoctor(int ID_Doctor)
        {
            var doctor = new Doctor()
            {
                ID_Doctor1 = ID_Doctor
            };
            return doctor.Eliminar();
        }
    }
}
