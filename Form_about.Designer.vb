<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_about
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_about))
        Me.img_SPZ = New System.Windows.Forms.PictureBox()
        Me.lbl_about1 = New System.Windows.Forms.Label()
        Me.lbl_about2 = New System.Windows.Forms.Label()
        Me.lbl_about3 = New System.Windows.Forms.Label()
        Me.lbl_about4 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_about5 = New System.Windows.Forms.Label()
        Me.lbl_about6 = New System.Windows.Forms.Label()
        CType(Me.img_SPZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_SPZ
        '
        Me.img_SPZ.Image = Global.BRANA_EV.My.Resources.Resources.SPZ
        Me.img_SPZ.Location = New System.Drawing.Point(2, 0)
        Me.img_SPZ.Name = "img_SPZ"
        Me.img_SPZ.Size = New System.Drawing.Size(203, 237)
        Me.img_SPZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img_SPZ.TabIndex = 0
        Me.img_SPZ.TabStop = False
        '
        'lbl_about1
        '
        Me.lbl_about1.AutoSize = True
        Me.lbl_about1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_about1.Location = New System.Drawing.Point(211, 0)
        Me.lbl_about1.Name = "lbl_about1"
        Me.lbl_about1.Size = New System.Drawing.Size(386, 25)
        Me.lbl_about1.TabIndex = 1
        Me.lbl_about1.Text = "BRÁNA - Evidence Provozu Vozidel"
        '
        'lbl_about2
        '
        Me.lbl_about2.AutoSize = True
        Me.lbl_about2.Location = New System.Drawing.Point(213, 29)
        Me.lbl_about2.Name = "lbl_about2"
        Me.lbl_about2.Size = New System.Drawing.Size(254, 13)
        Me.lbl_about2.TabIndex = 2
        Me.lbl_about2.Text = "Tento software slouží k monitoringu průjezdů bránou"
        '
        'lbl_about3
        '
        Me.lbl_about3.AutoSize = True
        Me.lbl_about3.Location = New System.Drawing.Point(213, 42)
        Me.lbl_about3.Name = "lbl_about3"
        Me.lbl_about3.Size = New System.Drawing.Size(205, 13)
        Me.lbl_about3.TabIndex = 3
        Me.lbl_about3.Text = "Program byl vytvořen pro výhradní použití"
        '
        'lbl_about4
        '
        Me.lbl_about4.AutoSize = True
        Me.lbl_about4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_about4.Location = New System.Drawing.Point(213, 78)
        Me.lbl_about4.Name = "lbl_about4"
        Me.lbl_about4.Size = New System.Drawing.Size(183, 16)
        Me.lbl_about4.TabIndex = 4
        Me.lbl_about4.Text = "Firmy App Rokytnice a.s."
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(509, 214)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Zavřít"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'lbl_about5
        '
        Me.lbl_about5.AutoSize = True
        Me.lbl_about5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_about5.Location = New System.Drawing.Point(213, 94)
        Me.lbl_about5.Name = "lbl_about5"
        Me.lbl_about5.Size = New System.Drawing.Size(92, 16)
        Me.lbl_about5.TabIndex = 6
        Me.lbl_about5.Text = "Rokytnice 203"
        '
        'lbl_about6
        '
        Me.lbl_about6.AutoSize = True
        Me.lbl_about6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_about6.Location = New System.Drawing.Point(213, 110)
        Me.lbl_about6.Name = "lbl_about6"
        Me.lbl_about6.Size = New System.Drawing.Size(121, 16)
        Me.lbl_about6.TabIndex = 7
        Me.lbl_about6.Text = "763 21     Rokytnice"
        '
        'form_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_about6)
        Me.Controls.Add(Me.lbl_about5)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.lbl_about4)
        Me.Controls.Add(Me.lbl_about3)
        Me.Controls.Add(Me.lbl_about2)
        Me.Controls.Add(Me.lbl_about1)
        Me.Controls.Add(Me.img_SPZ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "form_about"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O Programu"
        Me.TopMost = True
        CType(Me.img_SPZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_SPZ As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_about1 As System.Windows.Forms.Label
    Friend WithEvents lbl_about2 As System.Windows.Forms.Label
    Friend WithEvents lbl_about3 As System.Windows.Forms.Label
    Friend WithEvents lbl_about4 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents lbl_about5 As System.Windows.Forms.Label
    Friend WithEvents lbl_about6 As System.Windows.Forms.Label
End Class
