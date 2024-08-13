Public Class mdlPesaje

    Dim Id, IdDetTr, IdTrp, IdUs As Integer
    Dim Fec As Date
    Dim Tip, Obs, E As String
    Dim Pes, PoDes, Des, PesFin As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdPesaje()
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

    Public Property Tipo()
        Get
            Return Tip
        End Get
        Set(ByVal Valor)
            Tip = Valor
        End Set
    End Property

    Public Property Peso()
        Get
            Return Pes
        End Get
        Set(ByVal Valor)
            Pes = Valor
        End Set
    End Property

    Public Property PorcDesbate()
        Get
            Return PoDes
        End Get
        Set(ByVal Valor)
            PoDes = Valor
        End Set
    End Property

    Public Property Desbaste()
        Get
            Return Des
        End Get
        Set(ByVal Valor)
            Des = Valor
        End Set
    End Property

    Public Property PesoFinal()
        Get
            Return PesFin
        End Get
        Set(ByVal Valor)
            PesFin = Valor
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
    Public Property IdDetTropa()
        Get
            Return IdDetTr
        End Get
        Set(ByVal Valor)
            IdDetTr = Valor
        End Set
    End Property

    Public Property IdTropa()
        Get
            Return IdTrp
        End Get
        Set(ByVal Valor)
            IdTrp = Valor
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

    Public Property Err()
        Get
            Return E
        End Get
        Set(ByVal Valor)
            E = Valor
        End Set
    End Property


    'CONSTRUCTORES
    '---------------------------------------------------------------------------------------------

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal Tip As String, ByVal Pes As Double, ByVal PoDes As Double,
                   ByVal Des As Double, ByVal PesFin As Double, ByVal Obs As String, ByVal IdDetTr As Integer, ByVal Idtrp As Integer,
                   ByVal IdUs As Integer, ByVal E As String)

        IdPesaje = Id
        Fecha = Fec
        Tipo = Tip
        Peso = Pes
        PorcDesbate = PoDes
        Desbaste = Des
        PesoFinal = PesFin
        Observaciones = Obs
        IdDetTropa = IdDetTr
        IdTropa = Idtrp
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
