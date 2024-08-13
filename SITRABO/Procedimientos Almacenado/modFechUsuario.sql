CREATE DEFINER=`root`@`localhost` PROCEDURE `modFechUsuario`(
	in IdU int(11),
    in uFech datetime
)
BEGIN
	UPDATE Usuarios
	SET 
		FechaUltimoIngreso = uFech
	WHERE 
		idUsuario = IdU;
END