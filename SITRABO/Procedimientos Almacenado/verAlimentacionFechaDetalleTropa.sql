CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlimentacionFechaDetalleTropa`(
	in Fec date,
    in idDT int(11)
)
BEGIN
	SELECT
		*
	FROM
		Alimentacion_Prorrateo
	WHERE
		Fecha = Fec AND DETALLE_TROPA_idDetTropa = idDT;
END