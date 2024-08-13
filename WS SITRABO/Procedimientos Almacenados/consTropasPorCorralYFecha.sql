CREATE DEFINER=`root`@`localhost` PROCEDURE `consTropasPorCorralYFecha`(
	in IdCorr int(11)
)
BEGIN
	SELECT
        Corrales.idCorrales,
        Corrales.NombreCorral,
        Corrales.Superficie,
        Corrales.CabezasTotales,
        Corrales.CAMPO_idCampo,
        Corrales.USUARIOS_idUsuario,
        Tropa.idTropa
	FROM
		Tropa JOIN Campo ON Tropa.CAMPO_idCampo = Campo.idCampo
        JOIN Corrales ON Corrales.CAMPO_idCampo = Campo.idCampo
	WHERE
		Corrales.idCorrales  = IdCorr
	ORDER BY Tropa.NombreTropa Asc;
END