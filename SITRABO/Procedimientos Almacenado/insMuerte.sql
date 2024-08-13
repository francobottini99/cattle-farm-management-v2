CREATE DEFINER=`root`@`localhost` PROCEDURE `insMuerte`(
	in mFecha date,
    in mIdDT int(11),
    in mIdUS int(11)
    )
BEGIN
	INSERT INTO Muertes (
		Fecha,
        DETALLE_TROPA_idDetTropa,
        USUARIOS_idUsuario
)
	VALUES (mFecha, mIdDT, mIdUS);
END