Imports MySql.Data.MySqlClient

Module modFechUsuario
    Public Function Modificar(ByVal IngresoUs As mdlUsuario) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.modFechUsuario")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@IdU", IngresoUs.IdUsuario)
                Cmd.Parameters.AddWithValue("@uFech", Format(DateTime.Now, "yyyy/MM/dd H:mm:ss"))

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro modificado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
