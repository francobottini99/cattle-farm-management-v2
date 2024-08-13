CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAlimentacionProrrateoPorProductorYCorralFechaDH`(
	in fecD date,
    in fecH date,
	in idP int(11),
    in idC int(11)
)
BEGIN
	SELECT
		Sum(Alimentacion_Prorrateo.KgRacion) as TotKgRac,
        Sum(Alimentacion_Prorrateo.ImporteTotal) as SumaTotAlim
	FROM
		Alimentacion_Prorrateo JOIN Detalle_Tropa ON Detalle_Tropa.idDetTropa = Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
	WHERE Fecha >= fecD AND Fecha <= fecH AND Tropa.PRODUCTOR_idProductor = idP AND Detalle_Tropa.CORRALES_idCorrales = idC
	ORDER BY
		Fecha ASC;
END