CREATE DEFINER=`root`@`localhost` PROCEDURE `modTropa`(
	in IdT int(11),
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
	UPDATE Tropa
	SET 
		NombreTropa = tNom,
		OrigenProcedencia = tProc,
		FechaIngreso = tFec,
        Cabezas = tCab,
        Muertes = tMu,
        Ventas = tVta,
        Stock = tStkt,
        PesoIngreso = tKgCab,
        TotalKgTropa = tKgt,
        Observaciones = tObsv,
        PRODUCTOR_idProductor = tIdpd,
        CAMPO_idCampo = tIdCam,
        PROVEEDOR_idProveedor = tIdpv,
        USUARIOS_idUsuario = tIdus
	WHERE 
		idTropa = IdT;
END