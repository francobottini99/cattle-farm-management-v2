CREATE DEFINER=`root`@`localhost` PROCEDURE `insTropa`(
	in tNom varchar(250),
	in tProc varchar(250),
    in tFec date,
    in tCab int(11),
    in tMu int(11),
    in tVta int(11),
    in tStkt int(11),
    in tKgCab double,
    in tKgt int(11),
    in tObsv varchar(255),
    in tIdpd int(11),
    in tIdCam int(11),
    in tIdpv int(11),
    in tIdus int(11)
)
BEGIN
	INSERT INTO Tropa (
		NombreTropa,
		OrigenProcedencia,
		FechaIngreso,
        Cabezas,
        Muertes,
        Ventas,
        Stock,
        PesoIngreso,
        TotalKgTropa,
        Observaciones,
        PRODUCTOR_idProductor,
        CAMPO_idCampo,
        PROVEEDOR_idProveedor,
        USUARIOS_idUsuario
)
	VALUES (tNom, tProc, tFec, tCab, tMu, tVta, tStkt, tKgCab, tKgt, tObsv, tIdpd, tIdCam, tIdpv, tIdus);
END