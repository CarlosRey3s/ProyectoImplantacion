using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Consulta
    {
        public static DataTable AsignacionMedicamento(int consultafactura)
        {
            DataTable Resultado = new DataTable();

            String Consulta = "CALL ObtenerAsignacionMedicamentoPorConsulta(" + consultafactura + ");";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            { }
            return Resultado;

        }

        public static DataTable ObternerDetalleFac(int IDfactura)
        {
            DataTable Resultado = new DataTable();

            String Consulta = "CALL sp_ObtenerDetallesFactura(" + IDfactura + ");";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            { }
            return Resultado;

        }

        public static DataTable Paciente_vw()
        {

            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM vw_Pacientes";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            { }
            return Resultado;
        }
        public static DataTable Paciente()
        {
            // Linea2 -> agregue la line d.linea2
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM bdclinicamedica.cm_pacientes;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            { }
            return Resultado;
        }
        public static DataTable Doctor()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select * from Vista_Doctor;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }catch (Exception ex)
            {

            }
            return Resultado;
        }
        public static DataTable Empleados()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT e.ID_Empleado,e.Nombre,e.Apellido,e.FechaNacminiento,e.Telefono, 
            e.DUI, e.ISSS,e.Correo,e.Direccion,c.cargo
            FROM empleados AS e
            INNER JOIN cargos AS c
            ON e.Cargos_ID_Cargo = c.ID_Cargo;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }catch(Exception ex) { }
            return Resultado;
        }
        public static DataTable Cargos()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM cargos;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable RolesUsuario ()
        {
            DataTable resultado = new DataTable();
            String Consulta = @"select * from Roles;";
            DBOperaciones operaciones = new DBOperaciones();
            try
            {
                resultado = operaciones.Consultar(Consulta);
            }catch (Exception ex) { }
            return resultado;
        }
        public static DataTable Especialidad()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM especialidad;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable Direcciones()
        { 
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Direccion,Linea1,Linea2 FROM direcciones";
            DBOperaciones operaciones = new DBOperaciones();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        
        public static DataTable Usuario()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select u.ID_Usuario,e.Nombre, e.Apellido, u.Usuario, u.Clave, r.NombreRol
            from usuarios as u 
            inner join  roles as r on u.Roles_ID_Rol = r.ID_Rol
            inner join  empleados as e on e.ID_Empleado = u.Empleados_ID_Empleado;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Roles()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Rol, NombreRol FROM Roles;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }

        
        public static DataTable MedicamentosV2()
        {
            DataTable Resultado = new DataTable();
            string Consulta = "SELECT * FROM bdclinicamedica.cm_medicamentos; ";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable spConsulta()
        {
            DataTable Resultado = new DataTable();
            string Consulta = "CALL sp_ObtenerDatosConsulta();";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }


        
        
        public static DataTable ConsultaMedicas()
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT con.ID_Consulta, con.ID_Receta, con.ID_Cita, p.NombresPaciente, p.ApellidosPaciente, d.ID_Doctor,e.NombresEmpleado, con.ID_Consultorio, d.NumeroLicencia, con.Diagnostico, con.Indicaciones FROM Consulta con JOIN Citas c ON con.ID_Cita = c.ID_Cita JOIN Pacientes p ON c.ID_Paciente = p.ID_Paciente JOIN Doctor d ON con.ID_Doctor = d.ID_Doctor JOIN Empleados e ON d.ID_Empleado = e.ID_Empleado ORDER BY ID_Consulta ASC";

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }

        //Mande in Salvador
        public static DataTable RecetasMedicas()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select c.ID_Receta, rm.ID_Insumo , m.NombreInsumo from Consulta c join Receta_Medica rm ON c.ID_Receta = rm.ID_Receta join Medicamentos m on rm.ID_Insumo = m.ID_Insumo;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }

        //Salvador
        public static DataTable Consultorio()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select ID_Consultorio, Disponible, NumeroConsultorio from Consultorio;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {

            }
            return Resultado;
        }
        public static DataTable FacturarPreciosMedicamento()
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"Select f.ID_Factura,c.ID_Receta, rm.Cantidad, me.PrecioUnitario from  Factura f join Consulta c on c.ID_Consulta = f.ID_Consulta Join Receta_Medica rm on rm.ID_Receta = c.ID_Receta join Medicamentos me on me.ID_Insumo = rm.ID_Insumo;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);

            }
            catch (Exception)
            {


            }

            return Resultado;
        }
        public static DataTable Factura()
        {
            DataTable Resultado = new DataTable();

            String Consulta = "SELECT * FROM vw_Facturas;";

            DBOperaciones operacion = new DBOperaciones();

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
        public static DataTable DetallesFactura()
        {
            DataTable Resultado = new DataTable();

            String Consulta = "SELECT * FROM clinicamedica.detallefacturas;";

            DBOperaciones operacion = new DBOperaciones();

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


        public static DataTable MedicamentosSegunPeriodo(string pFechaInicio, string pFechaFinal)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"
                SELECT 
                M.ID_Insumo,
                M.NombreInsumo,
                M.CantidadDisponible,
                M.PrecioUnitario,
                M.FechaVencimiento,
                M.PrecioUnitario * M.CantidadDisponible AS CostoTotal,
                CASE 
                    WHEN M.FechaVencimiento < CURDATE() THEN 'Vencido'
                    ELSE 'Vigente'
                END AS Estado,
                M.Proveedor
            FROM 
                Medicamentos M
            WHERE  
                M.FechaVencimiento BETWEEN '" + pFechaInicio + @"' AND '" + pFechaFinal + @"'
            ORDER BY 
                M.FechaVencimiento ASC, 
                M.NombreInsumo ASC;";

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo del error, puedes agregar un log o mostrar un mensaje
                Console.WriteLine("Error al consultar los medicamentos: " + ex.Message);
            }

            return Resultado;
        }
        public static DataTable FacturasSegunPeriodo(string pFechaInicio, string pFechaFinal)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"
    SELECT 
        ID_Factura AS FacturaID,
        ID_Consulta,
        Concepto,
        Monto,
        FechaEmision,
        FechaPago,
        MetodoPago,
        SubTotal,
        Total
    FROM 
        Factura
    WHERE 
        FechaEmision BETWEEN '" + pFechaInicio + @"' AND '" + pFechaFinal + @"'
    ORDER BY 
        FechaEmision DESC;";

            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo del error, puedes agregar un log o mostrar un mensaje
                Console.WriteLine("Error al consultar las facturas: " + ex.Message);
            }

            return Resultado;
        }

   
    }
}
