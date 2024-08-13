Imports MySql.Data.MySqlClient

Module consDNI


    Public Function Ver(ByVal DNI As String) As String
        Dim Cmd As New MySqlCommand
        Dim Sdr As MySqlDataReader
        Dim Resp As String = ""

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.consDNI")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@usDNI", DNI)

                Conn.Open()
                Sdr = Cmd.ExecuteReader
                If Sdr.Read() = Nothing Then
                    Resp = "Usuario Nuevo"
                Else
                    Resp = "Usuario Existente"
                End If
                Sdr.Close()
            End Using

            Return Resp
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function













    'Public Function Ingresar(ByVal DNI As String, ByVal Contraseña As String) As ArrayList
    '    Dim _Dt As New DataTable
    '    Dim _Ver As New Mostrar
    '    Dim G As New GrabaDatos
    '    Dim Respuesta As New ArrayList

    '    _Dt = _Ver.consUsuariosIniciar(DNI, Contraseña)

    '    If _Dt.Rows.Count > 0 Then
    '        For Each _Dr As DataRow In _Dt.Rows
    '            Respuesta.Add(_Dr("idUsuario"))
    '            Respuesta.Add(_Dr("Apellido"))
    '            Respuesta.Add(_Dr("Nombres"))
    '            Respuesta.Add(_Dr("CategoriaUsuario"))
    '        Next

    '        G.Grabar("Usuarios", "NoImagen", "feedlot.modFechUsuario", CInt(Respuesta.Item(0)), Format(DateTime.Now, "yyyy/MM/dd H:mm:ss"))

    '        Return Respuesta
    '    Else
    '        Respuesta.Add("Usuario o Contraseña incorrectos !")

    '        Return Respuesta
    '    End If
    'End Function

    '<HttpGet>
    'Public Function Registrar(ByVal Apellido As String, ByVal Nombres As String, ByVal DNI As String, ByVal Contraseña As String) As Integer
    '    Dim G As New GrabaDatos
    '    Dim _Dt As New DataTable
    '    Dim _Ver As New Mostrar

    '    Try
    '        _Dt = _Ver.consDNIusuario(DNI)

    '        If _Dt.Rows.Count > 0 Then
    '            Return 2
    '        Else
    '            G.Grabar("Usuarios", "NoImagen", "feedlot.insUsuario", Apellido, Nombres, DNI, Contraseña,
    '                "Usuario", Format(Date.Now.Date, "yyyy/MM/dd"))
    '        End If

    '        Return 1
    '    Catch ex As MySqlException
    '        Return 0
    '        'BDxxx()
    '    Finally
    '        'BDxxx()
    '    End Try
    'End Function




End Module
