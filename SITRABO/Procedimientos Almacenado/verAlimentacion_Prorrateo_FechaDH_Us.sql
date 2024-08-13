CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacion_Prorrateo_FechaDH_Us`(
	in aUs integer(11),
    in aFecD date,
    in aFecH date
)
BEGIN 
	SELECT
		*
	FROM
		alimentacion_prorrateo
	WHERE
		USUARIOS_idUsuario = aUs AND Fecha >= aFecD AND Fecha <= aFecH; 
END