CREATE DEFINER=`root`@`localhost` PROCEDURE `verMuertes_HastaUltStk`(
	in mFech date
)
BEGIN
	SELECT
		*
	FROM
		Muertes
	WHERE
		Fecha >= mFech;
END