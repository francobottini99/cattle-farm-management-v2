CREATE DEFINER=`root`@`localhost` PROCEDURE `verRacionUs`(
	in uID int(11)
)
BEGIN
	SELECT
		*
	FROM
		raciones
	WHERE
		USUARIOS_idUsuario = uID;
END