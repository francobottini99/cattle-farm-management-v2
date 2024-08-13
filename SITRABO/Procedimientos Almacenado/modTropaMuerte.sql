CREATE DEFINER=`root`@`localhost` PROCEDURE `modTropaMuerte`(
	in IdC int(11),
    in mCab int(11)
)
BEGIN
	UPDATE Tropa
	SET 
		Muertes = Muertes + mCab,
        Stock = Stock - mCab
	WHERE 
		idTropa = IdC;
END