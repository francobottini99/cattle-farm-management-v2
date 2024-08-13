CREATE DEFINER=`root`@`localhost` PROCEDURE `modCorrales`(
	in IdP int(11),
    in mNC varchar(255),
    in mSup double,
    in mCT double
)
BEGIN
	UPDATE Corrales
	SET 
		NombreCorral = mNC,
        Superficie = mSup,
        CabezasTotales = mCT
	WHERE 
		idCorrales = IdP;
END