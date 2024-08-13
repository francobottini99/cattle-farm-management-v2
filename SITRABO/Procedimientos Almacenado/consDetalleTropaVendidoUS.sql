CREATE DEFINER=`root`@`localhost` PROCEDURE `consDetalleTropaVendidoUS`(
	in dtUs integer(11)
)
BEGIN
	SELECT
        detalle_tropa.Caravana,
        detalle_tropa.Descripcion,
        detalle_tropa.Estado,
        detalle_tropa.idDetTropa,
        tropa.NombreTropa,
        categorias.Categoria,
        tropa.idTropa
	FROM
		detalle_tropa JOIN tropa ON detalle_tropa.TROPA_idTropa = tropa.idTropa
        JOIN categorias ON detalle_tropa.CATEGORIAS_idCategorias = categorias.idCategorias
	WHERE
		Estado = "Vendido" AND detalle_tropa.USUARIOS_idUsuario = dtUs;

END