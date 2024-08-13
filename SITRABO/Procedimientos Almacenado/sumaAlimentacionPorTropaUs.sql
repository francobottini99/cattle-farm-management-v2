CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAlimentacionPorTropaUs`(
	in idT int(11),
    in idU int(11)
)
BEGIN
	SELECT
		Sum(Alimentacion_Prorrateo.KgRacion) as TotKgRac,
        Sum(Alimentacion_Prorrateo.ImporteTotal) as SumaTotAlim
	FROM
		Alimentacion_Prorrateo JOIN Detalle_Tropa ON Detalle_Tropa.idDetTropa = Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
	WHERE Tropa.idTropa = IDt AND Detalle_Tropa.USUARIOS_idUsuario = idU
	ORDER BY
		Fecha ASC;
END