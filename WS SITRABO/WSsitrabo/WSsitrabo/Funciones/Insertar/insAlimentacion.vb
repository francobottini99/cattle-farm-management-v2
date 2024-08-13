Imports MySql.Data.MySqlClient

Module insAlimentacion
    Public Function Insertar(ByVal Dts As mdlAlimentacion) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insAlimentacion")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@aFecha", Dts.Fecha)
                Cmd.Parameters.AddWithValue("@aKgRacion", Dts.KgRacion)
                Cmd.Parameters.AddWithValue("@aTurno", Dts.Turno)
                Cmd.Parameters.AddWithValue("@aKgGrano", Dts.KgGrano)
                Cmd.Parameters.AddWithValue("@aKgConcentrado", Dts.KgConc)
                Cmd.Parameters.AddWithValue("@aKgFibra", Dts.KgFibra)
                Cmd.Parameters.AddWithValue("@aKgOtros", Dts.KgOtros)
                Cmd.Parameters.AddWithValue("@aImporteGrano", Dts.ImpGrano)
                Cmd.Parameters.AddWithValue("@aImporteConcentrado", Dts.ImpConc)
                Cmd.Parameters.AddWithValue("@aImporteFibra", Dts.ImpFibra)
                Cmd.Parameters.AddWithValue("@aImporteOtros", Dts.ImpOtros)
                Cmd.Parameters.AddWithValue("@aImporteTotal", Dts.ImpTotal)
                Cmd.Parameters.AddWithValue("@aPorcentajeGrano", Dts.PorcGrano)
                Cmd.Parameters.AddWithValue("@aPorcentajeConc", Dts.PorcConc)
                Cmd.Parameters.AddWithValue("@aPorcentajeFibra", Dts.PorcFibra)
                Cmd.Parameters.AddWithValue("@aPorcentajeOtros", Dts.PorcOtros)
                Cmd.Parameters.AddWithValue("@aObser", Dts.Observaciones)
                Cmd.Parameters.AddWithValue("@aIdCorral", Dts.IdCorral)
                Cmd.Parameters.AddWithValue("@aIdRacion", Dts.IdRacion)
                Cmd.Parameters.AddWithValue("@aIdUsuario", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
