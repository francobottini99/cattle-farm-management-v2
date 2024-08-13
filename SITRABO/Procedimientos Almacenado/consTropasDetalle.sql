CREATE DEFINER=`root`@`localhost` PROCEDURE `consTropasDetalle`(
	in idT int(11)
)
BEGIN
	SELECT
        Tropa.idTropa,
        Tropa.NombreTropa,
        Productor.RazonSocial Productor,
        Proveedor.RazonSocial Proveedor,  
        Tropa.OrigenProcedencia Procedencia,
        Campo.NombreCampo Destino,
        Tropa.FechaIngreso Ingreso,
        Tropa.Cabezas Cab_Tropa,
        Tropa.Muertes,
        Tropa.Ventas,
        Tropa.Stock Stk_Tropa,
        Tropa.PesoIngreso,
        Tropa.TotalKgTropa,
        Detalle_Tropa.Caravana,
        Categorias.Categoria,
        Detalle_Tropa.Descripcion,
        Detalle_Tropa.Estado,
        Corrales.NombreCorral
	FROM
		Tropa JOIN Detalle_Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
        JOIN Categorias ON Categorias.idCategorias = Detalle_Tropa.CATEGORIAS_idCategorias
        JOIN Corrales ON Corrales.idCOrrales = Detalle_Tropa.CORRALES_idCorrales
        JOIN Productor ON Productor.idProductor = Tropa.PRODUCTOR_idProductor
        JOIN Proveedor ON Proveedor.idProveedor = Tropa.PROVEEDOR_idProveedor
        JOIN Campo ON Campo.idCampo = Tropa.CAMPO_idCampo
	WHERE Tropa.idTropa = idT
	ORDER BY Tropa.NombreTropa Asc;
END