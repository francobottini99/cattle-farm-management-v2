Public Class mdlDetalleTropa

    Dim Id, IdTrp, IdCat, IdCorr, IdUs As Integer
    Dim Carav, Desc, Est, RFID, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdDetalleTropa()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Caravana()
        Get
            Return Carav
        End Get
        Set(ByVal Valor)
            Carav = Valor
        End Set
    End Property

    Public Property Descripcion()
        Get
            Return Desc
        End Get
        Set(ByVal Valor)
            Desc = Valor
        End Set
    End Property

    Public Property Estado()
        Get
            Return Est
        End Get
        Set(ByVal Valor)
            Est = Valor
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

    Public Property IdCategoria()
        Get
            Return IdCat
        End Get
        Set(ByVal Valor)
            IdCat = Valor
        End Set
    End Property

    Public Property IdCorrales()
        Get
            Return IdCorr
        End Get
        Set(ByVal Valor)
            IdCorr = Valor
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

    Public Property CaravanaRFID()
        Get
            Return RFID
        End Get
        Set(ByVal Valor)
            RFID = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Carav As String, ByVal Desc As String, ByVal Est As String, ByVal IdTrp As Integer,
                   ByVal IdCat As Integer, ByVal IdCorr As Integer, ByVal IdUs As Integer, ByVal RFID As String, ByVal E As String)

        IdDetalleTropa = Id
        Caravana = Carav
        Descripcion = Desc
        Estado = Est
        IdTropa = IdTrp
        IdCategoria = IdCat
        IdCorrales = IdCorr
        IdUsuario = IdUs
        CaravanaRFID = RFID
        Err = E
    End Sub

End Class
