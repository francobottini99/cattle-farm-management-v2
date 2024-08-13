CREATE DEFINER=`root`@`localhost` PROCEDURE `VerVentasSinComercializarFechaUs`(
    in idUs int(11)
)
BEGIN
	SELECT
		Ventas.idVentas,
        Ventas.Fecha
	FROM
		Ventas
	WHERE
		Comprador = "-" AND USUARIOS_idUsuario = idUS
	ORDER BY Fecha Asc;
END