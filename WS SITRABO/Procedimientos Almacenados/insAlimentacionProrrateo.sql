CREATE DEFINER=`root`@`localhost` PROCEDURE `insAlimentacionProrrateo`(
	in aFecha date,
	in aKgRacion double,
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
	in aIdRacion int(11),
    in aDetTtro int(11),
    in aIdUsuario int(11),
    in aIdAlim int(11)
)
BEGIN
	INSERT INTO Alimentacion (
		Fecha,
		KgRacion,
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
        RACIONES_idRaciones,
        DETALLE_TROPA_idDetTropa,
        USUARIOS_idUsuario,
        ALIMENTACION_idAlimentacion
)
	VALUES (aFecha, aKgRacion, aKgGrano, aKgConcentrado, aKgFibra, aKgOtros, aImporteGrano, aImporteConcentrado, aImporteFibra, aImporteOtros, aImporteTotal, aPorcentajeGrano, aPorcentajeConc, aPorcentajeFibra, aPorcentajeOtros, aIdRacion, aDetTtro, aIdUsuario, aIdAlim);
END