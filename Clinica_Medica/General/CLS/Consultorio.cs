using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Consultorio
    {
        Int32 _ID_Consultorio;
        string _Numero;
        string _Descripcion;
        string _Estado;

        // Propiedades
        public int ID_Consultorio { get => _ID_Consultorio; set => _ID_Consultorio = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //Obtener consultorios
        public static DataTable ObtenerConsultoriosDisponibles()
        {
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            DataTable Resultado = new DataTable();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("SELECT ID_Consultorio, Con_Numero ");
            Sentencia.Append("FROM cm_consultorios ");
            Sentencia.Append("WHERE Con_Estado = 'Disponible';");

            try
            {
                Resultado = Operacion.Consultar(Sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener consultorios disponibles: " + ex.Message);
            }

            return Resultado;
        }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO cm_consultorios (Con_Numero, Con_Descripcion, Con_Estado) VALUES (");
            Sentencia.Append("'" + _Numero + "', ");
            Sentencia.Append("'" + _Descripcion + "', ");
            Sentencia.Append("'" + _Estado + "');");

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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE cm_consultorios SET ");
            Sentencia.Append("Con_Numero = '" + _Numero + "', ");
            Sentencia.Append("Con_Descripcion = '" + _Descripcion + "', ");
            Sentencia.Append("Con_Estado = '" + _Estado + "' ");
            Sentencia.Append("WHERE ID_Consultorio = " + _ID_Consultorio + ";");

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
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("DELETE FROM cm_consultorios ");
            Sentencia.Append("WHERE ID_Consultorio = " + _ID_Consultorio + ";");

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
    }
}
