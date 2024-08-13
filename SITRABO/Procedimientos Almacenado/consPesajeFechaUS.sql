CREATE DEFINER=`root`@`localhost` PROCEDURE `consPesajeFechaUS`(
	in idUS int(11),
    in Fec date
)
BEGIN
	SELECT
		pesaje.idPESAJE,
        tropa.idTropa,
        detalle_tropa.idDetTropa,
        pesaje.Fecha,
        tropa.NombreTropa,
        detalle_tropa.Caravana,
        detalle_tropa.Descripcion,
        pesaje.Tipo,
        categorias.Categoria,
        pesaje.Peso,
		pesaje.PorcDesbaste,
        pesaje.Desbaste,
        pesaje.PesoFinal,
        pesaje.Observaciones,
        detalle_tropa.Estado
	FROM
		pesaje JOIN detalle_tropa ON pesaje.DETALLE_TROPA_idDetTropa = detalle_tropa.idDetTropa
        JOIN tropa ON pesaje.TROPA_idTropa = tropa.idTropa
        JOIN categorias ON detalle_tropa.CATEGORIAS_idCategorias = categorias.idCategorias
	WHERE
        detalle_tropa.Estado = "Engorde" AND detalle_tropa.USUARIOS_idUsuario = idUS AND pesaje.Fecha = Fec; 
END