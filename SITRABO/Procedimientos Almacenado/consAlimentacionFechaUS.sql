CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimentacionFechaUS`(
	in Fec date,
    in idUs int(11)
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
		Fecha = Fec AND USUARIOS_idUsuario = idUs
	ORDER BY Alimentacion.Fecha, Corrales.NombreCorral Asc;
END