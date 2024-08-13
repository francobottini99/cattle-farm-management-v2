CREATE DEFINER=`root`@`localhost` PROCEDURE `consTropasSinRFIDUS`(
	in dtUs integer(11)
)
BEGIN
	SELECT
		tropa.idTropa,
        tropa.NombreTropa,
        tropa.OrigenProcedencia,
        tropa.FechaIngreso,
        tropa.Cabezas,
        tropa.Muertes,
        tropa.Ventas,
        tropa.Stock,
        tropa.PesoIngreso,
        tropa.TotalKgTropa,
        tropa.Observaciones,
        tropa.PRODUCTOR_idProductor,
        tropa.CAMPO_idCampo,
        tropa.PROVEEDOR_idProveedor,
        tropa.USUARIOS_idUsuario
	FROM
		detalle_tropa JOIN tropa ON detalle_tropa.TROPA_idTropa = tropa.idTropa
	WHERE
		Estado = "Engorde" AND detalle_tropa.USUARIOS_idUsuario = dtUs AND detalle_tropa.CaravanaRFID = '00 00 00 00 00 00 00'
	ORDER BY tropa.idTropa ASC;
END