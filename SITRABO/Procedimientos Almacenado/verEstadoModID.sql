CREATE DEFINER=`root`@`localhost` PROCEDURE `verEstadoModID`(
	in idT int(11)
)
BEGIN
	SELECT
		*
	FROM
		tropa_bloqueo_mod
	WHERE
		TROPA_idTropa = idT;
END