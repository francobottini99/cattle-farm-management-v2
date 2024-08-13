CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacion_Fecha_Us`(
	in aUs integer(11),
    in aFec date
)
BEGIN 
	SELECT
		*
	FROM
		Alimentacion 
	WHERE
		USUARIOS_idUsuario = aUs AND Fecha = aFec; 
END