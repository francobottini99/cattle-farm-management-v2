CREATE DEFINER=`root`@`localhost` PROCEDURE `insProveedor`(
	in pNom varchar(250),
	in pDir varchar(250),
	in pLoc varchar(250),
    in pProv varchar(250),
	in pCP varchar(45),
	in pCuit varchar(45),
    in pTe varchar(250),
    in pMail varchar(250),
    in pIDUs int(11)
)
BEGIN
	INSERT INTO Proveedor (
		RazonSocial,
		Direccion,
		Localidad,
        Provincia,
		CP,
		CUIT,
        TE,
        Mail, 
        USUARIOS_idUsuario
)
	VALUES (pNom, pDir, pLoc, pProv, pCP, pCuit, pTe, pMail, pIDUs);
END