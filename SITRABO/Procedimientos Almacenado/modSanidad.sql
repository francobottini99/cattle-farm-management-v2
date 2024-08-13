CREATE DEFINER=`root`@`localhost` PROCEDURE `modSanidad`(
	in IdP int(11),
    in mFe varchar(255),
    in mTrat varchar(255),
    in mImp varchar(255),
    in mObs varchar (255)
)
BEGIN
	UPDATE Sanidad
	SET 
		Fecha = mFe,
        Tratamiento = mTrat,
        Importe = mImp,
        Observaciones = mObs
	WHERE 
		idSanidad = IdP;
END