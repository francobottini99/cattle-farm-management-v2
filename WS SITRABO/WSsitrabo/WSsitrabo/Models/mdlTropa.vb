Public Class mdlTropa

    Dim Id, Cab, Muer, Vtas, Stk, IdPr, IdCam, IdPv, IdUs As Integer
    Dim Pes, KgTr As Double
    Dim Fec As Date
    Dim Nom, Orig, Obs, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdTropa()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property NombreTropa()
        Get
            Return Nom
        End Get
        Set(ByVal Valor)
            Nom = Valor
        End Set
    End Property

    Public Property Origen()
        Get
            Return Orig
        End Get
        Set(ByVal Valor)
            Orig = Valor
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

    Public Property Cabezas()
        Get
            Return Cab
        End Get
        Set(ByVal Valor)
            Cab = Valor
        End Set
    End Property

    Public Property Muertes()
        Get
            Return Muer
        End Get
        Set(ByVal Valor)
            Muer = Valor
        End Set
    End Property

    Public Property Ventas()
        Get
            Return Vtas
        End Get
        Set(ByVal Valor)
            Vtas = Valor
        End Set
    End Property

    Public Property Stock()
        Get
            Return Stk
        End Get
        Set(ByVal Valor)
            Stk = Valor
        End Set
    End Property

    Public Property PesoIngreso()
        Get
            Return Pes
        End Get
        Set(ByVal Valor)
            Pes = Valor
        End Set
    End Property

    Public Property KgTropa()
        Get
            Return KgTr
        End Get
        Set(ByVal Valor)
            KgTr = Valor
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

    Public Property IdProductor()
        Get
            Return IdPr
        End Get
        Set(ByVal Valor)
            IdPr = Valor
        End Set
    End Property

    Public Property idCampo()
        Get
            Return IdCam
        End Get
        Set(ByVal Valor)
            IdCam = Valor
        End Set
    End Property

    Public Property IdProveedor()
        Get
            Return IdPv
        End Get
        Set(ByVal Valor)
            IdPv = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Nom As String, ByVal Orig As String, ByVal Fec As Date, ByVal Cab As Integer, ByVal Muer As Integer, ByVal Vtas As Integer,
                   ByVal Stk As Integer, ByVal Pes As Double, ByVal KgTr As Double, ByVal Obs As String, ByVal IdPr As Integer, ByVal IdCam As Integer,
                   ByVal IdPv As Integer, ByVal IdUs As Integer, ByVal E As String)

        IdTropa = Id
        NombreTropa = Nom
        Origen = Orig
        Fecha = Fec
        Cabezas = Cab
        Muertes = Muer
        Ventas = Vtas
        Stock = Stk
        PesoIngreso = Pes
        KgTropa = KgTr
        Observaciones = Obs
        IdProductor = IdPr
        idCampo = IdCam
        IdProveedor = IdPv
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
