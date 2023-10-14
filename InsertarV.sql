CREATE PROCEDURE insertar_Venta(
p_Folio_V VARCHAR(12),
p_Nombre VARCHAR(50),
p_Hora TIME,
p_Fecha DATE,
p_Total DOUBLE)
BEGIN
INSERT venta VALUES(
p_Folio_V,
(SELECT cliente.Id_Cliente FROM cliente WHERE cliente.Nombre = p_Nombre 
LIMIT 1),
p_Hora,
p_Fecha,
p_Total);
END

CALL insertar_Venta('VEN002','Juan Manuel','17:30:00','2022-01-17','265');
DROP PROCEDURE insertar_Venta;

CREATE PROCEDURE insertar_DetalleV(
dv_Folio_DV VARCHAR(12),
dv_Nombre VARCHAR(50),
dv_Cantidad DOUBLE,
dv_Folio_V VARCHAR(12))
BEGIN
DECLARE existencia_stock double;
SELECT pan.Existencia INTO existencia_stock FROM pan WHERE pan.Nombre = dv_Nombre;
IF existencia_stock >= dv_cantidad AND dv_cantidad THEN
INSERT detalleventa VALUES(
dv_Folio_DV,
(SELECT pan.Codigo_Pan FROM pan
 where pan.Nombre = dv_Nombre),
dv_cantidad,
(SELECT venta.Folio_V FROM venta where venta.Folio_V = dv_Folio_V)
);
UPDATE pan SET Existencia = Existencia-dv_cantidad WHERE pan.Nombre = dv_Nombre;
ELSE
SELECT 'no vender' as RESPUESTA;
END IF;
END

call insertar_DetalleV('DV02D','Telera','40','VEN001');
DROP PROCEDURE insertar_DetalleV;
