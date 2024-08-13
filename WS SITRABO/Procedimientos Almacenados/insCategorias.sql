CREATE DEFINER=`root`@`localhost` PROCEDURE `insCategorias`(
	in cCategoria varchar(250),
    in cIDu int(11)
    )
BEGIN
	INSERT INTO Categorias (
		Categoria,
        USUARIOS_idUsuario
)
	VALUES (cCategoria, cIDu);
END