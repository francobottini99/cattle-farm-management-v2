CREATE DEFINER=`root`@`localhost` PROCEDURE `modBorrarEgreso`(
	in IdDT int(11)
)
BEGIN
	DELETE FROM ventas WHERE DETALLE_TROPA_idDetTropa = IdDT;
END