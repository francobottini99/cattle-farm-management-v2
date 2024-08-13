CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionProRateo_FechaDH_Tropa_Us`(
	in aUs integer(11),
    in aFecD date,
    in aFecH date,
    in aIdTropa integer(11)
)
BEGIN 
	SELECT
		*
	FROM
		Alimentacion_prorrateo JOIN Detalle_tropa ON Alimentacion_prorrateo.DETALLE_TROPA_idDetTropa = Detalle_tropa.idDetTropa
	WHERE
		Alimentacion_prorrateo.USUARIOS_idUsuario = aUs AND Alimentacion_prorrateo.Fecha >= aFecD AND Alimentacion_prorrateo.Fecha <= aFecH AND Detalle_tropa.TROPA_idTropa = aIdTropa; 
END