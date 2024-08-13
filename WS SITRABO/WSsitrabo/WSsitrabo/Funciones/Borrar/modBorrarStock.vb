Imports MySql.Data.MySqlClient

Module modBorrarStock
    Public Function Borrar(ByVal Fec As Date, ByVal IdU As Integer) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.modBorrarStock")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Fec", Fec)
                Cmd.Parameters.AddWithValue("@Idus", IdU)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registros Borrados"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
