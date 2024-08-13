CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimentacionUS`(
	in idUs int(11)
)
BEGIN
	SELECT
		Alimentacion.Fecha,
        Alimentacion.KgRacion,
        Alimentacion.Turno,
        Alimentacion.KgGrano,
        Alimentacion.KgSilo,
        Alimentacion.KgConcentrado,
        Alimentacion.KgFibra,
        Alimentacion.KgOtros,
        Alimentacion.PorcentajeGrano,
        Alimentacion.PorcentajeSilo,
        Alimentacion.PorcentajeConc,
        Alimentacion.PorcentajeFibra,
        Alimentacion.PorcentajeOtros,
        Alimentacion.ImporteGrano,
        Alimentacion.ImporteSilo,
        Alimentacion.ImporteConcentrado,
        Alimentacion.ImporteFibra,
        Alimentacion.ImporteOtros,
        Alimentacion.ImporteTotal,
        Alimentacion.Observaciones,
        Corrales.idCorrales,
		Corrales.NombreCorral,
        Raciones.NombreRacion,
        Raciones.idRaciones,
        Alimentacion.idAlimentacion
	FROM
		Alimentacion JOIN Raciones ON Raciones.idRaciones = Alimentacion.RACIONES_idRaciones
		JOIN Corrales ON Corrales.idCorrales = Alimentacion.CORRALES_idCorrales
	WHERE
		USUARIOS_idUsuario = idUs
	ORDER BY Alimentacion.Fecha Desc;
END