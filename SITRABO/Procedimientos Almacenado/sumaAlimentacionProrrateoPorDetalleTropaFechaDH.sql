CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAlimentacionProrrateoPorDetalleTropaFechaDH`(
	in fecD date,
    in fecH date,
	in idDT int(11)
)
BEGIN
	SELECT
		Sum(Alimentacion_Prorrateo.KgRacion) as TotKgRac,
        Sum(Alimentacion_Prorrateo.ImporteTotal) as SumaTotAlim
	FROM
		Alimentacion_Prorrateo 
	WHERE Fecha >= fecD AND Fecha <= fecH AND DETALLE_TROPA_idDetTropa = idDT
	ORDER BY
		Fecha ASC;
END