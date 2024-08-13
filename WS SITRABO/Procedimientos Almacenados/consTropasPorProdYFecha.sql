CREATE DEFINER=`root`@`localhost` PROCEDURE `consTropasPorProdYFecha`(
	in IdP int(11)
)
BEGIN
	SELECT
        Productor.idProductor,
        Productor.RazonSocial,
        Tropa.idTropa,
        Tropa.NombreTropa,
        Tropa.OrigenProcedencia,
        Tropa.FechaIngreso,
        Tropa.Cabezas,
        Tropa.Muertes,
        Tropa.Ventas,
        Tropa.Stock,
        Tropa.PesoIngreso,
        Tropa.TotalKgTropa,
        Tropa.Observaciones,
        Tropa.PRODUCTOR_idProductor,
        Tropa.CAMPO_idCampo,
        Tropa.PROVEEDOR_idProveedor,
        Tropa.USUARIOS_idUsuario
	FROM
		Tropa JOIN Productor ON Tropa.PRODUCTOR_idProductor = Productor.idProductor 
	WHERE
		Productor.idProductor  = IdP
	ORDER BY Tropa.NombreTropa Asc;
END