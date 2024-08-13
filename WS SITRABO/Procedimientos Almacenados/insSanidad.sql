CREATE DEFINER=`root`@`localhost` PROCEDURE `insSanidad`(
	in sFec date,
	in sTrat varchar(250),
	in sImp double,
	in sObs varchar(250),
    in sidDT int(11),
    in sIdU int(11)
)
BEGIN
	INSERT INTO Sanidad (
		Fecha,
		Tratamiento,
		Importe,
		Observaciones,
        DETALLE_TROPA_idDetTropa,
        USUARIOS_idUsuario
)
	VALUES (sFec, sTrat, sImp, sObs, sidDT, sIdU);
END