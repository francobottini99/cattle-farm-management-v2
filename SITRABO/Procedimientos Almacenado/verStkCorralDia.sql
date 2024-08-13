CREATE DEFINER=`root`@`localhost` PROCEDURE `verStkCorralDia`(
	in Fec date,
    in Trp integer(11)
)
BEGIN
	SELECT
		*
	FROM
		Stk_Corral_Dia
	WHERE
		Fecha = Fec AND TROPA_idTropa = Trp;
END