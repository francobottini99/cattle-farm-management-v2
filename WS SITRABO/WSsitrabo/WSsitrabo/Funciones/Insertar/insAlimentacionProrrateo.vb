Imports MySql.Data.MySqlClient

Module insAlimentacionProrrateo
    Public Function Insertar(ByVal AlimentacionProrrateo As mdlAlimentacionProrateo) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insAlimentacionProrrateo")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@aFecha", AlimentacionProrrateo.Fecha)
                Cmd.Parameters.AddWithValue("@aKgRacion", AlimentacionProrrateo.KgRacion)
                Cmd.Parameters.AddWithValue("@aKgGrano", AlimentacionProrrateo.KgGrano)
                Cmd.Parameters.AddWithValue("@aKgConcentrado", AlimentacionProrrateo.KgConc)
                Cmd.Parameters.AddWithValue("@aKgFibra", AlimentacionProrrateo.KgFibra)
                Cmd.Parameters.AddWithValue("@aKgOtros", AlimentacionProrrateo.KgOtros)
                Cmd.Parameters.AddWithValue("@aImporteGrano", AlimentacionProrrateo.ImpGrano)
                Cmd.Parameters.AddWithValue("@aImporteConcentrado", AlimentacionProrrateo.ImpConc)
                Cmd.Parameters.AddWithValue("@aImporteFibra", AlimentacionProrrateo.ImpFibra)
                Cmd.Parameters.AddWithValue("@aImporteOtros", AlimentacionProrrateo.ImpOtros)
                Cmd.Parameters.AddWithValue("@aImporteTotal", AlimentacionProrrateo.ImpTotal)
                Cmd.Parameters.AddWithValue("@aPorcentajeGrano", AlimentacionProrrateo.PorcGrano)
                Cmd.Parameters.AddWithValue("@aPorcentajeConc", AlimentacionProrrateo.PorcConc)
                Cmd.Parameters.AddWithValue("@aPorcentajeFibra", AlimentacionProrrateo.PorcFibra)
                Cmd.Parameters.AddWithValue("@aPorcentajeOtros", AlimentacionProrrateo.PorcOtros)
                Cmd.Parameters.AddWithValue("@aIdRacion", AlimentacionProrrateo.IdRacion)
                Cmd.Parameters.AddWithValue("@aDetTtro", AlimentacionProrrateo.IdDetalleTropa)
                Cmd.Parameters.AddWithValue("@aIdUsuario", AlimentacionProrrateo.IdUsuario)
                Cmd.Parameters.AddWithValue("@aIdAlim", AlimentacionProrrateo.IdAlimentacion)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
