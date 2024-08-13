Public Class frmConsCaravanas

    Private Sub frmConsCaravanas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consDetalleTropa_Engorde_Corral_Tropa_Todas
        Else
            _Dt = _Ver.consDetalleTropa_Engorde_Corral_Tropa_US_Todas(frmLogin.txtID.Text)
        End If

        dgvCaravanas.RowTemplate.Height = 25
        dgvCaravanas.DataSource = _Dt
        dgvCaravanas.Columns("Descripcion").Visible = False
        dgvCaravanas.Columns("Estado").Visible = False
        dgvCaravanas.Columns("idDetTropa").Visible = False
        dgvCaravanas.Columns("idTropa").Visible = False

        lblMsg.Select()
        dgvCaravanas.CurrentCell = Nothing
        dgvCaravanas.ClearSelection()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmConsAlimentacion.chbCarav.Checked = False

        lblMsg.Select()
        dgvCaravanas.CurrentCell = Nothing
        dgvCaravanas.ClearSelection()

        Me.Close()
    End Sub

    Private Sub btnSelec_Click(sender As Object, e As EventArgs) Handles btnSelec.Click
        If lblOrigen.Text = "CONSULTA ALIMENTACION" Then
            If dgvCaravanas.CurrentRow IsNot Nothing Then
                frmConsAlimentacion.txtCaravana.Text = dgvCaravanas.CurrentRow.Cells.Item(0).Value
                frmConsAlimentacion.txtIdCar.Text = dgvCaravanas.CurrentRow.Cells.Item(3).Value

                lblMsg.Select()
                dgvCaravanas.CurrentCell = Nothing
                dgvCaravanas.ClearSelection()

                Me.Close()
            Else
                MsgBox("No selecciono ninguna caravana... !", vbExclamation, "Servico de Alertas")
            End If
        Else
            If dgvCaravanas.CurrentRow IsNot Nothing Then
                frmConsPesajes.txtCaravana.Text = dgvCaravanas.CurrentRow.Cells.Item(0).Value
                frmConsPesajes.txtIdCar.Text = dgvCaravanas.CurrentRow.Cells.Item(3).Value

                lblMsg.Select()
                dgvCaravanas.CurrentCell = Nothing
                dgvCaravanas.ClearSelection()

                Me.Close()
            Else
                MsgBox("No selecciono ninguna caravana... !", vbExclamation, "Servico de Alertas")
            End If
        End If
    End Sub
End Class