CREATE DEFINER=`root`@`localhost` PROCEDURE `VerVentasSinComercializarFecha`(
)
BEGIN
	SELECT
		Ventas.idVentas,
        Ventas.Fecha
	FROM
		Ventas
	WHERE
		Comprador = "-"
	ORDER BY Fecha Asc;
END