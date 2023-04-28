Public Class Form_logon

    Private Sub Form_logon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.Main_form.Enabled = False

        If fn_sql_request("SELECT [user_name] FROM dbo.users WHERE status = 'active' ", "SELECT", 1) = False Then
            MsgBox("Nebyly nalezeni žádní uživatelé v Databázi")
        Else
            Me.cb_users.Items.Clear()
            For Each field As String In My.Forms.Main_form.sql_array
                Try
                    If Not field.Trim Is Nothing Then
                        cb_users.Items.Add(field)
                    End If
                Catch ex As Exception
                End Try
            Next
        End If


        Me.Focus()
        Me.cb_users.Focus()

    End Sub



    Private Sub cb_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_users.SelectedIndexChanged
        If cb_users.Text.Length > 0 Then
            btn_logon.Enabled = True
        Else
            btn_logon.Enabled = False
        End If
    End Sub


    Private Sub btn_logon_Click(sender As Object, e As EventArgs) Handles btn_logon.Click
        My.Forms.Main_form.user = cb_users.Text
        My.Forms.Main_form.Enabled = True
        My.Forms.Main_form.Text += " Přihlášen: " + cb_users.Text
        Me.Hide()
    End Sub


    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim result = MsgBox("Chcete Aplikaci skutečně Ukončit?", MsgBoxStyle.YesNo)
        If result = vbYes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub



End Class