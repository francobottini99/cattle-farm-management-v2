Imports MySql.Data.MySqlClient

Module insUsuario
    Public Function Insertar(ByVal Dts As mdlUsuario) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insUsuario")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@uApellido", Dts.Apellido)
                Cmd.Parameters.AddWithValue("@uNom", Dts.Nombre)
                Cmd.Parameters.AddWithValue("@uDni", Dts.DNIus)
                Cmd.Parameters.AddWithValue("@uContr", Dts.Contraseña)
                Cmd.Parameters.AddWithValue("@uCatg", Dts.CategoriaUs)
                Cmd.Parameters.AddWithValue("@uFechR", Dts.FechaUltimoIng)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Usuario Registrado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module

