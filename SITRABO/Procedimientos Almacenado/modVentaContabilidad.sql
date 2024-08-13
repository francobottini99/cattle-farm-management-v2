CREATE DEFINER=`root`@`localhost` PROCEDURE `modVentaContabilidad`(
	in IdV int(11),
	in vCom varchar(255),
	in vKgTotales double,
    in vKgCabeza double,
	in vImpSinIVAKG double,
	in vImpSinIVACab double,
    in vIVA double,
    in vImpConIVAKG double,
    in vImpConIVACab double,
    in vImpTotal double,
    in vFlete double,
    in vOtros double,
    in vImpNETO double
)
BEGIN
	UPDATE Ventas
	SET 
        Comprador = vCom,
		KgVendidos = vKgTotales,
        KgPorCabeza = vKgCabeza,
		PrecioVtaSinIvaPorKg = vImpSinIVAKG,
		ImporteVtaSinIvaPorCabeza = vImpSinIVACab,
        AlicuotaIva = vIVA,
        PrecioVtaConIvaPorKg = vImpConIVAKG,
        ImporteVtaConIvaPorCabeza = vImpConIVACab,
        ImporteTotalVenta = vImpTotal,
        Flete = vFlete,
        OtrosCostos = vOtros,
        ImporteNetoVenta = vImpNETO
	WHERE 
		idVentas = IdV;
END