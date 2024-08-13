CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdTropa`()
BEGIN
	SELECT
		Max(idTropa) as UltimoId
	FROM
		Tropa;
END