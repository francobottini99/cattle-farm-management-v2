CREATE DEFINER=`root`@`localhost` PROCEDURE `insEstadoMod`(
	in tbmEst varchar(45),
    in tbmIDt int(11)
    )
BEGIN
	INSERT INTO tropa_bloqueo_mod (
		HabilitaMod,
        TROPA_idTropa
)
	VALUES (tbmEst, tbmIDt);
END