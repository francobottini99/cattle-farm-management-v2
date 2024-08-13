CREATE DEFINER=`root`@`localhost` PROCEDURE `verStkDia`(
	in Fec date,
    in idUs int(11)
	
)
BEGIN
	SELECT
		*
	FROM
		stock
	WHERE
		Fecha = Fec AND USUARIOS_idUsuario = idUs;
END