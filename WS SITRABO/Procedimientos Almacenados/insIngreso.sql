CREATE DEFINER=`root`@`localhost` PROCEDURE `insIngreso`(
	in cFecha date,
	in cCostSinIvaKg double,
    in cCostSinIvaCab double,
    in cAlicuotaIVA double,
    in cCostConIvaKg double,
    in cCostConIvaCab double,
    in cCostConIvaFlete double,
    in cOtrosCostos double,
    in cCostFinalKg double,
    in cCostFinalCab double,
    in cCostTotalTropa double,
    in cFormaPago varchar(250),
    in cIdTropa int(11),
    in cIdProv int(11),
    in cIdProd int(11),
    in cIdUS int(11)
)
BEGIN
	INSERT INTO compras (
		Fecha,
		CostoSinIvaPorKg,
		CostoSinIvaPorCabeza,
        AlicuotaIVA,
        CostoConIvaPorKg,
        CostoConIvaPorCabeza,
        CostoConIvaFlete,
        OtrosCostos,
        CostoFinalPorKg,
        CostoFinalPorCabeza,
        CostoTotalTropa,
        FormaPago,
        TROPA_idTropa,
        PROVEEDOR_idProveedor,
        PRODUCTOR_idProductor,
        USUARIOS_idUsuario
)
	VALUES (cFecha, cCostSinIvaKg, cCostSinIvaCab, cAlicuotaIVA, cCostConIvaKg, cCostConIvaCab, cCostConIvaFlete, cOtrosCostos, cCostFinalKg, cCostFinalCab, cCostTotalTropa, cFormaPago, cIdTropa, cIdProv, cIdProd, cIdUS);
END