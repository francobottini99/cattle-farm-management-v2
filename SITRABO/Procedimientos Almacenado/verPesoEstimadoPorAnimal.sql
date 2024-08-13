CREATE DEFINER=`root`@`localhost` PROCEDURE `verPesoEstimadoPorAnimal`(
	in Pes int(11)
)
BEGIN
	SELECT
		*
	FROM
		pesos_estimados
	WHERE
		KGPV = Pes;
END