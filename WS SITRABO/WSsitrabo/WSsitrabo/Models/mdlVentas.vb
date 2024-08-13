Public Class mdlVentas

    Dim Id, Cab, IdPr, IdDetTr, IdUs, IdPes As Integer
    Dim Fec As Date
    Dim Comp As String
    Dim KgVta, KgCab, PrVSIKg, ImVSICab, AlIva, PrVCIKg, ImVCICab, ImTV, Fle, OtrCo, ImNV As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdVentas()
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

    Public Property Comprador()
        Get
            Return Comp
        End Get
        Set(ByVal Valor)
            Comp = Valor
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

    Public Property KgVendidos()
        Get
            Return KgVta
        End Get
        Set(ByVal Valor)
            KgVta = Valor
        End Set
    End Property

    Public Property KgPorCabeza()
        Get
            Return KgCab
        End Get
        Set(ByVal Valor)
            KgCab = Valor
        End Set
    End Property

    Public Property PrecioVtaSinIvaPorKg()
        Get
            Return PrVSIKg
        End Get
        Set(ByVal Valor)
            PrVSIKg = Valor
        End Set
    End Property

    Public Property ImporteVtaSinIvaPorCabeza()
        Get
            Return ImVSICab
        End Get
        Set(ByVal Valor)
            ImVSICab = Valor
        End Set
    End Property

    Public Property AlicuotaIVA()
        Get
            Return AlIva
        End Get
        Set(ByVal Valor)
            AlIva = Valor
        End Set
    End Property

    Public Property PrecioVtaConIvaPorKg()
        Get
            Return PrVCIKg
        End Get
        Set(ByVal Valor)
            PrVCIKg = Valor
        End Set
    End Property

    Public Property ImorteVtaConIvaPorCabeza()
        Get
            Return ImVCICab
        End Get
        Set(ByVal Valor)
            ImVCICab = Valor
        End Set
    End Property

    Public Property ImporteTotalVta()
        Get
            Return ImTV
        End Get
        Set(ByVal Valor)
            ImTV = Valor
        End Set
    End Property

    Public Property Flete()
        Get
            Return Fle
        End Get
        Set(ByVal Valor)
            Fle = Valor
        End Set
    End Property

    Public Property OtrosCostos()
        Get
            Return OtrCo
        End Get
        Set(ByVal Valor)
            OtrCo = Valor
        End Set
    End Property

    Public Property ImporteNetoVta()
        Get
            Return ImNV
        End Get
        Set(ByVal Valor)
            ImNV = Valor
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

    Public Property IdPesaje()
        Get
            Return IdPes
        End Get
        Set(ByVal Valor)
            IdPes = Valor
        End Set
    End Property


    'CONSTRUCTORES
    '---------------------------------------------------------------------------------------------

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal Comp As String, ByVal Cab As Double, ByVal KgVta As Double,
                   ByVal KgCab As Double, ByVal PrVSIKg As Double, ByVal ImVSICab As Double, ByVal AlIva As Double, ByVal PrVCIKg As Double, ByVal ImVCICab As Double,
                   ByVal ImTV As Double, ByVal Fle As Double, ByVal OtrCo As Double, ByVal ImNV As Double, ByVal IdPr As Integer,
                   ByVal IdDetTr As Integer, ByVal IdUs As Integer, ByVal IdPes As Integer)

        IdVentas = Id
        Fecha = Fec
        Comprador = Comp
        Cabezas = Cab
        KgVendidos = KgVta
        KgPorCabeza = KgCab
        PrecioVtaSinIvaPorKg = PrVSIKg
        ImporteVtaSinIvaPorCabeza = ImVSICab
        AlicuotaIVA = AlIva
        PrecioVtaConIvaPorKg = PrVCIKg
        ImorteVtaConIvaPorCabeza = ImVCICab
        ImporteTotalVta = ImTV
        Flete = Fle
        OtrosCostos = OtrCo
        ImporteNetoVta = ImNV
        IdProductor = IdPr
        IdDetalleTropa = IdDetTr
        IdUsuario = IdUs
        IdPesaje = IdPes
    End Sub




End Class
