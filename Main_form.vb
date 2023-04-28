Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class Main_form

    Inherits System.Windows.Forms.Form
    Public sql_array_count As Integer = 0
    Public sql_array(0, 0) As String
    Public temp As String
    Public tmp_rowi As Integer
    Public parent_id As Integer = 0
    Public movement_type_id As Integer = 0
    Public reload_time_sequence As Integer = 5
    Public time_check As Date = Date.Now.AddSeconds(reload_time_sequence)
    Public Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Boolean
    Public Const SRCCOPY As Integer = &HCC0020
    Public dgw_record_id As Integer
    Public user As String = ""


    Const KL_NAMELENGTH As Long = 9                      'length of the keyboardbuffer
    Const KLF_ACTIVATE As Long = &H1                     'activate the layout
    Public Const autosave_picture_time_interval = 15

    'the language constants
    Const LANG_NL_STD As String = "00000413"
    Const LANG_EN_US As String = "00000409"
    Const LANG_DU_STD As String = "00000407"
    Const LANG_FR_STD As String = "0000040C"
    Const LANG_CS_STD As String = "00000405"

    'api's to adjust the keyboardlayout
    Private Declare Function GetKeyboardLayoutName Lib "user32" Alias "GetKeyboardLayoutNameA" (ByVal pwszKLID As String) As Long
    Private Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Long) As Long

    Private Sub btnStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnStart.Click
        If My.Forms.Form_config.txt_url.TextLength > 0 Then
            VideoCapture1.IPCameraURL = My.Forms.Form_config.txt_url.Text
            VideoCapture1.IPCameraUser = My.Forms.Form_config.txt_cam_logname.Text
            VideoCapture1.IPCameraPassword = My.Forms.Form_config.txt_cam_logpw.Text
        End If
        Call VideoCapture1.StartCapture()
    End Sub

    Private Sub btnStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnStop.Click
        Call VideoCapture1.StopCapture()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            Me.Arriving_VehiclesTableAdapter.Fill(Me.Arriving_Vehicles_DataSet.Arriving_Vehicles)
        Catch ex As Exception
        End Try

        ANPREngine1.Init((True)) ' Video Mode
        ANPREngine1.LicenseManager.AddLicenseKey("UYWL0EB0KW5YOLQLUYNB")

        fn_load_setting()
        Me.rbtn_ingoing.Checked = True
        Me.rbtn_outgoing.Checked = False
        Me.lbl_act_datetime.Text = Date.Now

        'temp_array = Split(sql_request("SELECT name FROM dbo.dial_carrier ", "SELECT", 1), "#")
        'Me.lst_carrier.Items.Add(temp_array(0))

        fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
        If sql_array_count > 0 Then
            Me.lst_carrier.Items.Clear()
            For row As Integer = 0 To Me.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                    Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        End If

        If My.Forms.Form_config.txt_time_interval.Text = "" Then
            reload_time_sequence = 60
        Else
            reload_time_sequence = My.Forms.Form_config.txt_time_interval.Text
        End If
        time_check = Date.Now.AddSeconds(reload_time_sequence)
        fn_set_record_type()
        actual_data_fields()

    End Sub


    Private Sub main_form_Showned(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        My.Forms.Form_logon.Show()

    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim result = MsgBox("Chcete Aplikaci skutečně Ukončit?", MsgBoxStyle.YesNo)
        If result = vbYes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub Form_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        VideoCapture1.StopCapture()
    End Sub


    Private Sub AxVideoCapture1_FrameReceived(ByVal sender As System.Object, ByVal e As AxDTKVideoCapLib._IDTKVideoCaptureEvents_FrameReceivedEvent) Handles VideoCapture1.FrameReceived

        Dim i As Object
        'Dim plates As DTKANPRLib.PlateCollection

        Dim hBitmap As Integer

        Try
            hBitmap = e.hBitmap
        Catch ex As Exception

        End Try

        Call ANPREngine1.ReadFromBitmap(hBitmap, 0)

        If ANPREngine1.Plates.Count > 0 Then
            For i = 0 To ANPREngine1.Plates.Count - 1
                Dim plate As DTKANPRLib.Plate = ANPREngine1.Plates.Item(0)
                Dim repaired_plate As New System.Text.StringBuilder(plate.Text)



                Dim add_rec As Boolean = True
                If ((My.Forms.Form_config.cb_auto_spz_corection.Checked = True And plate.Text.Length >= My.Forms.Form_config.txt_spz_format.Text.Length) Or (My.Forms.Form_config.cb_auto_spz_corection.Checked = False And plate.Text.Length > 4)) And Me.txt_spz_field.Text.Length = 0 Then
                    Me.rbtn_ingoing.Checked = True
                    fn_set_record_type()
                    If (My.Forms.Form_config.cb_auto_spz_corection.Checked = True And plate.Text.Length >= My.Forms.Form_config.txt_spz_format.Text.Length) Then
                        For row As Integer = 0 To My.Forms.Form_config.txt_spz_format.Text.Length - 1 Step 1
                            If Mid(My.Forms.Form_config.txt_spz_format.Text, My.Forms.Form_config.txt_spz_format.Text.Length - row, 1) = "N" And IsNumeric(Mid(plate.Text, plate.Text.Length - row, 1)) = False Then
                                Select Case Mid(plate.Text, repaired_plate.Length - row, 1)
                                    Case "O", "o", "U", "u"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "0")
                                    Case "I", "l"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "1")
                                    Case "Z", "z"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "2")
                                    Case "E"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "3")
                                    Case "R", "A"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "4")
                                    Case "S"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "5")
                                    Case "G"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "6")
                                    Case "/", "T"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "7")
                                    Case "B"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "8")
                                    Case "f"   '"Z","D"  
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "9")
                                    Case " "
                                        repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "")
                                    Case Else
                                End Select
                            End If
                        Next
                    End If

                    If fn_insert_temp_number_plate(repaired_plate.ToString) = True Then
                        Me.txt_spz_field.Text = CStr(repaired_plate.ToString)
                        Me.pcx_screenshot.Image = GetFormImage()
                        Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

                        add_rec = False
                        Me.btn_use_spz.PerformClick()
                    End If
                End If

                If ((My.Forms.Form_config.cb_auto_spz_corection.Checked = True And plate.Text.Length >= My.Forms.Form_config.txt_spz_format.Text.Length) Or (My.Forms.Form_config.cb_auto_spz_corection.Checked = False And plate.Text.Length > 4)) And Me.txt_spz_field.Text.Length > 0 Then
                    For Each Row As DataGridViewRow In Me.dgw_detected_spz.Rows
                        If Row.Index >= 0 Then
                            If Row.Cells(0).Value().ToString = plate.Text Or Compare(Row.Cells(0).Value().ToString, plate.Text) > 0.7 Then
                                add_rec = False
                                Exit For
                            End If
                        End If
                    Next
                    If add_rec = True Then
                        If (My.Forms.Form_config.cb_auto_spz_corection.Checked = True And plate.Text.Length >= My.Forms.Form_config.txt_spz_format.Text.Length) Then
                            For row As Integer = 0 To My.Forms.Form_config.txt_spz_format.Text.Length - 1 Step 1
                                If Mid(My.Forms.Form_config.txt_spz_format.Text, My.Forms.Form_config.txt_spz_format.Text.Length - row, 1) = "N" And IsNumeric(Mid(plate.Text, repaired_plate.Length - row, 1)) = False Then
                                    Select Case Mid(plate.Text, repaired_plate.Length - row, 1)
                                        Case "O", "o", "U", "u"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "0")
                                        Case "I", "l"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "1")
                                        Case "Z", "z"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "2")
                                        Case "E"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "3")
                                        Case "R", "A"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "4")
                                        Case "S"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "5")
                                        Case "G"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "6")
                                        Case "/", "T"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "7")
                                        Case "B"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "8")
                                        Case "f"   '"Z","D"  
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "9")
                                        Case " "
                                            repaired_plate.Remove((repaired_plate.Length - row - 1), 1).Insert((repaired_plate.Length - row), "")
                                        Case Else
                                    End Select
                                End If
                            Next
                        End If

                        If (repaired_plate.ToString <> Me.txt_spz_field.Text) And fn_insert_temp_number_plate(repaired_plate.ToString) = True Then

                            Me.dgw_detected_spz.Rows.Insert(0, repaired_plate.ToString, GetFormImage(), DateAndTime.Now)
                            Me.dgw_detected_spz.Update()
                        End If

                    End If

                End If


                System.Runtime.InteropServices.Marshal.ReleaseComObject(plate)
                plate = Nothing

            Next i

            GC.Collect()

        End If
    End Sub


    Private Sub btn_use_spz_Click(sender As Object, e As EventArgs) Handles btn_use_spz.Click
        Me.pcx_screenshot.Image = GetFormImage()
        Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

        Me.parent_id = 0
        Me.btn_cancel.Enabled = False
        If fn_sql_request("SELECT TOP 1 id,name = ISNULL((SELECT name from dbo.dial_carrier where id = move_rec.carrier_id ),'NULL')  FROM dbo.record_gateway_movement move_rec WHERE [number_plate]='" + UCase(Me.txt_spz_field.Text) + "'  order by id DESC", "SELECT", 2) = True Then
            If sql_array_count > 0 Then
                Me.lst_carrier.SelectedItem = Me.sql_array(0, 1).ToString
            Else
                fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
                If sql_array_count > 0 Then
                    Me.lst_carrier.Items.Clear()
                    For row As Integer = 0 To Me.sql_array_count Step 1
                        Try
                            Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                            Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                        Catch ex As IndexOutOfRangeException
                        End Try
                    Next
                End If

            End If
        Else
            fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
            If sql_array_count > 0 Then
                Me.lst_carrier.Items.Clear()
                For row As Integer = 0 To Me.sql_array_count Step 1
                    Try
                        Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                        Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                    Catch ex As IndexOutOfRangeException
                    End Try
                Next
            End If
        End If

        If Me.txt_spz_field.Text = "" Then
            Me.txt_spz_field.BackColor = Color.PaleVioletRed
        Else

            For Each Row As DataGridViewRow In gw_Arriving_Vehicles.Rows
                If Row.Index >= 0 Then
                    If Row.Cells(2).Value().ToString = Me.txt_spz_field.Text Then
                        tmp_rowi = Row.Index
                        Me.pcx_screenshot.Image = GetFormImage()
                        Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

                        gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                        fn_clean_outgoing_movement_form()
                        fn_get_arrived_vehicle(tmp_rowi)
                        gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                        Me.rbtn_outgoing.Checked = True
                        Me.rbtn_ingoing.Checked = False
                        Me.txt_delivery_no.Focus()
                        MsgBox("Vozidlo je již v Areálu. Bylo Vybráno pro Odjezd")
                    End If
                End If
            Next

            Me.txt_spz_field.BackColor = Color.White
            Me.txt_delivery_no.Focus()
        End If
    End Sub



    Private Sub txt_spz_field_entered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_spz_field.KeyPress

        If AscW(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
            If Me.txt_spz_field.Text = "" Then
                Me.txt_spz_field.BackColor = Color.PaleVioletRed
            Else
                Me.txt_delivery_no.Focus()
            End If
        End If
    End Sub


    Private Sub txt_delivery_no_entered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_delivery_no.KeyPress
        If AscW(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
            Me.lst_carrier.Focus()
        End If
    End Sub


    Private Sub lst_carrier_entered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lst_carrier.KeyPress
        If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
            If fn_sql_request("SELECT id,name FROM dbo.dial_carrier WHERE name = '" + Me.lst_carrier.Text + "'", "SELECT", 2) = False Then
                Me.lst_carrier.BackColor = Color.PaleVioletRed
                Me.lst_carrier.Focus()
            Else
                Me.btn_save.Focus()
            End If
        End If
    End Sub


    Private Sub txt_ingoing_entered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ingoing.KeyPress
        If AscW(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
            Me.btn_save.Focus()
        End If
    End Sub

    Private Sub txt_outgoing_entered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_outgoing.KeyPress
        If AscW(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
            Me.btn_save.Focus()
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbl_act_datetime.Text = Date.Now
        If time_check < Date.Now Then
            time_check = Date.Now.AddSeconds(reload_time_sequence)
            Try
                actual_data_fields()
            Catch ex As Exception
            End Try

            time_check = Date.Now.AddSeconds(reload_time_sequence)
        End If
    End Sub


    Private Sub rbtn_ingoing_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_ingoing.CheckedChanged
        If Me.rbtn_ingoing.Checked = False Then
            Me.txt_destination.BackColor = Color.White
            fn_set_record_type()
        Else
            Me.txt_destination.BackColor = Color.PaleVioletRed

        End If

    End Sub

    Private Sub rbtn_outgoing_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_outgoing.CheckedChanged
        If Me.rbtn_outgoing.Checked = False Then fn_set_record_type()

    End Sub

    Private Sub btn_act_time_Click(sender As Object, e As EventArgs) Handles btn_act_time.Click
        fn_set_actual_time("")
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Me.txt_spz_field.Text = UCase(Me.txt_spz_field.Text)
        If fn_sql_movement_record_insert() = True Then
            fn_clean_movement_form()
        End If
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim result As MsgBoxResult = MsgBox("Chcete záznam skutečně stornovat?", MsgBoxStyle.YesNo)
        If result = vbYes Then 'obnova dat aplikace
            If fn_sql_cancel_movement_record() = True Then
                MsgBox("Záznam o příjezdu byl stornován")
                fn_clean_movement_form()
            End If
        End If
    End Sub


    Private Sub gw_Arriving_Vehicles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gw_Arriving_Vehicles.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.txt_spz_field.Focus()
            Me.pcx_screenshot.Image = GetFormImage()
            Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

            'gw_Arriving_Vehicles.Rows.Item(e.RowIndex).Cells.Item(5).Value 'vraci hodnotu z pole
            fn_clean_outgoing_movement_form()
            fn_get_arrived_vehicle(e.RowIndex)
            Me.txt_delivery_no.Focus()
        End If
    End Sub


    Private Sub dgw_detected_spz_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_detected_spz.CellDoubleClick
        If e.RowIndex >= 0 Then
            For Each Row As DataGridViewRow In gw_Arriving_Vehicles.Rows
                If Row.Index >= 0 Then
                    If Row.Cells(2).Value().ToString = Me.dgw_detected_spz.Rows.Item(e.RowIndex).Cells.Item(0).Value Then
                        tmp_rowi = Row.Index
                        Me.pcx_screenshot.Image = GetFormImage()
                        Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

                        gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                        fn_clean_outgoing_movement_form()
                        fn_get_arrived_vehicle(tmp_rowi)
                        gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                        Me.rbtn_outgoing.Checked = True
                        Me.rbtn_ingoing.Checked = False
                        Me.txt_delivery_no.Focus()
                        MsgBox("Vozidlo je již v Areálu. Bylo Vybráno pro Odjezd")
                        Me.dgw_detected_spz.Rows.RemoveAt(e.RowIndex)
                        Exit Sub
                    End If
                End If

            Next

            Me.rbtn_ingoing.Checked = True
            fn_set_record_type()
            Me.txt_spz_field.Text = Me.dgw_detected_spz.Rows.Item(e.RowIndex).Cells.Item(0).Value
            Me.txt_spz_field.BackColor = Color.White
            Me.pcx_screenshot.Image = Me.dgw_detected_spz.Rows.Item(e.RowIndex).Cells.Item(1).Value
            Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage
            Me.dt_rec_date.Value = Me.dgw_detected_spz.Rows.Item(e.RowIndex).Cells.Item(2).Value

            fn_set_actual_time(Me.dgw_detected_spz.Rows.Item(e.RowIndex).Cells.Item(2).Value)

            If fn_sql_request("SELECT TOP 1 id,name = ISNULL((SELECT name from dbo.dial_carrier where id = move_rec.carrier_id ),'NULL')  FROM dbo.record_gateway_movement move_rec WHERE [number_plate]='" + UCase(Me.txt_spz_field.Text) + "'  order by id DESC", "SELECT", 2) = True Then
                If sql_array_count > 0 Then
                    Me.lst_carrier.SelectedItem = Me.sql_array(0, 1).ToString
                Else
                    fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
                    If sql_array_count > 0 Then
                        Me.lst_carrier.Items.Clear()
                        For row As Integer = 0 To Me.sql_array_count Step 1
                            Try
                                Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                                Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                            Catch ex As IndexOutOfRangeException
                            End Try
                        Next
                    End If

                End If
            Else
                fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
                If sql_array_count > 0 Then
                    Me.lst_carrier.Items.Clear()
                    For row As Integer = 0 To Me.sql_array_count Step 1
                        Try
                            Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                            Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                        Catch ex As IndexOutOfRangeException
                        End Try
                    Next
                End If
            End If
            Me.dgw_detected_spz.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub




    Private Sub btn_Clear_form_Click(sender As Object, e As EventArgs) Handles btn_Clear_form.Click
        fn_clean_movement_form()
    End Sub





    Private Sub dt_rec_date_ValueChanged(sender As Object, e As EventArgs) Handles dt_rec_date.ValueChanged
        Me.btn_cancel.Enabled = False
    End Sub


    Private Sub tray_icon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tray_icon.MouseDoubleClick
        If Me.Visible = True Then
            Me.Hide()
            My.Forms.form_carrier.Hide()
        Else
            Me.Controls.Owner.Enabled = True
            Me.Show()
            Me.Focus()
        End If
    End Sub




    Private Sub btn_dial_carrier_Click(sender As Object, e As EventArgs) Handles btn_dial_carrier.Click

        Me.Controls.Owner.Enabled = False
        My.Forms.form_carrier.Show()
        My.Forms.form_carrier.Focus()
    End Sub


    Private Sub win_tray_menu_cloce_Click(sender As Object, e As EventArgs) Handles lsi_end.Click
        If MsgBox("Chcete skutečně ukončit aplikaci?", 4096 + 16 + 4) = vbYes Then
            My.Application.SaveMySettingsOnExit = True
            Application.Exit()
        End If
    End Sub


    Private Sub win_tray_menu_About_Opening(sender As Object, e As EventArgs) Handles lsi_about.Click
        My.Forms.form_about.Show()
        My.Forms.form_about.Focus()
    End Sub

    Private Sub win_tray_menu_help_Opening(sender As Object, e As EventArgs) Handles lsi_help.Click
        My.Forms.form_help.Show()
        My.Forms.form_help.Focus()
    End Sub



    Private Sub win_tray_menu_config_Opening(sender As Object, e As EventArgs) Handles lsi_config.Click
        My.Forms.Form_config.Show()
        My.Forms.Form_config.Focus()
        fn_load_setting()
        My.Forms.Form_config.txt_gate_name.Focus()
    End Sub


    Private Sub win_tray_menu_history_Opening(sender As Object, e As EventArgs) Handles lsi_history.Click
        Me.Controls.Owner.Enabled = False
        My.Forms.frm_gate_history.Show()
        My.Forms.frm_gate_history.Focus()
    End Sub


    Public Function GetFormImage() As Bitmap
        Dim me_gr As Graphics = Me.CreateGraphics
        Dim bm As New Bitmap(Me.VideoCapture1.ClientSize.Width, Me.VideoCapture1.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = me_gr.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc
        Dim me_hdc As IntPtr = me_gr.GetHdc
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height, me_hdc, 257, 8, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        'Return bm

        Dim graph As Graphics = Nothing
        Dim frmleft As System.Drawing.Point = Me.Bounds.Location
        Dim bmp As New Bitmap(Me.VideoCapture1.Size.Width, Me.VideoCapture1.Size.Height)
        graph = Graphics.FromImage(bmp)
        Dim screenx As Integer = frmleft.X
        Dim screeny As Integer = frmleft.Y
        graph.CopyFromScreen(screenx + 265, screeny + 35, 0, 0, bmp.Size)

        Return bmp
    End Function


    Public Function GetFormImage_for_autosave() As Bitmap
        Dim me_gr As Graphics = Me.CreateGraphics
        Dim bm As New Bitmap(Me.VideoCapture1.ClientSize.Width, Me.VideoCapture1.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = me_gr.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc
        Dim me_hdc As IntPtr = me_gr.GetHdc
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height, me_hdc, 257, 8, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        'Me.pcx_autosave.Image = bm
        'Return bm

        Dim graph As Graphics = Nothing
        Dim frmleft As System.Drawing.Point = Me.Bounds.Location
        Dim bmp As New Bitmap(Me.VideoCapture1.Size.Width, Me.VideoCapture1.Size.Height)
        graph = Graphics.FromImage(bmp)
        Dim screenx As Integer = frmleft.X
        Dim screeny As Integer = frmleft.Y
        graph.CopyFromScreen(screenx + 265, screeny + 35, 0, 0, bmp.Size)

        Me.pcx_autosave.Image = bmp
        Me.pcx_autosave.SizeMode = PictureBoxSizeMode.StretchImage

        Return bmp

    End Function


    Private Sub txt_spz_field_leave(sender As Object, e As EventArgs) Handles txt_spz_field.Leave
        If Me.btn_Clear_form.Focused = False Then
            Me.txt_spz_field.Text = UCase(Me.txt_spz_field.Text)
            If Me.txt_spz_field.Text = "" Then
                Me.txt_spz_field.BackColor = Color.PaleVioletRed
            Else
                Me.txt_spz_field.BackColor = Color.White
                For Each Row As DataGridViewRow In gw_Arriving_Vehicles.Rows
                    If Row.Index >= 0 Then
                        If Row.Cells(2).Value().ToString = Me.txt_spz_field.Text Then
                            tmp_rowi = Row.Index
                            Me.pcx_screenshot.Image = GetFormImage()
                            Me.pcx_screenshot.SizeMode = PictureBoxSizeMode.StretchImage

                            gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                            'fn_clean_outgoing_movement_form()
                            fn_get_arrived_vehicle(tmp_rowi)
                            ' Me.parent_id = Me.gw_Arriving_Vehicles.Rows.Item(tmp_rowi).Cells.Item(7).Value()
                            Me.rbtn_outgoing.Checked = True
                            Me.rbtn_ingoing.Checked = False
                            MsgBox("Vozidlo je již v Areálu. Bylo Vybráno pro Odjezd")
                            Me.btn_cancel.Enabled = True
                            Me.parent_id = Me.gw_Arriving_Vehicles.Rows.Item(tmp_rowi).Cells.Item(7).Value()
                            gw_Arriving_Vehicles.Rows(tmp_rowi).Selected = True
                        End If
                    End If
                Next

            End If
            If fn_sql_request("SELECT TOP 1 id,name = ISNULL((SELECT name from dbo.dial_carrier where id = move_rec.carrier_id ),'NULL')  FROM dbo.record_gateway_movement move_rec WHERE [number_plate]='" + UCase(Me.txt_spz_field.Text) + "'  order by id DESC", "SELECT", 2) = True Then
                If sql_array_count > 0 Then
                    Me.lst_carrier.SelectedItem = Me.sql_array(0, 1).ToString
                Else
                    fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
                    If sql_array_count > 0 Then
                        Me.lst_carrier.Items.Clear()
                        For row As Integer = 0 To Me.sql_array_count Step 1
                            Try
                                Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                                Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                            Catch ex As IndexOutOfRangeException
                            End Try
                        Next
                    End If

                End If
            Else
                fn_sql_request("SELECT id,name FROM dbo.dial_carrier order by name ASC", "SELECT", 2)
                If sql_array_count > 0 Then
                    Me.lst_carrier.Items.Clear()
                    For row As Integer = 0 To Me.sql_array_count Step 1
                        Try
                            Console.WriteLine(CStr(Me.sql_array((row - 1), 1).Length))
                            Me.lst_carrier.Items.Add(Me.sql_array((row - 1), 1))
                        Catch ex As IndexOutOfRangeException
                        End Try
                    Next
                End If
            End If

            If Me.lb_number_plate.Focused = False Then
                Me.txt_delivery_no.Focus()
            End If


        End If
    End Sub


    Private Sub btn_clean_detect_Click(sender As Object, e As EventArgs) Handles btn_clean_detect.Click
        Me.dgw_detected_spz.Rows.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Controls.Owner.Enabled = False
        My.Forms.frm_gate_history.Show()
        My.Forms.frm_gate_history.Focus()
    End Sub


    Private Sub gw_Arriving_Vehicles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gw_Arriving_Vehicles.KeyDown

        Dim status = False

        For Each Row As DataGridViewRow In Me.gw_Arriving_Vehicles.Rows
            If Row.Visible = True Then
                status = True
                Exit For
            End If
        Next

        If e.KeyCode = Keys.Enter And status = True Then
            e.Handled = True
            Me.Controls.Owner.Enabled = False
            Me.dgw_record_id = Me.gw_Arriving_Vehicles.Rows.Item(Me.gw_Arriving_Vehicles.CurrentCell.RowIndex).Cells.Item(7).Value
            parent_form = "Main_form"
            My.Forms.form_record_note.Show()
            My.Forms.form_record_note.Focus()
        End If

        If e.KeyCode = Keys.F1 And status = True Then
            parent_form = "Main_form"
            Me.Controls.Owner.Enabled = False
            My.Forms.form_picture_preview.Show()
            My.Forms.form_picture_preview.Focus()
            If Me.gw_Arriving_Vehicles.Item("picture", Me.gw_Arriving_Vehicles.CurrentCell.RowIndex).Value.ToString.Length > 0 Then
                Dim myIMGCell As New DataGridViewImageCell
                myIMGCell = Me.gw_Arriving_Vehicles.Item("picture", Me.gw_Arriving_Vehicles.CurrentCell.RowIndex)
                My.Forms.form_picture_preview.psx_preview.Image = byteArrayToImage(myIMGCell.Value)
                My.Forms.form_picture_preview.psx_preview.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
    End Sub


    Private Sub txt_carrier_name_TextChanged(sender As Object, e As EventArgs) Handles txt_carrier_name.TextChanged
        fn_sql_request("SELECT surname,name,inserted_name FROM dbo.dial_name WHERE inserted_name LIKE '" + Me.txt_carrier_name.Text + "%' OR [personal_number] = '" + Me.txt_carrier_name.Text + "' ORDER BY SURNAME ASC", "SELECT", 3)
        If sql_array_count > 0 And Me.txt_carrier_name.Text.Length > 0 And (sql_array_count <> 1 Or Me.sql_array(0, 2) <> Me.txt_carrier_name.Text) Then
            Me.lb_name.Visible = True
            Me.lb_name.Items.Clear()
            For row As Integer = 0 To Me.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(Me.sql_array((row - 1), 2).Length))
                    Me.lb_name.Items.Add(Me.sql_array((row - 1), 2))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        Else
            Me.lb_name.Visible = False
        End If
    End Sub


    Private Sub txt_carrier_name_keydown(sender As Object, e As KeyEventArgs) Handles txt_carrier_name.KeyDown
        If (e.KeyCode = Keys.F8 Or e.KeyCode = Keys.Delete) And fn_sql_request("SELECT id FROM dbo.dial_name WHERE inserted_name = '" + Me.txt_carrier_name.Text + "' OR [personal_number] = '" + Me.txt_carrier_name.Text + "' ORDER BY SURNAME ASC", "SELECT", 1) = True Then
            Dim result As MsgBoxResult = MsgBox("Chcete opravdu jméno dopravce: " + txt_carrier_name.Text + " vymazat z číselníku?", MsgBoxStyle.YesNo)
            If result = vbYes Then 'obnova dat aplikace
                If fn_sql_request("DELETE FROM dbo.dial_name WHERE inserted_name = '" + txt_carrier_name.Text + "' ", "DELETE", 1) = True Then
                    MessageBox.Show("Jméno dopravce: " + txt_carrier_name.Text + " bylo vymazána")
                    txt_carrier_name.Text = ""
                Else
                    MessageBox.Show("Jméno dopravce: " + txt_carrier_name.Text + " se nepodařilo vymazat")
                End If
            End If
        End If
    End Sub

    Private Sub lb_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_name.SelectedIndexChanged
        Me.txt_carrier_name.Text = lb_name.SelectedItem
        Me.lb_name.Items.Clear()
        Me.lb_name.Visible = False
        Me.btn_save.Focus()
    End Sub


    Private Sub txt_carrier_name_LostFocus(sender As Object, e As EventArgs) Handles txt_carrier_name.LostFocus
        If Me.lb_name.Focused = False Then Me.lb_name.Visible = False
    End Sub


    Private Sub txt_spz_field_TextChanged(sender As Object, e As EventArgs) Handles txt_spz_field.TextChanged
        fn_sql_request("SELECT number_plate FROM dbo.dial_number_plate WHERE number_plate LIKE '" + txt_spz_field.Text + "%' ORDER BY number_plate ASC", "SELECT", 1)
        If sql_array_count > 0 And Me.txt_spz_field.Text.Length > 0 And (sql_array_count <> 1 Or Me.sql_array(0, 0) <> Me.txt_spz_field.Text) Then
            Me.lb_number_plate.Visible = True
            Me.lb_number_plate.Items.Clear()
            For row As Integer = 0 To Me.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(Me.sql_array((row - 1), 0).Length))
                    Me.lb_number_plate.Items.Add(Me.sql_array((row - 1), 0))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        Else
            Me.lb_number_plate.Visible = False
        End If
    End Sub


    Private Sub txt_spz_field_keydown(sender As Object, e As KeyEventArgs) Handles txt_spz_field.KeyDown
        If (e.KeyCode = Keys.F8 Or e.KeyCode = Keys.Delete) And fn_sql_request("SELECT number_plate FROM dbo.dial_number_plate WHERE number_plate = '" + txt_spz_field.Text + "' ORDER BY number_plate ASC", "SELECT", 1) = True Then
            Dim result As MsgBoxResult = MsgBox("Chcete opravdu vybranou SPZ: " + txt_spz_field.Text + " smazat z číselníku?", MsgBoxStyle.YesNo)
            If result = vbYes Then 'obnova dat aplikace
                If fn_sql_request("DELETE FROM dbo.dial_number_plate WHERE number_plate = '" + txt_spz_field.Text + "' ", "DELETE", 1) = True Then
                    MessageBox.Show("SPZ: " + txt_spz_field.Text + " byla vymazána")
                    txt_spz_field.Text = ""
                Else
                    MessageBox.Show("SPZ: " + txt_spz_field.Text + " se nepodařilo vymazat")
                End If
            End If
        End If
    End Sub



    Private Sub lb_number_plate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_number_plate.SelectedIndexChanged
        Me.txt_spz_field.Text = lb_number_plate.SelectedItem
        Me.lb_number_plate.Items.Clear()
        Me.lb_number_plate.Visible = False
        Me.txt_spz_field_leave(sender, e)
        Me.txt_delivery_no.Focus()
    End Sub


    Private Sub txt_spz_field_LostFocus(sender As Object, e As EventArgs) Handles txt_spz_field.LostFocus
        If Me.lb_number_plate.Focused = False Then Me.lb_number_plate.Visible = False
    End Sub


    Private Sub cb_company_CheckedChanged(sender As Object, e As EventArgs) Handles cb_company.CheckedChanged
        actual_data_fields()
    End Sub


    Private Sub txt_delivery_no_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_delivery_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txt_delivery_no.Text = "," + Me.txt_delivery_no.Text
            e.SuppressKeyPress = True
            'System.Text.Encoding.UTF8
            'Dim abData, i
            'abData = System.Text.Encoding.UTF8.GetBytes(Me.txt_delivery_no.Text)
            'For i = 0 To UBound(abData)
            '    Console.WriteLine(Hex(abData(i)) & "='" & Chr(abData(i)) & "'")
            'Next
            '' Convert bytes to string
            'Dim Str = System.Text.Encoding.Default.GetString(abData)
            'MsgBox(Str)
        End If
    End Sub


    Public Function SetKbLayout(strLocaleId As String) As Boolean
        'Changes the KeyboardLayout
        'Returns TRUE when the KeyboardLayout was adjusted properly, FALSE otherwise
        'If the KeyboardLayout isn't installed, this function will install it for you
        On Error Resume Next
        Dim strLocId As String 'used to retrieve current KeyboardLayout
        Dim strMsg As String   'used as buffer
        Dim lngErrNr As Long   'receives the API-error number

        'create a buffer
        strLocId = Str(KL_NAMELENGTH)
        'retrieve the current KeyboardLayout
        GetKeyboardLayoutName(strLocId)
        'Check whether the current KeyboardLayout and the
        'new one are the same
        If strLocId = (strLocaleId & Chr(0)) Then
            'If they're the same, we return immediately
            SetKbLayout = True
        Else
            'create buffer

            strLocId = Str(KL_NAMELENGTH)
            'load and activate the layout for the current thread
            strLocId = LoadKeyboardLayout((strLocaleId & Chr(0)), KLF_ACTIVATE)
            If IsDBNull(strLocId) Then  'returns NULL when it fails
                SetKbLayout = False
            Else 'check again
                'create buffer
                strLocId = Str(KL_NAMELENGTH)
                'retrieve the current layout
                GetKeyboardLayoutName(strLocId)
                If strLocId = (strLocaleId & Chr(0)) Then
                    SetKbLayout = True
                Else
                    SetKbLayout = False
                End If
            End If
        End If
    End Function


    Private Sub txt_delivery_no_LostFocus(sender As Object, e As EventArgs) Handles txt_delivery_no.LostFocus
        SetKbLayout(LANG_CS_STD)
    End Sub


    Private Sub txt_delivery_no_Focus(sender As Object, e As EventArgs) Handles txt_delivery_no.GotFocus
        SetKbLayout(LANG_EN_US)
    End Sub


    Private Sub txt_destination_TextChanged(sender As Object, e As EventArgs) Handles txt_destination.TextChanged
        fn_sql_request("SELECT destination FROM dbo.dial_destination WHERE destination LIKE '" + txt_destination.Text + "%' ORDER BY destination ASC", "SELECT", 1)
        If sql_array_count > 0 And Me.txt_destination.Text.Length > 0 And (sql_array_count <> 1 Or Me.sql_array(0, 0) <> Me.txt_destination.Text) Then
            Me.lb_destination.Visible = True
            Me.lb_destination.Items.Clear()
            For row As Integer = 0 To Me.sql_array_count Step 1
                Try
                    Console.WriteLine(CStr(Me.sql_array((row - 1), 0).Length))
                    Me.lb_destination.Items.Add(Me.sql_array((row - 1), 0))
                Catch ex As IndexOutOfRangeException
                End Try
            Next
        Else
            Me.lb_destination.Visible = False
        End If
    End Sub


    Private Sub txt_destination_keydown(sender As Object, e As KeyEventArgs) Handles txt_destination.KeyDown
        If (e.KeyCode = Keys.F8 Or e.KeyCode = Keys.Delete) And fn_sql_request("SELECT destination FROM dbo.dial_destination WHERE destination = '" + txt_destination.Text + "' ORDER BY destination ASC", "SELECT", 1) = True Then
            Dim result As MsgBoxResult = MsgBox("Chcete opravdu cíl cesty: " + txt_destination.Text + " smazat z číselníku?", MsgBoxStyle.YesNo)
            If result = vbYes Then 'obnova dat aplikace
                If fn_sql_request("DELETE FROM dbo.dial_destination WHERE destination = '" + txt_destination.Text + "' ", "DELETE", 1) = True Then
                    MessageBox.Show("Cíl cesty: " + txt_carrier_name.Text + " byl vymazán")
                    txt_destination.Text = ""
                Else
                    MessageBox.Show("Cíl cesty: " + txt_carrier_name.Text + " se nepodařilo vymazat")
                End If
            End If
        End If
    End Sub



    Private Sub lb_destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_destination.SelectedIndexChanged
        Me.txt_destination.Text = lb_destination.SelectedItem
        Me.lb_destination.Items.Clear()
        Me.lb_destination.Visible = False
        Me.btn_save.Focus()
    End Sub

    Private Sub txt_destination_LostFocus(sender As Object, e As EventArgs) Handles txt_destination.LostFocus
        If Me.lb_destination.Focused = False Then Me.lb_destination.Visible = False
    End Sub



    Private Sub gw_Arriving_Vehicles_DataBindingComplete(ByVal sender As Object, ByVal e As EventArgs) Handles gw_Arriving_Vehicles.Sorted


        Dim first_row = True
        Me.gw_Arriving_Vehicles.CurrentCell = Nothing
        For Each Row As DataGridViewRow In Me.gw_Arriving_Vehicles.Rows
            Row.Visible = True
            If (Me.cb_company.Checked = True And Me.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0).Value = My.Forms.Form_config.txt_company.Text) Or (Me.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0).Value <> My.Forms.Form_config.txt_company.Text) Then
                If first_row = True Then
                    Me.gw_Arriving_Vehicles.CurrentCell = Me.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(0)
                    first_row = False
                End If
            Else
                Row.Visible = False
            End If
            If Row.Index >= 0 Then
                If Me.gw_Arriving_Vehicles.Rows.Item(Row.Index).Cells.Item(9).Value.ToString.Length > 0 Then
                    Me.gw_Arriving_Vehicles.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    Me.gw_Arriving_Vehicles.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next

    End Sub



    Private Sub btn_without_delivery_doc_no_Click(sender As Object, e As EventArgs) Handles btn_without_delivery_doc_no.Click
        Me.txt_delivery_no.Text = "Bez.Dod.L."
    End Sub



    Private Sub btn_insert_internal_dod_note_Click(sender As Object, e As EventArgs) Handles btn_insert_internal_dod_note.Click
        If fn_sql_request(" SELECT ([prefix] + [number]),[prefix],[number] FROM [dbo].[delivery_note_line] WHERE [start_date]<=GETDATE() AND [end_date]>=GETDATE() ", "SELECT", 3) = True Then
            Me.txt_delivery_no.Text = sql_array(0, 0)
            Dim updated_delivery_note_no As String = CStr(Int(sql_array(0, 2)) + 1)
            For i As Integer = 1 To (sql_array(0, 2).Length - CStr(Int(sql_array(0, 2)) + 1).ToString.Length)
                updated_delivery_note_no = "0" + updated_delivery_note_no
            Next
            fn_sql_request(" UPDATE [dbo].[delivery_note_line] SET number = '" + updated_delivery_note_no + "' WHERE prefix = '" + sql_array(0, 1) + "' AND  [start_date]<=GETDATE() AND [end_date]>=GETDATE() ", "UPDATE", 1)
        Else
            MessageBox.Show("Není nastavena řada Interních dodacích Listů")
        End If
    End Sub




End Class