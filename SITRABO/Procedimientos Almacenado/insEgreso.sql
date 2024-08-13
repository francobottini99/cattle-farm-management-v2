CREATE DEFINER=`root`@`localhost` PROCEDURE `insEgreso`(
	in vFecha date,
	in vComprador varchar(255),
    in vCab double,
    in vKgVendidos double,
    in vKgCab double,
    in vPrecVtaSinIvaKg double,
    in vImpVtaSinIvaCab double,
    in vAlicuotaIva double,
    in vPrecVtaConIvaKg double,
    in vImpVtaConIvaCab double,
    in vImpTotalVenta double,
    in vFlete double,
    in vOtrosCostos double,
    in vImpNetoVenta double,
    in vIdProd int(11),
    in vIdDetTropa int(11),
    in vIdUS int(11),
    in vIdPesaje int(11)
)
BEGIN
	INSERT INTO Ventas (
		Fecha,
		Comprador,
		Cabezas,
        KgVendidos,
        KgPorCabeza,
        PrecioVtaSinIvaPorKg,
        ImporteVtaSinIvaPorCabeza,
        AlicuotaIva,
        PrecioVtaConIvaPorKg,
        ImporteVtaConIvaPorCabeza,
        ImporteTotalVenta,
        Flete,
        OtrosCostos,
        ImporteNetoVenta,
        PRODUCTOR_idProductor,
        DETALLE_TROPA_idDetTropa,
        USUARIOS_idUsuario,
        PESAJE_idPESAJE
)
	VALUES (vFecha, vComprador, vCab, vKgVendidos, vKgCab, vPrecVtaSinIvaKg, vImpVtaSinIvaCab, vAlicuotaIva, vPrecVtaConIvaKg, vImpVtaConIvaCab, vImpTotalVenta, vFlete, vOtrosCostos, vImpNetoVenta, vIdProd, vIdDetTropa, vIdUS, vIdPesaje);
END