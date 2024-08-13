CREATE DEFINER=`root`@`localhost` PROCEDURE `insPesaje`(
	in pFecha date,
    in pTipo varchar(255),
	in pPeso double,
    in pPorcDesb double,
    in pDesb double,
    in pPesoFin double,
    in pObsrv varchar(255),
    in pidDetTropa int(11),
    in pidTropa int(11),
    in pidUs int(11)
    )
BEGIN
	INSERT INTO pesaje (
		Fecha,
        Tipo,
        Peso,
        PorcDesbaste,
        Desbaste,
        PesoFinal,
        Observaciones,
        DETALLE_TROPA_idDetTropa,
        TROPA_idTropa,
        USUARIOS_idUsuario
)
	VALUES (pFecha, pTipo, pPeso, pPorcDesb, pDesb, pPesoFin, pObsrv, pidDetTropa, pidTropa, pidUs);
END