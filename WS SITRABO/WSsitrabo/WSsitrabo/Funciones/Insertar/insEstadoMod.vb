Imports MySql.Data.MySqlClient

Module insEstadoMod
    Public Function Insertar(ByVal TropaBloqueo As mdlTropaBloqueo) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insEstadoMod")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@tbmEst", "SI")
                Cmd.Parameters.AddWithValue("@tbmIDt", TropaBloqueo.IdTropa)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
