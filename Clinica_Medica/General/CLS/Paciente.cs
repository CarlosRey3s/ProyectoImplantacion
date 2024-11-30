using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Paciente
    {
        Int32 _ID_Paciente;
        string _Nombre;
        string _Apellido;
        DateTime _FechaNacimiento;
        string _Genero;
        string _Telefono;
        string _CorreoElectronico;
        string _Direccion;
        // CTRL + R + E
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("INSERT INTO `clinicamedica`.`pacientes` (`Nombre`, `Apellido`, `FechaNacimiento`, `Genero`, `Telefono`, `CorreoElectronico`, `Direccion`) VALUES(");
            Setencia.Append("'" + _Nombre + "','" + _Apellido + "','" + _FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "','" + _Genero + "','" + _Telefono + "','" + _CorreoElectronico + "','" + _Direccion + "');");
            try
            {
                if (Operacion.EjecutarSentencia(Setencia.ToString()) >= 0)
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
                Resultado |= false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("UPDATE pacientes SET ");
            Setencia.Append("`Nombre`='" + _Nombre + "',");
            Setencia.Append("`Apellido` = '" + _Apellido + "',");
            Setencia.Append("`FechaNacimiento` = '" + _FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "',");
            Setencia.Append("`Genero` = '" + _Genero + "',");
            Setencia.Append("`Telefono` ='" + _Telefono + "',");
            Setencia.Append("`CorreoElectronico` ='" + _CorreoElectronico + "',");
            Setencia.Append("`Direccion` = '" + Direccion + "'");
            Setencia.Append("WHERE `ID_Paciente` ='" + _ID_Paciente + "';");
            try
            {
                if (Operacion.EjecutarSentencia(Setencia.ToString()) >= 0)
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
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();
            Setencia.Append("DELETE FROM pacientes ");
            Setencia.Append("WHERE ID_Paciente =" + _ID_Paciente + ";");
            try
            {
                if (Operacion.EjecutarSentencia(Setencia.ToString()) >= 0)
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
