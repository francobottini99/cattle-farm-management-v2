CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacion_Fecha`(
    in aFec date
)
BEGIN 
	SELECT
		*
	FROM
		Alimentacion 
	WHERE
		Fecha = aFec; 
END