CREATE DEFINER=`root`@`localhost` PROCEDURE `consStockPorFecha`(
	in stkFec date
)
BEGIN
	SELECT
        Stock.idSTOCK,
        Stock.Fecha,
        Stock.Caravana,
        Stock.Descripcion,
        Stock.Cabezas,
        Tropa.idTropa,
        Tropa.NombreTropa,
        Tropa.FechaIngreso,
        Tropa.Cabezas,
        Tropa.PesoIngreso,
        Detalle_Tropa.idDetTropa,
        Detalle_Tropa.Caravana,
        Detalle_Tropa.Descripcion,
        Detalle_Tropa.Estado,
        Corrales.idCorrales,
        Corrales.NombreCorral,
        Corrales.CabezasTotales,
        Categorias.idCategorias,
        Categorias.Categoria
	FROM
		Stock JOIN Tropa ON Stock.TROPA_idTropa = Tropa.idTropa
        JOIN Detalle_Tropa ON Stock.DETALLE_TROPA_idDetTropa = Detalle_Tropa.idDetTropa
        JOIN Corrales ON Stock.CORRALES_idCorrales = Corrales.idCorrales
        JOIN Categorias ON Stock.CATEGORIAS_idCategorias = Categorias.idCategorias
	WHERE
		Stock.Fecha = stkFec And Detalle_Tropa.Estado = "Engorde";
END