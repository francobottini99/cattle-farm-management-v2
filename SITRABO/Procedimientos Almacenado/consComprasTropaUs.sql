CREATE DEFINER=`root`@`localhost` PROCEDURE `consComprasTropaUs`(
	in idT int(11),
    in idU int(11)
)
BEGIN
	SELECT
        Compras.idCompras,
        Compras.Fecha,
        Proveedor.RazonSocial Proveedor,
        Tropa.NombreTropa Tropa,
        Tropa.OrigenProcedencia,
        Tropa.Cabezas Cab_Tropa,
        Tropa.PesoIngreso,
        Tropa.TotalKgTropa,
        Compras.CostoSinIvaPorKg,
        Compras.CostoSinIvaPorCabeza,
        Compras.AlicuotaIVA,
        Compras.CostoConIvaPorKg,
        Compras.CostoConIvaPorCabeza,
        Compras.CostoConIvaFlete,
        Compras.OtrosCostos,
        Compras.CostoFinalPorKg,
        Compras.CostoFinalPorCabeza,
        Compras.CostoTotalTropa,
        Compras.FormaPago
	FROM
		Compras JOIN Tropa ON Compras.TROPA_idTropa = Tropa.idTropa
        JOIN Proveedor ON Proveedor.idProveedor = Compras.PROVEEDOR_idProveedor
	WHERE Compras.TROPA_idTropa = idT AND Compras.USUARIOS_idUsuario = idU
	ORDER BY Compras.Fecha Asc;
END