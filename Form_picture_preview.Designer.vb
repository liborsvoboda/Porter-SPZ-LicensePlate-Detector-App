<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_picture_preview
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
        Me.psx_preview = New System.Windows.Forms.PictureBox()
        CType(Me.psx_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'psx_preview
        '
        Me.psx_preview.ErrorImage = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.psx_preview.Image = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.psx_preview.Location = New System.Drawing.Point(-1, -1)
        Me.psx_preview.Name = "psx_preview"
        Me.psx_preview.Size = New System.Drawing.Size(785, 563)
        Me.psx_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.psx_preview.TabIndex = 0
        Me.psx_preview.TabStop = False
        Me.psx_preview.WaitOnLoad = True
        '
        'form_picture_preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.psx_preview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_picture_preview"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Náhled Snímku"
        Me.TopMost = True
        CType(Me.psx_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents psx_preview As System.Windows.Forms.PictureBox
End Class
