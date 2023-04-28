Imports System.IO

Module functions_SQL
    Dim move_time As String = ""
    Dim temp_string As String

    'query,typ:SELECT/jiný,počet sloupců - jen při selectu jinak 0

    Public Function fn_sql_request(ByVal query As String, ByVal type As String, ByVal rows As Integer) As Boolean
        fn_sql_request = False
        Main_form.Cursor = Cursors.WaitCursor
        If My.Forms.Form_config.chb_sql_debugger.Checked = True Then MsgBox(query)

        Dim sqlConnection_string As New System.Data.SqlClient.SqlConnection(My.Settings.sql_connection)
        Dim cmd As New System.Data.SqlClient.SqlCommand(query, sqlConnection_string)
        Dim reader As System.Data.SqlClient.SqlDataReader



        Try
            If Not type = "INSERT_IMAGE" And Not type = "INSERT_AUTO_IMAGE" Then
                sqlConnection_string.Open()
                reader = cmd.ExecuteReader()

                If type = "INSERT" And reader.RecordsAffected > 0 Then
                    fn_sql_request = True
                End If

                If type = "UPDATE" And reader.RecordsAffected > 0 Then
                    fn_sql_request = True
                End If

                If type = "DELETE" And reader.RecordsAffected > 0 Then
                    fn_sql_request = True
                End If

                If type = "SELECT" Then
                    Dim count As Integer = 0

                    While reader.Read()
                        count += 1
                    End While

                    reader.Close()
                    reader = cmd.ExecuteReader()
                    ReDim My.Forms.Main_form.sql_array(count.ToString, (rows - 1))

                    count = 0
                    If reader.HasRows = True Then fn_sql_request = True
                    While reader.Read()
                        'MessageBox.Show((reader.GetInt32(0) & ", " & reader.GetString(1)))
                        'MessageBox.Show(reader.GetInt16(0))
                        'MsgBox(reader.GetString(1))
                        For row As Integer = 0 To (rows - 1) Step 1
                            My.Forms.Main_form.sql_array(count, row) = reader(row).ToString()
                        Next
                        count += 1
                    End While
                    My.Forms.Main_form.sql_array_count = count

                End If

                reader.Close()
            Else
                If type = "INSERT_IMAGE" Then
                    Dim ms As New MemoryStream()
                    My.Forms.Main_form.pcx_screenshot.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg())

                    Dim byteArray() As Byte = ms.GetBuffer()

                    ms = New MemoryStream(byteArray)
                    My.Forms.Main_form.pcx_screenshot.Image = Image.FromStream(ms)
                    My.Forms.Main_form.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

                    cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_for_save", System.Data.SqlDbType.Image)).Value = byteArray

                    sqlConnection_string.Open()
                    cmd.ExecuteNonQuery()

                    My.Forms.Main_form.pcx_screenshot.Image = Nothing
                    fn_sql_request = True
                End If

                If type = "INSERT_AUTO_IMAGE" Then
                    Dim ms As New MemoryStream()
                    My.Forms.Main_form.pcx_autosave.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg())
                    Dim byteArray() As Byte = ms.GetBuffer()
                    ms = New MemoryStream(byteArray)
                    My.Forms.Main_form.pcx_autosave.Image = Image.FromStream(ms)
                    My.Forms.Main_form.pcx_autosave.SizeMode = PictureBoxSizeMode.StretchImage

                    cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_for_save", System.Data.SqlDbType.Image)).Value = byteArray

                    sqlConnection_string.Open()
                    cmd.ExecuteNonQuery()

                    'My.Forms.Main_form.pcx_autosave.Image = Nothing
                    fn_sql_request = True
                End If
            End If
            sqlConnection_string.Close()
            Main_form.Cursor = Cursors.Default
        Catch ex As Exception
            Main_form.Cursor = Cursors.Default

        End Try

    End Function




    Public Function fn_sql_movement_record_insert() As Boolean
        fn_sql_movement_record_insert = False
        If fn_movement_form_check() = False Then Exit Function

        If My.Forms.Main_form.txt_ingoing.Enabled = True Then
            move_time = My.Forms.Main_form.txt_ingoing.Text
        Else
            move_time = My.Forms.Main_form.txt_outgoing.Text
        End If

        Dim query As String = "INSERT INTO [dbo].[record_gateway_movement]  ([gateway_id],[carrier_id],[movement_type_id],[movement_date],[movement_time],[document_nr],[number_plate],[insert_date],[insert_name],[status],[parent_rec_id],[carrier_name],[destination],[user_name]) VALUES ( '" + My.Forms.Form_config.txt_Gate_id.Text + "',(SELECT id FROM dbo.dial_carrier where name='" + My.Forms.Main_form.lst_carrier.Text + "'),'" + CStr(My.Forms.Main_form.movement_type_id) + "','" + My.Forms.Main_form.dt_rec_date.Value.ToString("yyyy-MM-dd") + "','" + move_time + "','" + CStr(My.Forms.Main_form.txt_delivery_no.Text) + "','" + CStr(UCase(My.Forms.Main_form.txt_spz_field.Text)) + "',GETDATE(),'program','active','" + CStr(My.Forms.Main_form.parent_id) + "','" + CStr(My.Forms.Main_form.txt_carrier_name.Text) + "','" + CStr(My.Forms.Main_form.txt_destination.Text) + "','" + My.Forms.Main_form.user.ToString + "')"
        If fn_sql_request(query, "INSERT", 0) = True Then
            fn_sql_request("SELECT TOP 1 id  FROM [dbo].[record_gateway_movement] ORDER BY ID DESC", "SELECT", 1)

            '            If My.Forms.Main_form.pcx_screenshot.
            If Not My.Forms.Main_form.pcx_screenshot.Image Is Nothing Then
                query = "INSERT INTO [dbo].[movement_pictures] ([record_id],[gateway_id],[image],[insert_date],[user_name])VALUES('" + My.Forms.Main_form.sql_array(0, 0) + "','" + My.Forms.Form_config.txt_Gate_id.Text + "',@image_for_save,GETDATE(),'" + My.Forms.Main_form.user.ToString + "') "
                If fn_sql_request(query, "INSERT_IMAGE", 0) = True Then
                    fn_sql_movement_record_insert = True
                End If
            Else
                fn_sql_movement_record_insert = True
            End If

        Else
            MsgBox("Záznam není možné uložit: Kontaktujte Vašeho správce IT pro kontrolu MSSQL serveru")
        End If

    End Function



    Function fn_insert_temp_number_plate(number_plate As String) As Boolean
        Dim add_rec = True
        For Each Row As DataGridViewRow In My.Forms.Main_form.dgw_detected_spz.Rows
            If Row.Index >= 0 Then
                If Row.Cells(0).Value().ToString = number_plate Or Compare(Row.Cells(0).Value().ToString, number_plate) > 0.7 Then
                    add_rec = False
                    Exit For
                End If
            End If
        Next

        If My.Forms.Form_config.ch_int_spz_detect.Checked = True Then
            Dim query As String = "SELECT TOP 1 id FROM [dbo].[temp_number_plate] WHERE [number_plate] = '" + number_plate + "' AND [cam_ignore_time] > '" + Date.Now + "' ORDER BY id DESC"

            If fn_sql_request(query, "SELECT", 1) = True And My.Forms.Main_form.sql_array_count > 0 And My.Forms.Main_form.txt_spz_field.Text = number_plate Then
                fn_insert_temp_number_plate = False
                add_rec = False
            Else
                fn_autosave_pictures(number_plate)

                fn_insert_temp_number_plate = True
            End If
        Else
            fn_autosave_pictures(number_plate)
            fn_insert_temp_number_plate = True
        End If

            If fn_insert_temp_number_plate = True And add_rec = True Then
            Dim query = "INSERT INTO [dbo].[temp_number_plate]  ([number_plate],[gateway_id],[insert_date],[cam_ignore_time],[user_name]) VALUES ( '" + number_plate + "','" + My.Forms.Form_config.txt_Gate_id.Text + "',GETDATE(), '" + Date.Now.AddSeconds(My.Forms.Form_config.txt_cam_spz_detection.Text) + "','" + My.Forms.Main_form.user.ToString + "' )"
                fn_sql_request(query, "INSERT", 0)
            End If


    End Function



    Function fn_autosave_pictures(number_plate As String) As Boolean
        fn_autosave_pictures = False
        Try
            If fn_sql_request("SELECT id FROM [dbo].[auto_saving_pictures] WHERE number_plate = '" + number_plate + "' AND [insert_date] >= DATEADD(n, -" + My.Forms.Main_form.autosave_picture_time_interval.ToString + ", GETDATE()) ", "SELECT", 1) = False And My.Forms.Main_form.sql_array_count = 0 Then
                If My.Forms.Form_config.chb_autostatus.Checked = True Then
                    My.Forms.Main_form.GetFormImage_for_autosave()
                    If Not My.Forms.Main_form.pcx_autosave.Image Is Nothing Then
                        Dim query = "INSERT INTO [dbo].[auto_saving_pictures] ([gateway_id],[number_plate],[image],[user_name],[insert_date])VALUES('" + My.Forms.Form_config.txt_Gate_id.Text + "','" + number_plate + "',@image_for_save,'" + My.Forms.Main_form.user.ToString + "',GETDATE()) "
                        If fn_sql_request(query, "INSERT_AUTO_IMAGE", 0) = True Then
                            fn_autosave_pictures = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function





    Function fn_save_SQL_setting() As Boolean
        fn_save_SQL_setting = False
        temp_string = "active" 'only temp ideal for activating for inserting app records


        If fn_sql_request("SELECT id FROM dbo.dial_gateway WHERE id='" + My.Forms.Form_config.txt_Gate_id.Text + "' ", "SELECT", 1) = True Then
            fn_sql_request("UPDATE dbo.dial_gateway SET name='" + My.Forms.Form_config.txt_gate_name.Text + "',description='" + My.Forms.Form_config.txt_description.Text + "',time_interval='" + My.Forms.Form_config.txt_time_interval.Text + "',status='active' ,cam_url ='" + My.Forms.Form_config.txt_url.Text + "', cam_logname = '" + My.Forms.Form_config.txt_cam_logname.Text + "', cam_logpw = '" + My.Forms.Form_config.txt_cam_logpw.Text + "', autosave_picture = '" + My.Forms.Form_config.chb_autostatus.CheckState.ToString + "', user_name = '" + My.Forms.Main_form.user.ToString + "' WHERE id='" + My.Forms.Main_form.sql_array(0, 0) + "' ", "UPDATE", 0)
            fn_save_SQL_setting = True
        Else

            If fn_sql_request("INSERT INTO dbo.dial_gateway([name],[description],[time_interval],[status],[cam_url],[cam_logname],[cam_logpw],[autosave_picture],[user_name])VALUES('" + My.Forms.Form_config.txt_gate_name.Text + "','" + My.Forms.Form_config.txt_description.Text + "','" + My.Forms.Form_config.txt_time_interval.Text + "','" + temp_string + "','" + My.Forms.Form_config.txt_url.Text + "','" + My.Forms.Form_config.txt_cam_logname.Text + "','" + My.Forms.Form_config.txt_cam_logpw.Text + "','" + My.Forms.Form_config.chb_autostatus.CheckState.ToString + "','" + My.Forms.Main_form.user.ToString + "' ) ", "INSERT", 0) = True Then
                fn_sql_request("SELECT id FROM dbo.dial_gateway WHERE name='" + My.Forms.Form_config.txt_gate_name.Text + "' ", "SELECT", 1)
                My.Forms.Form_config.txt_Gate_id.Text = My.Forms.Main_form.sql_array(0, 0)
                fn_save_SQL_setting = True
            End If
        End If

    End Function


    Public Function fn_sql_cancel_movement_record() As Boolean
        Dim query As String = "UPDATE [dbo].[record_gateway_movement] SET [status] = 'cancel' WHERE id='" + CStr(My.Forms.Main_form.parent_id) + "' "
        If fn_sql_request(query, "UPDATE", 0) = True Then fn_sql_cancel_movement_record = True
    End Function





End Module
