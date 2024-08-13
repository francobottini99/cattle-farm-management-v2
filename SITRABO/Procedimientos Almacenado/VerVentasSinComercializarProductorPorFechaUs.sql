CREATE DEFINER=`root`@`localhost` PROCEDURE `VerVentasSinComercializarProductorPorFechaUs`(
	in Fec date,
    in idUs int(11)
)
BEGIN
	SELECT
		Productor.idProductor,
        Productor.RazonSocial
	FROM
		Ventas JOIN Productor ON Productor.idProductor = Ventas.PRODUCTOR_idProductor
	WHERE
		Ventas.Comprador = "-" AND Ventas.Fecha = Fec AND Ventas.USUARIOS_idUsuario = idUS
	ORDER BY Productor.RazonSocial Asc;
END