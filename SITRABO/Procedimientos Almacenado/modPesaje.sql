CREATE DEFINER=`root`@`localhost` PROCEDURE `modPesaje`(
	in pID int(11),
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
	UPDATE pesaje
	SET 
		Fecha = pFecha,
        Tipo = pTipo,
        Peso = pPeso,
        PorcDesbaste = pPorcDesb,
        Desbaste = pDesb,
        PesoFinal = pPesoFin,
        Observaciones = pObsrv,
        DETALLE_TROPA_idDetTropa = pidDetTropa,
        TROPA_idTropa = pidTropa,
        USUARIOS_idUsuario =	pidUs
	WHERE
		idPESAJE = pID;
END