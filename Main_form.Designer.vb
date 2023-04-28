<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Main_form
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents btnStop As System.Windows.Forms.Button
    Public WithEvents btnStart As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_carrier = New System.Windows.Forms.ComboBox()
        Me.txt_spz_field = New System.Windows.Forms.TextBox()
        Me.btn_use_spz = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_delivery_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_Clear_form = New System.Windows.Forms.Button()
        Me.rbtn_ingoing = New System.Windows.Forms.RadioButton()
        Me.rbtn_outgoing = New System.Windows.Forms.RadioButton()
        Me.lbl_act_datetime = New System.Windows.Forms.Label()
        Me.dt_rec_date = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VideoCapture1 = New AxDTKVideoCapLib.AxDTKVideoCapture()
        Me.ANPREngine1 = New AxDTKANPRLib.AxANPREngine()
        Me.txt_ingoing = New System.Windows.Forms.TextBox()
        Me.btn_act_time = New System.Windows.Forms.Button()
        Me.txt_outgoing = New System.Windows.Forms.TextBox()
        Me.gw_Arriving_Vehicles = New System.Windows.Forms.DataGridView()
        Me.carrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poznamka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tray_icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.win_tray_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lsi_config = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsi_history = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsi_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsi_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsi_end = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_dial_carrier = New System.Windows.Forms.Button()
        Me.dgw_detected_spz = New System.Windows.Forms.DataGridView()
        Me.spz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spz_shot = New System.Windows.Forms.DataGridViewImageColumn()
        Me.move_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clean_detect = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_carrier_name = New System.Windows.Forms.Label()
        Me.txt_destination = New System.Windows.Forms.TextBox()
        Me.txt_carrier_name = New System.Windows.Forms.TextBox()
        Me.lbl_destination = New System.Windows.Forms.Label()
        Me.lb_name = New System.Windows.Forms.ListBox()
        Me.lb_number_plate = New System.Windows.Forms.ListBox()
        Me.cb_company = New System.Windows.Forms.CheckBox()
        Me.lb_destination = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pcx_screenshot = New System.Windows.Forms.PictureBox()
        Me.btn_without_delivery_doc_no = New System.Windows.Forms.Button()
        Me.btn_insert_internal_dod_note = New System.Windows.Forms.Button()
        Me.pcx_autosave = New System.Windows.Forms.PictureBox()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberplateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovementdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovementtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoznamkaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivingVehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arriving_Vehicles_DataSet = New BRANA_EV.Arriving_Vehicles_DataSet()
        Me.Arriving_VehiclesTableAdapter = New BRANA_EV.Arriving_Vehicles_DataSetTableAdapters.Arriving_VehiclesTableAdapter()
        CType(Me.VideoCapture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANPREngine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gw_Arriving_Vehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.win_tray_menu.SuspendLayout()
        CType(Me.dgw_detected_spz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcx_screenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcx_autosave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrivingVehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arriving_Vehicles_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.btnStop, "btnStop")
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStop.Name = "btnStop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Name = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Name = "Label1"
        '
        'lst_carrier
        '
        Me.lst_carrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.lst_carrier, "lst_carrier")
        Me.lst_carrier.FormattingEnabled = True
        Me.lst_carrier.Name = "lst_carrier"
        '
        'txt_spz_field
        '
        Me.txt_spz_field.AcceptsReturn = True
        resources.ApplyResources(Me.txt_spz_field, "txt_spz_field")
        Me.txt_spz_field.Name = "txt_spz_field"
        '
        'btn_use_spz
        '
        resources.ApplyResources(Me.btn_use_spz, "btn_use_spz")
        Me.btn_use_spz.Name = "btn_use_spz"
        Me.btn_use_spz.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txt_delivery_no
        '
        Me.txt_delivery_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txt_delivery_no, "txt_delivery_no")
        Me.txt_delivery_no.Name = "txt_delivery_no"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'btn_cancel
        '
        resources.ApplyResources(Me.btn_cancel, "btn_cancel")
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        resources.ApplyResources(Me.btn_save, "btn_save")
        Me.btn_save.Name = "btn_save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_Clear_form
        '
        resources.ApplyResources(Me.btn_Clear_form, "btn_Clear_form")
        Me.btn_Clear_form.Name = "btn_Clear_form"
        Me.btn_Clear_form.UseVisualStyleBackColor = True
        '
        'rbtn_ingoing
        '
        resources.ApplyResources(Me.rbtn_ingoing, "rbtn_ingoing")
        Me.rbtn_ingoing.Name = "rbtn_ingoing"
        Me.rbtn_ingoing.TabStop = True
        Me.rbtn_ingoing.UseVisualStyleBackColor = True
        '
        'rbtn_outgoing
        '
        resources.ApplyResources(Me.rbtn_outgoing, "rbtn_outgoing")
        Me.rbtn_outgoing.Name = "rbtn_outgoing"
        Me.rbtn_outgoing.TabStop = True
        Me.rbtn_outgoing.UseVisualStyleBackColor = True
        '
        'lbl_act_datetime
        '
        Me.lbl_act_datetime.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.lbl_act_datetime, "lbl_act_datetime")
        Me.lbl_act_datetime.ForeColor = System.Drawing.Color.Red
        Me.lbl_act_datetime.Name = "lbl_act_datetime"
        '
        'dt_rec_date
        '
        resources.ApplyResources(Me.dt_rec_date, "dt_rec_date")
        Me.dt_rec_date.Name = "dt_rec_date"
        Me.dt_rec_date.Value = New Date(2014, 12, 18, 0, 0, 0, 0)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'VideoCapture1
        '
        Me.VideoCapture1.AllowDrop = True
        resources.ApplyResources(Me.VideoCapture1, "VideoCapture1")
        Me.VideoCapture1.Name = "VideoCapture1"
        Me.VideoCapture1.OcxState = CType(resources.GetObject("VideoCapture1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'ANPREngine1
        '
        resources.ApplyResources(Me.ANPREngine1, "ANPREngine1")
        Me.ANPREngine1.Name = "ANPREngine1"
        Me.ANPREngine1.OcxState = CType(resources.GetObject("ANPREngine1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'txt_ingoing
        '
        Me.txt_ingoing.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.txt_ingoing.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.txt_ingoing, "txt_ingoing")
        Me.txt_ingoing.Name = "txt_ingoing"
        Me.txt_ingoing.ReadOnly = True
        '
        'btn_act_time
        '
        resources.ApplyResources(Me.btn_act_time, "btn_act_time")
        Me.btn_act_time.Name = "btn_act_time"
        Me.btn_act_time.UseVisualStyleBackColor = True
        '
        'txt_outgoing
        '
        resources.ApplyResources(Me.txt_outgoing, "txt_outgoing")
        Me.txt_outgoing.Name = "txt_outgoing"
        Me.txt_outgoing.ReadOnly = True
        '
        'gw_Arriving_Vehicles
        '
        Me.gw_Arriving_Vehicles.AllowUserToAddRows = False
        Me.gw_Arriving_Vehicles.AllowUserToDeleteRows = False
        Me.gw_Arriving_Vehicles.AllowUserToResizeColumns = False
        Me.gw_Arriving_Vehicles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gw_Arriving_Vehicles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.gw_Arriving_Vehicles, "gw_Arriving_Vehicles")
        Me.gw_Arriving_Vehicles.AutoGenerateColumns = False
        Me.gw_Arriving_Vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gw_Arriving_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gw_Arriving_Vehicles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.carrier, Me.NumberplateDataGridViewTextBoxColumn, Me.MovementdateDataGridViewTextBoxColumn, Me.MovementtimeDataGridViewTextBoxColumn, Me.DocumentnrDataGridViewTextBoxColumn, Me.picture, Me.IdDataGridViewTextBoxColumn, Me.PoznamkaDataGridViewTextBoxColumn, Me.poznamka})
        Me.gw_Arriving_Vehicles.DataSource = Me.ArrivingVehiclesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gw_Arriving_Vehicles.DefaultCellStyle = DataGridViewCellStyle2
        Me.gw_Arriving_Vehicles.MultiSelect = False
        Me.gw_Arriving_Vehicles.Name = "gw_Arriving_Vehicles"
        Me.gw_Arriving_Vehicles.ReadOnly = True
        Me.gw_Arriving_Vehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gw_Arriving_Vehicles.RowTemplate.ReadOnly = True
        Me.gw_Arriving_Vehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gw_Arriving_Vehicles.StandardTab = True
        '
        'carrier
        '
        Me.carrier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.carrier.DataPropertyName = "carrier_name"
        Me.carrier.FillWeight = 91.08049!
        resources.ApplyResources(Me.carrier, "carrier")
        Me.carrier.Name = "carrier"
        Me.carrier.ReadOnly = True
        Me.carrier.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'poznamka
        '
        Me.poznamka.DataPropertyName = "poznamka"
        resources.ApplyResources(Me.poznamka, "poznamka")
        Me.poznamka.Name = "poznamka"
        Me.poznamka.ReadOnly = True
        '
        'tray_icon
        '
        Me.tray_icon.ContextMenuStrip = Me.win_tray_menu
        resources.ApplyResources(Me.tray_icon, "tray_icon")
        '
        'win_tray_menu
        '
        Me.win_tray_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lsi_config, Me.lsi_history, Me.lsi_help, Me.lsi_about, Me.lsi_end})
        Me.win_tray_menu.Name = "win_tray_menu"
        resources.ApplyResources(Me.win_tray_menu, "win_tray_menu")
        '
        'lsi_config
        '
        Me.lsi_config.Name = "lsi_config"
        resources.ApplyResources(Me.lsi_config, "lsi_config")
        '
        'lsi_history
        '
        Me.lsi_history.Name = "lsi_history"
        resources.ApplyResources(Me.lsi_history, "lsi_history")
        '
        'lsi_help
        '
        Me.lsi_help.Name = "lsi_help"
        resources.ApplyResources(Me.lsi_help, "lsi_help")
        '
        'lsi_about
        '
        Me.lsi_about.Name = "lsi_about"
        resources.ApplyResources(Me.lsi_about, "lsi_about")
        '
        'lsi_end
        '
        Me.lsi_end.Name = "lsi_end"
        resources.ApplyResources(Me.lsi_end, "lsi_end")
        '
        'btn_dial_carrier
        '
        resources.ApplyResources(Me.btn_dial_carrier, "btn_dial_carrier")
        Me.btn_dial_carrier.Name = "btn_dial_carrier"
        Me.btn_dial_carrier.UseVisualStyleBackColor = True
        '
        'dgw_detected_spz
        '
        Me.dgw_detected_spz.AllowUserToAddRows = False
        Me.dgw_detected_spz.AllowUserToDeleteRows = False
        Me.dgw_detected_spz.AllowUserToResizeColumns = False
        Me.dgw_detected_spz.AllowUserToResizeRows = False
        Me.dgw_detected_spz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw_detected_spz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw_detected_spz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.dgw_detected_spz, "dgw_detected_spz")
        Me.dgw_detected_spz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgw_detected_spz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.spz, Me.spz_shot, Me.move_time})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw_detected_spz.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgw_detected_spz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgw_detected_spz.MultiSelect = False
        Me.dgw_detected_spz.Name = "dgw_detected_spz"
        Me.dgw_detected_spz.ReadOnly = True
        Me.dgw_detected_spz.RowHeadersVisible = False
        Me.dgw_detected_spz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgw_detected_spz.TabStop = False
        '
        'spz
        '
        Me.spz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.spz.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.spz, "spz")
        Me.spz.Name = "spz"
        Me.spz.ReadOnly = True
        '
        'spz_shot
        '
        resources.ApplyResources(Me.spz_shot, "spz_shot")
        Me.spz_shot.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.spz_shot.Name = "spz_shot"
        Me.spz_shot.ReadOnly = True
        Me.spz_shot.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'move_time
        '
        resources.ApplyResources(Me.move_time, "move_time")
        Me.move_time.Name = "move_time"
        Me.move_time.ReadOnly = True
        '
        'btn_clean_detect
        '
        resources.ApplyResources(Me.btn_clean_detect, "btn_clean_detect")
        Me.btn_clean_detect.Name = "btn_clean_detect"
        Me.btn_clean_detect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_carrier_name
        '
        resources.ApplyResources(Me.lbl_carrier_name, "lbl_carrier_name")
        Me.lbl_carrier_name.Name = "lbl_carrier_name"
        '
        'txt_destination
        '
        resources.ApplyResources(Me.txt_destination, "txt_destination")
        Me.txt_destination.Name = "txt_destination"
        '
        'txt_carrier_name
        '
        resources.ApplyResources(Me.txt_carrier_name, "txt_carrier_name")
        Me.txt_carrier_name.Name = "txt_carrier_name"
        '
        'lbl_destination
        '
        resources.ApplyResources(Me.lbl_destination, "lbl_destination")
        Me.lbl_destination.Name = "lbl_destination"
        '
        'lb_name
        '
        Me.lb_name.FormattingEnabled = True
        resources.ApplyResources(Me.lb_name, "lb_name")
        Me.lb_name.Name = "lb_name"
        '
        'lb_number_plate
        '
        Me.lb_number_plate.FormattingEnabled = True
        resources.ApplyResources(Me.lb_number_plate, "lb_number_plate")
        Me.lb_number_plate.Name = "lb_number_plate"
        '
        'cb_company
        '
        resources.ApplyResources(Me.cb_company, "cb_company")
        Me.cb_company.Name = "cb_company"
        Me.cb_company.UseVisualStyleBackColor = True
        '
        'lb_destination
        '
        Me.lb_destination.FormattingEnabled = True
        resources.ApplyResources(Me.lb_destination, "lb_destination")
        Me.lb_destination.Name = "lb_destination"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "image"
        resources.ApplyResources(Me.DataGridViewImageColumn1, "DataGridViewImageColumn1")
        Me.DataGridViewImageColumn1.Image = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pcx_screenshot
        '
        resources.ApplyResources(Me.pcx_screenshot, "pcx_screenshot")
        Me.pcx_screenshot.Name = "pcx_screenshot"
        Me.pcx_screenshot.TabStop = False
        '
        'btn_without_delivery_doc_no
        '
        resources.ApplyResources(Me.btn_without_delivery_doc_no, "btn_without_delivery_doc_no")
        Me.btn_without_delivery_doc_no.Name = "btn_without_delivery_doc_no"
        Me.btn_without_delivery_doc_no.UseVisualStyleBackColor = True
        '
        'btn_insert_internal_dod_note
        '
        resources.ApplyResources(Me.btn_insert_internal_dod_note, "btn_insert_internal_dod_note")
        Me.btn_insert_internal_dod_note.Name = "btn_insert_internal_dod_note"
        Me.btn_insert_internal_dod_note.UseVisualStyleBackColor = True
        '
        'pcx_autosave
        '
        resources.ApplyResources(Me.pcx_autosave, "pcx_autosave")
        Me.pcx_autosave.Name = "pcx_autosave"
        Me.pcx_autosave.TabStop = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        resources.ApplyResources(Me.NameDataGridViewTextBoxColumn, "NameDataGridViewTextBoxColumn")
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumberplateDataGridViewTextBoxColumn
        '
        Me.NumberplateDataGridViewTextBoxColumn.DataPropertyName = "number_plate"
        resources.ApplyResources(Me.NumberplateDataGridViewTextBoxColumn, "NumberplateDataGridViewTextBoxColumn")
        Me.NumberplateDataGridViewTextBoxColumn.Name = "NumberplateDataGridViewTextBoxColumn"
        Me.NumberplateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovementdateDataGridViewTextBoxColumn
        '
        Me.MovementdateDataGridViewTextBoxColumn.DataPropertyName = "movement_date"
        resources.ApplyResources(Me.MovementdateDataGridViewTextBoxColumn, "MovementdateDataGridViewTextBoxColumn")
        Me.MovementdateDataGridViewTextBoxColumn.Name = "MovementdateDataGridViewTextBoxColumn"
        Me.MovementdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovementtimeDataGridViewTextBoxColumn
        '
        Me.MovementtimeDataGridViewTextBoxColumn.DataPropertyName = "movement_time"
        resources.ApplyResources(Me.MovementtimeDataGridViewTextBoxColumn, "MovementtimeDataGridViewTextBoxColumn")
        Me.MovementtimeDataGridViewTextBoxColumn.Name = "MovementtimeDataGridViewTextBoxColumn"
        Me.MovementtimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentnrDataGridViewTextBoxColumn
        '
        Me.DocumentnrDataGridViewTextBoxColumn.DataPropertyName = "document_nr"
        resources.ApplyResources(Me.DocumentnrDataGridViewTextBoxColumn, "DocumentnrDataGridViewTextBoxColumn")
        Me.DocumentnrDataGridViewTextBoxColumn.Name = "DocumentnrDataGridViewTextBoxColumn"
        Me.DocumentnrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'picture
        '
        Me.picture.DataPropertyName = "image"
        resources.ApplyResources(Me.picture, "picture")
        Me.picture.Image = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.picture.Name = "picture"
        Me.picture.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        resources.ApplyResources(Me.IdDataGridViewTextBoxColumn, "IdDataGridViewTextBoxColumn")
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoznamkaDataGridViewTextBoxColumn
        '
        Me.PoznamkaDataGridViewTextBoxColumn.DataPropertyName = "destination"
        resources.ApplyResources(Me.PoznamkaDataGridViewTextBoxColumn, "PoznamkaDataGridViewTextBoxColumn")
        Me.PoznamkaDataGridViewTextBoxColumn.Name = "PoznamkaDataGridViewTextBoxColumn"
        Me.PoznamkaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArrivingVehiclesBindingSource
        '
        Me.ArrivingVehiclesBindingSource.DataMember = "Arriving_Vehicles"
        Me.ArrivingVehiclesBindingSource.DataSource = Me.Arriving_Vehicles_DataSet
        '
        'Arriving_Vehicles_DataSet
        '
        Me.Arriving_Vehicles_DataSet.DataSetName = "Arriving_Vehicles_DataSet"
        Me.Arriving_Vehicles_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Arriving_VehiclesTableAdapter
        '
        Me.Arriving_VehiclesTableAdapter.ClearBeforeFill = True
        '
        'Main_form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip = Me.win_tray_menu
        Me.Controls.Add(Me.pcx_autosave)
        Me.Controls.Add(Me.btn_insert_internal_dod_note)
        Me.Controls.Add(Me.btn_without_delivery_doc_no)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lb_destination)
        Me.Controls.Add(Me.cb_company)
        Me.Controls.Add(Me.lb_number_plate)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.lbl_destination)
        Me.Controls.Add(Me.txt_carrier_name)
        Me.Controls.Add(Me.txt_destination)
        Me.Controls.Add(Me.lbl_carrier_name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Clear_form)
        Me.Controls.Add(Me.btn_clean_detect)
        Me.Controls.Add(Me.dgw_detected_spz)
        Me.Controls.Add(Me.pcx_screenshot)
        Me.Controls.Add(Me.btn_dial_carrier)
        Me.Controls.Add(Me.gw_Arriving_Vehicles)
        Me.Controls.Add(Me.txt_outgoing)
        Me.Controls.Add(Me.btn_act_time)
        Me.Controls.Add(Me.txt_ingoing)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dt_rec_date)
        Me.Controls.Add(Me.lbl_act_datetime)
        Me.Controls.Add(Me.rbtn_outgoing)
        Me.Controls.Add(Me.rbtn_ingoing)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_delivery_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_use_spz)
        Me.Controls.Add(Me.txt_spz_field)
        Me.Controls.Add(Me.lst_carrier)
        Me.Controls.Add(Me.VideoCapture1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ANPREngine1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "Main_form"
        CType(Me.VideoCapture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANPREngine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gw_Arriving_Vehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.win_tray_menu.ResumeLayout(False)
        CType(Me.dgw_detected_spz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcx_screenshot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcx_autosave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrivingVehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arriving_Vehicles_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ANPREngine1 As AxDTKANPRLib.AxANPREngine
    Friend WithEvents btn_use_spz As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_delivery_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_Clear_form As System.Windows.Forms.Button
    Friend WithEvents txt_spz_field As System.Windows.Forms.TextBox
    Friend WithEvents rbtn_ingoing As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_outgoing As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_act_datetime As System.Windows.Forms.Label
    Friend WithEvents dt_rec_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ingoing As System.Windows.Forms.TextBox
    Friend WithEvents btn_act_time As System.Windows.Forms.Button
    Friend WithEvents txt_outgoing As System.Windows.Forms.TextBox
    Friend WithEvents lst_carrier As System.Windows.Forms.ComboBox
    Friend WithEvents GatewayidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gw_Arriving_Vehicles As System.Windows.Forms.DataGridView
    Friend WithEvents ArrivingVehiclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Arriving_VehiclesTableAdapter As BRANA_EV.Arriving_Vehicles_DataSetTableAdapters.Arriving_VehiclesTableAdapter
    Friend WithEvents tray_icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_dial_carrier As System.Windows.Forms.Button
    Friend WithEvents pcx_screenshot As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgw_detected_spz As System.Windows.Forms.DataGridView
    Friend WithEvents btn_clean_detect As System.Windows.Forms.Button
    Friend WithEvents spz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spz_shot As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents move_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents win_tray_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lsi_config As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lsi_history As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lsi_about As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lsi_end As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_carrier_name As System.Windows.Forms.Label
    Friend WithEvents txt_destination As System.Windows.Forms.TextBox
    Friend WithEvents txt_carrier_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_destination As System.Windows.Forms.Label
    Friend WithEvents lb_name As System.Windows.Forms.ListBox
    Friend WithEvents lb_number_plate As System.Windows.Forms.ListBox
    Friend WithEvents cb_company As System.Windows.Forms.CheckBox
    Friend WithEvents Arriving_Vehicles_DataSet As BRANA_EV.Arriving_Vehicles_DataSet
    Friend WithEvents lb_destination As System.Windows.Forms.ListBox
    Friend WithEvents lsi_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carrier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberplateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovementdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovementtimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picture As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoznamkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents poznamka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_without_delivery_doc_no As System.Windows.Forms.Button
    Friend WithEvents btn_insert_internal_dod_note As System.Windows.Forms.Button
    Friend WithEvents pcx_autosave As System.Windows.Forms.PictureBox
    Private WithEvents VideoCapture1 As AxDTKVideoCapLib.AxDTKVideoCapture
#End Region
End Class