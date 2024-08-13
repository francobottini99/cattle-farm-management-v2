CREATE DEFINER=`root`@`localhost` PROCEDURE `consVentasSinComercializar`(
	in idP int(11),
    in Fec date
)
BEGIN
	SELECT
		Ventas.idVentas,
        Ventas.Fecha,
        Ventas.Comprador,
        Ventas.Cabezas,
        Ventas.KgVendidos,
        Ventas.KgPorCabeza,
        Ventas.PrecioVtaSinIvaPorKg,
        Ventas.ImporteVtaSinIvaPorCabeza,
        Ventas.AlicuotaIva,
        Ventas.PrecioVtaConIvaPorKg,
        Ventas.ImporteVtaConIvaPorCabeza,
        Ventas.ImporteTotalVenta,
        Ventas.Flete,
        Ventas.OtrosCostos,
        Ventas.ImporteNetoVenta,
        Productor.idProductor,
		Productor.RazonSocial,
        Detalle_Tropa.idDetTropa,
        Detalle_Tropa.Caravana,
        Detalle_Tropa.Descripcion,
        Detalle_Tropa.Estado,
        Tropa.idTropa,
        Tropa.NombreTropa,
        Pesaje.idPESAJE,
        Pesaje.Peso,
        Pesaje.PorcDesbaste,
        Pesaje.PesoFinal
	FROM
		Ventas JOIN Productor ON Productor.idProductor = Ventas.PRODUCTOR_idProductor
		JOIN Detalle_Tropa ON Detalle_Tropa.idDetTropa = Ventas.DETALLE_TROPA_idDetTropa
        JOIN Tropa ON Tropa.idTropa = Detalle_Tropa.TROPA_idTropa
        JOIN Pesaje ON Pesaje.idPESAJE = Ventas.PESAJE_idPESAJE
	WHERE
		Ventas.Comprador = "-" AND Productor.idProductor = idP AND Ventas.Fecha = Fec
	ORDER BY Detalle_Tropa.Caravana Asc;
END