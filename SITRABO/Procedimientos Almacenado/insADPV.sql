CREATE DEFINER=`root`@`localhost` PROCEDURE `insADPV`(
	in Peso double,
    in GPV double
    )
BEGIN
	INSERT INTO adpv (
		Peso,
        GPV
)
	VALUES (Peso, GPV);
END