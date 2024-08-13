<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltasCorrales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltasCorrales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblDetR = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbxD = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCampo = New System.Windows.Forms.ComboBox()
        Me.txtNombreCorral = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCab = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvCorrales = New System.Windows.Forms.DataGridView()
        Me.txtIDCampo = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        Me.gbxD.SuspendLayout()
        CType(Me.dgvCorrales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 636)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnNuevoNo
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Location = New System.Drawing.Point(23, 18)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(160, 116)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 8
        Me.pbxNuevo.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Location = New System.Drawing.Point(23, 384)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(160, 116)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 10
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Location = New System.Drawing.Point(23, 262)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(160, 116)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 9
        Me.pbxGuardar.TabStop = False
        '
        'pbxModificar
        '
        Me.pbxModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbxModificar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnModificarNo
        Me.pbxModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxModificar.Location = New System.Drawing.Point(23, 140)
        Me.pbxModificar.Name = "pbxModificar"
        Me.pbxModificar.Size = New System.Drawing.Size(160, 116)
        Me.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxModificar.TabIndex = 7
        Me.pbxModificar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(23, 506)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(160, 116)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 6
        Me.pbxSalir.TabStop = False
        '
        'gbxDatos
        '
        Me.gbxDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxDatos.Controls.Add(Me.lblDetR)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.gbxD)
        Me.gbxDatos.Controls.Add(Me.dgvCorrales)
        Me.gbxDatos.Controls.Add(Me.txtIDCampo)
        Me.gbxDatos.Controls.Add(Me.txtID)
        Me.gbxDatos.Controls.Add(Me.txtOrigen)
        Me.gbxDatos.Controls.Add(Me.lblMsg)
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(225, 12)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(844, 636)
        Me.gbxDatos.TabIndex = 21
        Me.gbxDatos.TabStop = False
        '
        'lblDetR
        '
        Me.lblDetR.AutoSize = True
        Me.lblDetR.ForeColor = System.Drawing.Color.Moccasin
        Me.lblDetR.Location = New System.Drawing.Point(24, 62)
        Me.lblDetR.Name = "lblDetR"
        Me.lblDetR.Size = New System.Drawing.Size(226, 16)
        Me.lblDetR.TabIndex = 50
        Me.lblDetR.Text = " Listado De Corrales Cargados "
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Moccasin
        Me.Label16.Location = New System.Drawing.Point(9, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(825, 5)
        Me.Label16.TabIndex = 51
        '
        'gbxD
        '
        Me.gbxD.Controls.Add(Me.Label1)
        Me.gbxD.Controls.Add(Me.txtSup)
        Me.gbxD.Controls.Add(Me.Label2)
        Me.gbxD.Controls.Add(Me.cbxCampo)
        Me.gbxD.Controls.Add(Me.txtNombreCorral)
        Me.gbxD.Controls.Add(Me.Label6)
        Me.gbxD.Controls.Add(Me.Label5)
        Me.gbxD.Controls.Add(Me.txtCab)
        Me.gbxD.Controls.Add(Me.Label7)
        Me.gbxD.Enabled = False
        Me.gbxD.Location = New System.Drawing.Point(6, 391)
        Me.gbxD.Name = "gbxD"
        Me.gbxD.Size = New System.Drawing.Size(832, 231)
        Me.gbxD.TabIndex = 30
        Me.gbxD.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccione Campo"
        '
        'txtSup
        '
        Me.txtSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSup.Location = New System.Drawing.Point(50, 139)
        Me.txtSup.MaxLength = 45
        Me.txtSup.Name = "txtSup"
        Me.txtSup.Size = New System.Drawing.Size(119, 22)
        Me.txtSup.TabIndex = 20
        Me.txtSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(47, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre Corral"
        '
        'cbxCampo
        '
        Me.cbxCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCampo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCampo.FormattingEnabled = True
        Me.cbxCampo.Location = New System.Drawing.Point(50, 50)
        Me.cbxCampo.Name = "cbxCampo"
        Me.cbxCampo.Size = New System.Drawing.Size(731, 24)
        Me.cbxCampo.TabIndex = 28
        '
        'txtNombreCorral
        '
        Me.txtNombreCorral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCorral.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtNombreCorral.Location = New System.Drawing.Point(50, 95)
        Me.txtNombreCorral.MaxLength = 250
        Me.txtNombreCorral.Name = "txtNombreCorral"
        Me.txtNombreCorral.Size = New System.Drawing.Size(731, 22)
        Me.txtNombreCorral.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(47, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Cabezas Totales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(47, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Superficie"
        '
        'txtCab
        '
        Me.txtCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCab.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCab.Location = New System.Drawing.Point(50, 184)
        Me.txtCab.MaxLength = 45
        Me.txtCab.Name = "txtCab"
        Me.txtCab.Size = New System.Drawing.Size(119, 22)
        Me.txtCab.TabIndex = 26
        Me.txtCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Moccasin
        Me.Label7.Location = New System.Drawing.Point(175, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "m2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvCorrales
        '
        Me.dgvCorrales.AllowUserToAddRows = False
        Me.dgvCorrales.AllowUserToDeleteRows = False
        Me.dgvCorrales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCorrales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCorrales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCorrales.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvCorrales.ColumnHeadersVisible = False
        Me.dgvCorrales.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCorrales.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCorrales.Location = New System.Drawing.Point(6, 84)
        Me.dgvCorrales.MultiSelect = False
        Me.dgvCorrales.Name = "dgvCorrales"
        Me.dgvCorrales.ReadOnly = True
        Me.dgvCorrales.RowHeadersVisible = False
        Me.dgvCorrales.RowHeadersWidth = 100
        Me.dgvCorrales.Size = New System.Drawing.Size(832, 301)
        Me.dgvCorrales.TabIndex = 0
        '
        'txtIDCampo
        '
        Me.txtIDCampo.BackColor = System.Drawing.Color.LightCoral
        Me.txtIDCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCampo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIDCampo.Location = New System.Drawing.Point(692, 33)
        Me.txtIDCampo.MaxLength = 10
        Me.txtIDCampo.Name = "txtIDCampo"
        Me.txtIDCampo.Size = New System.Drawing.Size(37, 20)
        Me.txtIDCampo.TabIndex = 29
        Me.txtIDCampo.Visible = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightCoral
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(649, 33)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(37, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(606, 33)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(37, 20)
        Me.txtOrigen.TabIndex = 24
        Me.txtOrigen.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(6, 18)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(832, 38)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "CORRAL"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAltasCorrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAltasCorrales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltasCorrales"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.gbxD.ResumeLayout(False)
        Me.gbxD.PerformLayout()
        CType(Me.dgvCorrales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCorral As System.Windows.Forms.TextBox
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSup As System.Windows.Forms.TextBox
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCorrales As System.Windows.Forms.DataGridView
    Friend WithEvents cbxCampo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCab As System.Windows.Forms.TextBox
    Friend WithEvents txtIDCampo As System.Windows.Forms.TextBox
    Friend WithEvents gbxD As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetR As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
