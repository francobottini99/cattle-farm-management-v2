Imports MySql.Data.MySqlClient

Module insStock
    Public Function Insertar(ByVal Dts As mdlStock) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insStock")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@stkFec", Dts.Fecha)
                Cmd.Parameters.AddWithValue("@sktCaravana", Dts.Caravana)
                Cmd.Parameters.AddWithValue("@sktDescripcion", Dts.Descripcion)
                Cmd.Parameters.AddWithValue("@stkCabezas", Dts.Cabezas)
                Cmd.Parameters.AddWithValue("@stkIDt", Dts.IdTropa)
                Cmd.Parameters.AddWithValue("@sktIDdt", Dts.IdDetalleTropa)
                Cmd.Parameters.AddWithValue("@sktIDcrr", Dts.IdCorrales)
                Cmd.Parameters.AddWithValue("@sktIDcatg", Dts.IdCategorias)
                Cmd.Parameters.AddWithValue("@sktIDus", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
