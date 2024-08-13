CREATE DEFINER=`root`@`localhost` PROCEDURE `verPesajeVenta`(
	in idDt int(11)
)
BEGIN
	SELECT
		*
	FROM
		pesaje
	WHERE
		DETALLE_TROPA_idDetTropa = idDt AND Tipo = "Venta";
END