CREATE DEFINER=`root`@`localhost` PROCEDURE `consDetalleTropa_Corral_Tropa_Productor`(
	in idDT int(11)
)
BEGIN
	SELECT
        detalle_tropa.Caravana,
        detalle_tropa.Descripcion,
        detalle_tropa.Estado,
        detalle_tropa.idDetTropa,
        tropa.NombreTropa,
        corrales.NombreCorral,
        corrales.idCorrales,
        categorias.Categoria,
        tropa.idTropa,
        productor.idProductor,
        productor.RazonSocial
	FROM
		detalle_tropa JOIN tropa ON detalle_tropa.TROPA_idTropa = tropa.idTropa
        JOIN categorias ON detalle_tropa.CATEGORIAS_idCategorias = categorias.idCategorias
        JOIN corrales ON detalle_tropa.CORRALES_idCorrales = corrales.idCorrales
		JOIN productor ON tropa.PRODUCTOR_idProductor = productor.idProductor
	WHERE
		detalle_tropa.idDetTropa = idDT;

END