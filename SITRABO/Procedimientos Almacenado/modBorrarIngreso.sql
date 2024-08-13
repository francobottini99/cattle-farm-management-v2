CREATE DEFINER=`root`@`localhost` PROCEDURE `modBorrarIngreso`(
	in IdT int(11)
)
BEGIN
	DELETE FROM compras WHERE TROPA_idTropa = IdT;
END