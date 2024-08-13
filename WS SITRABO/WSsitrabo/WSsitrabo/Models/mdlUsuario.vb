Public Class mdlUsuario

    Dim Id As Integer
    Dim Fec, FecUing As Date
    Dim Apell, Nom, DNI, Cont, Cat, E As String

    'PROPIEDADES
    '---------------------------------------------------------------------------------------------

    Public Property IdUsuario()
        Get
            Return Id
        End Get
        Set(ByVal Valor)
            Id = Valor
        End Set
    End Property

    Public Property Apellido()
        Get
            Return Apell
        End Get
        Set(ByVal Valor)
            Apell = Valor
        End Set
    End Property

    Public Property Nombre()
        Get
            Return Nom
        End Get
        Set(ByVal Valor)
            Nom = Valor
        End Set
    End Property

    Public Property DNIus()
        Get
            Return DNI
        End Get
        Set(ByVal Valor)
            DNI = Valor
        End Set
    End Property

    Public Property Contraseña()
        Get
            Return Cont
        End Get
        Set(ByVal Valor)
            Cont = Valor
        End Set
    End Property

    Public Property CategoriaUs()
        Get
            Return Cat
        End Get
        Set(ByVal Valor)
            Cat = Valor
        End Set
    End Property

    Public Property FechaReg()
        Get
            Return Fec
        End Get
        Set(ByVal Valor)
            Fec = Valor
        End Set
    End Property

    Public Property FechaUltimoIng()
        Get
            Return FecUing
        End Get
        Set(ByVal Valor)
            FecUing = Valor
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

    Public Sub New(ByVal Id As Integer, ByVal Apell As String, ByVal Nom As String, ByVal DNI As String, ByVal Cont As String, ByVal Cat As String, ByVal Fec As Date,
                   ByVal FecUing As Date, ByVal E As String)

        IdUsuario = Id
        Apellido = Apell
        Nombre = Nom
        DNIus = DNI
        Contraseña = Cont
        CategoriaUs = Cat
        FechaReg = Fec
        FechaUltimoIng = FecUing
        Err = E
    End Sub

End Class
