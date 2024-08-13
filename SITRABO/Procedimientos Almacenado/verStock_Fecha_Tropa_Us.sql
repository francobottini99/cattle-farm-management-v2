CREATE DEFINER=`root`@`localhost` PROCEDURE `verStock_Fecha_Tropa_Us`(
	in sFec date,
    in sIdT int(11),
	in sUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Stock
	WHERE
        Fecha = sFec And USUARIOS_idUsuario = sUs And TROPA_idTropa = sIdT;
END