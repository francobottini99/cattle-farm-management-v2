Public Class TarjetaDetalleTropa
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Public Property lblTituloTropa As Label
    Public Property dgvDetalleTropa As DataGridView

    Public Sub New(ByVal NombreTropa As String, ByVal posX As Integer, ByVal posY As Integer)
        Dim DataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsStock))
        lblTituloTropa = New System.Windows.Forms.Label()
        dgvDetalleTropa = New System.Windows.Forms.DataGridView()

        CType(dgvDetalleTropa, System.ComponentModel.ISupportInitialize).BeginInit()

        SuspendLayout()
        '
        'lblTituloTropa
        '
        lblTituloTropa.BackColor = Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(97, Byte), Integer))
        lblTituloTropa.Font = New Font("Arial Black", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTituloTropa.ForeColor = Color.White
        lblTituloTropa.Name = "lblTituloTropa"
        lblTituloTropa.Size = New Size(299, 30)
        lblTituloTropa.Location = New Point(8, posY - lblTituloTropa.Height)
        lblTituloTropa.TabIndex = 2
        lblTituloTropa.Text = NombreTropa
        lblTituloTropa.TextAlign = ContentAlignment.MiddleCenter
        '
        'dgvDetalleTropa
        '
        dgvDetalleTropa.AllowUserToAddRows = False
        dgvDetalleTropa.AllowUserToDeleteRows = False
        dgvDetalleTropa.AllowUserToResizeRows = False
        DataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvDetalleTropa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle
        dgvDetalleTropa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        dgvDetalleTropa.ColumnHeadersVisible = False
        dgvDetalleTropa.Cursor = System.Windows.Forms.Cursors.Default
        dgvDetalleTropa.DefaultCellStyle = DataGridViewCellStyle
        dgvDetalleTropa.Location = New System.Drawing.Point(posX, posY)
        dgvDetalleTropa.MultiSelect = False
        dgvDetalleTropa.Name = "dgvTotales"
        dgvDetalleTropa.ReadOnly = True
        dgvDetalleTropa.RowHeadersVisible = False
        dgvDetalleTropa.Size = New System.Drawing.Size(299, 108)
        dgvDetalleTropa.TabIndex = 5
        dgvDetalleTropa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleTropa.ColumnHeadersVisible = False

        dgvDetalleTropa.ColumnCount = 2
        dgvDetalleTropa.RowTemplate.Height = 35
        dgvDetalleTropa.Columns(0).Name = "Categoria"
        dgvDetalleTropa.Columns(1).Name = "Cabezas"

        dgvDetalleTropa.Columns("Cabezas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
End Class
