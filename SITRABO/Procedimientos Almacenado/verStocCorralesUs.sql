CREATE DEFINER=`root`@`localhost` PROCEDURE `verStocCorralesUs`(
	in sMod varchar(100),
	in sUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Detalle_Tropa
	WHERE
        Estado = sMod And USUARIOS_idUsuario = sUs;
END