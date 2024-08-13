CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimentacionProrateoPorTropa`(
    in Trp integer(11)
)
BEGIN
	SELECT
        alimentacion_prorrateo.Fecha,
        tropa.idTropa
	FROM
		detalle_tropa JOIN tropa ON detalle_tropa.TROPA_idTropa = tropa.idTropa
        JOIN alimentacion_prorrateo ON alimentacion_prorrateo.DETALLE_TROPA_idDetTropa = detalle_tropa.idDetTropa
	WHERE
		tropa.idTropa = Trp
	ORDER BY alimentacion_prorrateo.Fecha ASC;

END