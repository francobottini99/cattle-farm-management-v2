CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxFecAlimporTropaUs`(
	in idT int(11),
    in idU int(11)
)
BEGIN
	SELECT
		Max(Alimentacion_Prorrateo.Fecha) as UltimaAlim
	FROM
		Alimentacion_Prorrateo JOIN Detalle_Tropa ON Detalle_Tropa.idDetTropa = Alimentacion_Prorrateo.DETALLE_TROPA_idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
	WHERE Tropa.idTropa = IDt AND Detalle_Tropa.USUARIOS_idUsuario = idU
	ORDER BY
		Fecha ASC;
END