<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_config
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_config))
        Me.lbl_gate_id = New System.Windows.Forms.Label()
        Me.txt_Gate_id = New System.Windows.Forms.TextBox()
        Me.lbl_gate_name = New System.Windows.Forms.Label()
        Me.txt_gate_name = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.RichTextBox()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.btn_save_close = New System.Windows.Forms.Button()
        Me.chb_autostatus = New System.Windows.Forms.CheckBox()
        Me.lbl_time_interval = New System.Windows.Forms.Label()
        Me.txt_time_interval = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_serverSQL = New System.Windows.Forms.Label()
        Me.txt_serverSQL = New System.Windows.Forms.TextBox()
        Me.lbl_db_name = New System.Windows.Forms.Label()
        Me.txt_db_name = New System.Windows.Forms.TextBox()
        Me.lbl_dn_name = New System.Windows.Forms.Label()
        Me.txt_db_loginname = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_connection_text = New System.Windows.Forms.Button()
        Me.txt_db_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.lbl_cam_logname = New System.Windows.Forms.Label()
        Me.txt_cam_logname = New System.Windows.Forms.TextBox()
        Me.lbl_cam_logpw = New System.Windows.Forms.Label()
        Me.txt_cam_logpw = New System.Windows.Forms.TextBox()
        Me.lbl_company = New System.Windows.Forms.Label()
        Me.txt_company = New System.Windows.Forms.TextBox()
        Me.cb_company_show = New System.Windows.Forms.CheckBox()
        Me.cb_auto_spz_corection = New System.Windows.Forms.CheckBox()
        Me.txt_spz_format = New System.Windows.Forms.TextBox()
        Me.lbl_spz_format = New System.Windows.Forms.Label()
        Me.txt_cam_spz_detection = New System.Windows.Forms.TextBox()
        Me.lbl_cam_spz_detection = New System.Windows.Forms.Label()
        Me.chb_sql_debugger = New System.Windows.Forms.CheckBox()
        Me.ch_int_spz_detect = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgw_delivery_note_number = New System.Windows.Forms.DataGridView()
        Me.prefix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numbering = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.start_date_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.end_date_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saved = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dt_date_selection = New System.Windows.Forms.DateTimePicker()
        Me.chb_multiselect = New System.Windows.Forms.CheckBox()
        CType(Me.dgw_delivery_note_number, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_gate_id
        '
        Me.lbl_gate_id.AutoSize = True
        Me.lbl_gate_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_gate_id.Location = New System.Drawing.Point(2, 8)
        Me.lbl_gate_id.Name = "lbl_gate_id"
        Me.lbl_gate_id.Size = New System.Drawing.Size(62, 16)
        Me.lbl_gate_id.TabIndex = 200
        Me.lbl_gate_id.Text = "ID Brány:"
        '
        'txt_Gate_id
        '
        Me.txt_Gate_id.Location = New System.Drawing.Point(120, 8)
        Me.txt_Gate_id.Name = "txt_Gate_id"
        Me.txt_Gate_id.ReadOnly = True
        Me.txt_Gate_id.Size = New System.Drawing.Size(171, 20)
        Me.txt_Gate_id.TabIndex = 1
        '
        'lbl_gate_name
        '
        Me.lbl_gate_name.AutoSize = True
        Me.lbl_gate_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_gate_name.Location = New System.Drawing.Point(2, 38)
        Me.lbl_gate_name.Name = "lbl_gate_name"
        Me.lbl_gate_name.Size = New System.Drawing.Size(88, 16)
        Me.lbl_gate_name.TabIndex = 205
        Me.lbl_gate_name.Text = "Název Brány:"
        '
        'txt_gate_name
        '
        Me.txt_gate_name.Location = New System.Drawing.Point(120, 34)
        Me.txt_gate_name.Name = "txt_gate_name"
        Me.txt_gate_name.Size = New System.Drawing.Size(171, 20)
        Me.txt_gate_name.TabIndex = 20
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(120, 383)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(441, 84)
        Me.txt_description.TabIndex = 95
        Me.txt_description.Text = ""
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(2, 383)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(46, 16)
        Me.lbl_description.TabIndex = 270
        Me.lbl_description.Text = "Popis:"
        '
        'btn_save_close
        '
        Me.btn_save_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_save_close.Location = New System.Drawing.Point(119, 473)
        Me.btn_save_close.Name = "btn_save_close"
        Me.btn_save_close.Size = New System.Drawing.Size(104, 23)
        Me.btn_save_close.TabIndex = 100
        Me.btn_save_close.Text = "Uložit a Zavřít"
        Me.btn_save_close.UseVisualStyleBackColor = True
        '
        'chb_autostatus
        '
        Me.chb_autostatus.AutoSize = True
        Me.chb_autostatus.Enabled = False
        Me.chb_autostatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chb_autostatus.Location = New System.Drawing.Point(389, 7)
        Me.chb_autostatus.Name = "chb_autostatus"
        Me.chb_autostatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chb_autostatus.Size = New System.Drawing.Size(175, 20)
        Me.chb_autostatus.TabIndex = 35
        Me.chb_autostatus.Text = ":Automatické snímkování"
        Me.chb_autostatus.UseVisualStyleBackColor = True
        '
        'lbl_time_interval
        '
        Me.lbl_time_interval.AutoSize = True
        Me.lbl_time_interval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_time_interval.Location = New System.Drawing.Point(297, 35)
        Me.lbl_time_interval.Name = "lbl_time_interval"
        Me.lbl_time_interval.Size = New System.Drawing.Size(116, 16)
        Me.lbl_time_interval.TabIndex = 210
        Me.lbl_time_interval.Text = "Obnova Dat (sec):"
        '
        'txt_time_interval
        '
        Me.txt_time_interval.Location = New System.Drawing.Point(410, 34)
        Me.txt_time_interval.Name = "txt_time_interval"
        Me.txt_time_interval.Size = New System.Drawing.Size(153, 20)
        Me.txt_time_interval.TabIndex = 40
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(487, 473)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 105
        Me.btn_close.Text = "Zavřít"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'lbl_serverSQL
        '
        Me.lbl_serverSQL.AutoSize = True
        Me.lbl_serverSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_serverSQL.Location = New System.Drawing.Point(2, 61)
        Me.lbl_serverSQL.Name = "lbl_serverSQL"
        Me.lbl_serverSQL.Size = New System.Drawing.Size(100, 16)
        Me.lbl_serverSQL.TabIndex = 215
        Me.lbl_serverSQL.Text = "Server MSSQL:"
        '
        'txt_serverSQL
        '
        Me.txt_serverSQL.Location = New System.Drawing.Point(120, 60)
        Me.txt_serverSQL.Name = "txt_serverSQL"
        Me.txt_serverSQL.Size = New System.Drawing.Size(171, 20)
        Me.txt_serverSQL.TabIndex = 25
        '
        'lbl_db_name
        '
        Me.lbl_db_name.AutoSize = True
        Me.lbl_db_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_db_name.Location = New System.Drawing.Point(2, 87)
        Me.lbl_db_name.Name = "lbl_db_name"
        Me.lbl_db_name.Size = New System.Drawing.Size(112, 16)
        Me.lbl_db_name.TabIndex = 225
        Me.lbl_db_name.Text = "Název Databáze:"
        '
        'txt_db_name
        '
        Me.txt_db_name.Location = New System.Drawing.Point(120, 86)
        Me.txt_db_name.Name = "txt_db_name"
        Me.txt_db_name.Size = New System.Drawing.Size(171, 20)
        Me.txt_db_name.TabIndex = 30
        '
        'lbl_dn_name
        '
        Me.lbl_dn_name.AutoSize = True
        Me.lbl_dn_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_dn_name.Location = New System.Drawing.Point(313, 61)
        Me.lbl_dn_name.Name = "lbl_dn_name"
        Me.lbl_dn_name.Size = New System.Drawing.Size(100, 16)
        Me.lbl_dn_name.TabIndex = 220
        Me.lbl_dn_name.Text = "DB Log Jméno:"
        '
        'txt_db_loginname
        '
        Me.txt_db_loginname.Location = New System.Drawing.Point(410, 60)
        Me.txt_db_loginname.Name = "txt_db_loginname"
        Me.txt_db_loginname.Size = New System.Drawing.Size(153, 20)
        Me.txt_db_loginname.TabIndex = 45
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(313, 87)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(95, 16)
        Me.lbl_password.TabIndex = 230
        Me.lbl_password.Text = "DB Log Heslo:"
        Me.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_connection_text
        '
        Me.btn_connection_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_connection_text.Location = New System.Drawing.Point(466, 134)
        Me.btn_connection_text.Name = "btn_connection_text"
        Me.btn_connection_text.Size = New System.Drawing.Size(98, 23)
        Me.btn_connection_text.TabIndex = 55
        Me.btn_connection_text.Text = "Test Připojení"
        Me.btn_connection_text.UseVisualStyleBackColor = True
        '
        'txt_db_password
        '
        Me.txt_db_password.Location = New System.Drawing.Point(410, 86)
        Me.txt_db_password.Name = "txt_db_password"
        Me.txt_db_password.Size = New System.Drawing.Size(153, 20)
        Me.txt_db_password.TabIndex = 50
        Me.txt_db_password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "IP URL (rtsp):"
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(121, 163)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(443, 20)
        Me.txt_url.TabIndex = 80
        '
        'lbl_cam_logname
        '
        Me.lbl_cam_logname.AutoSize = True
        Me.lbl_cam_logname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_cam_logname.Location = New System.Drawing.Point(3, 191)
        Me.lbl_cam_logname.Name = "lbl_cam_logname"
        Me.lbl_cam_logname.Size = New System.Drawing.Size(83, 16)
        Me.lbl_cam_logname.TabIndex = 255
        Me.lbl_cam_logname.Text = "Cam Jméno:"
        Me.lbl_cam_logname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cam_logname
        '
        Me.txt_cam_logname.Location = New System.Drawing.Point(121, 191)
        Me.txt_cam_logname.Name = "txt_cam_logname"
        Me.txt_cam_logname.Size = New System.Drawing.Size(154, 20)
        Me.txt_cam_logname.TabIndex = 85
        '
        'lbl_cam_logpw
        '
        Me.lbl_cam_logpw.AutoSize = True
        Me.lbl_cam_logpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_cam_logpw.Location = New System.Drawing.Point(312, 191)
        Me.lbl_cam_logpw.Name = "lbl_cam_logpw"
        Me.lbl_cam_logpw.Size = New System.Drawing.Size(97, 16)
        Me.lbl_cam_logpw.TabIndex = 260
        Me.lbl_cam_logpw.Text = "Kamera Heslo:"
        Me.lbl_cam_logpw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cam_logpw
        '
        Me.txt_cam_logpw.Location = New System.Drawing.Point(411, 191)
        Me.txt_cam_logpw.Name = "txt_cam_logpw"
        Me.txt_cam_logpw.Size = New System.Drawing.Size(153, 20)
        Me.txt_cam_logpw.TabIndex = 90
        '
        'lbl_company
        '
        Me.lbl_company.AutoSize = True
        Me.lbl_company.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_company.Location = New System.Drawing.Point(3, 115)
        Me.lbl_company.Name = "lbl_company"
        Me.lbl_company.Size = New System.Drawing.Size(45, 16)
        Me.lbl_company.TabIndex = 240
        Me.lbl_company.Text = "Firma:"
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(120, 112)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(86, 20)
        Me.txt_company.TabIndex = 60
        '
        'cb_company_show
        '
        Me.cb_company_show.AutoSize = True
        Me.cb_company_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_company_show.Location = New System.Drawing.Point(213, 113)
        Me.cb_company_show.Name = "cb_company_show"
        Me.cb_company_show.Size = New System.Drawing.Size(75, 20)
        Me.cb_company_show.TabIndex = 65
        Me.cb_company_show.Text = "Zobrazit"
        Me.cb_company_show.UseVisualStyleBackColor = True
        '
        'cb_auto_spz_corection
        '
        Me.cb_auto_spz_corection.AutoSize = True
        Me.cb_auto_spz_corection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_auto_spz_corection.Location = New System.Drawing.Point(213, 138)
        Me.cb_auto_spz_corection.Name = "cb_auto_spz_corection"
        Me.cb_auto_spz_corection.Size = New System.Drawing.Size(154, 20)
        Me.cb_auto_spz_corection.TabIndex = 75
        Me.cb_auto_spz_corection.Text = "Automatická Korekce"
        Me.cb_auto_spz_corection.UseVisualStyleBackColor = True
        '
        'txt_spz_format
        '
        Me.txt_spz_format.Location = New System.Drawing.Point(121, 138)
        Me.txt_spz_format.Name = "txt_spz_format"
        Me.txt_spz_format.Size = New System.Drawing.Size(86, 20)
        Me.txt_spz_format.TabIndex = 70
        '
        'lbl_spz_format
        '
        Me.lbl_spz_format.AutoSize = True
        Me.lbl_spz_format.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_spz_format.Location = New System.Drawing.Point(3, 142)
        Me.lbl_spz_format.Name = "lbl_spz_format"
        Me.lbl_spz_format.Size = New System.Drawing.Size(82, 16)
        Me.lbl_spz_format.TabIndex = 245
        Me.lbl_spz_format.Text = "Formát SPZ:"
        '
        'txt_cam_spz_detection
        '
        Me.txt_cam_spz_detection.Location = New System.Drawing.Point(480, 112)
        Me.txt_cam_spz_detection.Name = "txt_cam_spz_detection"
        Me.txt_cam_spz_detection.Size = New System.Drawing.Size(82, 20)
        Me.txt_cam_spz_detection.TabIndex = 53
        '
        'lbl_cam_spz_detection
        '
        Me.lbl_cam_spz_detection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_cam_spz_detection.Location = New System.Drawing.Point(295, 108)
        Me.lbl_cam_spz_detection.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_cam_spz_detection.Name = "lbl_cam_spz_detection"
        Me.lbl_cam_spz_detection.Size = New System.Drawing.Size(168, 29)
        Me.lbl_cam_spz_detection.TabIndex = 272
        Me.lbl_cam_spz_detection.Text = "Inverval detekce stejné SPZ (sec):"
        Me.lbl_cam_spz_detection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chb_sql_debugger
        '
        Me.chb_sql_debugger.AutoSize = True
        Me.chb_sql_debugger.Location = New System.Drawing.Point(4, 501)
        Me.chb_sql_debugger.Name = "chb_sql_debugger"
        Me.chb_sql_debugger.Size = New System.Drawing.Size(97, 17)
        Me.chb_sql_debugger.TabIndex = 273
        Me.chb_sql_debugger.Text = "SQL Debbuger"
        Me.chb_sql_debugger.UseVisualStyleBackColor = True
        '
        'ch_int_spz_detect
        '
        Me.ch_int_spz_detect.Location = New System.Drawing.Point(466, 107)
        Me.ch_int_spz_detect.Name = "ch_int_spz_detect"
        Me.ch_int_spz_detect.Size = New System.Drawing.Size(15, 24)
        Me.ch_int_spz_detect.TabIndex = 274
        Me.ch_int_spz_detect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 40)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "Řada Int.Dod.Listů:  Př.(DODL / 000001)"
        '
        'dgw_delivery_note_number
        '
        Me.dgw_delivery_note_number.AllowUserToDeleteRows = False
        Me.dgw_delivery_note_number.AllowUserToResizeColumns = False
        Me.dgw_delivery_note_number.AllowUserToResizeRows = False
        Me.dgw_delivery_note_number.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw_delivery_note_number.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgw_delivery_note_number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_delivery_note_number.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prefix, Me.numbering, Me.start_date_value, Me.end_date_value, Me.saved})
        Me.dgw_delivery_note_number.Location = New System.Drawing.Point(121, 218)
        Me.dgw_delivery_note_number.MultiSelect = False
        Me.dgw_delivery_note_number.Name = "dgw_delivery_note_number"
        Me.dgw_delivery_note_number.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw_delivery_note_number.RowHeadersWidth = 22
        Me.dgw_delivery_note_number.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgw_delivery_note_number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgw_delivery_note_number.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw_delivery_note_number.ShowCellErrors = False
        Me.dgw_delivery_note_number.ShowCellToolTips = False
        Me.dgw_delivery_note_number.ShowRowErrors = False
        Me.dgw_delivery_note_number.Size = New System.Drawing.Size(442, 150)
        Me.dgw_delivery_note_number.TabIndex = 276
        '
        'prefix
        '
        Me.prefix.HeaderText = "Prefix"
        Me.prefix.MaxInputLength = 10
        Me.prefix.Name = "prefix"
        Me.prefix.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prefix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'numbering
        '
        Me.numbering.HeaderText = "Číslování (001)"
        Me.numbering.Name = "numbering"
        Me.numbering.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.numbering.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'start_date_value
        '
        Me.start_date_value.HeaderText = "Datum Od"
        Me.start_date_value.Name = "start_date_value"
        Me.start_date_value.ReadOnly = True
        Me.start_date_value.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.start_date_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'end_date_value
        '
        Me.end_date_value.HeaderText = "Datum Do"
        Me.end_date_value.Name = "end_date_value"
        Me.end_date_value.ReadOnly = True
        Me.end_date_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'saved
        '
        Me.saved.FalseValue = "0"
        Me.saved.HeaderText = "saved"
        Me.saved.Name = "saved"
        Me.saved.ReadOnly = True
        Me.saved.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.saved.TrueValue = "1"
        Me.saved.Visible = False
        '
        'dt_date_selection
        '
        Me.dt_date_selection.CustomFormat = "dd.MM.yyyy"
        Me.dt_date_selection.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_date_selection.Location = New System.Drawing.Point(342, 261)
        Me.dt_date_selection.Name = "dt_date_selection"
        Me.dt_date_selection.Size = New System.Drawing.Size(102, 20)
        Me.dt_date_selection.TabIndex = 277
        Me.dt_date_selection.Visible = False
        '
        'chb_multiselect
        '
        Me.chb_multiselect.AutoSize = True
        Me.chb_multiselect.Location = New System.Drawing.Point(4, 479)
        Me.chb_multiselect.Name = "chb_multiselect"
        Me.chb_multiselect.Size = New System.Drawing.Size(78, 17)
        Me.chb_multiselect.TabIndex = 278
        Me.chb_multiselect.Text = "MultiSelect"
        Me.chb_multiselect.UseVisualStyleBackColor = True
        '
        'Form_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.chb_multiselect)
        Me.Controls.Add(Me.dt_date_selection)
        Me.Controls.Add(Me.dgw_delivery_note_number)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ch_int_spz_detect)
        Me.Controls.Add(Me.btn_connection_text)
        Me.Controls.Add(Me.chb_sql_debugger)
        Me.Controls.Add(Me.txt_cam_spz_detection)
        Me.Controls.Add(Me.lbl_cam_spz_detection)
        Me.Controls.Add(Me.cb_auto_spz_corection)
        Me.Controls.Add(Me.txt_spz_format)
        Me.Controls.Add(Me.lbl_spz_format)
        Me.Controls.Add(Me.cb_company_show)
        Me.Controls.Add(Me.txt_company)
        Me.Controls.Add(Me.lbl_company)
        Me.Controls.Add(Me.txt_cam_logpw)
        Me.Controls.Add(Me.lbl_cam_logpw)
        Me.Controls.Add(Me.txt_cam_logname)
        Me.Controls.Add(Me.lbl_cam_logname)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_db_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_db_loginname)
        Me.Controls.Add(Me.lbl_dn_name)
        Me.Controls.Add(Me.txt_db_name)
        Me.Controls.Add(Me.lbl_db_name)
        Me.Controls.Add(Me.txt_serverSQL)
        Me.Controls.Add(Me.lbl_serverSQL)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_time_interval)
        Me.Controls.Add(Me.lbl_time_interval)
        Me.Controls.Add(Me.chb_autostatus)
        Me.Controls.Add(Me.btn_save_close)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_gate_name)
        Me.Controls.Add(Me.lbl_gate_name)
        Me.Controls.Add(Me.txt_Gate_id)
        Me.Controls.Add(Me.lbl_gate_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_config"
        Me.ShowInTaskbar = False
        Me.Text = "SPZ Vrátný - Konfigurace"
        Me.TopMost = True
        CType(Me.dgw_delivery_note_number, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gate_id As System.Windows.Forms.Label
    Friend WithEvents txt_Gate_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gate_name As System.Windows.Forms.Label
    Friend WithEvents txt_gate_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_description As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_description As System.Windows.Forms.Label
    Friend WithEvents btn_save_close As System.Windows.Forms.Button
    Friend WithEvents chb_autostatus As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_time_interval As System.Windows.Forms.Label
    Friend WithEvents txt_time_interval As System.Windows.Forms.TextBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents lbl_serverSQL As System.Windows.Forms.Label
    Friend WithEvents txt_serverSQL As System.Windows.Forms.TextBox
    Friend WithEvents lbl_db_name As System.Windows.Forms.Label
    Friend WithEvents txt_db_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dn_name As System.Windows.Forms.Label
    Friend WithEvents txt_db_loginname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents btn_connection_text As System.Windows.Forms.Button
    Friend WithEvents txt_db_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_url As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cam_logname As System.Windows.Forms.Label
    Friend WithEvents txt_cam_logname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cam_logpw As System.Windows.Forms.Label
    Friend WithEvents txt_cam_logpw As System.Windows.Forms.TextBox
    Friend WithEvents lbl_company As System.Windows.Forms.Label
    Friend WithEvents txt_company As System.Windows.Forms.TextBox
    Friend WithEvents cb_company_show As System.Windows.Forms.CheckBox
    Friend WithEvents cb_auto_spz_corection As System.Windows.Forms.CheckBox
    Friend WithEvents txt_spz_format As System.Windows.Forms.TextBox
    Friend WithEvents lbl_spz_format As System.Windows.Forms.Label
    Friend WithEvents txt_cam_spz_detection As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cam_spz_detection As System.Windows.Forms.Label
    Friend WithEvents chb_sql_debugger As System.Windows.Forms.CheckBox
    Friend WithEvents ch_int_spz_detect As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgw_delivery_note_number As System.Windows.Forms.DataGridView
    Friend WithEvents dt_date_selection As System.Windows.Forms.DateTimePicker
    Friend WithEvents prefix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numbering As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents start_date_value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents end_date_value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saved As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chb_multiselect As System.Windows.Forms.CheckBox
End Class
