CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleTropaUs`(
	in dtUs integer(11)
)
BEGIN
	SELECT
		*
	FROM
		detalle_tropa
	WHERE
		USUARIOS_idUsuario = dtUs;
END