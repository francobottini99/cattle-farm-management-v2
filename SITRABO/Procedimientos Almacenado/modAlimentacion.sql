CREATE DEFINER=`root`@`localhost` PROCEDURE `modAlimentacion`(
	in aIdAlim int(11),
	in aFecha date,
	in aKgRacion double,
    in aTurno varchar(250),
    in aKgGrano double,
    in aKgSilo double,
    in aKgConcentrado double,
    in aKgFibra double,
    in aKgOtros double,
    in aImporteGrano double,
    in aImporteSilo double,
    in aImporteConcentrado double,
    in aImporteFibra double,
    in aImporteOtros double,
    in aImporteTotal double,
    in aPorcentajeGrano double,
    in aPorcentajeSilo double,
    in aPorcentajeConc double,
    in aPorcentajeFibra double,
    in aPorcentajeOtros double,
    in aObser varchar(250),
	in aIdCorral int(11),
    in aIdRacion int(11),
    in aIdUsuario int(11)
)
BEGIN
	UPDATE Alimentacion
	SET 
		Fecha = aFecha,
		KgRacion = aKgRacion,
		Turno = aTurno,
        KgGrano = aKgGrano,
        KgSilo = aKgSilo,
        KgConcentrado = aKgConcentrado,
        KgFibra = aKgFibra,
        KgOtros = aKgOtros,
        ImporteGrano = aImporteGrano,
        ImporteSilo = aImporteSilo,
        ImporteConcentrado = aImporteConcentrado,
        ImporteFibra = aImporteFibra,
        ImporteOtros = aImporteOtros,
        ImporteTotal = aImporteTotal,
        PorcentajeGrano = aPorcentajeGrano,
        PorcentajeSilo = aPorcentajeSilo,
        PorcentajeConc = aPorcentajeConc,
        PorcentajeFibra = aPorcentajeFibra,
        PorcentajeOtros = aPorcentajeOtros,
        Observaciones = aObser,
        CORRALES_idCorrales = aIdCorral,
        RACIONES_idRaciones = aIdRacion,
        USUARIOS_idUsuario = aIdUsuario
	WHERE 
		idAlimentacion = aIdAlim;
END