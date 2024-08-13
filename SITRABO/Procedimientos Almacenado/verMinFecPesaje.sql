CREATE DEFINER=`root`@`localhost` PROCEDURE `verMinFecPesaje`()
BEGIN
	SELECT
		Min(Pesaje.Fecha) as PrimerPesaje
	FROM
		Pesaje
	ORDER BY
		Fecha ASC;
END