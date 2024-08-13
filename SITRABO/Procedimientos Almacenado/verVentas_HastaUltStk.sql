CREATE DEFINER=`root`@`localhost` PROCEDURE `verVentas_HastaUltStk`(
	in vFech date
)
BEGIN
	SELECT
		*
	FROM
		Ventas
	WHERE
		Fecha >= vFech;
END