CREATE DEFINER=`root`@`localhost` PROCEDURE `modEstadoMod`(
	in tbmEst varchar(45),
    in tbmIDt int(11)
    )
BEGIN
	UPDATE tropa_bloqueo_mod
    SET
		HabilitaMod = tbmEst
	WHERE
		TROPA_idTropa = tbmIDt;
END