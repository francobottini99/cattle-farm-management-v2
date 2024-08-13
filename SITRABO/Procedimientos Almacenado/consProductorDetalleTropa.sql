CREATE DEFINER=`root`@`localhost` PROCEDURE `consProductorDetalleTropa`(
	in idDT int(11)
)
BEGIN
	SELECT
		tropa.PRODUCTOR_idProductor
	FROM
		detalle_tropa JOIN tropa ON detalle_tropa.TROPA_idTropa = tropa.idTropa
	WHERE
        idDetTropa = idDT;
END