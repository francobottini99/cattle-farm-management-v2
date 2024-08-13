CREATE DEFINER=`root`@`localhost` PROCEDURE `verCategoriaUs`(
	in uID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Categorias
	WHERE
		USUARIOS_idUsuario = uID;
END