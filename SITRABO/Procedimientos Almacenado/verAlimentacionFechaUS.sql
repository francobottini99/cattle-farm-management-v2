CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionFechaUS`(
	in Fec date,
    in idUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Alimentacion
	WHERE
		Fecha = Fec AND USUARIOS_idUsuario = idUs;
END