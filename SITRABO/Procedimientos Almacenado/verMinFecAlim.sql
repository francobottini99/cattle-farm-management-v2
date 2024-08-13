CREATE DEFINER=`root`@`localhost` PROCEDURE `verMinFecAlim`()
BEGIN
	SELECT
		Min(Alimentacion.Fecha) as PrimeraAlim
	FROM
		Alimentacion
	ORDER BY
		Fecha ASC;
END