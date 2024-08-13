CREATE DEFINER=`root`@`localhost` PROCEDURE `verProductorPorID`(
	in idProd int(11)
)
BEGIN
	SELECT
		*
	FROM
		Productor
	WHERE
		idProductor = idProd;
END