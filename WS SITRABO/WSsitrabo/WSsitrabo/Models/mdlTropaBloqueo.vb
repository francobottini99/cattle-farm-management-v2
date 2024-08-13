Public Class mdlTropaBloqueo

    Dim Id, IdTr As Integer
    Dim Hab As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdBloqueo()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property HabilitaMov()
        Get
            Return Hab
        End Get
        Set(ByVal Valor)
            Hab = Valor
        End Set
    End Property

    Public Property IdTropa()
        Get
            Return IdTr
        End Get
        Set(ByVal Valor)
            IdTr = Valor
        End Set
    End Property

    'CONSTRUCTORES
    '---------------------------------------------------------------------------------------------

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Hab As String, ByVal IdTr As Integer)

        IdBloqueo = Id
        HabilitaMov = Hab
        IdTropa = IdTr
    End Sub

End Class
