CREATE DEFINER=`root`@`localhost` PROCEDURE `modCampo`(
	in IdP int(11),
    in mNC varchar(255),
    in mProp varchar(255),
    in mLoc varchar(255),
    in mPro varchar (255),
    in mHas double
)
BEGIN
	UPDATE Campo
	SET 
		NombreCampo = mNC,
        Propietario = mProp,
        Localidad = mLoc,
        Provincia = mPro,
        Superficie = mHas
	WHERE 
		idCampo = IdP;
END