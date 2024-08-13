Public Class TarjetaStkCorral
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Public Property pnlTarjetaCorral As Panel
    Public Property lblTituloPPal As Label
    Public Property lblTituloTotales As Label
    Public Property dgvTotales As DataGridView
    Public Property ascTarjetaDetalleTropa As List(Of TarjetaDetalleTropa)
    Public Property bnfElipse As Bunifu.Framework.UI.BunifuElipse

    Public Sub New(ByVal CantTropas As Integer, ByVal posX As Integer, ByVal posY As Integer, ByVal NombreCorral As String, ByVal NombresTropas() As String)
        Dim DataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsStock))
        pnlTarjetaCorral = New System.Windows.Forms.Panel()
        ascTarjetaDetalleTropa = New List(Of TarjetaDetalleTropa)
        lblTituloPPal = New System.Windows.Forms.Label()
        lblTituloTotales = New System.Windows.Forms.Label()
        dgvTotales = New System.Windows.Forms.DataGridView()
        bnfElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)

        pnlTarjetaCorral.SuspendLayout()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()

        SuspendLayout()
        '
        'pnlTarjetaCorral
        '
        pnlTarjetaCorral.AutoScroll = True
        pnlTarjetaCorral.AutoScrollMargin = New Size(0, 10)
        pnlTarjetaCorral.BackColor = Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(43, Byte), Integer))
        pnlTarjetaCorral.Controls.Add(lblTituloPPal)
        pnlTarjetaCorral.Controls.Add(lblTituloTotales)
        pnlTarjetaCorral.Controls.Add(dgvTotales)

        Dim Y As Integer = 87

        For i As Integer = 0 To CantTropas - 1
            ascTarjetaDetalleTropa.Add(New TarjetaDetalleTropa(NombresTropas(i), 8, Y))

            pnlTarjetaCorral.Controls.Add(ascTarjetaDetalleTropa.Item(i).lblTituloTropa)
            pnlTarjetaCorral.Controls.Add(ascTarjetaDetalleTropa.Item(i).dgvDetalleTropa)

            Y += ascTarjetaDetalleTropa.Item(i).dgvDetalleTropa.Height + ascTarjetaDetalleTropa.Item(i).lblTituloTropa.Height + 5
        Next

        pnlTarjetaCorral.Location = New Point(posX, posY)
        pnlTarjetaCorral.Name = "pnlTarjetaCorral"
        pnlTarjetaCorral.Size = New Size(570, 357)
        pnlTarjetaCorral.TabIndex = 0
        '
        'lblTituloPPal
        '
        lblTituloPPal.BackColor = Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(24, Byte), Integer))
        lblTituloPPal.Font = New Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTituloPPal.ForeColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(94, Byte), Integer))
        lblTituloPPal.Location = New Point(0, 0)
        lblTituloPPal.Name = "lblTituloPPal"

        If CantTropas >= 3 Then
            lblTituloPPal.Size = New Size(553, 44)
        Else
            lblTituloPPal.Size = New Size(570, 44)
        End If

        lblTituloPPal.TabIndex = 0
        lblTituloPPal.Text = NombreCorral
        lblTituloPPal.TextAlign = ContentAlignment.MiddleCenter
        '
        'lblTituloTotales
        '
        lblTituloTotales.BackColor = Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(97, Byte), Integer))
        lblTituloTotales.Font = New Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTituloTotales.ForeColor = Color.White
        lblTituloTotales.Location = New Point(320, 57)
        lblTituloTotales.Name = "lblTituloTotales"

        If CantTropas >= 3 Then
            lblTituloTotales.Size = New Size(216, 30)
        Else
            lblTituloTotales.Size = New Size(233, 30)
        End If

        lblTituloTotales.TabIndex = 6
        lblTituloTotales.Text = "Totales"
        lblTituloTotales.TextAlign = ContentAlignment.MiddleCenter
        '
        'dgvTotales
        '
        dgvTotales.AllowUserToAddRows = False
        dgvTotales.AllowUserToDeleteRows = False
        dgvTotales.AllowUserToResizeRows = False
        DataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvTotales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle
        dgvTotales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        dgvTotales.ColumnHeadersVisible = False
        dgvTotales.Cursor = System.Windows.Forms.Cursors.Default
        dgvTotales.DefaultCellStyle = DataGridViewCellStyle
        dgvTotales.Location = New System.Drawing.Point(320, 87)
        dgvTotales.MultiSelect = False
        dgvTotales.Name = "dgvTotales"
        dgvTotales.ReadOnly = True
        dgvTotales.RowHeadersVisible = False

        If CantTropas >= 3 Then
            dgvTotales.Size = New System.Drawing.Size(216, Y - 122)
        Else
            dgvTotales.Size = New System.Drawing.Size(233, Y - 122)
        End If

        dgvTotales.TabIndex = 5
        dgvTotales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTotales.ColumnHeadersVisible = False

        dgvTotales.ColumnCount = 2
        dgvTotales.RowTemplate.Height = 35
        dgvTotales.Columns(0).Name = "Categoria"
        dgvTotales.Columns(1).Name = "Cabezas"

        dgvTotales.Columns("Cabezas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '
        'bnfElipse
        '
        bnfElipse.ElipseRadius = 20
        bnfElipse.TargetControl = pnlTarjetaCorral

        pnlTarjetaCorral.ResumeLayout()
    End Sub
End Class
