Imports MySql.Data.MySqlClient

Module verCorrales
    Public Function Ver() As List(Of mdlCorrales)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlCorrales)
        Dim E As New mdlCorrales
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verCorrales")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlCorrales(
                        Sdr("idCorrales"),
                        Sdr("NombreCorral"),
                        Sdr("Superficie"),
                        Sdr("CabezasTotales"),
                        Sdr("CAMPO_idCampo"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Corrales cargados, ingrese Corrales para poder Operar !"
                    Lista.Insert(0, E)
                Else
                    Return Lista
                End If

                Sdr.Close()
            End Using

            Return Lista
        Catch ex As Exception
            E.Err = "Error: " & ex.Message.ToString
            Lista.Insert(0, E)
            Return Lista
        End Try
    End Function
End Module
