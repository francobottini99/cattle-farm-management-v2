Public Class mdlAlimentacion

    Dim Id, IdCorr, IdRac, IdUs As Integer
    Dim Fec As Date
    Dim Turn, Obs, E As String
    Dim KgRac, KgGr, KgCon, KgFib, KgOtr, ImpGr, ImpCon, ImpFib, ImpOtr, ImpTot, PorGr, PorcCon, PorFib, PorOtr As Double

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdAlim()
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

    Public Property KgRacion()
        Get
            Return KgRac
        End Get
        Set(ByVal Valor)
            KgRac = Valor
        End Set
    End Property

    Public Property Turno()
        Get
            Return Turn
        End Get
        Set(ByVal Valor)
            Turn = Valor
        End Set
    End Property

    Public Property KgGrano()
        Get
            Return KgGr
        End Get
        Set(ByVal Valor)
            KgGr = Valor
        End Set
    End Property

    Public Property KgConc()
        Get
            Return KgCon
        End Get
        Set(ByVal Valor)
            KgCon = Valor
        End Set
    End Property

    Public Property KgFibra()
        Get
            Return KgFib
        End Get
        Set(ByVal Valor)
            KgFib = Valor
        End Set
    End Property

    Public Property KgOtros()
        Get
            Return KgOtr
        End Get
        Set(ByVal Valor)
            KgOtr = Valor
        End Set
    End Property

    Public Property ImpGrano()
        Get
            Return ImpGr
        End Get
        Set(ByVal Valor)
            ImpGr = Valor
        End Set
    End Property

    Public Property ImpConc()
        Get
            Return ImpCon
        End Get
        Set(ByVal Valor)
            ImpCon = Valor
        End Set
    End Property

    Public Property ImpFibra()
        Get
            Return ImpFib
        End Get
        Set(ByVal Valor)
            ImpFib = Valor
        End Set
    End Property

    Public Property ImpOtros()
        Get
            Return ImpOtr
        End Get
        Set(ByVal Valor)
            ImpOtr = Valor
        End Set
    End Property

    Public Property ImpTotal()
        Get
            Return ImpTot
        End Get
        Set(ByVal Valor)
            ImpTot = Valor
        End Set
    End Property

    Public Property PorcGrano()
        Get
            Return PorGr
        End Get
        Set(ByVal Valor)
            PorGr = Valor
        End Set
    End Property

    Public Property PorcConc()
        Get
            Return PorcCon
        End Get
        Set(ByVal Valor)
            PorcCon = Valor
        End Set
    End Property

    Public Property PorcFibra()
        Get
            Return PorFib
        End Get
        Set(ByVal Valor)
            PorFib = Valor
        End Set
    End Property

    Public Property PorcOtros()
        Get
            Return PorOtr
        End Get
        Set(ByVal Valor)
            PorOtr = Valor
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

    Public Property IdCorral()
        Get
            Return IdCorr
        End Get
        Set(ByVal Valor)
            IdCorr = Valor
        End Set
    End Property

    Public Property IdRacion()
        Get
            Return IdRac
        End Get
        Set(ByVal Valor)
            IdRac = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Fec As Date, ByVal KgRac As Double, ByVal Turn As String, ByVal KgGr As Double,
                   ByVal KgCon As Double, ByVal KgFib As Double, ByVal KgOtr As Double, ByVal ImpGr As Double, ByVal ImpCon As Double, ByVal ImpFib As Double,
                   ByVal ImpOtr As Double, ByVal ImpTot As Double, ByVal PorGr As Double, ByVal PorcCon As Double, ByVal PorFib As Double, ByVal PorOtr As Double,
                   ByVal Obs As String, ByVal IdCorr As Integer, ByVal IdRac As Integer, ByVal IdUs As Integer, ByVal E As String)

        IdAlim = Id
        Fecha = Fec
        KgRacion = KgRac
        Turno = Turn
        KgGrano = KgGr
        KgConc = KgCon
        KgFibra = KgFib
        KgOtros = KgOtr
        ImpGrano = ImpGr
        ImpConc = ImpCon
        ImpFibra = ImpFib
        ImpOtros = ImpOtr
        ImpTotal = ImpTot
        PorcGrano = PorGr
        PorcConc = PorcCon
        PorcFibra = PorFib
        PorcOtros = PorOtr
        Observaciones = Obs
        IdCorral = IdCorr
        IdRacion = IdRac
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
