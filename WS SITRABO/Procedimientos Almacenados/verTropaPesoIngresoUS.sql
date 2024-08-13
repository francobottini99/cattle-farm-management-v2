CREATE DEFINER=`root`@`localhost` PROCEDURE `verTropaPesoIngresoUS`(
	in dtUs integer(11),
    in idT integer(11)
)
BEGIN 
	SELECT
		*
	FROM
		tropa
	WHERE
		USUARIOS_idUsuario = dtUs AND idTropa = idT; 
END