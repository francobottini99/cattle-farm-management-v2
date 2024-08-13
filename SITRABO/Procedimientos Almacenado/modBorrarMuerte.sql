CREATE DEFINER=`root`@`localhost` PROCEDURE `modBorrarMuerte`(
	in IdDT int(11)
)
BEGIN
	DELETE FROM muertes WHERE DETALLE_TROPA_idDetTropa = IdDT;
END