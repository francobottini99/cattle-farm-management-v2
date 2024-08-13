CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleTropa`(
	in dtCarv varchar(255),
	in dtDescp varchar(255),
	in dtEstado varchar(45),
	in dtIDTropa int(11),
    in dtIDCatg int(11),
    in dtIDCorrales int(11),
    in dtIDus int(11),
    in dtRF varchar (100)
)
BEGIN
	INSERT INTO Detalle_Tropa (
		Caravana,
		Descripcion,
		Estado,
		TROPA_idTropa,
        CATEGORIAS_idCategorias,
        CORRALES_idCorrales,
        USUARIOS_idUsuario,
        CaravanaRFID
)
	VALUES (dtCarv, dtDescp, dtEstado, dtIDTropa, dtIDCatg, dtIDCorrales, dtIDus, dtRF);
END