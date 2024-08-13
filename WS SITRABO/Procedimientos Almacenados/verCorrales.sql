CREATE DEFINER=`root`@`localhost` PROCEDURE `verCorrales`(
)
BEGIN
	SELECT
		*
	FROM
		Corrales;
END