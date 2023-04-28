Public Class Form_config


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save_close.Click
        If fn_save_SQL_setting() = True Then
            If fn_save_file_setting(Application.StartupPath() + "\config.ini") = True Then
                MsgBox("Nastavení bylo Uloženo")
                fn_load_setting()
                My.Forms.Main_form.reload_time_sequence = Me.txt_time_interval.Text
                My.Forms.Main_form.time_check = Date.Now.AddSeconds(My.Forms.Main_form.reload_time_sequence)
                Me.Hide()
                Application.Restart()
            Else
                MsgBox("Nastavení se nepodařilo Uložit / Zkontrolujte práva pro Zápis")
            End If
        End If
    End Sub


    Private Sub Form_config_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        My.Forms.form_carrier.Close()
        My.Forms.form_about.Hide()
        If Me.txt_company.Text = "" Then
            Me.cb_company_show.Enabled = False
        Else
            Me.cb_company_show.Enabled = True
        End If
        If Me.txt_spz_format.Text = "" Then
            Me.cb_auto_spz_corection.Enabled = False
        Else
            Me.cb_auto_spz_corection.Enabled = True
        End If

        load_delivery_note_line()
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub


    Private Sub form_config_escaped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            Me.Close()
        End If
    End Sub


    Private Sub btn_connection_text_Click(sender As Object, e As EventArgs) Handles btn_connection_text.Click
        'Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection("Data Source=" + Me.txt_db_name.Text + ";Initial Catalog=" + Me.txt_db_name.Text + ";Persist Security Info=True;User ID=" + Me.txt_db_loginname.Text + ";Password=" + Me.txt_db_password.Text + "")
        'Dim cmd As New System.Data.SqlClient.SqlCommand(query, sqlConnection_string)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection("Data Source=" + Me.txt_serverSQL.Text + ";Initial Catalog=" + Me.txt_db_name.Text + ";Persist Security Info=True;User ID=" + Me.txt_db_loginname.Text + ";Password=" + Me.txt_db_password.Text + "")
            sqlConnection_string.Open()
            MsgBox("Připojení k Databázi proběhlo úspěšně")
            sqlConnection_string.Close()
        Catch
            MessageBox.Show("Připojení k Databázi se nezdařilo, opravte Konfiguraci")
        End Try
        Me.Cursor = Cursors.Default


        My.MySettings.Default.Item("sql_connection") = "Data Source=" + Me.txt_serverSQL.Text + ";Initial Catalog=" + Me.txt_db_name.Text + ";Persist Security Info=True;User ID=" + Me.txt_db_loginname.Text + ";Password=" + Me.txt_db_password.Text + ""
    End Sub

    Private Sub lbl_dn_name_Click(sender As Object, e As EventArgs) Handles lbl_dn_name.Click

    End Sub

    Private Sub txt_time_interval_TextChanged(sender As Object, e As EventArgs) Handles txt_time_interval.TextChanged

    End Sub

    Private Sub lbl_password_Click(sender As Object, e As EventArgs) Handles lbl_password.Click

    End Sub

    Private Sub lbl_description_Click(sender As Object, e As EventArgs) Handles lbl_description.Click

    End Sub



    Private Sub txt_company_TextChanged(sender As Object, e As EventArgs) Handles txt_company.TextChanged
        If Me.txt_company.Text = "" Then
            Me.cb_company_show.Enabled = False
        Else
            Me.cb_company_show.Enabled = True
        End If
    End Sub



    Private Sub txt_spz_format_TextChanged(sender As Object, e As EventArgs) Handles txt_spz_format.TextChanged
        If Me.txt_spz_format.Text = "" Then
            Me.cb_auto_spz_corection.Enabled = False
        Else
            Me.cb_auto_spz_corection.Enabled = True
        End If
    End Sub



    Private Sub ch_int_spz_detect_CheckedChanged(sender As Object, e As EventArgs) Handles ch_int_spz_detect.CheckedChanged
        If ch_int_spz_detect.Checked = False Then
            txt_cam_spz_detection.Enabled = False
        Else
            txt_cam_spz_detection.Enabled = True
        End If
    End Sub



    Private Sub dgw_delivery_note_number_CellContentClick(sender As Object, e As EventArgs) Handles dgw_delivery_note_number.CurrentCellChanged
        Try
            delivery_note_check()
            If Me.dgw_delivery_note_number.Rows.Item(Me.dgw_delivery_note_number.CurrentCellAddress.Y).Cells(4).Value <> "1" Then
                If Me.dgw_delivery_note_number.CurrentCellAddress.X = 2 Or Me.dgw_delivery_note_number.CurrentCellAddress.X = 3 Then
                    Me.dt_date_selection.Location = New Point(Me.dgw_delivery_note_number.GetCellDisplayRectangle(Me.dgw_delivery_note_number.CurrentCellAddress.X, Me.dgw_delivery_note_number.CurrentCellAddress.Y, False).Left + Me.dgw_delivery_note_number.Left, Me.dgw_delivery_note_number.GetCellDisplayRectangle(Me.dgw_delivery_note_number.CurrentCellAddress.X, Me.dgw_delivery_note_number.CurrentCellAddress.Y, False).Bottom + Me.dgw_delivery_note_number.Top)
                    Me.dt_date_selection.Visible = True
                Else
                    Me.dt_date_selection.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dt_date_selection_ValueChanged(sender As Object, e As EventArgs) Handles dt_date_selection.ValueChanged
        Me.dgw_delivery_note_number.CurrentCell.Value = Format(Me.dt_date_selection.Value, "dd.MM.yyyy")
        Me.dt_date_selection.Visible = False
    End Sub


End Class