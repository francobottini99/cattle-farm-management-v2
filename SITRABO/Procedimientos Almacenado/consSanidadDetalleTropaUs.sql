CREATE DEFINER=`root`@`localhost` PROCEDURE `consSanidadDetalleTropaUs`(
	in sUs int(11)
)
BEGIN
	SELECT
		Sanidad.idSanidad,
        Sanidad.Fecha,
        Sanidad.Tratamiento,
        Sanidad.Importe,
        Sanidad.Observaciones,
        Detalle_Tropa.idDetTropa,
        Detalle_Tropa.Caravana,
        Detalle_Tropa.Descripcion,
        Detalle_Tropa.Estado,
        Tropa.idTropa,
        Tropa.NombreTropa
	FROM
		Sanidad JOIN Detalle_Tropa ON Sanidad.DETALLE_TROPA_idDetTropa = Detalle_Tropa.idDetTropa
        JOIN Tropa ON Detalle_Tropa.TROPA_idTropa = Tropa.idTropa
	WHERE
        USUARIOS_idUsuario = sUs;
END