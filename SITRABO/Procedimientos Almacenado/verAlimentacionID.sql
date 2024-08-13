CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionID`(
	in iD int(11)
)
BEGIN
	SELECT
		*
	FROM
		Alimentacion
	WHERE
		idAlimentacion = iD;
END