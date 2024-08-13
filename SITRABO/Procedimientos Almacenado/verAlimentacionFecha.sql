CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionFecha`(
	in Fec date
)
BEGIN
	SELECT
		*
	FROM
		Alimentacion
	WHERE
		Fecha = Fec;
END