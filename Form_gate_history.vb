Imports System.Data.SqlClient

Public Class frm_gate_history

    Private Sub frm_gate_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'App_PORTERDataSet1.Gateway_Record'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        'Me.Gateway_RecordTableAdapter.Fill(Me.App_PORTERDataSet1.Gateway_Record)

        'Dim query As String = "SELECT brana, dopravce, spz, [Příjezd], [Čas Příjezdu], Odjezd, [Čas Odjezdu], dokument, [Snímek Příjezdu], [Snímek Odjezdu],[ID Záznamu],poznamka,carrier_name,destination FROM dbo.Gateway_Record ORDER BY insert_date DESC"
        'Dim adapter As New SqlDataAdapter(query, My.Settings.sql_connection)
        'Dim table As New System.Data.DataTable()
        'adapter.Fill(table)
        'Me.GatewayRecordBindingSource2.DataSource = table
        'Try
        '    Me.App_PORTERDataSet1.Gateway_Record.Load(Me.GatewayRecordBindingSource2.DataSource)
        '    Me.Gateway_RecordTableAdapter.Fill(table)
        'Catch ex As Exception
        'End Try

        My.Forms.Form_config.Hide()
        My.Forms.form_about.Hide()
        fn_sql_request("SELECT id,name FROM dbo.dial_gateway ORDER BY name ASC", "SELECT", 2)
        If My.Forms.Main_form.sql_array_count > 0 Then
            Me.cb_gate_filter.Items.Clear()
            Me.cb_gate_filter.Items.Add("Všechny")
            Me.cb_gate_filter.SelectedItem = "Všechny"
            For row As Integer = 0 To My.Forms.Main_form.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(My.Forms.Main_form.sql_array((row - 1), 1).Length))
                    Me.cb_gate_filter.Items.Add(My.Forms.Main_form.sql_array((row - 1), 1))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        End If

        For Each Row As DataGridViewRow In Me.dgw_list.Rows
            If Row.Index >= 0 Then
                If Me.dgw_list.Rows.Item(Row.Index).Cells.Item(11).Value.ToString.Length > 0 Then
                    Me.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    Me.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next
        Me.cb_income_mark.SelectedItem = "="
        Me.cb_outcome_mark.SelectedItem = "="
    End Sub



    Private Sub form_gate_history_keypressing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim status = False

        For Each Row As DataGridViewRow In Me.dgw_list.Rows
            If Row.Visible = True Then
                status = True
                Exit For
            End If
        Next

        If AscW(e.KeyChar) = 27 Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            My.Forms.Main_form.Show()
            My.Forms.Main_form.Focus()
            parent_form = ""
            Me.Close()
        End If

        If AscW(e.KeyChar) = 13 And status = True Then
            My.Forms.Main_form.dgw_record_id = Me.dgw_list.Rows.Item(Me.dgw_list.CurrentCell.RowIndex).Cells.Item(10).Value
            parent_form = "Form_gate_history"
            Me.Controls.Owner.Enabled = False
            My.Forms.form_record_note.Show()
            My.Forms.form_record_note.Focus()
        End If

    End Sub

    Private Sub dgw_history_rec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgw_list.KeyDown
        Dim status = False

        For Each Row As DataGridViewRow In Me.dgw_list.Rows
            If Row.Visible = True Then
                status = True
                Exit For
            End If
        Next

        If e.KeyCode = Keys.Enter And status = True Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F1 And status = True Then
            Me.Controls.Owner.Enabled = False
            parent_form = "Form_gate_history"
            My.Forms.form_picture_preview.Show()
            My.Forms.form_picture_preview.Focus()
            If Me.dgw_list.Item("picture1", Me.dgw_list.CurrentCell.RowIndex).Value.ToString.Length > 0 Then
                Dim myIMGCell As New DataGridViewImageCell
                myIMGCell = Me.dgw_list.Item("picture1", Me.dgw_list.CurrentCell.RowIndex)
                My.Forms.form_picture_preview.psx_preview.Image = byteArrayToImage(myIMGCell.Value)
                My.Forms.form_picture_preview.psx_preview.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If

        If e.KeyCode = Keys.F2 And status = True Then
            Me.Controls.Owner.Enabled = False
            parent_form = "Form_gate_history"
            My.Forms.form_picture_preview.Show()
            My.Forms.form_picture_preview.Focus()

            If Me.dgw_list.Item("picture2", Me.dgw_list.CurrentCell.RowIndex).Value.ToString.Length > 0 Then
                Dim myIMGCell As New DataGridViewImageCell
                myIMGCell = Me.dgw_list.Item("picture2", Me.dgw_list.CurrentCell.RowIndex)
                My.Forms.form_picture_preview.psx_preview.Image = byteArrayToImage(myIMGCell.Value)
                My.Forms.form_picture_preview.psx_preview.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If

    End Sub


    Private Sub frm_gate_history_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        parent_form = ""
        My.Forms.Main_form.Controls.Owner.Enabled = True
        My.Forms.Main_form.Show()
        My.Forms.Main_form.Focus()
    End Sub


    Private Sub btn_clear_spz_Click(sender As Object, e As EventArgs) Handles btn_clear_spz.Click
        Me.tb_spz_filter.Text = ""
    End Sub


    Private Sub btn_clear_document_filter_Click(sender As Object, e As EventArgs) Handles btn_clear_document_filter.Click
        Me.tb_document_filter.Text = ""
    End Sub


    Private Sub btx_carrier_filter_clear_Click(sender As Object, e As EventArgs) Handles btx_carrier_filter_clear.Click
        Me.txt_carrier_filter.Text = ""
    End Sub


    Private Sub btn_clear_carrier_name_Click(sender As Object, e As EventArgs) Handles btn_clear_carrier_name.Click
        Me.txt_carrier_name.Text = ""
    End Sub

    Private Sub btn_destination_Click(sender As Object, e As EventArgs) Handles btn_destination.Click
        Me.txt_destination.Text = ""
    End Sub





    Private Sub dgw_history_rec_sorted(ByVal sender As Object, ByVal e As EventArgs) Handles dgw_list.Sorted
        Dim checked As Boolean

        Dim filter_history = False
        Me.dgw_list.CurrentCell = Nothing
        For Each Row As DataGridViewRow In Me.dgw_list.Rows
            checked = False
            If Row.Index >= 0 Then
                If ((InStr(UCase(Row.Cells(7).Value().ToString), UCase(Me.tb_document_filter.Text)) <> 0 Or Me.tb_document_filter.Text.Length = 0) And
                    InStr(UCase(Row.Cells(2).Value().ToString), UCase(Me.tb_spz_filter.Text)) <> 0 And
                    ((Me.cb_gate_filter.SelectedItem.ToString = "Všechny") Or (InStr(Row.Cells(0).Value().ToString, Me.cb_gate_filter.SelectedItem.ToString) <> 0)) And
                    InStr(UCase(Row.Cells(1).Value().ToString), UCase(Me.txt_carrier_filter.Text)) <> 0 And
                    (InStr(UCase(Row.Cells(12).Value().ToString), UCase(Me.txt_carrier_name.Text)) Or Me.txt_carrier_name.Text.Length = 0) And
                    (InStr(UCase(Row.Cells(13).Value().ToString), UCase(Me.txt_destination.Text)) Or Me.txt_destination.Text.Length = 0)
                    ) Then
                    If Me.dt_income_date_filter.Value.ToShortDateString = Today Then
                        Row.Visible = True
                    Else
                        If Row.Cells(3).Value().ToString.Length > 0 Then
                            If Row.Cells(3).Value() = Me.dt_income_date_filter.Value.ToShortDateString Then
                                checked = True
                                Row.Visible = True
                            End If
                        End If

                        If Row.Cells(5).Value().ToString.Length > 0 And checked = False Then
                            If Row.Cells(5).Value() = Me.dt_income_date_filter.Value.ToShortDateString Then
                                checked = True
                                Row.Visible = True
                            End If
                        End If

                        If checked = False Then Row.Visible = False
                    End If
                Else
                    Row.Visible = False
                End If
            End If

            If Row.Index >= 0 Then
                If Me.dgw_list.Rows.Item(Row.Index).Cells.Item(11).Value.ToString.Length > 0 Then
                    Me.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    Me.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next

    End Sub


    Private Sub cb_all_records_CheckedChanged(sender As Object, e As EventArgs) Handles cb_all_records.CheckedChanged
        If cb_all_records.Checked = True Then
            dud_date_binding.Enabled = False
            dt_income_date_filter.Checked = False
            dt_income_date_filter.Enabled = False
            dt_outcome_date_filter.Enabled = False
            cb_income_mark.Enabled = False
            cb_outcome_mark.Enabled = False
        Else
            dt_income_date_filter.Enabled = True
            dt_income_date_filter.Checked = True
            cb_income_mark.Enabled = True
            'cb_income_mark.SelectedItem = "="
            dt_outcome_date_filter.Enabled = True
            cb_outcome_mark.Enabled = True
            'cb_outcome_mark.SelectedItem = "="
            If dt_income_date_filter.Checked = True And dt_outcome_date_filter.Checked = True Then
                dud_date_binding.Enabled = True
                '    dud_date_binding.SelectedItem = "AND"
            End If

        End If
    End Sub


    Private Sub chb_Income_date_CheckedChanged(sender As Object, e As EventArgs) Handles dt_income_date_filter.ValueChanged
        If dt_income_date_filter.Checked = True Then
            dt_income_date_filter.Enabled = True
            cb_income_mark.Enabled = True
            cb_income_mark.SelectedItem = "="
            If dt_outcome_date_filter.Checked = True Then
                dud_date_binding.Enabled = True
                dud_date_binding.SelectedItem = "AND"
            End If

        Else
            dud_date_binding.Enabled = False
            cb_income_mark.Enabled = False
            If dt_outcome_date_filter.Checked = False Then cb_all_records.Checked = True
        End If
    End Sub



    Private Sub chb_outcome_date_CheckedChanged(sender As Object, e As EventArgs) Handles dt_outcome_date_filter.ValueChanged
        If dt_outcome_date_filter.Checked = True Then
            dt_outcome_date_filter.Enabled = True
            cb_outcome_mark.Enabled = True
            cb_outcome_mark.SelectedItem = "="
            If dt_income_date_filter.Checked = True Then
                dud_date_binding.Enabled = True
                dud_date_binding.SelectedItem = "AND"
            End If

        Else
            dud_date_binding.Enabled = False
            cb_outcome_mark.Enabled = False
            If dt_income_date_filter.Checked = False Then cb_all_records.Checked = True
        End If
    End Sub


    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        filter_history()
    End Sub
End Class
