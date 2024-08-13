CREATE DEFINER=`root`@`localhost` PROCEDURE `verCategoria`(
)
BEGIN
	SELECT
		*
	FROM
		Categorias;
END