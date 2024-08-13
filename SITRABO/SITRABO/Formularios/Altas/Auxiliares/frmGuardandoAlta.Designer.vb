<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuardandoAlta
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pgbGuardando = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCabProgreso = New System.Windows.Forms.Label()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.lblListo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Adobe Gothic Std B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(133, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(322, 60)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "GUARDANDO"
        '
        'pgbGuardando
        '
        Me.pgbGuardando.BackColor = System.Drawing.Color.White
        Me.pgbGuardando.Location = New System.Drawing.Point(15, 100)
        Me.pgbGuardando.MarqueeAnimationSpeed = 1
        Me.pgbGuardando.Name = "pgbGuardando"
        Me.pgbGuardando.Size = New System.Drawing.Size(551, 58)
        Me.pgbGuardando.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 10)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(0, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(582, 10)
        Me.Label3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.CausesValidation = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(-1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 214)
        Me.Label4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.CausesValidation = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(572, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 214)
        Me.Label5.TabIndex = 8
        '
        'lblCabProgreso
        '
        Me.lblCabProgreso.AutoSize = True
        Me.lblCabProgreso.BackColor = System.Drawing.Color.Transparent
        Me.lblCabProgreso.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCabProgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblCabProgreso.Location = New System.Drawing.Point(218, 76)
        Me.lblCabProgreso.Name = "lblCabProgreso"
        Me.lblCabProgreso.Size = New System.Drawing.Size(99, 20)
        Me.lblCabProgreso.TabIndex = 9
        Me.lblCabProgreso.Text = "PROGRESO: "
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.BackColor = System.Drawing.Color.Transparent
        Me.lblProgreso.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblProgreso.Location = New System.Drawing.Point(313, 76)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(41, 20)
        Me.lblProgreso.TabIndex = 10
        Me.lblProgreso.Text = "98%"
        '
        'lblListo
        '
        Me.lblListo.AutoSize = True
        Me.lblListo.BackColor = System.Drawing.Color.Transparent
        Me.lblListo.Font = New System.Drawing.Font("Adobe Gothic Std B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblListo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblListo.Location = New System.Drawing.Point(10, 66)
        Me.lblListo.Name = "lblListo"
        Me.lblListo.Size = New System.Drawing.Size(560, 60)
        Me.lblListo.TabIndex = 11
        Me.lblListo.Text = "GUARDADO CON EXITO !"
        Me.lblListo.Visible = False
        '
        'frmGuardandoAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(580, 182)
        Me.Controls.Add(Me.lblListo)
        Me.Controls.Add(Me.lblProgreso)
        Me.Controls.Add(Me.lblCabProgreso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pgbGuardando)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGuardandoAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGuardandoAlta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pgbGuardando As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCabProgreso As System.Windows.Forms.Label
    Friend WithEvents lblProgreso As System.Windows.Forms.Label
    Friend WithEvents lblListo As System.Windows.Forms.Label
End Class
