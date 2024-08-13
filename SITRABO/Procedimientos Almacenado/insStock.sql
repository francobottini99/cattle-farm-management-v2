CREATE DEFINER=`root`@`localhost` PROCEDURE `insStock`(
	in stkFec date,
    in sktCaravana varchar(255),
    in sktDescripcion varchar(255),
	in stkCabezas int(11),
	in stkIDt int(11),
    in sktIDdt int(11),
    in sktIDcrr int(11),
    in sktIDcatg int(11),
    in sktIDus int(11)
)
BEGIN
	INSERT INTO Stock (
		Fecha,
		Caravana,
        Descripcion,
		Cabezas,
        TROPA_idTropa,
        DETALLE_TROPA_idDetTropa,
        CORRALES_idCorrales,
        CATEGORIAS_idCategorias,
		USUARIOS_idUsuario        
)
	VALUES (stkFec, sktCaravana, sktDescripcion, stkCabezas, stkIDt, sktIDdt, sktIDcrr, sktIDcatg, sktIDus);
END