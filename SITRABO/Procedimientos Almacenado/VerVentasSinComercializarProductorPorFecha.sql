CREATE DEFINER=`root`@`localhost` PROCEDURE `VerVentasSinComercializarProductorPorFecha`(
	in Fec date
)
BEGIN
	SELECT
		Productor.idProductor,
        Productor.RazonSocial
	FROM
		Ventas JOIN Productor ON Productor.idProductor = Ventas.PRODUCTOR_idProductor
	WHERE
		Ventas.Comprador = "-" AND Ventas.Fecha = Fec
	ORDER BY Productor.RazonSocial Asc;
END