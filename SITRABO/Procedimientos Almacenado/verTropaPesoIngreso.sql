CREATE DEFINER=`root`@`localhost` PROCEDURE `verTropaPesoIngreso`(
    in idT integer(11)
)
BEGIN 
	SELECT
		*
	FROM
		tropa
	WHERE
		idTropa = idT; 
END