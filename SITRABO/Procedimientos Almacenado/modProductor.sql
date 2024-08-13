CREATE DEFINER=`root`@`localhost` PROCEDURE `modProductor`(
	in IdP int(11),
    in mRS varchar(255),
    in mDir varchar(255),
    in mLoc varchar(255),
    in mCp varchar(255),
    in mCuit varchar(255)
)
BEGIN
	UPDATE Productor
	SET 
		RazonSocial = mRS,
        Direccion = mDir,
        Localidad = mLoc,
        CP = mCp,
        CUIT = mCuit
	WHERE 
		idProductor = IdP;
END