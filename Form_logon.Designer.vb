<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_logon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_logon))
        Me.cb_users = New System.Windows.Forms.ComboBox()
        Me.lbl_logged = New System.Windows.Forms.Label()
        Me.btn_logon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_users
        '
        Me.cb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_users.FormattingEnabled = True
        Me.cb_users.Location = New System.Drawing.Point(108, 6)
        Me.cb_users.Name = "cb_users"
        Me.cb_users.Size = New System.Drawing.Size(173, 21)
        Me.cb_users.TabIndex = 3
        '
        'lbl_logged
        '
        Me.lbl_logged.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_logged.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_logged.Location = New System.Drawing.Point(1, 6)
        Me.lbl_logged.Name = "lbl_logged"
        Me.lbl_logged.Size = New System.Drawing.Size(101, 24)
        Me.lbl_logged.TabIndex = 2
        Me.lbl_logged.Text = "Přihlásit Jako:"
        Me.lbl_logged.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_logon
        '
        Me.btn_logon.Enabled = False
        Me.btn_logon.Location = New System.Drawing.Point(206, 33)
        Me.btn_logon.Name = "btn_logon"
        Me.btn_logon.Size = New System.Drawing.Size(75, 23)
        Me.btn_logon.TabIndex = 4
        Me.btn_logon.Text = "Přihlásit"
        Me.btn_logon.UseVisualStyleBackColor = True
        '
        'Form_logon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 61)
        Me.Controls.Add(Me.btn_logon)
        Me.Controls.Add(Me.cb_users)
        Me.Controls.Add(Me.lbl_logged)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_logon"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brána EV Přihlášení"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_users As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_logged As System.Windows.Forms.Label
    Friend WithEvents btn_logon As System.Windows.Forms.Button
End Class
