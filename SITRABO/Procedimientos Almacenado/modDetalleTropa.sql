CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleTropa`(
	in IdT int(11)
)
BEGIN
	DELETE FROM detalle_tropa WHERE TROPA_idTropa = IdT;
END