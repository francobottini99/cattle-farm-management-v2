CREATE DEFINER=`root`@`localhost` PROCEDURE `verCorralesUs`(
	in uID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Corrales
	WHERE
		USUARIOS_idUsuario = uID;
END