Imports MySql.Data.MySqlClient

Module modCorral
    Public Function Modificar(ByVal idC As Integer, ByVal Cab As Integer) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.modCorral")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@IdC", idC)
                Cmd.Parameters.AddWithValue("@mCab", Cab)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro Modificado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
