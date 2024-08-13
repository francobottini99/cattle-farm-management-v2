CREATE DEFINER=`root`@`localhost` PROCEDURE `modTropaVta`(
	in IdC int(11),
    in mCab int(11)
)
BEGIN
	UPDATE Tropa
	SET 
		Ventas = Ventas + mCab,
        Stock = Stock - mCab
	WHERE 
		idTropa = IdC;
END