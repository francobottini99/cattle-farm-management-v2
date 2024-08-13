CREATE DEFINER=`root`@`localhost` PROCEDURE `verStock`(
)
BEGIN
	SELECT
		*
	FROM
		Stock;
END