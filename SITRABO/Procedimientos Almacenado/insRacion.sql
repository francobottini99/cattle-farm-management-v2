CREATE DEFINER=`root`@`localhost` PROCEDURE `insRacion`(
	in rNom varchar(250),
	in rGrano varchar(250),
    in rSilo varchar(250),
    in rConcentrado varchar(250),
    in rFibra varchar(250),
    in rOtros varchar(250),
    in rCostGrano double,
    in rCostoSilo double,
    in rCostConcentrado double,
    in rCostFibra double,
    in rCostOtros double,
    in rIDu int(11)
)
BEGIN
	INSERT INTO Raciones (
		NombreRacion,
		Grano,
        Silo,
		Concentrado,
        Fibra,
        Otros,
        CostoGrano,
        CostoSilo,
        CostoConcentrado,
        CostoFibra,
        CostoOtros,
        USUARIOS_idUsuario
)
	VALUES (rNom, rGrano, rSilo, rConcentrado, rFibra, rOtros, rCostGrano, rCostoSilo, rCostConcentrado, rCostFibra, rCostOtros, rIDu);
END