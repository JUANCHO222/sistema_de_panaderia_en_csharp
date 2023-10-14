CREATE PROCEDURE buscar_pan(valor VARCHAR(50))
BEGIN
SELECT Codigo_Pan as Codigo, Nombre as Pan, Categoria,Descripcion as Descripción, Existencia, Precio
FROM pan
WHERE Nombre LIKE valor 
OR Codigo_Pan LIKE valor 
OR Categoria LIKE valor 
OR Descripcion LIKE valor 
OR Existencia LIKE valor
OR Precio LIKE valor
ORDER BY Nombre
LIMIT 5;
END

call buscar_pan('%e%');
DROP PROCEDURE buscar_pan;


CREATE PROCEDURE buscar_cliente(valor VARCHAR(50))
BEGIN
SELECT bitacora.Id_Bitacora as Clave, cliente.Nombre as cliente, cliente.Direccion as Direccion, zona.Municipio,bitacora.Dia as Dias, bitacora.Hora
from cliente 
INNER JOIN bitacora ON bitacora.Id_Cliente = cliente.Id_Cliente
INNER JOIN zona ON zona.Id_Zona = cliente.Id_Zona
OR Id_Bitacora LIKE valor  
OR Nombre LIKE valor 
OR Direccion LIKE valor
OR Municipio LIKE valor
OR Dia LIKE valor
OR Hora LIKE valor
LIMIT 1;
END


call buscar_cliente('%e%');

DROP PROCEDURE buscar_cliente;


CREATE PROCEDURE buscar_venta(valor VARCHAR(50))
BEGIN
SELECT venta.Folio_V as Venta, cliente.Nombre as Cliente, pan.Nombre as Pan, pan.Precio as Precio,detalleventa.Cantidad as Cantidad, venta.Hora as Hora,venta.Fecha as Fecha, venta.Total as Total, tipopago.Tipo_P as TipoPAGO
FROM pan
INNER JOIN detalleventa ON detalleventa.Codigo_Pan = pan.Codigo_Pan
INNER JOIN venta on venta.Folio_V = detalleventa.Folio_V
INNER JOIN cliente on cliente.Id_Cliente = venta.Id_Cliente
INNER JOIN detallepago ON detallepago.Folio_V = venta.Folio_V
INNER JOIN tipopago ON tipopago.Folio_P = detallepago.Folio_P
WHERE pan.Nombre LIKE valor
OR venta.Folio_V LIKE valor
OR cliente.Nombre LIKE valor  
OR pan.Precio LIKE valor
OR detalleventa.Cantidad LIKE valor
OR tipopago.Tipo_P LIKE valor
OR detallepago.Cantidad LIKE valor
OR venta.Hora LIKE valor
OR venta.Total LIKE valor
OR venta.Fecha LIKE valor
OR tipopago.Tipo_P LIKE valor
ORDER BY Fecha;
END

CALL buscar_venta('%VEN002%');
DROP PROCEDURE buscar_venta;



call buscar_venta('%a%');
Drop PROCEDURE buscar_venta;