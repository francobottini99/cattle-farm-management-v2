CREATE DEFINER=`root`@`localhost` PROCEDURE `modBorrarAlimentacion`(
	in IdAlim int(11)
)
BEGIN
	DELETE FROM Alimentacion_prorrateo WHERE ALIMENTACION_idAlimentacion = IdAlim;	
END