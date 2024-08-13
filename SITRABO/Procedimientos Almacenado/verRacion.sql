CREATE DEFINER=`root`@`localhost` PROCEDURE `verRacion`(
)
BEGIN
	SELECT
		*
	FROM
		raciones;
END