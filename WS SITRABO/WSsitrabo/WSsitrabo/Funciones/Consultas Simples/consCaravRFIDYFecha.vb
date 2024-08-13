Imports MySql.Data.MySqlClient

Module consCaravRFIDYFecha
    Public Function Ver(ByVal Carav As String, ByVal Fd As Date, ByVal Fh As Date) As mdlAlimentacionProrateo
        Dim Cmd As New MySqlCommand
        Dim Alm As New mdlAlimentacionProrateo
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.consCaravRFIDYFecha")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Carav", Carav)
                Cmd.Parameters.AddWithValue("@Fd", Fd)
                Cmd.Parameters.AddWithValue("@Fh", Fh)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Sdr.Read()

                Alm.KgRacion = Sdr("KgRac")
                Alm.KgGrano = Sdr("KgGr")
                Alm.KgConc = Sdr("KgCons")
                Alm.KgFibra = Sdr("KgFib")
                Alm.KgOtros = Sdr("KgOtr")
                Alm.ImpGrano = Sdr("ImGr")
                Alm.ImpConc = Sdr("ImCons")
                Alm.ImpFibra = Sdr("ImFib")
                Alm.ImpOtros = Sdr("ImOtr")
                Alm.ImpTotal = Sdr("ImTot")
                Alm.PorcGrano = Format(Sdr("PorGr"), "#.##0,00")
                Alm.PorcConc = Format(Sdr("PorConc"), "#.##0,00")
                Alm.PorcFibra = Format(Sdr("PorFib"), "#.##0,00")
                Alm.PorcOtros = Format(Sdr("PorOt"), "#.##0,00")
                Alm.Err = Sdr("Caravana")

                Sdr.Close()
            End Using

            Return Alm
        Catch ex As Exception
            Alm.Err = ex.Message.ToString
            Return Alm
        End Try
    End Function
End Module
