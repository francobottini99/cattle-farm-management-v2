Public Class mdlCorrales
    Dim Id, Cab, idCam, IdUs As Integer
    Dim Sup As Double
    Dim Nomb, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdCorral()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Nombre()
        Get
            Return Nomb
        End Get
        Set(ByVal Valor)
            Nomb = Valor
        End Set
    End Property

    Public Property Superficie()
        Get
            Return Sup
        End Get
        Set(ByVal Valor)
            Sup = Valor
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

    Public Property IdCampo()
        Get
            Return idCam
        End Get
        Set(ByVal Valor)
            idCam = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Nomb As String, ByVal Sup As Double, ByVal Cab As Integer, ByVal IdCam As Integer,
                   ByVal IdUs As Integer, ByVal E As String)

        IdCorral = Id
        Nombre = Nomb
        Superficie = Sup
        Cabezas = Cab
        IdCampo = IdCam
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
