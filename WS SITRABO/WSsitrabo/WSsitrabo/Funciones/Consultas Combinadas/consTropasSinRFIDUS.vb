Imports MySql.Data.MySqlClient

Module consTropasSinRFIDUS
    Public Function Ver(ByVal dtUs As Integer) As List(Of mdlTropa)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlTropa)
        Dim Tropas As New List(Of mdlTropa)
        Dim E As New mdlTropa
        Dim Sdr As MySqlDataReader
        Dim I As Integer = 0

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.consTropasSinRFIDUS")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtUs", dtUs)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlTropa(
                        Sdr("idTropa"),
                        Sdr("NombreTropa"),
                        Sdr("OrigenProcedencia"),
                        Sdr("FechaIngreso"),
                        Sdr("Cabezas"),
                        Sdr("Muertes"),
                        Sdr("Ventas"),
                        Sdr("Stock"),
                        Sdr("PesoIngreso"),
                        Sdr("TotalKgTropa"),
                        Sdr("Observaciones"),
                        Sdr("PRODUCTOR_idProductor"),
                        Sdr("CAMPO_idCampo"),
                        Sdr("PROVEEDOR_idProveedor"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay tropas sin RFID asignado !"
                    Lista.Insert(0, E)
                    Return Lista
                Else
                    Dim Anterior As Integer = Lista.Item(0).IdTropa
                    I = 1
                    For Each Item In Lista
                        If Item.IdTropa <> Anterior Then
                            Tropas.Add(New mdlTropa(
                                            Item.IdTropa,
                                            Item.NombreTropa,
                                            Item.Origen,
                                            Item.Fecha,
                                            Item.Cabezas,
                                            Item.Muertes,
                                            Item.Ventas,
                                            Item.Stock,
                                            Item.PesoIngreso,
                                            Item.KgTropa,
                                            Item.Observaciones,
                                            Item.IdProductor,
                                            Item.idCampo,
                                            Item.IdProveedor,
                                            Item.IdUsuario,
                                            "OK"))
                            Anterior = Item.IdTropa
                            I = I + 1
                        End If
                    Next
                    Return Tropas
                End If

                Sdr.Close()
            End Using
        Catch ex As Exception
            E.Err = "Error: " & ex.Message.ToString
            Lista.Insert(0, E)
            Return Lista
        End Try
    End Function
End Module
