CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleTropa`(
)
BEGIN
	SELECT
		*
	FROM
		detalle_tropa;
END