CREATE DEFINER=`root`@`localhost` PROCEDURE `modCorral`(
	in IdC int(11),
    in mCab int(11)
)
BEGIN
	UPDATE Corrales
	SET 
		CabezasTotales = mCab
	WHERE 
		idCorrales = IdC;
END