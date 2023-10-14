#Inserciones para el archivo de Producto

CREATE PROCEDURE insertar_pan(
p_Codigo_Pan VARCHAR(12),
p_Nombre varchar(50),
p_Descripcion VARCHAR(255),
p_Categoria VARCHAR(7),
p_Precio DOUBLE,
p_Existencia DOUBLE
)
BEGIN
INSERT pan VALUES(
p_Codigo_Pan,
p_Nombre,
p_Descripcion,
p_Categoria,
p_Precio,
p_Existencia
);
END

call insertar_pan('PAN002','Bolillo','El bolillo, pan blanco, barra o pan francés es, en México y Centroamérica, un tipo de pan económico y bastante popular elaborado con harina de trigo, que no es considerado dulce.','Telera','3.0','50');

#Inserciones para el archivo cliente_zona

CREATE PROCEDURE insertar_zona(
z_Id_Zona VARCHAR(12),
z_Municipio varchar(50)
)
BEGIN
INSERT zona VALUES(
z_Id_Zona,
z_Municipio
);
END

call insertar_zona('ZONE002','Chapa de Mota');
DROP PROCEDURE insertar_zona;



CREATE PROCEDURE insertar_cliente(
c_Id_Cliente VARCHAR(12),
c_Nombre varchar(50),
c_Direccion VARCHAR(100),
c_Telefono VARCHAR(16),
c_Localidad VARCHAR(50)
)
BEGIN
INSERT cliente VALUES(
c_Id_Cliente,
c_Nombre,
c_Direccion,
c_Telefono,
(SELECT zona.Id_Zona FROM zona where zona.Localidad = c_Localidad)
);
END

call insertar_cliente('USER003','Alexander Martinez','Canalejas','+52 55 1841 4050','La Esperanza');
DROP PROCEDURE insertar_cliente;



CREATE PROCEDURE insertar_bitacora(
b_Id_Bitacora varchar(12),
b_Nombre VARCHAR(50),
b_Dia VARCHAR(50),
b_Hora VARCHAR(5)
)
BEGIN
INSERT bitacora VALUES(
b_Id_Bitacora,
(SELECT cliente.Id_Cliente FROM cliente where cliente.Nombre = b_Nombre),
b_Dia,
b_Hora
);
END

call insertar_bitacora('BIT001','Alexander Martinez','Lunes, Jueves','16:30');
DROP PROCEDURE insertar_bitacora;

# Inserciones para el archivo Pago



CREATE PROCEDURE insertar_tipopago(
tp_Folio_P VARCHAR(12),
tp_Tipo_P VARCHAR(50))
BEGIN
INSERT tipopago VALUES(
tp_Folio_P,
tp_Tipo_P);
END

call insertar_tipopago('DV01D','SOLD004');
DROP PROCEDURE insertar_tipopago;
