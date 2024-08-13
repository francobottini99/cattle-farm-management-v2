<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsCaravanas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsCaravanas))
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.dgvCaravanas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSelec = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxNuevo = New System.Windows.Forms.GroupBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        CType(Me.dgvCaravanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxNuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(6, 16)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(580, 38)
        Me.lblMsg.TabIndex = 39
        Me.lblMsg.Text = "CARAVANAS"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCaravanas
        '
        Me.dgvCaravanas.AllowUserToAddRows = False
        Me.dgvCaravanas.AllowUserToDeleteRows = False
        Me.dgvCaravanas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCaravanas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCaravanas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCaravanas.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvCaravanas.ColumnHeadersHeight = 30
        Me.dgvCaravanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCaravanas.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCaravanas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCaravanas.Location = New System.Drawing.Point(6, 87)
        Me.dgvCaravanas.MultiSelect = False
        Me.dgvCaravanas.Name = "dgvCaravanas"
        Me.dgvCaravanas.ReadOnly = True
        Me.dgvCaravanas.RowHeadersVisible = False
        Me.dgvCaravanas.RowHeadersWidth = 100
        Me.dgvCaravanas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCaravanas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaravanas.Size = New System.Drawing.Size(581, 490)
        Me.dgvCaravanas.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(3, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(584, 5)
        Me.Label5.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(23, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "  Detalle De Caravanas En Engorde "
        '
        'btnSelec
        '
        Me.btnSelec.BackColor = System.Drawing.Color.DimGray
        Me.btnSelec.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.btnSelec.FlatAppearance.BorderSize = 3
        Me.btnSelec.FlatAppearance.CheckedBackColor = System.Drawing.Color.Sienna
        Me.btnSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelec.ForeColor = System.Drawing.Color.BurlyWood
        Me.btnSelec.Location = New System.Drawing.Point(340, 583)
        Me.btnSelec.Name = "btnSelec"
        Me.btnSelec.Size = New System.Drawing.Size(121, 36)
        Me.btnSelec.TabIndex = 68
        Me.btnSelec.Text = "Seleccionar"
        Me.btnSelec.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.btnCancelar.FlatAppearance.BorderSize = 3
        Me.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Sienna
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood
        Me.btnCancelar.Location = New System.Drawing.Point(467, 583)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 36)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbxNuevo
        '
        Me.gbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.gbxNuevo.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxNuevo.Controls.Add(Me.lblOrigen)
        Me.gbxNuevo.Controls.Add(Me.btnCancelar)
        Me.gbxNuevo.Controls.Add(Me.btnSelec)
        Me.gbxNuevo.Controls.Add(Me.Label3)
        Me.gbxNuevo.Controls.Add(Me.Label5)
        Me.gbxNuevo.Controls.Add(Me.dgvCaravanas)
        Me.gbxNuevo.Controls.Add(Me.lblMsg)
        Me.gbxNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxNuevo.Location = New System.Drawing.Point(4, 5)
        Me.gbxNuevo.Name = "gbxNuevo"
        Me.gbxNuevo.Size = New System.Drawing.Size(594, 634)
        Me.gbxNuevo.TabIndex = 43
        Me.gbxNuevo.TabStop = False
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.Color.Salmon
        Me.lblOrigen.Location = New System.Drawing.Point(496, 27)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(72, 27)
        Me.lblOrigen.TabIndex = 70
        Me.lblOrigen.Visible = False
        '
        'frmConsCaravanas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(603, 643)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsCaravanas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsCaravanas"
        CType(Me.dgvCaravanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxNuevo.ResumeLayout(False)
        Me.gbxNuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents dgvCaravanas As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelec As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbxNuevo As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrigen As Label
End Class
