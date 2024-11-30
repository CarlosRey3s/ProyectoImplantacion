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
        public static DataTable Paciente()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select ID_Paciente, Pac_Nombre, Pac_Apellido, Pac_FechaNacimiento,
            Pac_Genero,Pac_Telefono, Pac_CorreoElectronico, Pac_Direccion  from CM_Pacientes";
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
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Opciones()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Opcion, NombreOpcion FROM Opciones;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable VerPermisos()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT NombreRol, NombreOpcion FROM verPermisos;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Medicamentos()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT ID_Insumo, NombreInsumo, Descripcion, CantidadDisponible, PrecioUnitario, Proveedor, FechaVencimiento, ImagenMedicamento FROM Medicamentos;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Citas()
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT c.ID_Cita, c.Pacientes_ID_Paciente, p.Pac_Nombre, p.Pac_Apellido, c.Cit_FechaHora, 
                        c.Cit_Motivo, c.Cit_Estado, c.Doctores_ID_Doctor, c.Consultorios_ID_Consultorio
                        FROM CM_Citas c 
                        JOIN CM_Pacientes p ON c.Pacientes_ID_Paciente = p.ID_Paciente 
                        ORDER BY c.ID_Cita ASC";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
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
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
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

            String Consulta = @"
                        SELECT 
                            f.ID_Factura,
                            f.ID_Consulta,
                            f.Concepto,
                            f.Monto,
                            f.FechaEmision,
                            f.FechaPago,
                            f.MetodoPago,
                            f.SubTotal,
                            f.Total,
                            m.NombreInsumo AS NombreMedicamento,
                            m.PrecioUnitario AS Precio
                        FROM 
                            Factura f
                        JOIN 
                            Medicamentos m ON m.ID_Insumo = m.ID_Insumo 
                        ORDER BY 
                            f.ID_Factura ASC;";

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
        public static DataTable CITAS_SEGUN_PERIODO(string pFechaInicio, string pFechaFinal)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"
            SELECT 
                CI.ID_Cita AS CitaID, 
                CI.Fecha_Hora AS FechaHoraCita, 
                CONCAT(P.NombresPaciente, ' ', P.ApellidosPaciente) AS PacienteNombreCompleto, 
                CONCAT(D.NombresEmpleado, ' ', D.ApellidosEmpleado) AS DoctorNombreCompleto,
                E.Especialidad AS EspecialidadDoctor,
                CASE 
                    WHEN CU.ID_Consulta IS NOT NULL THEN 'Atendida'
                    ELSE 'Pendiente'
                END AS EstadoCita
            FROM 
                Citas CI
            JOIN 
                Pacientes P ON CI.ID_Paciente = P.ID_Paciente
            LEFT JOIN 
                Consulta CU ON CI.ID_Cita = CU.ID_Cita
            LEFT JOIN 
                Doctor DOC ON CU.ID_Doctor = DOC.ID_Doctor
            LEFT JOIN 
                Empleados D ON DOC.ID_Empleado = D.ID_Empleado
            LEFT JOIN 
                Especialidad E ON DOC.ID_Especialidad = E.ID_Especialidad 
            WHERE 
                CAST(CI.Fecha_Hora AS DATE) BETWEEN '" + pFechaInicio + @"' AND '" + pFechaFinal + @"'
            ORDER BY
                  CI.Fecha_Hora DESC; ";
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
    }
}
