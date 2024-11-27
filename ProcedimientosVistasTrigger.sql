-- Cambio que realize a la tabla detallefactura

CREATE TABLE IF NOT EXISTS `CM_DetalleFacturas` (
  `ID_DetalleFactura` INT NOT NULL AUTO_INCREMENT,
  `Det_Cantidad` INT NOT NULL,
  `Det_Descuento` DECIMAL(10,2) NOT NULL,
  `Det_SubTotal` DECIMAL(10,2) NOT NULL,
  `Det_Total` DECIMAL(10,2) NOT NULL,
  `Facturas_ID_Factura` INT NOT NULL,
  `Medicamentos_ID_Medicamento` INT NOT NULL,
  PRIMARY KEY (`ID_DetalleFactura`),
  INDEX `fk_DetalleFacturas_Facturas1_idx` (`Facturas_ID_Factura` ASC),
  INDEX `fk_DetalleFacturas_Medicamentos1_idx` (`Medicamentos_ID_Medicamento` ASC),
  CONSTRAINT `fk_DetalleFacturas_Facturas1`
    FOREIGN KEY (`Facturas_ID_Factura`)
    REFERENCES `CM_Facturas` (`ID_Factura`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_DetalleFacturas_Medicamentos1`
    FOREIGN KEY (`Medicamentos_ID_Medicamento`)
    REFERENCES `CM_Medicamentos` (`ID_Medicamento`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
) ENGINE = InnoDB;


-- =================================================================

DELIMITER $$

CREATE PROCEDURE ObtenerIDFactura()
BEGIN
    -- Devolver el siguiente ID directamente
    SELECT COALESCE(MAX(ID_Factura), 0) AS siguienteID
    FROM cm_facturas;
END$$

DELIMITER ;

-- CALL ObtenerIDFactura();
-- sp_ObtenerDetallesFactura

-- =================================================================

DELIMITER $$

CREATE PROCEDURE sp_ObtenerDatosConsulta()
BEGIN
    SELECT 
        co.ID_Consulta,
        co.Cons_Diganostico,
        co.Cons_PrecioConsulta,
        CONCAT(e.Emp_Nombre, ' ', e.Emp_Apellido) AS Doctor_NombreCompleto
    FROM
        CM_Consultas co
    INNER JOIN CM_Citas ci ON co.Citas_ID_Cita = ci.ID_Cita
    INNER JOIN CM_Doctores d ON ci.Doctores_ID_Doctor = d.ID_Doctor
    INNER JOIN CM_Empleados e ON d.Empleados_ID_Empleado = e.ID_Empleado;
END $$

DELIMITER ;

-- CALL sp_ObtenerDatosConsulta();

-- =============================================================================================


CREATE OR REPLACE VIEW vw_Facturas AS
SELECT 
    f.ID_Factura,
    f.Fac_NumeroFactura,
    f.Fac_Fecha,
    f.Fac_MetodoPago,
    CONCAT(p.Pac_Nombre, ' ', p.Pac_Apellido) AS NombrePaciente,
    f.Pacientes_ID_Paciente,
    f.Consulta_ID_Consulta,
    c.Cons_PrecioConsulta AS PrecioConsulta,
    CONCAT(e.Emp_Nombre, ' ', e.Emp_Apellido) AS NombreDoctor
FROM 
    CM_Facturas f
JOIN 
    CM_Pacientes p ON f.Pacientes_ID_Paciente = p.ID_Paciente
JOIN 
    CM_Consultas c ON f.Consulta_ID_Consulta = c.ID_Consulta
LEFT JOIN 
    CM_Citas ci ON c.Citas_ID_Cita = ci.ID_Cita
LEFT JOIN 
    CM_Doctores d ON ci.Doctores_ID_Doctor = d.ID_Doctor
LEFT JOIN 
    CM_Empleados e ON d.Empleados_ID_Empleado = e.ID_Empleado;

-- Como llamarla
-- SELECT * FROM vw_Facturas ORDER BY ID_Factura ASC;

-- ============================================================ --
-- vista paciente

CREATE VIEW vw_Pacientes AS
SELECT ID_Paciente, Pac_Nombre, Pac_Apellido, Pac_Telefono, Pac_Direccion 
FROM CM_Pacientes;

-- como llamarla
-- SELECT * FROM vw_Pacientes;

-- ====================================================


-- -------------------------------------------------

-- ===================================================================

DELIMITER $$

CREATE PROCEDURE sp_InsertarDetalleFactura(
    IN p_cantidad INT,
    IN p_descuento DECIMAL(10,2),
    IN p_subtotal DECIMAL(10,2),
    IN p_total DECIMAL(10,2),
    IN p_id_factura INT,
    IN p_id_medicamento INT
)
BEGIN
    INSERT INTO CM_DetalleFacturas (
        Det_Cantidad,
        Det_Descuento,
        Det_SubTotal,
        Det_Total,
        Facturas_ID_Factura,
        Medicamentos_ID_Medicamento
    )
    VALUES (
        p_cantidad,
        p_descuento,
        p_subtotal,
        p_total,
        p_id_factura,
        p_id_medicamento
    );
END $$

DELIMITER ;
-- Ejemplo
-- CALL sp_InsertarDetalleFactura(10, 5.00, 100.00, 95.00, 1, 2);
-- ======================================================================
DELIMITER $$

CREATE PROCEDURE `ActualizarFactura` (
    IN p_ID_Factura INT,
    IN p_Fac_NumeroFactura DECIMAL(10,2),
    IN p_Fac_Fecha DATE,
    IN p_Fac_MetodoPago VARCHAR(45),
    IN p_Pacientes_ID_Paciente INT,
    IN p_Consulta_ID_Consulta INT
)
BEGIN
    UPDATE `CM_Facturas`
    SET 
        `Fac_NumeroFactura` = p_Fac_NumeroFactura,
        `Fac_Fecha` = p_Fac_Fecha,
        `Fac_MetodoPago` = p_Fac_MetodoPago,
        `Pacientes_ID_Paciente` = p_Pacientes_ID_Paciente,
        `Consulta_ID_Consulta` = p_Consulta_ID_Consulta
    WHERE 
        `ID_Factura` = p_ID_Factura;
END$$

DELIMITER ;


-- CALL `ActualizarFactura`(
--    1,               
--    12345.67,        -- Nuevo número de factura
--    '2024-11-15',    -- Nueva fecha
--    'Tarjeta',       -- Nuevo método de pago
--    2,               -- Nuevo ID del paciente
--    3                -- Nuevo ID de la consulta
-- );
-- ----------------------------------------------------


-- ===========================================================
DELIMITER $$

CREATE PROCEDURE `sp_ObtenerDetallesFactura` (
    IN p_ID_Factura INT
)
BEGIN
    SELECT 
        df.ID_DetalleFactura,
        m.Med_Nombre,
        m.Med_PrecioUnitario,
        m.ID_Medicamento,
        df.Det_Cantidad,
        df.Det_Descuento,
        df.Det_SubTotal,
        df.Det_Total,
        df.Facturas_ID_Factura AS ID_Factura
    FROM
        `CM_DetalleFacturas` df
    INNER JOIN 
        `CM_Medicamentos` m 
    ON 
        df.Medicamentos_ID_Medicamento = m.ID_Medicamento
    WHERE 
        df.Facturas_ID_Factura = p_ID_Factura;
END $$

DELIMITER ;


-- CALL sp_ObtenerDetallesFactura(1);
-- ================================================================

-- ================================================================
DELIMITER $$

CREATE PROCEDURE EliminarFactura(IN facturaID INT)
BEGIN
    -- Eliminar la factura. Los detalles relacionados se eliminan automáticamente por la clave foránea.
    DELETE FROM `CM_Facturas`
    WHERE `ID_Factura` = facturaID;

    -- Mensaje opcional para verificar la operación.
    SELECT CONCAT('Factura con ID ', facturaID, ' y sus detalles relacionados han sido eliminados.') AS Mensaje;
END $$

DELIMITER ;

-- ===================================================================================================================

DELIMITER $$

CREATE PROCEDURE sp_EliminarDetalle(IN detalleFacturaID INT)
BEGIN
    -- Verifica si el registro existe antes de intentar eliminarlo.
    IF EXISTS (SELECT 1 FROM `CM_DetalleFacturas` WHERE `ID_DetalleFactura` = detalleFacturaID) THEN
        -- Elimina el registro de la tabla CM_DetalleFacturas.
        DELETE FROM `CM_DetalleFacturas`
        WHERE `ID_DetalleFactura` = detalleFacturaID;

        -- Mensaje opcional.
        SELECT CONCAT('DetalleFactura con ID ', detalleFacturaID, ' eliminado correctamente.') AS Mensaje;
    ELSE
        -- Mensaje si el registro no existe.
        SELECT CONCAT('El DetalleFactura con ID ', detalleFacturaID, ' no existe.') AS Mensaje;
    END IF;
END $$

DELIMITER ;

-- ==========================================================
-- Trigger para descontar la cantidad vendida en medicamento

DELIMITER $$

CREATE TRIGGER trg_actualizar_medicamentos AFTER INSERT ON CM_DetalleFacturas
FOR EACH ROW
BEGIN
    DECLARE nueva_cantidad INT;

    -- Actualizar la cantidad vendida y restar de la cantidad disponible
    UPDATE CM_Medicamentos
    SET 
        Med_CantidadVendida = Med_CantidadVendida + NEW.Det_Cantidad,
        Med_Cantidad = Med_Cantidad - NEW.Det_Cantidad
    WHERE ID_Medicamento = NEW.Medicamentos_ID_Medicamento;

    -- Obtener la nueva cantidad para verificar si debe ser cero
    SELECT Med_Cantidad INTO nueva_cantidad
    FROM CM_Medicamentos
    WHERE ID_Medicamento = NEW.Medicamentos_ID_Medicamento;

    -- Si la cantidad llega a cero, también se pone la cantidad vendida en cero
    IF nueva_cantidad <= 0 THEN
        UPDATE CM_Medicamentos
        SET 
            Med_Cantidad = 0,
            Med_CantidadVendida = 0
        WHERE ID_Medicamento = NEW.Medicamentos_ID_Medicamento;
    END IF;
END$$

DELIMITER ;

-- ====================================================================

DELIMITER $$

CREATE PROCEDURE ListaMedicamentos()
BEGIN
        SELECT 
            ID_Medicamento,
            Med_Nombre,
            Med_Descripcion,
            Med_Cantidad,
            Med_CantidadVendida,
            Med_PrecioUnitario,
            Med_FechaVen
        FROM 
            CM_Medicamentos;
END$$

DELIMITER ;


-- CALL ListaMedicamentos();






