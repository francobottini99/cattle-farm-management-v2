CREATE DEFINER=`root`@`localhost` PROCEDURE `consDNI`(
	in usDNI varchar(10)
)
BEGIN
	SELECT
        *
	FROM
		Usuarios
	WHERE
		DNI = usDNI;
END