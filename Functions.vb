Imports System.Data.SqlClient

Module functions

    Public parent_form As String
    Dim sql_temp As String
    Dim block_dgw_reaction As Boolean = False
    
    Function fn_set_record_type() As Boolean
        My.Forms.Main_form.dt_rec_date.Value = Date.Now
        Dim selected_move As String = ""

        If My.Forms.Main_form.rbtn_ingoing.Checked = True Then
            My.Forms.Main_form.txt_ingoing.Enabled = True
            My.Forms.Main_form.txt_outgoing.Enabled = False
            My.Forms.Main_form.rbtn_outgoing.Checked = False
            If My.Forms.Main_form.txt_outgoing.Text.Length > 0 Then
                My.Forms.Main_form.txt_ingoing.Text = My.Forms.Main_form.txt_outgoing.Text
            Else
                My.Forms.Main_form.txt_ingoing.Text = Format(Date.Now, "HH:mm:ss")
            End If
            My.Forms.Main_form.txt_outgoing.Text = ""
            selected_move = "ingoing"
        Else
            My.Forms.Main_form.txt_ingoing.Enabled = False
            My.Forms.Main_form.rbtn_outgoing.Checked = True
            My.Forms.Main_form.txt_outgoing.Enabled = True
            If My.Forms.Main_form.txt_ingoing.Text.Length > 0 Then
                My.Forms.Main_form.txt_outgoing.Text = My.Forms.Main_form.txt_ingoing.Text
            Else
                My.Forms.Main_form.txt_outgoing.Text = Format(Date.Now, "HH:mm:ss")
            End If

            My.Forms.Main_form.txt_ingoing.Text = ""
            selected_move = "outgoing"

        End If

        My.Forms.Main_form.parent_id = 0
        fn_sql_request("SELECT id FROM dbo.dial_movement_type where movement_type = '" + selected_move + "' and status = 'active' ", "SELECT", 1)
        My.Forms.Main_form.movement_type_id = My.Forms.Main_form.sql_array(0, 0)

        My.Forms.Main_form.btn_cancel.Enabled = False
    End Function

    Function fn_check_file(ByVal file As String) As Boolean
        fn_check_file = System.IO.File.Exists(file)
    End Function


    Function fn_create_file(ByVal file As String) As Boolean
        If Not System.IO.File.Exists(file) Then
            System.IO.File.Create(file).Close()
        End If

        If fn_check_file(file) = True Then
            fn_create_file = True
        Else
            fn_create_file = False
        End If
    End Function

    Function fn_delete_file(ByVal file As String) As Boolean
        System.IO.File.Delete(file)

        If fn_check_file(file) = False Then
            fn_delete_file = True
        Else
            fn_delete_file = False
        End If
    End Function


    Function Compare(ByVal str1 As String, ByVal str2 As String) As Double
        Dim count As Integer = If(str1.Length > str2.Length, str1.Length, str2.Length)
        Dim hits As Integer = 0
        Dim i, j As Integer : i = 0 : j = 0
        For i = 0 To str1.Length - 1
            If str1.Chars(i) = " " Then i += 1 : j = str2.IndexOf(" "c, j) + 1 : hits += 1
            While j < str2.Length AndAlso str2.Chars(j) <> " "c
                If str1.Chars(i) = str2.Chars(j) Then
                    hits += 1
                    j += 1
                    Exit While
                Else
                    j += 1
                End If
            End While
            If Not (j < str2.Length AndAlso str2.Chars(j) <> " "c) Then
                j -= 1
            End If
        Next
        Return Math.Round((hits / count), 2)
    End Function


    Function fn_load_setting() As Boolean
        fn_load_setting = False

        If fn_check_file(Application.StartupPath() + "\config.ini") = False Then
            MsgBox("Konfigurační soubor neexistuje, Proveďte konfiguraci")
        Else
            Dim objReader As New System.IO.StreamReader(Application.StartupPath() + "\config.ini", True)
            sql_temp = objReader.ReadLine()
            objReader.Close()
            Dim temp As String() = Split(sql_temp, "#")

            My.MySettings.Default.Item("sql_connection") = "Data Source=" + temp(1).ToString + ";Initial Catalog=" + temp(2).ToString + ";Persist Security Info=True;User ID=" + temp(3).ToString + ";Password=" + temp(4).ToString + ""

            If fn_sql_request("SELECT [id],[name],'description'=ISNULL([description],'NULL'),'time_interval'=ISNULL([time_interval],10),'status'=ISNULL([status],'active'),'cam_url'=ISNULL(cam_url,'NULL'),'cam_logname' = ISNULL(cam_logname,'NULL'),'cam_logpw'=ISNULL(cam_logpw,'NULL'),[autosave_picture] FROM dbo.dial_gateway WHERE id = " + temp(0).ToString + " ", "SELECT", 9) = False Then
                MsgBox("Zadané ID v konfiguračním souboru nebylo v DB nalezeno")
            Else

                Try

                    My.Forms.Form_config.txt_Gate_id.Text = temp(0).ToString()
                    My.Forms.Form_config.txt_serverSQL.Text = temp(1).ToString()
                    My.Forms.Form_config.txt_db_name.Text = temp(2).ToString()
                    My.Forms.Form_config.txt_db_loginname.Text = temp(3).ToString()
                    My.Forms.Form_config.txt_db_password.Text = temp(4).ToString()
                    My.Forms.Main_form.Arriving_VehiclesTableAdapter.GetData()
                    My.Forms.Form_config.txt_company.Text = temp(5).ToString
                    If (temp(6).ToString = "1") Then
                        My.Forms.Form_config.cb_company_show.Checked = True
                        My.Forms.Main_form.cb_company.Checked = True
                    Else
                        My.Forms.Form_config.cb_company_show.Checked = False
                        My.Forms.Main_form.cb_company.Checked = False
                    End If
                    My.Forms.Form_config.txt_spz_format.Text = temp(7).ToString
                    If (temp(8).ToString = "1") Then
                        My.Forms.Form_config.cb_auto_spz_corection.Checked = True
                    Else
                        My.Forms.Form_config.cb_auto_spz_corection.Checked = False
                    End If
                    My.Forms.Form_config.txt_cam_spz_detection.Text = temp(9).ToString

                    If (temp(10).ToString = "1") Then
                        My.Forms.Form_config.ch_int_spz_detect.Checked = True
                    Else
                        My.Forms.Form_config.ch_int_spz_detect.Checked = False
                        My.Forms.Form_config.txt_cam_spz_detection.Enabled = False
                    End If

                    If (temp(11).ToString = "1") Then
                        My.Forms.Form_config.chb_multiselect.Checked = True
                        My.Forms.frm_gate_history.dgw_list.MultiSelect = True
                    Else
                        My.Forms.Form_config.chb_multiselect.Checked = False
                        My.Forms.frm_gate_history.dgw_list.MultiSelect = False
                    End If


                Catch ex As Exception
                    MsgBox("Nastavení Aplikace není v pořádku." & vbNewLine & "Smažte soubor config.ini v adresáři aplikace a Program znovu nastavte.")
                End Try

                Try
                    My.Forms.Form_config.txt_Gate_id.Text = My.Forms.Main_form.sql_array(0, 0)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_gate_name.Text = My.Forms.Main_form.sql_array(0, 1)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_description.Text = My.Forms.Main_form.sql_array(0, 2)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_time_interval.Text = My.Forms.Main_form.sql_array(0, 3)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_url.Text = My.Forms.Main_form.sql_array(0, 5)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_cam_logname.Text = My.Forms.Main_form.sql_array(0, 6)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.txt_cam_logpw.Text = My.Forms.Main_form.sql_array(0, 7)
                Catch ex As Exception
                End Try
                Try
                    My.Forms.Form_config.chb_autostatus.Checked = My.Forms.Main_form.sql_array(0, 8)
                Catch ex As Exception
                End Try

                'If My.Forms.Main_form.sql_array(0, 4) = "active" Then
                '    My.Forms.Form_config.chb_autostatus.Checked = True
                '    My.Forms.Main_form.Controls.Owner.Enabled = True
                'Else
                '    My.Forms.Form_config.chb_autostatus.Checked = False
                '    My.Forms.Main_form.Controls.Owner.Enabled = False
                'End If


                fn_load_setting = True

            End If
        End If

    End Function



    Function fn_save_file_setting(ByVal filename As String) As Boolean
        fn_delete_file(filename)
        fn_create_file(filename)
        Dim objWriter As New System.IO.StreamWriter(filename, True)
        objWriter.WriteLine(My.Forms.Form_config.txt_Gate_id.Text + "#" + My.Forms.Form_config.txt_serverSQL.Text + "#" + My.Forms.Form_config.txt_db_name.Text + "#" + My.Forms.Form_config.txt_db_loginname.Text + "#" + My.Forms.Form_config.txt_db_password.Text + "#" + My.Forms.Form_config.txt_company.Text + "#" + CStr(My.Forms.Form_config.cb_company_show.CheckState) + "#" + My.Forms.Form_config.txt_spz_format.Text + "#" + CStr(My.Forms.Form_config.cb_auto_spz_corection.CheckState) + "#" + CStr(My.Forms.Form_config.txt_cam_spz_detection.Text) + "#" + CStr(My.Forms.Form_config.ch_int_spz_detect.CheckState) + "#" + CStr(My.Forms.Form_config.chb_multiselect.CheckState))
        objWriter.Close()
        fn_save_file_setting = True
    End Function


    Function fn_set_actual_time(ByVal rec_time As String) As Boolean
        If My.Forms.Main_form.txt_outgoing.Enabled = True Then
            If rec_time = "" Then
                My.Forms.Main_form.txt_outgoing.Text = Format(Date.Now, "HH:mm:ss")
            Else
                My.Forms.Main_form.txt_outgoing.Text = Format(Date.Parse(rec_time), "h:mm:ss")
            End If

        Else
            If rec_time = "" Then
                My.Forms.Main_form.txt_ingoing.Text = Format(Date.Now, "HH:mm:ss")
            Else
                My.Forms.Main_form.txt_ingoing.Text = Format(Date.Parse(rec_time), "h:mm:ss")
            End If
        End If
        My.Forms.Main_form.btn_cancel.Enabled = False
        actual_data_fields()
    End Function


    Function fn_movement_form_check() As Boolean
        fn_movement_form_check = True

        If My.Forms.Main_form.rbtn_ingoing.Checked = True And My.Forms.Main_form.txt_destination.Text = "" Then
            fn_movement_form_check = False
            My.Forms.Main_form.txt_destination.BackColor = Color.PaleVioletRed
            My.Forms.Main_form.txt_destination.Focus()
        Else
            My.Forms.Main_form.txt_destination.BackColor = Color.White
        End If

        If My.Forms.Main_form.lst_carrier.Text = "" Then
            fn_movement_form_check = False
            My.Forms.Main_form.lst_carrier.BackColor = Color.PaleVioletRed
            My.Forms.Main_form.lst_carrier.Focus()
        Else
            My.Forms.Main_form.lst_carrier.BackColor = Color.White
        End If
        If fn_sql_request("SELECT id,name FROM dbo.dial_carrier WHERE name = '" + My.Forms.Main_form.lst_carrier.Text + "'", "SELECT", 2) = False Then
            fn_movement_form_check = False
            My.Forms.Main_form.lst_carrier.BackColor = Color.PaleVioletRed
            My.Forms.Main_form.lst_carrier.Focus()
        End If

        If My.Forms.Main_form.txt_spz_field.Text = "" Then
            fn_movement_form_check = False
            My.Forms.Main_form.txt_spz_field.BackColor = Color.PaleVioletRed
            My.Forms.Main_form.txt_spz_field.Focus()
        Else
            My.Forms.Main_form.txt_spz_field.BackColor = Color.White
        End If
        My.Forms.Main_form.btn_cancel.Enabled = False
        actual_data_fields()
    End Function


    Function fn_clean_movement_form() As Boolean
        My.Forms.Main_form.lst_carrier.BackColor = Color.White
        My.Forms.Main_form.lst_carrier.Items.Clear()
        fn_sql_request("SELECT id,name FROM dbo.dial_carrier ", "SELECT", 2)
        If My.Forms.Main_form.sql_array_count > 0 Then
            For row As Integer = 0 To My.Forms.Main_form.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(My.Forms.Main_form.sql_array((row - 1), 1).Length))
                    My.Forms.Main_form.lst_carrier.Items.Add(My.Forms.Main_form.sql_array((row - 1), 1))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        End If
        My.Forms.Main_form.lst_carrier.Text = ""
        My.Forms.Main_form.txt_spz_field.BackColor = Color.White
        My.Forms.Main_form.txt_spz_field.Text = ""
        My.Forms.Main_form.txt_delivery_no.Text = ""
        My.Forms.Main_form.pcx_screenshot.Image = Nothing
        My.Forms.Main_form.dt_rec_date.Text = Date.Now
        My.Forms.Main_form.rbtn_outgoing.Checked = False
        My.Forms.Main_form.rbtn_ingoing.Checked = True
        My.Forms.Main_form.txt_outgoing.Text = ""
        My.Forms.Main_form.txt_carrier_name.Text = ""
        My.Forms.Main_form.txt_destination.Text = ""
        My.Forms.Main_form.txt_outgoing.Enabled = False
        My.Forms.Main_form.txt_ingoing.Enabled = True
        My.Forms.Main_form.txt_ingoing.Text = Format(Date.Now, "HH:mm:ss")
        fn_sql_request("SELECT id FROM dbo.dial_movement_type where movement_type = 'ingoing' and status = 'active' ", "SELECT", 1)
        My.Forms.Main_form.movement_type_id = My.Forms.Main_form.sql_array(0, 0)
        fn_set_record_type()

        My.Forms.Main_form.btn_use_spz.Enabled = True
        My.Forms.Main_form.rbtn_ingoing.Enabled = True
        My.Forms.Main_form.txt_spz_field.ReadOnly = False
        'My.Forms.Main_form.lst_carrier.DropDownStyle = ComboBoxStyle.DropDown

        My.Forms.Main_form.parent_id = 0
        My.Forms.Main_form.btn_cancel.Enabled = False
        actual_data_fields()
        'My.Forms.Main_form.txt_spz_field.Focus()
    End Function


    Function fn_clean_outgoing_movement_form() As Boolean
        My.Forms.Main_form.lst_carrier.BackColor = Color.White
        My.Forms.Main_form.lst_carrier.Items.Clear()
        fn_sql_request("SELECT id,name FROM dbo.dial_carrier ", "SELECT", 2)
        If My.Forms.Main_form.sql_array_count > 0 Then
            For row As Integer = 0 To My.Forms.Main_form.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(My.Forms.Main_form.sql_array((row - 1), 1).Length))
                    My.Forms.Main_form.lst_carrier.Items.Add(My.Forms.Main_form.sql_array((row - 1), 1))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        End If
        My.Forms.Main_form.lst_carrier.Text = ""
        My.Forms.Main_form.txt_spz_field.BackColor = Color.White
        My.Forms.Main_form.txt_spz_field.Text = ""
        My.Forms.Main_form.txt_delivery_no.Text = ""
        My.Forms.Main_form.dt_rec_date.Text = Date.Now
        My.Forms.Main_form.rbtn_outgoing.Checked = True
        My.Forms.Main_form.rbtn_ingoing.Checked = False
        My.Forms.Main_form.txt_outgoing.Text = Format(Date.Now, "HH:mm:ss")
        My.Forms.Main_form.txt_outgoing.Enabled = True
        My.Forms.Main_form.txt_ingoing.Enabled = False
        My.Forms.Main_form.txt_ingoing.Text = ""
        My.Forms.Main_form.txt_carrier_name.Text = ""
        My.Forms.Main_form.txt_destination.Text = ""
        fn_sql_request("SELECT id FROM dbo.dial_movement_type where movement_type = 'outgoing' and status = 'active' ", "SELECT", 1)
        My.Forms.Main_form.movement_type_id = My.Forms.Main_form.sql_array(0, 0)
        fn_set_record_type()
        My.Forms.Main_form.btn_cancel.Enabled = False
        'My.Forms.Main_form.txt_spz_field.Focus()
        actual_data_fields()
    End Function



    Function fn_get_arrived_vehicle(ByVal selected_array_id As Integer) As Boolean
        My.Forms.Main_form.txt_spz_field.Text = UCase(My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(2).Value())
        My.Forms.Main_form.lst_carrier.Items.Clear()
        'My.Forms.Main_form.lst_carrier.DropDownStyle = ComboBoxStyle.DropDownList
        My.Forms.Main_form.lst_carrier.Items.Add(My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(0).Value())
        My.Forms.Main_form.lst_carrier.Text = My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(0).Value()
        My.Forms.Main_form.txt_delivery_no.Text = My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(5).Value()
        My.Forms.Main_form.parent_id = My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(7).Value()
        If My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(1).Value.ToString.Length > 0 Then My.Forms.Main_form.txt_carrier_name.Text = My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(selected_array_id).Cells.Item(1).Value()
        My.Forms.Main_form.btn_use_spz.Enabled = False
        My.Forms.Main_form.rbtn_ingoing.Enabled = False
        My.Forms.Main_form.txt_spz_field.ReadOnly = True

        My.Forms.Main_form.btn_cancel.Enabled = True
        'actual_data_fields()
    End Function


    Function actual_data_fields() As Boolean
        Dim first_row = True
        My.Forms.Main_form.gw_Arriving_Vehicles.DataSource = My.Forms.Main_form.Arriving_VehiclesTableAdapter.GetData()
        My.Forms.Main_form.gw_Arriving_Vehicles.CurrentCell = Nothing
        For Each Row As DataGridViewRow In My.Forms.Main_form.gw_Arriving_Vehicles.Rows

            Row.Visible = True
            If (My.Forms.Main_form.cb_company.Checked = True And My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0).Value = My.Forms.Form_config.txt_company.Text) Or (My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0).Value <> My.Forms.Form_config.txt_company.Text) Then
                If first_row = True Then
                    My.Forms.Main_form.gw_Arriving_Vehicles.CurrentCell = My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0)
                    first_row = False
                End If
            Else
                Row.Visible = False
            End If
            If Row.Index >= 0 Then
                If My.Forms.Main_form.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(9).Value.ToString.Length > 0 Then
                    My.Forms.Main_form.gw_Arriving_Vehicles.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    My.Forms.Main_form.gw_Arriving_Vehicles.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next


        actual_data_fields = True
    End Function




    Function filter_history() As Boolean
        My.Forms.frm_gate_history.Cursor = Cursors.WaitCursor
        Dim sql_where_cmd As String = "WHERE ( 1 = 1  "
        Dim date_parts()
        filter_history = False

        Dim query As String = "SELECT brana, dopravce, spz, [Příjezd], [Čas Příjezdu], Odjezd, [Čas Odjezdu], dokument, [Snímek Příjezdu], [Snímek Odjezdu],[ID Záznamu],poznamka,carrier_name,destination FROM dbo.Gateway_Record "

        If My.Forms.frm_gate_history.cb_all_records.Checked = True Then

        Else
            If My.Forms.frm_gate_history.dud_date_binding.Enabled = True Then
                sql_where_cmd &= " AND ( "
            Else
                sql_where_cmd &= " AND "
            End If


            If My.Forms.frm_gate_history.dt_income_date_filter.Checked = True Then
                date_parts = Split(My.Forms.frm_gate_history.dt_income_date_filter.Value.ToShortDateString, ".")
                If date_parts(1).ToString.Length = 1 Then date_parts(1) = "0" + date_parts(1)
                If date_parts(0).ToString.Length = 1 Then date_parts(0) = "0" + date_parts(0)
                'MsgBox(date_parts(2) + date_parts(1) + date_parts(0))

                sql_where_cmd &= " CONVERT(DATE,CONVERT(VARCHAR(10),Příjezd,112)) " + My.Forms.frm_gate_history.cb_income_mark.SelectedItem + " '" + date_parts(2) + date_parts(1) + date_parts(0) + "' "
            End If

            If My.Forms.frm_gate_history.dud_date_binding.Enabled = True Then sql_where_cmd &= My.Forms.frm_gate_history.dud_date_binding.SelectedItem

            If My.Forms.frm_gate_history.dt_outcome_date_filter.Checked = True Then
                date_parts = Split(My.Forms.frm_gate_history.dt_outcome_date_filter.Value.ToShortDateString, ".")
                If date_parts(1).ToString.Length = 1 Then date_parts(1) = "0" + date_parts(1)
                If date_parts(0).ToString.Length = 1 Then date_parts(0) = "0" + date_parts(0)
                'MsgBox(date_parts(2) + date_parts(1) + date_parts(0))

                sql_where_cmd &= " CONVERT(DATE,CONVERT(VARCHAR(10),Odjezd,112)) " + My.Forms.frm_gate_history.cb_outcome_mark.SelectedItem + " '" + date_parts(2) + date_parts(1) + date_parts(0) + "' "
            End If
            If My.Forms.frm_gate_history.dud_date_binding.Enabled = True Then sql_where_cmd &= " ) "

        End If



        If My.Forms.frm_gate_history.cb_gate_filter.SelectedItem.ToString <> "Všechny" Then
            sql_where_cmd = sql_where_cmd + " AND brana = '" + My.Forms.frm_gate_history.cb_gate_filter.SelectedItem.ToString + "' "
        End If



        If My.Forms.frm_gate_history.txt_carrier_filter.Text.Length > 0 Then
            sql_where_cmd = sql_where_cmd + " AND UPPER(dopravce) like '%" + UCase(My.Forms.frm_gate_history.txt_carrier_filter.Text) + "%' "
        End If



        If My.Forms.frm_gate_history.tb_spz_filter.Text.Length > 0 Then
            sql_where_cmd = sql_where_cmd + " AND UPPER(spz) like '%" + UCase(My.Forms.frm_gate_history.tb_spz_filter.Text) + "%' "
        End If

        If My.Forms.frm_gate_history.tb_document_filter.Text.Length > 0 Then
            sql_where_cmd = sql_where_cmd + " AND UPPER(dokument) like '%" + UCase(My.Forms.frm_gate_history.tb_document_filter.Text) + "%' "
        End If

        If My.Forms.frm_gate_history.txt_carrier_name.Text.Length > 0 Then
            sql_where_cmd = sql_where_cmd + " AND UPPER(carrier_name) like '%" + UCase(My.Forms.frm_gate_history.txt_carrier_name.Text) + "%' "
        End If

        If My.Forms.frm_gate_history.txt_destination.Text.Length > 0 Then
            sql_where_cmd = sql_where_cmd + " AND UPPER(destination) like '%" + UCase(My.Forms.frm_gate_history.txt_destination.Text) + "%' "
        End If

        sql_where_cmd = sql_where_cmd + " AND 1 = 1 ) ORDER BY insert_date DESC "

        If My.Forms.Form_config.chb_sql_debugger.Checked = True Then MessageBox.Show(query + sql_where_cmd)

        MessageBox.Show(query + sql_where_cmd)

        Dim adapter As New SqlDataAdapter(query + sql_where_cmd, My.Settings.sql_connection)
        Dim table As New System.Data.DataTable()
        Try
            adapter.Fill(table)
            My.Forms.frm_gate_history.GatewayRecordBindingSource2.DataSource = table
            My.Forms.frm_gate_history.App_PORTERDataSet1.Gateway_Record.Load(My.Forms.frm_gate_history.GatewayRecordBindingSource2.DataSource)
            My.Forms.frm_gate_history.Gateway_RecordTableAdapter.Fill(table)

        Catch ex As Exception
            My.Forms.frm_gate_history.Cursor = Cursors.Default
        End Try



        'My.Forms.frm_gate_history.dgw_history_rec.CurrentCell = Nothing
        'For Each Row As DataGridViewRow In My.Forms.frm_gate_history.dgw_history_rec.Rows
        '    checked = False
        '    If Row.Index >= 0 Then
        '        If ((InStr(UCase(Row.Cells(7).Value().ToString), UCase(My.Forms.frm_gate_history.tb_document_filter.Text)) <> 0 Or My.Forms.frm_gate_history.tb_document_filter.Text.Length = 0) And
        '            InStr(UCase(Row.Cells(2).Value().ToString), UCase(My.Forms.frm_gate_history.tb_spz_filter.Text)) <> 0 And
        '            ((My.Forms.frm_gate_history.cb_gate_filter.SelectedItem.ToString = "Všechny") Or (InStr(Row.Cells(0).Value().ToString, My.Forms.frm_gate_history.cb_gate_filter.SelectedItem.ToString) <> 0)) And
        '            InStr(UCase(Row.Cells(1).Value().ToString), UCase(My.Forms.frm_gate_history.txt_carrier_filter.Text)) <> 0 And
        '            (InStr(UCase(Row.Cells(12).Value().ToString), UCase(My.Forms.frm_gate_history.txt_carrier_name.Text)) Or My.Forms.frm_gate_history.txt_carrier_name.Text.Length = 0) And
        '            (InStr(UCase(Row.Cells(13).Value().ToString), UCase(My.Forms.frm_gate_history.txt_destination.Text)) Or My.Forms.frm_gate_history.txt_destination.Text.Length = 0)
        '            ) Then

        '            If My.Forms.frm_gate_history.cb_all_records.Checked = True Then
        '                'If My.Forms.frm_gate_history.dt_date_filter.Value.ToShortDateString = Today Then
        '                Row.Visible = True
        '            Else
        '                If Row.Cells(3).Value().ToString.Length > 0 Then
        '                    If Row.Cells(3).Value() = My.Forms.frm_gate_history.dt_date_filter.Value.ToShortDateString Then
        '                        checked = True
        '                        Row.Visible = True
        '                    End If
        '                End If

        '                If Row.Cells(5).Value().ToString.Length > 0 And checked = False Then
        '                    If Row.Cells(5).Value() = My.Forms.frm_gate_history.dt_date_filter.Value.ToShortDateString Then
        '                        checked = True
        '                        Row.Visible = True
        '                    End If
        '                End If

        '                If checked = False Then Row.Visible = False
        '            End If
        '        Else
        '            Row.Visible = False
        '        End If
        '    End If
        'Next

        For Each Row As DataGridViewRow In My.Forms.frm_gate_history.dgw_list.Rows
            If Row.Index >= 0 Then
                If My.Forms.frm_gate_history.dgw_list.Rows.Item(Row.Index).Cells.Item(11).Value.ToString.Length > 0 Then
                    My.Forms.frm_gate_history.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    My.Forms.frm_gate_history.dgw_list.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next

        filter_history = True
        My.Forms.frm_gate_history.Cursor = Cursors.Default
    End Function



    Public Function byteArrayToImage(ByVal ba As Byte()) As Image

        Dim ms As New System.IO.MemoryStream()
        Dim rc As Image = Nothing

        Try
            ms.Write(ba, 0, ba.Length)
            rc = New Bitmap(ms)
        Finally
            ms.Close()
        End Try

        Return rc

    End Function



    Public Function delivery_note_check()
        Dim isEmpty As Boolean = True
        Dim rec_inserted = False
        Dim check_cursor

        Try
            check_cursor = My.Forms.Form_config.dgw_delivery_note_number.CurrentRow.Index
        Catch ex As Exception
            MessageBox.Show("now")
            My.Forms.Form_config.dgw_delivery_note_number.Rows(0).Cells(0).Selected = True
        End Try



        For Each row As DataGridViewRow In My.Forms.Form_config.dgw_delivery_note_number.Rows
            Try
                If My.Forms.Form_config.dgw_delivery_note_number.CurrentRow.Index = row.Index And row.IsNewRow Then
                    My.Forms.Form_config.dgw_delivery_note_number.Rows.Item(row.Index).DefaultCellStyle.BackColor = Color.Orange
                End If

                isEmpty = True
                For Each cell As DataGridViewCell In row.Cells
                    If String.IsNullOrEmpty(cell.Value) And cell.ColumnIndex <> 4 Then
                        'If String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        'End If
                    End If
                Next

                If row.Cells.Item(4).Value = "1" Then
                    My.Forms.Form_config.dgw_delivery_note_number.Rows.Item(row.Index).ReadOnly = True
                End If

                If isEmpty = False And row.IsNewRow = False Then
                    My.Forms.Form_config.dgw_delivery_note_number.Rows.Item(row.Index).DefaultCellStyle.BackColor = Color.Orange
                Else
                    If row.IsNewRow = False Then
                        My.Forms.Form_config.dgw_delivery_note_number.Rows.Item(row.Index).DefaultCellStyle.BackColor = Color.LightGreen

                        If block_dgw_reaction = False Then
                            If IsNumeric(row.Cells.Item(1).Value) And row.Cells.Item(4).Value <> "1" And fn_sql_request("SELECT [id] FROM  [dbo].[delivery_note_line] WHERE ('" + Format(Date.ParseExact(row.Cells.Item(2).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' >= [start_date] AND '" + Format(Date.ParseExact(row.Cells.Item(2).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' <= [end_date]) OR ('" + Format(Date.ParseExact(row.Cells.Item(3).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' >= [start_date] AND '" + Format(Date.ParseExact(row.Cells.Item(3).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' <= [end_date])", "SELECT", 1) = False Then
                                If fn_sql_request("INSERT INTO [dbo].[delivery_note_line] ([prefix],[number],[start_date],[end_date],[user_name]) VALUES ( '" + row.Cells.Item(0).Value.ToString + "','" + row.Cells.Item(1).Value.ToString + "','" + Format(Date.ParseExact(row.Cells.Item(2).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "','" + Format(Date.ParseExact(row.Cells.Item(3).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "','" + My.Forms.Main_form.user.ToString + "')", "INSERT", 0) = False Then
                                    MessageBox.Show("řadu se nepodařilo uložit . Více: SQL debugger")
                                Else
                                    row.Cells.Item(4).Value = "1"
                                    rec_inserted = True
                                End If
                            Else
                                If fn_sql_request("SELECT [id] FROM  [dbo].[delivery_note_line] WHERE [prefix] = '" + row.Cells.Item(0).Value.ToString + "' AND [number] = '" + row.Cells.Item(1).Value.ToString + "' AND start_date = '" + Format(Date.ParseExact(row.Cells.Item(2).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' AND end_date= '" + Format(Date.ParseExact(row.Cells.Item(3).Value.ToString, "dd.mm.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), "yyyy-mm-dd") + "' ", "SELECT", 1) = False Then
                                    My.Forms.Form_config.dgw_delivery_note_number.Rows.Item(row.Index).DefaultCellStyle.BackColor = Color.Red
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        Next


        If rec_inserted = True Then
            load_delivery_note_line()
            rec_inserted = False
        End If


    End Function


    Public Function load_delivery_note_line()
        Try
            For Each row As DataGridViewRow In My.Forms.Form_config.dgw_delivery_note_number.Rows
                row.Dispose()
            Next

        Catch ex As Exception
        End Try

        block_dgw_reaction = True
        Try
            If fn_sql_request("SELECT [prefix],[number],CONVERT(varchar(10),[start_date]),CONVERT(varchar(10),[end_date]) FROM [dbo].[delivery_note_line] order by [start_date] DESC", "SELECT", 4) = True Then
                For cycle As Integer = 0 To My.Forms.Main_form.sql_array_count - 1 Step 1
                    My.Forms.Form_config.dgw_delivery_note_number.Rows.Add(My.Forms.Main_form.sql_array(cycle, 0), My.Forms.Main_form.sql_array(cycle, 1), CDate(My.Forms.Main_form.sql_array(cycle, 2)).ToString("dd.MM.yyyy"), CDate(My.Forms.Main_form.sql_array(cycle, 3)).ToString("dd.MM.yyyy"), "1")
                Next
            End If
        Catch ex As Exception
            block_dgw_reaction = False
        End Try
        block_dgw_reaction = False

    End Function


End Module