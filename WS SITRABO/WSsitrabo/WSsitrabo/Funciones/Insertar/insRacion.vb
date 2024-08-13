Imports MySql.Data.MySqlClient

Module insRacion
    Public Function Insertar(ByVal Dts As mdlRaciones) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insRacion")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@rNom", Dts.Nombre)
                Cmd.Parameters.AddWithValue("@rGrano", Dts.Grano)
                Cmd.Parameters.AddWithValue("@rConcentrado", Dts.Concentrado)
                Cmd.Parameters.AddWithValue("@rFibra", Dts.Fibra)
                Cmd.Parameters.AddWithValue("@rOtros", Dts.Otros)
                Cmd.Parameters.AddWithValue("@rCostGrano", Dts.CostoGrano)
                Cmd.Parameters.AddWithValue("@rCostConcentrado", Dts.CostoConc)
                Cmd.Parameters.AddWithValue("@rCostFibra", Dts.CostoFibra)
                Cmd.Parameters.AddWithValue("@rCostOtros", Dts.CostoOtros)
                Cmd.Parameters.AddWithValue("@rIDu", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
