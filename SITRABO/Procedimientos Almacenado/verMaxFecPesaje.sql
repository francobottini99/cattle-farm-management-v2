CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxFecPesaje`()
BEGIN
	SELECT
		Max(Pesaje.Fecha) as UltimaFecPeso
	FROM
		Pesaje
	ORDER BY
		Fecha ASC;
END