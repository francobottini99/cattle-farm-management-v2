CREATE DEFINER=`root`@`localhost` PROCEDURE `consPesajeFechaCaravana`(
	in fD date,
    in fH date,
	in carav varchar(255)
)
BEGIN
	SELECT
		pesaje.idPESAJE,
        tropa.idTropa,
        detalle_tropa.idDetTropa,
        pesaje.Fecha,
        tropa.NombreTropa,
        detalle_tropa.CORRALES_idCorrales,
        corrales.NombreCorral,
        detalle_tropa.Caravana,
        detalle_tropa.Descripcion,
        pesaje.Tipo,
        categorias.Categoria,
        pesaje.Peso,
		pesaje.PorcDesbaste,
        pesaje.Desbaste,
        pesaje.PesoFinal,
        pesaje.Observaciones,
        detalle_tropa.Estado
	FROM
		pesaje JOIN detalle_tropa ON pesaje.DETALLE_TROPA_idDetTropa = detalle_tropa.idDetTropa
        JOIN tropa ON pesaje.TROPA_idTropa = tropa.idTropa
        JOIN categorias ON detalle_tropa.CATEGORIAS_idCategorias = categorias.idCategorias
        JOIN corrales ON corrales.idCorrales = detalle_tropa.CORRALES_idCorrales
	WHERE
        pesaje.Fecha = fD And pesaje.Fecha = fH And detalle_tropa.Caravana = carav
	ORDER BY Pesaje.Fecha;
END