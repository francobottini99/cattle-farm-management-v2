CREATE DEFINER=`root`@`localhost` PROCEDURE `verProveedor`(
)
BEGIN
	SELECT
		*
	FROM
		Proveedor;
END