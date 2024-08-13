CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropaEngorde`(
    in idDt int(11)
    )
BEGIN
	UPDATE detalle_tropa
    SET
		Estado = "Engorde"
	WHERE
		idDetTropa = idDt;
END