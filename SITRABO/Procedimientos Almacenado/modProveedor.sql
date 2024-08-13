CREATE DEFINER=`root`@`localhost` PROCEDURE `modProveedor`(
	in IdP int(11),
    in mRS varchar(255),
    in mDir varchar(255),
    in mLoc varchar(255),
    in mPro varchar (255),
    in mCp varchar(255),
    in mCuit varchar(255),
    in mTe varchar(255),
    in mMail varchar(255)
)
BEGIN
	UPDATE Proveedor
	SET 
		RazonSocial = mRS,
        Direccion = mDir,
        Localidad = mLoc,
        Provincia = mPro,
        CP = mCp,
        CUIT = mCuit,
        TE = mTe,
        Mail = mMail
	WHERE 
		idProveedor = IdP;
END