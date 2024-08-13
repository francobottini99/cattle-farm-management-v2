Imports MySql.Data.MySqlClient

Module insCategorias
    Public Function Insertar(ByVal Dts As mdlCategorias) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insCategorias")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@cCategoria", Dts.Categoria)
                Cmd.Parameters.AddWithValue("@cIDu", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
