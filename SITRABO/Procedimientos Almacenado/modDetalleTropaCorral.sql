CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropaCorral`(
	in IdDT int(11),
    in Crr int(11)
)
BEGIN
	UPDATE detalle_tropa
	SET 
		CORRALES_idCorrales = Crr
	WHERE 
		idDetTropa = IdDT;
END