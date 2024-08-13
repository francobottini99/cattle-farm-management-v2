CREATE DEFINER=`root`@`localhost` PROCEDURE `verStocDiariokUs`(
	in sMod varchar(100),
    in sCorr int(11),
	in sUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Detalle_Tropa
	WHERE
        Estado = sMod And CORRALES_idCorrales = sCorr And USUARIOS_idUsuario = sUs;
END