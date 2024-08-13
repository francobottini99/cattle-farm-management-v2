CREATE DEFINER=`root`@`localhost` PROCEDURE `consCaravRFIDYFecha`(
	in Carav varchar(255),
    in Fd date,
    in Fh date
)
BEGIN
	SELECT
		Detalle_Tropa.Caravana,
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
		Detalle_Tropa JOIN Alimentacion_Prorrateo ON Detalle_Tropa.idDetTropa = Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa 
	WHERE
		Detalle_Tropa.Caravana  = Carav AND Alimentacion_Prorrateo.Fecha >= Fd AND Alimentacion_Prorrateo.Fecha <= Fh
	ORDER BY Alimentacion_Prorrateo.Fecha Asc;
END