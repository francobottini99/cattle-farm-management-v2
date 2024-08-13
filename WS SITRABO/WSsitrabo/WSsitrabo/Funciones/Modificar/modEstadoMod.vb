Imports MySql.Data.MySqlClient

Module modEstadoMod
    Public Function Modificar(ByVal TropaBloqueo As mdlTropaBloqueo) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.modEstadoMod")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@tbmEst", "NO")
                Cmd.Parameters.AddWithValue("@tbmIDt", TropaBloqueo.IdTropa)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro modificado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
