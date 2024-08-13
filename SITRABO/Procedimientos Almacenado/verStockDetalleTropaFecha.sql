CREATE DEFINER=`root`@`localhost` PROCEDURE `verStockDetalleTropaFecha`(
	in idDt int(11),
    in Fec date
)
BEGIN
	SELECT
		*
	FROM
		Stock
	Where
		DETALLE_TROPA_idDetTropa = idDt AND Fecha = Fec;
END