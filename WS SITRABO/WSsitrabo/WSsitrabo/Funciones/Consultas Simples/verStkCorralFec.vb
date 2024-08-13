Imports MySql.Data.MySqlClient

Module verStkCorralFec
    Public Function Ver(ByVal dtUs As Integer, ByVal idCrr As Integer, ByVal Fec As Date) As List(Of mdlStock)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlStock)
        Dim E As New mdlStock
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verStkCorralFec")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtUs", dtUs)
                Cmd.Parameters.AddWithValue("@idCrr", idCrr)
                Cmd.Parameters.AddWithValue("@Fec", Fec)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlStock(
                        Sdr("idSTOCK"),
                        Sdr("Fecha"),
                        Sdr("Caravana"),
                        Sdr("Descripcion"),
                        Sdr("Cabezas"),
                        Sdr("TROPA_idTropa"),
                        Sdr("DETALLE_TROPA_idDetTropa"),
                        Sdr("CORRALES_idCorrales"),
                        Sdr("CATEGORIAS_idCategorias"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Stock de animales para esa Fecha !"
                    Lista.Insert(0, E)
                Else
                    Return Lista
                End If

                Sdr.Close()
            End Using

            Return Lista
        Catch ex As Exception
            E.Err = ex.Message.ToString
            Lista.Insert(0, E)
            Return Lista
        End Try
    End Function
End Module
