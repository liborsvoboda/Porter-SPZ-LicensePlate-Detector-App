Public Class form_record_note
    Public record_id As Integer

    Private Sub btn_only_close_Click(sender As Object, e As EventArgs) Handles btn_only_close.Click
        If parent_form = "Main_form" Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            parent_form = ""
            My.Forms.Main_form.Show()
            My.Forms.Main_form.Focus()
        End If

        If parent_form = "Form_gate_history" Then
            My.Forms.frm_gate_history.Controls.Owner.Enabled = True
            My.Forms.frm_gate_history.Show()
            My.Forms.frm_gate_history.Focus()
        End If
        Me.Close()

    End Sub


    Private Sub form_carrier_escaped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then
            If parent_form = "Main_form" Then
                My.Forms.Main_form.Controls.Owner.Enabled = True
                parent_form = ""
                My.Forms.Main_form.Show()
                My.Forms.Main_form.Focus()
            End If
            If parent_form = "Form_gate_history" Then
                My.Forms.frm_gate_history.Controls.Owner.Enabled = True
                My.Forms.frm_gate_history.Show()
                My.Forms.frm_gate_history.Focus()
            End If
            Me.Close()
        End If
    End Sub


    Private Sub form_record_note_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.record_id = My.Forms.Main_form.dgw_record_id
        Me.Text = "HISTORIE ZÁZNAMU - Založení Poznámky k ID_záznamu: " + Me.record_id.ToString
        fn_sql_request("SELECT rec_gate.movement_type_id,'gate_name'  = ISNULL((SELECT name FROM dbo.dial_gateway WHERE id = rec_gate.gateway_id),''), 'carrier_name' = ISNULL((SELECT name FROM dbo.dial_carrier WHERE id = rec_gate.carrier_id),''), CONVERT(VARCHAR(10),rec_gate.movement_date,104), CONVERT(VARCHAR,rec_gate.movement_time,8), rec_gate.document_nr, rec_gate.number_plate, rec_gate.[status], rec_gate.carrier_name, rec_gate.destination,id FROM dbo.record_gateway_movement rec_gate WHERE rec_gate.id =  '" + CStr(Me.record_id) + "' OR rec_gate.parent_rec_id= '" + CStr(Me.record_id) + "' ORDER BY rec_gate.movement_type_id ASC", "SELECT", 11)
        If My.Forms.Main_form.sql_array_count > 0 Then

            If My.Forms.Main_form.sql_array_count = 1 Then
                If Me.txt_outgoing_id.Text.Length = 0 Then bnt_outgoing_save.Enabled = False
            End If

            For row As Integer = 0 To My.Forms.Main_form.sql_array_count Step 1
                Try
                    If (My.Forms.Main_form.sql_array((row), 0)) = 1 Then
                        Me.txt_gate_in.Text = CStr((My.Forms.Main_form.sql_array((row), 1)))
                        Me.txt_carrier_in.Text = CStr((My.Forms.Main_form.sql_array((row), 2)))
                        Me.txt_date_in.Text = CStr((My.Forms.Main_form.sql_array((row), 3)))
                        Me.txt_time_in.Text = CStr((My.Forms.Main_form.sql_array((row), 4)))
                        Me.txt_dodl_in.Text = CStr((My.Forms.Main_form.sql_array((row), 5)))
                        Me.txt_spz_in.Text = CStr((My.Forms.Main_form.sql_array((row), 6)))
                        If CStr((My.Forms.Main_form.sql_array((row), 7))) = "cancel" Then
                            Me.lbl_status_in.Visible = True
                        Else
                            Me.lbl_status_in.Visible = False
                        End If
                        Me.txt_name_in.Text = CStr((My.Forms.Main_form.sql_array((row), 8)))
                        Me.txt_way_target_in.Text = CStr((My.Forms.Main_form.sql_array((row), 9)))
                        Me.txt_incoming_id.Text = CStr((My.Forms.Main_form.sql_array((row), 10)))
                    End If
                    If (My.Forms.Main_form.sql_array((row), 0)) = 2 Then
                        Me.txt_gate_out.Text = CStr((My.Forms.Main_form.sql_array((row), 1)))
                        Me.txt_carrier_out.Text = CStr((My.Forms.Main_form.sql_array((row), 2)))
                        Me.txt_date_out.Text = CStr((My.Forms.Main_form.sql_array((row), 3)))
                        Me.txt_time_out.Text = CStr((My.Forms.Main_form.sql_array((row), 4)))
                        Me.txt_dodl_out.Text = CStr((My.Forms.Main_form.sql_array((row), 5)))
                        Me.txt_spz_out.Text = CStr((My.Forms.Main_form.sql_array((row), 6)))
                        If CStr((My.Forms.Main_form.sql_array((row), 7))) = "cancel" Then
                            Me.lbl_status_out.Visible = True
                        Else
                            Me.lbl_status_out.Visible = False
                        End If
                        Me.txt_name_out.Text = CStr((My.Forms.Main_form.sql_array((row), 8)))
                        Me.txt_way_target_out.Text = CStr((My.Forms.Main_form.sql_array((row), 9)))
                        Me.txt_outgoing_id.Text = CStr((My.Forms.Main_form.sql_array((row), 10)))
                    End If
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        End If

        fn_sql_request("SELECT * FROM [dbo].[gateway_record_note] WHERE parent_id = '" + CStr(record_id) + "' ORDER BY sequence DESC", "SELECT", 6)
        If My.Forms.Main_form.sql_array_count > 0 Then
            Me.txt_history_note.Clear()
            For row As Integer = 0 To My.Forms.Main_form.sql_array_count Step 1
                Try
                    Me.txt_history_note.Text = Me.txt_history_note.Text + CStr((My.Forms.Main_form.sql_array((row - 1), 4))) + vbNewLine + (My.Forms.Main_form.sql_array((row - 1), 3)) + vbNewLine + vbNewLine
                Catch ex As IndexOutOfRangeException
                End Try
            Next

        End If
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If Me.txt_note.Text.Length > 0 Then
            Dim query As String = "INSERT INTO [dbo].[gateway_record_note]  ([parent_id],[sequence],[note],[insert_date],[gate_id],[user_name]) VALUES ( '" + CStr(Me.record_id) + "',(ISNULL( 1 + (SELECT TOP 1 sequence FROM  [dbo].[gateway_record_note] WHERE parent_id = '" + CStr(record_id) + "' ORDER BY sequence DESC ),1)),'" + CStr(Me.txt_note.Text) + "',GETDATE(),'" + My.Forms.Form_config.txt_Gate_id.Text + "','" + My.Forms.Main_form.user.ToString + "')"
            If fn_sql_request(query, "INSERT", 0) = True Then

                If parent_form = "Main_form" Then
                    My.Forms.Main_form.Controls.Owner.Enabled = True
                    parent_form = ""
                    My.Forms.Main_form.Show()
                    My.Forms.Main_form.Focus()
                End If

                If parent_form = "Form_gate_history" Then
                    My.Forms.frm_gate_history.Controls.Owner.Enabled = True
                    My.Forms.frm_gate_history.Show()
                    'My.Forms.frm_gate_history.Focus()
                End If

                actual_data_fields()
                Me.Close()
            Else
                MsgBox("Poznámku nebylo možné uložit. Kontaktujte Vašeho správce IT")
            End If
        Else
            MsgBox("Nelze uložit prázdnou poznámku")
        End If
    End Sub


    Private Sub btn_income_save_Click(sender As Object, e As EventArgs) Handles btn_income_savebtn_income_save.Click
        Dim query As String = "UPDATE [dbo].[record_gateway_movement] SET document_nr = '" + Me.txt_dodl_in.Text + "' WHERE id = " + Me.txt_incoming_id.Text + " "
        If fn_sql_request(query, "UPDATE", 0) = True Then
            MessageBox.Show("Dodací list byl úspěšně uložen")
        Else
            MessageBox.Show("Dodací list se nepodařilo uložit")
        End If
    End Sub


    Private Sub bnt_outcome_save_Click(sender As Object, e As EventArgs) Handles bnt_outgoing_save.Click
        Dim query As String = "UPDATE [dbo].[record_gateway_movement] SET document_nr = '" + Me.txt_dodl_out.Text + "' WHERE id = " + Me.txt_outgoing_id.Text + " "
        If fn_sql_request(query, "UPDATE", 0) = True Then
            MessageBox.Show("Dodací list byl úspěšně uložen")
        Else
            MessageBox.Show("Dodací list se nepodařilo uložit")
        End If
    End Sub

End Class