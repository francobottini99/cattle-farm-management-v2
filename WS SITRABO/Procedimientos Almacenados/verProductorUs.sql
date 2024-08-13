CREATE DEFINER=`root`@`localhost` PROCEDURE `verProductorUs`(
	in pUs integer(11)
)
BEGIN
	SELECT
		*
	FROM
		Productor
	WHERE
		USUARIOS_idUsuario = pUs;
END