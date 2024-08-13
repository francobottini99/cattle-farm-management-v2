CREATE DEFINER=`root`@`localhost` PROCEDURE `insProductor`(
	in pNom varchar(250),
	in pDir varchar(250),
	in pLoc varchar(250),
	in pCP varchar(45),
	in pCuit varchar(45),
    in pUs integer(11)
)
BEGIN
	INSERT INTO Productor (
		RazonSocial,
		Direccion,
		Localidad,
		CP,
		CUIT,
        USUARIOS_idUsuario
)
	VALUES (pNom, pDir, pLoc, pCP, pCuit, pUs);
END