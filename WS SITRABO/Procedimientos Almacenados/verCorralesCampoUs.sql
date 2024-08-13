CREATE DEFINER=`root`@`localhost` PROCEDURE `verCorralesCampoUs`(
	in idC int(11),
    in uID int(11)    
)
BEGIN
	SELECT
		*
	FROM
		Corrales
	WHERE
		CAMPO_idCampo = idC AND USUARIOS_idUsuario = uID;
END