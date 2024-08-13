Imports MySql.Data.MySqlClient

Module consUsuariosIniciar
    Public Function Ver(ByVal DNI As String, ByVal Contraseña As String) As mdlUsuario
        Dim Cmd As New MySqlCommand
        Dim Sdr As MySqlDataReader
        Dim Usuario As New mdlUsuario

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.consUsuarioIniciar")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@uDNI", DNI)
                Cmd.Parameters.AddWithValue("@uContr", Contraseña)

                Conn.Open()
                Sdr = Cmd.ExecuteReader
                If Sdr.Read() = Nothing Then
                    Usuario.Err = "Error: Usuario o Contraseña incorrectos"
                Else
                    Sdr.Read()
                    Usuario.IdUsuario = Sdr("idUsuario")
                    Usuario.Apellido = Sdr("Apellido")
                    Usuario.Nombre = Sdr("Nombres")
                    Usuario.CategoriaUs = Sdr("CategoriaUsuario")
                    Usuario.Err = "OK"
                End If
                Sdr.Close()
            End Using

            Return Usuario
        Catch ex As Exception
            Return Usuario.Err + " " + ex.Message.ToString
        End Try
    End Function
End Module
