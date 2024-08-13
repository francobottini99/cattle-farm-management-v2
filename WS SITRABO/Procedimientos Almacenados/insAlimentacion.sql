CREATE DEFINER=`root`@`localhost` PROCEDURE `insAlimentacion`(
	in aFecha date,
	in aKgRacion double,
    in aTurno varchar(250),
    in aKgGrano double,
    in aKgConcentrado double,
    in aKgFibra double,
    in aKgOtros double,
    in aImporteGrano double,
    in aImporteConcentrado double,
    in aImporteFibra double,
    in aImporteOtros double,
    in aImporteTotal double,
    in aPorcentajeGrano double,
    in aPorcentajeConc double,
    in aPorcentajeFibra double,
    in aPorcentajeOtros double,
    in aObser varchar(250),
	in aIdCorral int(11),
    in aIdRacion int(11),
    in aIdUsuario int(11)
)
BEGIN
	INSERT INTO Alimentacion (
		Fecha,
		KgRacion,
		Turno,
        KgGrano,
        KgConcentrado,
        KgFibra,
        KgOtros,
        ImporteGrano,
        ImporteConcentrado,
        ImporteFibra,
        ImporteOtros,
        ImporteTotal,
        PorcentajeGrano,
        PorcentajeConc,
        PorcentajeFibra,
        PorcentajeOtros,
        Observaciones,
        CORRALES_idCorrales,
        RACIONES_idRaciones,
        USUARIOS_idUsuario
)
	VALUES (aFecha, aKgRacion, aTurno, aKgGrano, aKgConcentrado, aKgFibra, aKgOtros, aImporteGrano, aImporteConcentrado, aImporteFibra, aImporteOtros, aImporteTotal, aPorcentajeGrano, aPorcentajeConc, aPorcentajeFibra, aPorcentajeOtros, aObser, aIdCorral, aIdRacion, aIdUsuario);
END