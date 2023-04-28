Public Class form_help



    Private Sub form_about_escaped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            Me.Close()
        End If
    End Sub


End Class