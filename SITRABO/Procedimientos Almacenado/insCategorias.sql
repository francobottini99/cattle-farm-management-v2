CREATE DEFINER=`root`@`localhost` PROCEDURE `insCategorias`(
	in cCategoria varchar(250),
    in cSexo varchar(45),
    in cIDu int(11)
    )
BEGIN
	INSERT INTO Categorias (
		Categoria,
        Sexo,
        USUARIOS_idUsuario
)
	VALUES (cCategoria, cSexo, cIDu);
END