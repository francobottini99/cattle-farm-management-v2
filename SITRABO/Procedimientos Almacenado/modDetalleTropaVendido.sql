CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropaVendido`(
    in idDt int(11)
    )
BEGIN
	UPDATE detalle_tropa
    SET
		Estado = "Vendido"
	WHERE
		idDetTropa = idDt;
END