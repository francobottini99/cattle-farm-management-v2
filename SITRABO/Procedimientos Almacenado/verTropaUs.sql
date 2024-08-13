CREATE DEFINER=`root`@`localhost` PROCEDURE `verTropaUs`(
	in uID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Tropa
	WHERE
		USUARIOS_idUsuario = uID;
END