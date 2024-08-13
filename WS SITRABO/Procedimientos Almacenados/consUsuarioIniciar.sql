CREATE DEFINER=`root`@`localhost` PROCEDURE `consUsuarioIniciar`(
	in uDNI varchar(10),
    in uContr varchar (255)
)
BEGIN
	SELECT
		*
	FROM
		Usuarios
	WHERE
		DNI = uDNI And Contraseña = uContr;
END