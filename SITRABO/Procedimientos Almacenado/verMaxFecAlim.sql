CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxFecAlim`()
BEGIN
	SELECT
		Max(Alimentacion.Fecha) as UltimaAlim
	FROM
		Alimentacion
	ORDER BY
		Fecha ASC;
END