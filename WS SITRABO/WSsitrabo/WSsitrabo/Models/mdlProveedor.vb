Public Class mdlProveedor

    Dim Id, IdUs As Integer
    Dim RazSoc, Dir, Loc, Prov, CP, Cu, TE, Mail, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdProvedor()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property RazonSocial()
        Get
            Return RazSoc
        End Get
        Set(ByVal Valor)
            RazSoc = Valor
        End Set
    End Property

    Public Property Direccion()
        Get
            Return Dir
        End Get
        Set(ByVal Valor)
            Dir = Valor
        End Set
    End Property

    Public Property Localidad()
        Get
            Return Loc
        End Get
        Set(ByVal Valor)
            Loc = Valor
        End Set
    End Property

    Public Property Provincia()
        Get
            Return Prov
        End Get
        Set(ByVal Valor)
            Prov = Valor
        End Set
    End Property

    Public Property CodPostal()
        Get
            Return CP
        End Get
        Set(ByVal Valor)
            CP = Valor
        End Set
    End Property

    Public Property CUIT()
        Get
            Return Cu
        End Get
        Set(ByVal Valor)
            Cu = Valor
        End Set
    End Property

    Public Property Telefono()
        Get
            Return TE
        End Get
        Set(ByVal Valor)
            TE = Valor
        End Set
    End Property

    Public Property eMail()
        Get
            Return Mail
        End Get
        Set(ByVal Valor)
            Mail = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal RazSoc As String, ByVal Dir As String, ByVal Loc As String, ByVal Prov As String,
                   ByVal CP As String, ByVal Cu As String, ByVal TE As String, ByVal Mail As String, IdUs As Integer, ByVal E As String)

        IdProvedor = Id
        RazonSocial = RazSoc
        Direccion = Dir
        Localidad = Loc
        Provincia = Prov
        CodPostal = CP
        CUIT = Cu
        Telefono = TE
        eMail = Mail
        IdUsuario = IdUs
        Err = E
    End Sub

End Class
