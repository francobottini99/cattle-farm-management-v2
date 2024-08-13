CREATE DEFINER=`root`@`localhost` PROCEDURE `modRacion`(
	in IdP int(11),
    in mRac varchar(255),
    in mGr varchar(255),
    in mSil varchar(255),
    in mConc varchar(255),
    in mFib varchar (255),
    in mOtr varchar(255),
    in mCgr double,
    in mCsil double,
    in mCcon double,
    in mCfib double,
    in mCOt double
)
BEGIN
	UPDATE Raciones
	SET 
		NombreRacion = mRac,
        Grano = mGr,
        Silo = mSil,
        Concentrado = mConc,
        Fibra = mFib,
        Otros = mOtr,
        CostoGrano = mCgr,
        CostoSilo = mCsil,
        CostoConcentrado = mCcon,
        CostoFibra = mCfib,
        CostoOtros = mCOt
	WHERE 
		idRaciones = IdP;
END