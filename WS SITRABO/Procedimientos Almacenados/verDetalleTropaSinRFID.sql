CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleTropaSinRFID`(
	in idT int(11)
)
BEGIN
	SELECT
		*
	FROM
		detalle_tropa
	WHERE Estado = 'Engorde' AND CaravanaRFID = '00 00 00 00 00 00 00' AND TROPA_idTropa = idT;
END