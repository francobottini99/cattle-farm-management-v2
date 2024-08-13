CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleTropaCorralesID`(
	in tID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Detalle_Tropa
	WHERE
		TROPA_idTropa = tID;
END