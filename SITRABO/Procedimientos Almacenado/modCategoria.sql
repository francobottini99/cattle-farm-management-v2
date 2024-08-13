CREATE DEFINER=`root`@`localhost` PROCEDURE `modCategoria`(
	in IdP int(11),
    in mRac varchar(255),
    in mSexo varchar(45)
)
BEGIN
	UPDATE Categorias
	SET 
		Categoria = mRac,
        Sexo = mSexo
	WHERE 
		idCategorias = IdP;
END