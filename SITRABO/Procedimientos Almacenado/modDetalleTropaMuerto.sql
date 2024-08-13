CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropaMuerto`(
    in idDt int(11)
    )
BEGIN
	UPDATE detalle_tropa
    SET
		Estado = "Muerto"
	WHERE
		idDetTropa = idDt;
END