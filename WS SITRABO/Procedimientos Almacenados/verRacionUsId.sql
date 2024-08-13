CREATE DEFINER=`root`@`localhost` PROCEDURE `verRacionUsId`(
	in uID int(11),
    in idR int(11)
)
BEGIN
	SELECT
		*
	FROM
		raciones
	WHERE
		USUARIOS_idUsuario = uID AND idRaciones = idR;
END