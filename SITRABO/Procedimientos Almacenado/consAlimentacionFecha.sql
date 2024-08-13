CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimentacionFecha`(
	in Fec date
)
BEGIN
	SELECT
		Alimentacion.Fecha,
        Alimentacion.KgRacion,
        Alimentacion.Turno,
        Alimentacion.KgGrano,
        Alimentacion.KgConcentrado,
        Alimentacion.KgFibra,
        Alimentacion.KgOtros,
        Alimentacion.PorcentajeGrano,
        Alimentacion.PorcentajeConc,
        Alimentacion.PorcentajeFibra,
        Alimentacion.PorcentajeOtros,
        Alimentacion.ImporteGrano,
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
		Fecha = Fec
	ORDER BY Alimentacion.Fecha, Corrales.NombreCorral Asc;
END