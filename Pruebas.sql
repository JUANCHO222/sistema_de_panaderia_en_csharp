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