CREATE DEFINER=`root`@`localhost` PROCEDURE `consPesajeTropaInicioaFin`(
    in idTrp int(11) 
)
BEGIN
	SELECT
		pesaje.idPESAJE,
        tropa.idTropa,
        detalle_tropa.idDetTropa,
        detalle_tropa.CORRALES_idCorrales,
        pesaje.Fecha,
        corrales.NombreCorral,
        categorias.Categoria, 
        tropa.NombreTropa,
        detalle_tropa.Caravana,
        detalle_tropa.Descripcion,
        pesaje.Peso,
		pesaje.PorcDesbaste,
        pesaje.Desbaste,
        pesaje.PesoFinal,
        pesaje.Observaciones,
        pesaje.Tipo,        
        detalle_tropa.Estado
	FROM
		pesaje JOIN detalle_tropa ON pesaje.DETALLE_TROPA_idDetTropa = detalle_tropa.idDetTropa
        JOIN tropa ON pesaje.TROPA_idTropa = tropa.idTropa
        JOIN categorias ON detalle_tropa.CATEGORIAS_idCategorias = categorias.idCategorias
        JOIN corrales ON corrales.idCorrales = detalle_tropa.CORRALES_idCorrales
	WHERE
		tropa.idTropa = idTrp
	ORDER BY pesaje.Peso DESC;
END