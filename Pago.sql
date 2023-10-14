CREATE PROCEDURE insertar_DetalleV(
dv_Folio_DV VARCHAR(12),
dv_Nombre VARCHAR(50),
dv_Cantidad DOUBLE,
dv_Folio_V VARCHAR(12))
BEGIN
INSERT detalleventa VALUES(
dv_Folio_DV,
(SELECT pan.Codigo_Pan FROM pan
 where pan.Nombre = dv_Nombre),
dv_cantidad,
(SELECT venta.Folio_V FROM venta where venta.Folio_V = dv_Folio_V)
);
END

call insertar_DetalleV('DV01D','Telera','60','VEN001');
DROP PROCEDURE insertar_DetalleP;


CREATE PROCEDURE insertar_DetalleP(
dp_Folio_Pago VARCHAR(12),
dp_Cantidad DOUBLE,
dp_Pago VARCHAR(50),
dp_Folio_V VARCHAR(12))
BEGIN
INSERT detallepago VALUES(
dp_Folio_Pago,
dp_Cantidad,
(SELECT tipopago.Folio_P FROM tipopago where tipopago.Tipo_P = dp_Pago),
(SELECT venta.Folio_V FROM venta where venta.Folio_V = dp_Folio_V)
);
END

call insertar_DetalleP('PAGE002','300','Efectivo','VEN001');
