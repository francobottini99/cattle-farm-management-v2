CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimTropasYFechas`(
	in IdT int(11),
    in Fd date,
    in Fh date 
)
BEGIN
	SELECT
		Tropa.NombreTropa,
        sum(alimentacion_prorrateo.KgRacion) as KgRac,
        sum(alimentacion_prorrateo.KgGrano) as KgGr,
        sum(alimentacion_prorrateo.KgConcentrado) as KgCons,
        sum(alimentacion_prorrateo.KgFibra) as KgFib,
        sum(alimentacion_prorrateo.KgOtros) as KgOtr,
        sum(alimentacion_prorrateo.ImporteGrano) as ImGr,
        sum(alimentacion_prorrateo.ImporteConcentrado) as ImCons,
        sum(alimentacion_prorrateo.ImporteFibra) as ImFib,
        sum(alimentacion_prorrateo.ImporteOtros) as ImOtr,
        sum(alimentacion_prorrateo.ImporteTotal) as ImTot,
        avg(alimentacion_prorrateo.PorcentajeGrano) as PorGr,
        avg(alimentacion_prorrateo.PorcentajeConc) as PorConc,
        avg(alimentacion_prorrateo.PorcentajeFibra) as PorFib,
        avg(alimentacion_prorrateo.PorcentajeOtros) as PorOt
	FROM
		Alimentacion_Prorrateo JOIN Detalle_Tropa ON Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa = Detalle_Tropa.idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
	WHERE alimentacion_prorrateo.Fecha >= Fd AND alimentacion_prorrateo.Fecha <= Fh AND Tropa.idTropa = IdT
	ORDER BY alimentacion_prorrateo.Fecha Asc;
END