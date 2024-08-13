CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedorUs`(
	in pUs int(11)
)
BEGIN
	SELECT
		*
	FROM
		Proveedor
	WHERE
        USUARIOS_idUsuario = pUs;
END