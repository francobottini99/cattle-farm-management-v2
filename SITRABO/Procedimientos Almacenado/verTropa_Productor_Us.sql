CREATE DEFINER=`root`@`localhost` PROCEDURE `verTropa_Productor_Us`(
	in uID int(11),
    in uIDP int(11)
)
BEGIN
	SELECT
		*
	FROM
		Tropa
	WHERE
		USUARIOS_idUsuario = uID AND PRODUCTOR_idProductor = uIDP;
END