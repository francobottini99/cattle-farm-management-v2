CREATE DEFINER=`root`@`localhost` PROCEDURE `modBorrarStock`(
	in Fec date,
	in Idus int(11)
)
BEGIN
	DELETE FROM Stock WHERE USUARIOS_idUsuario = Idus AND Fecha = Fec;
END