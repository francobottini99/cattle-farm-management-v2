CREATE DEFINER=`root`@`localhost` PROCEDURE `verStkCorralFec`(
	in dtUs integer(11),
    in idCrr integer(11),
    in Fec date	
)
BEGIN
	SELECT
		*
	FROM
		stock
	WHERE
		USUARIOS_idUsuario = dtUs AND CORRALES_idCorrales = idCrr AND Fecha = Fec;
END