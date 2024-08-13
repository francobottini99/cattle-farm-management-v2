CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAlimentacionProrrateoTodoPorProductor`(
	in fecD date,
    in fecH date,
    in idP int(11)
)
BEGIN
	SELECT
		Sum(KgGrano) as KgGrano,
        sum(KgSilo) as KgSilo,
        Sum(KgConcentrado) as KgConcentrado,
        Sum(KgFibra) as KgFibra,
        Sum(KgOtros) as KgOtros,
        Sum(KgRacion) as KgRacion,
        Sum(ImporteGrano) as ImporteGrano,
        Sum(ImporteSilo) as ImporteSilo,
        Sum(ImporteConcentrado) as ImporteConcentrado,
        Sum(ImporteFibra) as ImporteFibra,
        Sum(ImporteOtros) as ImporteOtros,
        Sum(ImporteTotal) as ImporteTotal
	FROM
		Alimentacion_Prorrateo JOIN Detalle_Tropa ON Detalle_Tropa.idDetTropa = Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
	WHERE Fecha >= fecD AND Fecha <= fecH AND Tropa.PRODUCTOR_idProductor = idP
	ORDER BY
		Fecha ASC;
END