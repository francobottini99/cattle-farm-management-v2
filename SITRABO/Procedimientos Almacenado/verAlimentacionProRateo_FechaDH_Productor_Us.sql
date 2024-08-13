CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionProRateo_FechaDH_Productor_Us`(
	in aUs integer(11),
    in aFecD date,
    in aFecH date,
    in aIdProductor integer(11)
)
BEGIN 
	SELECT
		*
	FROM
		Alimentacion_prorrateo JOIN Detalle_tropa ON Alimentacion_prorrateo.DETALLE_TROPA_idDetTropa = Detalle_tropa.idDetTropa
        JOIN Tropa ON Detalle_tropa.TROPA_idTropa = Tropa.idTropa
	WHERE
		Alimentacion_prorrateo.USUARIOS_idUsuario = aUs AND Alimentacion_prorrateo.Fecha >= aFecD AND Alimentacion_prorrateo.Fecha <= aFecH AND Tropa.PRODUCTOR_idProductor = aIdProductor; 
END