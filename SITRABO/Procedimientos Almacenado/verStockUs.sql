CREATE DEFINER=`root`@`localhost` PROCEDURE `verStockUs`(
	in stkUs integer(11)
)
BEGIN
	SELECT
		*
	FROM
		stock
	WHERE
		USUARIOS_idUsuario = stkUs order by Fecha;
END