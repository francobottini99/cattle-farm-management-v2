Public Class mdlCategorias

    Dim Id, IdUs As Integer
    Dim Cat As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdCategoria()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Categoria()
        Get
            Return Cat
        End Get
        Set(ByVal Valor)
            Cat = Valor
        End Set
    End Property

    Public Property IdUsuario()
        Get
            Return IdUs
        End Get
        Set(ByVal Valor)
            IdUs = Valor
        End Set
    End Property

    'CONSTRUCTORES
    '---------------------------------------------------------------------------------------------

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Cat As String, ByVal IdUs As Integer)

        IdCategoria = Id
        Categoria = Cat
        IdUsuario = IdUs
    End Sub

End Class
