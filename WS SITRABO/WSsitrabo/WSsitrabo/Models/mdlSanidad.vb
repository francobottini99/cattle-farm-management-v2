Public Class mdlSanidad

    Dim Id, IdDetTr, IdUs As Integer
    Dim Fec As Date
    Dim Trat, Obs As String
    Dim Imp As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdSanidad()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Fecha()
        Get
            Return Fec
        End Get
        Set(ByVal Valor)
            Fec = Valor
        End Set
    End Property

    Public Property Tratamiento()
        Get
            Return Trat
        End Get
        Set(ByVal Valor)
            Trat = Valor
        End Set
    End Property

    Public Property Importe()
        Get
            Return Imp
        End Get
        Set(ByVal Valor)
            Imp = Valor
        End Set
    End Property

    Public Property Observaciones()
        Get
            Return Obs
        End Get
        Set(ByVal Valor)
            Obs = Valor
        End Set
    End Property

    Public Property IdDetalleTropa()
        Get
            Return IdDetTr
        End Get
        Set(ByVal Valor)
            IdDetTr = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal Trat As String, ByVal Imp As Double, ByVal Obs As Double,
                   ByVal IdDetTr As Integer, ByVal IdUs As Integer)

        IdSanidad = Id
        Fecha = Fec
        Tratamiento = Trat
        Importe = Imp
        Observaciones = Obs
        IdDetalleTropa = IdDetTr
        IdUsuario = IdUs
    End Sub

End Class
