CREATE DEFINER=`root`@`localhost` PROCEDURE `verStocFechaUs`(
	in sFec date,
	in sUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Stock
	WHERE
        Fecha = sFec And USUARIOS_idUsuario = sUs;
END