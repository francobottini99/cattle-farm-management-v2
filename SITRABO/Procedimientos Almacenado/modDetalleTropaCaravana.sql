CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropaCaravana`(
    in idDt int(11),
    in Carav varchar(250)
    )
BEGIN
	UPDATE detalle_tropa
    SET
		Caravana = Carav
	WHERE
		idDetTropa = idDt;
END