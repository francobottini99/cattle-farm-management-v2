CREATE DEFINER=`root`@`localhost` PROCEDURE `verCampos`(
)
BEGIN
	SELECT
		*
	FROM
		Campo;
END