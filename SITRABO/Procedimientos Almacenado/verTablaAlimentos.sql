CREATE DEFINER=`root`@`localhost` PROCEDURE `verTablaAlimentos`(
)
BEGIN
	SELECT
		*
	FROM
		Alimentos;
END