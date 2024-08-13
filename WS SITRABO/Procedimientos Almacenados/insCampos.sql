CREATE DEFINER=`root`@`localhost` PROCEDURE `insCampos`(
	in pNom varchar(250),
	in pProp varchar(250),
	in pLoc varchar(250),
    in pProv varchar(250),
	in pSup int(11),
	in pIDu int(11)
)
BEGIN
	INSERT INTO Campo (
		NombreCampo,
		Propietario,
		Localidad,
        Provincia,
		Superficie,
        USUARIOS_idUsuario
)
	VALUES (pNom, pProp, pLoc, pProv, pSup, pIDu);
END