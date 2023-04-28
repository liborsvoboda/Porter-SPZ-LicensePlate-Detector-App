Public Class form_about

    Private Sub Form_about_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        My.Forms.form_carrier.Hide()
        My.Forms.Form_config.Hide()
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub


    Private Sub form_about_escaped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            Me.Close()
        End If
    End Sub


End Class