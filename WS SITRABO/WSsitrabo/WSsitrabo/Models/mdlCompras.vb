Public Class mdlCompras

    Dim Id, IdTr, IdPv, IdPr, IdUs As Integer
    Dim Fec As Date
    Dim FormP As String
    Dim CoSIKg, CoSICab, AlIva, CoCIKg, CoCICab, CoCIFl, OtrCo, CoFKg, CoFCab, CoFTr As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdCompras()
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

    Public Property CostoSinIvaKg()
        Get
            Return CoSIKg
        End Get
        Set(ByVal Valor)
            CoSIKg = Valor
        End Set
    End Property

    Public Property CostoSinIvaCabeza()
        Get
            Return CoSICab
        End Get
        Set(ByVal Valor)
            CoSICab = Valor
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

    Public Property CostoConIvaKg()
        Get
            Return CoCIKg
        End Get
        Set(ByVal Valor)
            CoCIKg = Valor
        End Set
    End Property

    Public Property CostoConIvaCabeza()
        Get
            Return CoCICab
        End Get
        Set(ByVal Valor)
            CoCICab = Valor
        End Set
    End Property

    Public Property CostoConIvaFlete()
        Get
            Return CoCIFl
        End Get
        Set(ByVal Valor)
            CoCIFl = Valor
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

    Public Property CostoFinalKg()
        Get
            Return CoFKg
        End Get
        Set(ByVal Valor)
            CoFKg = Valor
        End Set
    End Property

    Public Property CostoFinalCabeza()
        Get
            Return CoFCab
        End Get
        Set(ByVal Valor)
            CoFCab = Valor
        End Set
    End Property

    Public Property CostoTotalTropa()
        Get
            Return CoFTr
        End Get
        Set(ByVal Valor)
            CoFTr = Valor
        End Set
    End Property

    Public Property FormaPago()
        Get
            Return FormP
        End Get
        Set(ByVal Valor)
            FormP = Valor
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

    Public Property IdProveedor()
        Get
            Return IdPv
        End Get
        Set(ByVal Valor)
            IdPv = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal CoSIKg As Double, ByVal CoSICab As Double, ByVal AlIva As Double,
                   ByVal CoCIKg As Double, ByVal CoCICab As Double, ByVal CoCIFl As Double, ByVal OtrCo As Double, ByVal CoFKg As Double, ByVal CoFCab As Double,
                   ByVal CoFTr As Double, ByVal FormP As String, ByVal IdTr As Integer, ByVal IdPv As Integer, ByVal IdPr As Integer, ByVal IdUs As Integer)

        IdCompras = Id
        Fecha = Fec
        CostoSinIvaKg = CoSIKg
        CostoSinIvaCabeza = CoSICab
        AlicuotaIVA = AlIva
        CostoConIvaKg = CoCIKg
        CostoConIvaCabeza = CoCICab
        CostoConIvaFlete = CoCIFl
        OtrosCostos = OtrCo
        CostoFinalKg = CoFKg
        CostoFinalCabeza = CoFCab
        CostoTotalTropa = CoFTr
        FormaPago = FormP
        IdTropa = IdTr
        IdProveedor = IdPv
        IdProductor = IdPr
        IdUsuario = IdUs
    End Sub

End Class
