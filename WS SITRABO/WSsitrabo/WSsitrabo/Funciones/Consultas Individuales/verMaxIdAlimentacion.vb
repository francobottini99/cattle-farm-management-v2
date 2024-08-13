Imports MySql.Data.MySqlClient

Module verMaxIdAlimentacion
    Public Function Ver() As String
        Dim Cmd As New MySqlCommand
        Dim MaxId As New mdlAlimentacion
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verMaxIdAlimentacion")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Conn.Open()
                Sdr = Cmd.ExecuteReader
                Sdr.Read()

                MaxId.IdAlim = Sdr("UltimoId")

                Sdr.Close()
            End Using

            Return MaxId.IdAlim.ToString
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
