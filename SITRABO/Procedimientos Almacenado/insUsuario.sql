CREATE DEFINER=`root`@`localhost` PROCEDURE `insUsuario`(
	in uApellido varchar(255),
	in uNom varchar(255),
    in uDni varchar(10),
    in uContr varchar(255),
    in uCatg varchar(100),
    in uFechR date
)
BEGIN
	INSERT INTO Usuarios (
		Apellido,
		Nombres,
		DNI,
        Contraseña,
        CategoriaUsuario,
        FechaRegistro
)
	VALUES (uApellido, uNom, uDni, uContr, uCatg, uFechR);
END