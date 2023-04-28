Public Class form_picture_preview


    Private Sub form_picture_preview_keypressed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then

            If parent_form = "Main_form" Then
                parent_form = ""
                My.Forms.Main_form.Show()
                My.Forms.Main_form.Controls.Owner.Enabled = True
                'My.Forms.Main_form.Focus()
            End If

            If parent_form = "Form_gate_history" Then
                My.Forms.frm_gate_history.Show()
                My.Forms.frm_gate_history.Controls.Owner.Enabled = True
                'My.Forms.frm_gate_history.Focus()
            End If

            Me.Close()

        End If
    End Sub


    Private Sub form_picture_preview_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If parent_form = "Main_form" Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            parent_form = ""
            My.Forms.Main_form.Show()
            'My.Forms.Main_form.Focus()
        End If

        If parent_form = "Form_gate_history" Then
            My.Forms.frm_gate_history.Controls.Owner.Enabled = True
            My.Forms.frm_gate_history.Show()
            'My.Forms.frm_gate_history.Focus()
        End If


    End Sub





End Class



