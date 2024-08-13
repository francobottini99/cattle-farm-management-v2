CREATE DEFINER=`root`@`localhost` PROCEDURE `modStock`(
	in sFecha date,
	in sIngreso int(11),
	in sEgreso int(11),
    in sStock int(11),
	in sIDTropa int(11)
)
BEGIN
	INSERT INTO Stock (
		Fecha,
		Ingresos,
		Egresos,
        Stock,
		TROPA_idTropa
)
	VALUES (sFecha, sIngreso, sEgreso, sStock, sIDTropa);
END