Public Class ValidaCUIT

    Public Function CUIT(ByVal mk_p_nro As String) As Boolean
        Dim mk_suma As Integer
        Dim mk_valido As String
        mk_p_nro = mk_p_nro.Replace("-", "")
        If IsNumeric(mk_p_nro) Then
            If mk_p_nro.Length <> 11 Then
                mk_valido = False
            Else
                mk_suma = 0
                mk_suma += CInt(mk_p_nro.Substring(0, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(1, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(2, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(3, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(4, 1)) * 7
                mk_suma += CInt(mk_p_nro.Substring(5, 1)) * 6
                mk_suma += CInt(mk_p_nro.Substring(6, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(7, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(8, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(9, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(10, 1)) * 1
            End If

            If Math.Round(mk_suma / 11, 0) = (mk_suma / 11) Then
                mk_valido = True
            Else
                mk_valido = False
            End If
        Else
            mk_valido = False
        End If

        Return (mk_valido)
    End Function

End Class
