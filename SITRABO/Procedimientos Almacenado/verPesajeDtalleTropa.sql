CREATE DEFINER=`root`@`localhost` PROCEDURE `verPesajeDtalleTropa`(
	in dtUs integer(11),
    in idDtcrr integer(11)
)
BEGIN
	SELECT
		*
	FROM
		pesaje
	WHERE
		USUARIOS_idUsuario = dtUs AND DETALLE_TROPA_idDetTropa = idDtcrr ORDER BY Fecha DESC; 
END