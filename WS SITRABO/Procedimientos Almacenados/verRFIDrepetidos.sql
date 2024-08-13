CREATE DEFINER=`root`@`localhost` PROCEDURE `verRFIDrepetidos`(
	in Rfid varchar(250)
)
BEGIN
	SELECT
		*
	FROM
		detalle_tropa
	WHERE
		CaravanaRFID = Rfid;
END