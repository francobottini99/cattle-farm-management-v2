CREATE DEFINER=`root`@`localhost` PROCEDURE `verCamposUs`(
	in uID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Campo
	WHERE
		USUARIOS_idUsuario = uID;
END