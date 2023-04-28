<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gate_history
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gate_history))
        Me.dgw_list = New System.Windows.Forms.DataGridView()
        Me.BranaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DopravceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PříjezdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ČasPříjezduDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdjezdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ČasOdjezduDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokumentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picture1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.picture2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IDZáznamuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoznamkaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carrier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GatewayRecordBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_PORTERDataSet1 = New BRANA_EV.App_PORTERDataSet()
        Me.Gateway_RecordTableAdapter = New BRANA_EV.App_PORTERDataSetTableAdapters.Gateway_RecordTableAdapter()
        Me.cb_gate_filter = New System.Windows.Forms.ComboBox()
        Me.lbl_gate_filter = New System.Windows.Forms.Label()
        Me.dt_income_date_filter = New System.Windows.Forms.DateTimePicker()
        Me.tb_spz_filter = New System.Windows.Forms.TextBox()
        Me.lbl_spz_filter = New System.Windows.Forms.Label()
        Me.lbl_document_filter = New System.Windows.Forms.Label()
        Me.tb_document_filter = New System.Windows.Forms.TextBox()
        Me.btn_clear_spz = New System.Windows.Forms.Button()
        Me.btn_clear_document_filter = New System.Windows.Forms.Button()
        Me.btx_carrier_filter_clear = New System.Windows.Forms.Button()
        Me.lbl_carrier_filter = New System.Windows.Forms.Label()
        Me.txt_carrier_filter = New System.Windows.Forms.TextBox()
        Me.lbl_keyboard_help = New System.Windows.Forms.Label()
        Me.btn_clear_carrier_name = New System.Windows.Forms.Button()
        Me.lbl_carrier_name = New System.Windows.Forms.Label()
        Me.txt_carrier_name = New System.Windows.Forms.TextBox()
        Me.btn_destination = New System.Windows.Forms.Button()
        Me.lbl_destination = New System.Windows.Forms.Label()
        Me.txt_destination = New System.Windows.Forms.TextBox()
        Me.cb_all_records = New System.Windows.Forms.CheckBox()
        Me.dt_outcome_date_filter = New System.Windows.Forms.DateTimePicker()
        Me.cb_income_mark = New System.Windows.Forms.ComboBox()
        Me.cb_outcome_mark = New System.Windows.Forms.ComboBox()
        Me.lbl_outcome_date = New System.Windows.Forms.Label()
        Me.lbl_income_date = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.dud_date_binding = New System.Windows.Forms.DomainUpDown()
        CType(Me.dgw_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatewayRecordBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.App_PORTERDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgw_list
        '
        Me.dgw_list.AllowUserToAddRows = False
        Me.dgw_list.AllowUserToDeleteRows = False
        Me.dgw_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgw_list.AutoGenerateColumns = False
        Me.dgw_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BranaDataGridViewTextBoxColumn, Me.DopravceDataGridViewTextBoxColumn, Me.SpzDataGridViewTextBoxColumn, Me.PříjezdDataGridViewTextBoxColumn, Me.ČasPříjezduDataGridViewTextBoxColumn, Me.OdjezdDataGridViewTextBoxColumn, Me.ČasOdjezduDataGridViewTextBoxColumn, Me.DokumentDataGridViewTextBoxColumn, Me.picture1, Me.picture2, Me.IDZáznamuDataGridViewTextBoxColumn, Me.PoznamkaDataGridViewTextBoxColumn, Me.carrier_name, Me.destination})
        Me.dgw_list.DataSource = Me.GatewayRecordBindingSource2
        Me.dgw_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgw_list.Location = New System.Drawing.Point(-1, 49)
        Me.dgw_list.MultiSelect = False
        Me.dgw_list.Name = "dgw_list"
        Me.dgw_list.ReadOnly = True
        Me.dgw_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw_list.Size = New System.Drawing.Size(1135, 492)
        Me.dgw_list.TabIndex = 0
        Me.dgw_list.VirtualMode = True
        '
        'BranaDataGridViewTextBoxColumn
        '
        Me.BranaDataGridViewTextBoxColumn.DataPropertyName = "brana"
        Me.BranaDataGridViewTextBoxColumn.HeaderText = "brana"
        Me.BranaDataGridViewTextBoxColumn.Name = "BranaDataGridViewTextBoxColumn"
        Me.BranaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DopravceDataGridViewTextBoxColumn
        '
        Me.DopravceDataGridViewTextBoxColumn.DataPropertyName = "dopravce"
        Me.DopravceDataGridViewTextBoxColumn.HeaderText = "dopravce"
        Me.DopravceDataGridViewTextBoxColumn.Name = "DopravceDataGridViewTextBoxColumn"
        Me.DopravceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpzDataGridViewTextBoxColumn
        '
        Me.SpzDataGridViewTextBoxColumn.DataPropertyName = "spz"
        Me.SpzDataGridViewTextBoxColumn.HeaderText = "spz"
        Me.SpzDataGridViewTextBoxColumn.Name = "SpzDataGridViewTextBoxColumn"
        Me.SpzDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PříjezdDataGridViewTextBoxColumn
        '
        Me.PříjezdDataGridViewTextBoxColumn.DataPropertyName = "Příjezd"
        Me.PříjezdDataGridViewTextBoxColumn.HeaderText = "Příjezd"
        Me.PříjezdDataGridViewTextBoxColumn.Name = "PříjezdDataGridViewTextBoxColumn"
        Me.PříjezdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ČasPříjezduDataGridViewTextBoxColumn
        '
        Me.ČasPříjezduDataGridViewTextBoxColumn.DataPropertyName = "Čas Příjezdu"
        Me.ČasPříjezduDataGridViewTextBoxColumn.HeaderText = "Čas Příjezdu"
        Me.ČasPříjezduDataGridViewTextBoxColumn.Name = "ČasPříjezduDataGridViewTextBoxColumn"
        Me.ČasPříjezduDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OdjezdDataGridViewTextBoxColumn
        '
        Me.OdjezdDataGridViewTextBoxColumn.DataPropertyName = "Odjezd"
        Me.OdjezdDataGridViewTextBoxColumn.HeaderText = "Odjezd"
        Me.OdjezdDataGridViewTextBoxColumn.Name = "OdjezdDataGridViewTextBoxColumn"
        Me.OdjezdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ČasOdjezduDataGridViewTextBoxColumn
        '
        Me.ČasOdjezduDataGridViewTextBoxColumn.DataPropertyName = "Čas Odjezdu"
        Me.ČasOdjezduDataGridViewTextBoxColumn.HeaderText = "Čas Odjezdu"
        Me.ČasOdjezduDataGridViewTextBoxColumn.Name = "ČasOdjezduDataGridViewTextBoxColumn"
        Me.ČasOdjezduDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DokumentDataGridViewTextBoxColumn
        '
        Me.DokumentDataGridViewTextBoxColumn.DataPropertyName = "dokument"
        Me.DokumentDataGridViewTextBoxColumn.HeaderText = "dokument"
        Me.DokumentDataGridViewTextBoxColumn.Name = "DokumentDataGridViewTextBoxColumn"
        Me.DokumentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'picture1
        '
        Me.picture1.DataPropertyName = "Snímek Příjezdu"
        Me.picture1.HeaderText = "Snímek Příjezdu F1"
        Me.picture1.Image = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.picture1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.picture1.Name = "picture1"
        Me.picture1.ReadOnly = True
        '
        'picture2
        '
        Me.picture2.DataPropertyName = "Snímek Odjezdu"
        Me.picture2.HeaderText = "Snímek Odjezdu F2"
        Me.picture2.Image = Global.BRANA_EV.My.Resources.Resources.No_Cover_
        Me.picture2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.picture2.Name = "picture2"
        Me.picture2.ReadOnly = True
        '
        'IDZáznamuDataGridViewTextBoxColumn
        '
        Me.IDZáznamuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDZáznamuDataGridViewTextBoxColumn.DataPropertyName = "ID Záznamu"
        Me.IDZáznamuDataGridViewTextBoxColumn.HeaderText = "IDZ"
        Me.IDZáznamuDataGridViewTextBoxColumn.Name = "IDZáznamuDataGridViewTextBoxColumn"
        Me.IDZáznamuDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDZáznamuDataGridViewTextBoxColumn.Width = 30
        '
        'PoznamkaDataGridViewTextBoxColumn
        '
        Me.PoznamkaDataGridViewTextBoxColumn.DataPropertyName = "poznamka"
        Me.PoznamkaDataGridViewTextBoxColumn.HeaderText = "poznamka"
        Me.PoznamkaDataGridViewTextBoxColumn.Name = "PoznamkaDataGridViewTextBoxColumn"
        Me.PoznamkaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoznamkaDataGridViewTextBoxColumn.Visible = False
        '
        'carrier_name
        '
        Me.carrier_name.DataPropertyName = "carrier_name"
        Me.carrier_name.HeaderText = "Jméno"
        Me.carrier_name.Name = "carrier_name"
        Me.carrier_name.ReadOnly = True
        '
        'destination
        '
        Me.destination.DataPropertyName = "destination"
        Me.destination.HeaderText = "Cíl Cesty"
        Me.destination.Name = "destination"
        Me.destination.ReadOnly = True
        '
        'GatewayRecordBindingSource2
        '
        Me.GatewayRecordBindingSource2.DataMember = "Gateway_Record"
        Me.GatewayRecordBindingSource2.DataSource = Me.App_PORTERDataSet1
        '
        'App_PORTERDataSet1
        '
        Me.App_PORTERDataSet1.DataSetName = "App_PORTERDataSet"
        Me.App_PORTERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gateway_RecordTableAdapter
        '
        Me.Gateway_RecordTableAdapter.ClearBeforeFill = True
        '
        'cb_gate_filter
        '
        Me.cb_gate_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gate_filter.Location = New System.Drawing.Point(-1, 22)
        Me.cb_gate_filter.Name = "cb_gate_filter"
        Me.cb_gate_filter.Size = New System.Drawing.Size(109, 21)
        Me.cb_gate_filter.Sorted = True
        Me.cb_gate_filter.TabIndex = 1
        '
        'lbl_gate_filter
        '
        Me.lbl_gate_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_gate_filter.Location = New System.Drawing.Point(-4, -1)
        Me.lbl_gate_filter.Name = "lbl_gate_filter"
        Me.lbl_gate_filter.Size = New System.Drawing.Size(112, 20)
        Me.lbl_gate_filter.TabIndex = 2
        Me.lbl_gate_filter.Text = "Brána"
        Me.lbl_gate_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dt_income_date_filter
        '
        Me.dt_income_date_filter.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_income_date_filter.Location = New System.Drawing.Point(829, 5)
        Me.dt_income_date_filter.Name = "dt_income_date_filter"
        Me.dt_income_date_filter.ShowCheckBox = True
        Me.dt_income_date_filter.Size = New System.Drawing.Size(97, 20)
        Me.dt_income_date_filter.TabIndex = 3
        '
        'tb_spz_filter
        '
        Me.tb_spz_filter.Location = New System.Drawing.Point(248, 24)
        Me.tb_spz_filter.Name = "tb_spz_filter"
        Me.tb_spz_filter.Size = New System.Drawing.Size(87, 20)
        Me.tb_spz_filter.TabIndex = 5
        '
        'lbl_spz_filter
        '
        Me.lbl_spz_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_spz_filter.Location = New System.Drawing.Point(248, 2)
        Me.lbl_spz_filter.Name = "lbl_spz_filter"
        Me.lbl_spz_filter.Size = New System.Drawing.Size(97, 20)
        Me.lbl_spz_filter.TabIndex = 6
        Me.lbl_spz_filter.Text = "SPZ"
        Me.lbl_spz_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_document_filter
        '
        Me.lbl_document_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_document_filter.Location = New System.Drawing.Point(351, 2)
        Me.lbl_document_filter.Name = "lbl_document_filter"
        Me.lbl_document_filter.Size = New System.Drawing.Size(101, 20)
        Me.lbl_document_filter.TabIndex = 7
        Me.lbl_document_filter.Text = "Dokument"
        Me.lbl_document_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_document_filter
        '
        Me.tb_document_filter.Location = New System.Drawing.Point(351, 25)
        Me.tb_document_filter.Name = "tb_document_filter"
        Me.tb_document_filter.Size = New System.Drawing.Size(101, 20)
        Me.tb_document_filter.TabIndex = 8
        '
        'btn_clear_spz
        '
        Me.btn_clear_spz.Location = New System.Drawing.Point(331, 22)
        Me.btn_clear_spz.Name = "btn_clear_spz"
        Me.btn_clear_spz.Size = New System.Drawing.Size(14, 24)
        Me.btn_clear_spz.TabIndex = 9
        Me.btn_clear_spz.Text = "X"
        Me.btn_clear_spz.UseVisualStyleBackColor = True
        '
        'btn_clear_document_filter
        '
        Me.btn_clear_document_filter.Location = New System.Drawing.Point(449, 23)
        Me.btn_clear_document_filter.Name = "btn_clear_document_filter"
        Me.btn_clear_document_filter.Size = New System.Drawing.Size(14, 23)
        Me.btn_clear_document_filter.TabIndex = 10
        Me.btn_clear_document_filter.Text = "X"
        Me.btn_clear_document_filter.UseVisualStyleBackColor = True
        '
        'btx_carrier_filter_clear
        '
        Me.btx_carrier_filter_clear.Location = New System.Drawing.Point(228, 24)
        Me.btx_carrier_filter_clear.Name = "btx_carrier_filter_clear"
        Me.btx_carrier_filter_clear.Size = New System.Drawing.Size(14, 22)
        Me.btx_carrier_filter_clear.TabIndex = 13
        Me.btx_carrier_filter_clear.Text = "X"
        Me.btx_carrier_filter_clear.UseVisualStyleBackColor = True
        '
        'lbl_carrier_filter
        '
        Me.lbl_carrier_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_carrier_filter.Location = New System.Drawing.Point(114, 2)
        Me.lbl_carrier_filter.Name = "lbl_carrier_filter"
        Me.lbl_carrier_filter.Size = New System.Drawing.Size(128, 20)
        Me.lbl_carrier_filter.TabIndex = 12
        Me.lbl_carrier_filter.Text = "Dopravce"
        Me.lbl_carrier_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_carrier_filter
        '
        Me.txt_carrier_filter.Location = New System.Drawing.Point(114, 24)
        Me.txt_carrier_filter.Name = "txt_carrier_filter"
        Me.txt_carrier_filter.Size = New System.Drawing.Size(118, 20)
        Me.txt_carrier_filter.TabIndex = 11
        '
        'lbl_keyboard_help
        '
        Me.lbl_keyboard_help.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_keyboard_help.Location = New System.Drawing.Point(-1, 544)
        Me.lbl_keyboard_help.Name = "lbl_keyboard_help"
        Me.lbl_keyboard_help.Size = New System.Drawing.Size(397, 21)
        Me.lbl_keyboard_help.TabIndex = 14
        Me.lbl_keyboard_help.Text = "Funkční Klávesy: F1 / F2 / Enter"
        '
        'btn_clear_carrier_name
        '
        Me.btn_clear_carrier_name.Location = New System.Drawing.Point(560, 24)
        Me.btn_clear_carrier_name.Name = "btn_clear_carrier_name"
        Me.btn_clear_carrier_name.Size = New System.Drawing.Size(14, 22)
        Me.btn_clear_carrier_name.TabIndex = 17
        Me.btn_clear_carrier_name.Text = "X"
        Me.btn_clear_carrier_name.UseVisualStyleBackColor = True
        '
        'lbl_carrier_name
        '
        Me.lbl_carrier_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_carrier_name.Location = New System.Drawing.Point(466, 2)
        Me.lbl_carrier_name.Name = "lbl_carrier_name"
        Me.lbl_carrier_name.Size = New System.Drawing.Size(105, 20)
        Me.lbl_carrier_name.TabIndex = 16
        Me.lbl_carrier_name.Text = "Jméno"
        Me.lbl_carrier_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_carrier_name
        '
        Me.txt_carrier_name.Location = New System.Drawing.Point(469, 25)
        Me.txt_carrier_name.Name = "txt_carrier_name"
        Me.txt_carrier_name.Size = New System.Drawing.Size(94, 20)
        Me.txt_carrier_name.TabIndex = 15
        '
        'btn_destination
        '
        Me.btn_destination.Location = New System.Drawing.Point(691, 25)
        Me.btn_destination.Name = "btn_destination"
        Me.btn_destination.Size = New System.Drawing.Size(14, 20)
        Me.btn_destination.TabIndex = 20
        Me.btn_destination.Text = "X"
        Me.btn_destination.UseVisualStyleBackColor = True
        '
        'lbl_destination
        '
        Me.lbl_destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_destination.Location = New System.Drawing.Point(577, 2)
        Me.lbl_destination.Name = "lbl_destination"
        Me.lbl_destination.Size = New System.Drawing.Size(125, 20)
        Me.lbl_destination.TabIndex = 19
        Me.lbl_destination.Text = "Cíl Cesty"
        Me.lbl_destination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_destination
        '
        Me.txt_destination.Location = New System.Drawing.Point(580, 25)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.Size = New System.Drawing.Size(118, 20)
        Me.txt_destination.TabIndex = 18
        '
        'cb_all_records
        '
        Me.cb_all_records.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_all_records.Location = New System.Drawing.Point(976, 8)
        Me.cb_all_records.Name = "cb_all_records"
        Me.cb_all_records.Size = New System.Drawing.Size(66, 36)
        Me.cb_all_records.TabIndex = 22
        Me.cb_all_records.Text = "NEBO VŠE"
        Me.cb_all_records.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_all_records.UseVisualStyleBackColor = True
        '
        'dt_outcome_date_filter
        '
        Me.dt_outcome_date_filter.Checked = False
        Me.dt_outcome_date_filter.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_outcome_date_filter.Location = New System.Drawing.Point(829, 26)
        Me.dt_outcome_date_filter.Name = "dt_outcome_date_filter"
        Me.dt_outcome_date_filter.ShowCheckBox = True
        Me.dt_outcome_date_filter.Size = New System.Drawing.Size(97, 20)
        Me.dt_outcome_date_filter.TabIndex = 23
        '
        'cb_income_mark
        '
        Me.cb_income_mark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_income_mark.FormattingEnabled = True
        Me.cb_income_mark.Items.AddRange(New Object() {"=", ">", "<", ">=", "<=", "<>"})
        Me.cb_income_mark.Location = New System.Drawing.Point(932, 5)
        Me.cb_income_mark.Name = "cb_income_mark"
        Me.cb_income_mark.Size = New System.Drawing.Size(38, 21)
        Me.cb_income_mark.TabIndex = 27
        '
        'cb_outcome_mark
        '
        Me.cb_outcome_mark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_outcome_mark.FormattingEnabled = True
        Me.cb_outcome_mark.Items.AddRange(New Object() {"=", ">", "<", ">=", "<=", "<>"})
        Me.cb_outcome_mark.Location = New System.Drawing.Point(932, 25)
        Me.cb_outcome_mark.Name = "cb_outcome_mark"
        Me.cb_outcome_mark.Size = New System.Drawing.Size(38, 21)
        Me.cb_outcome_mark.TabIndex = 28
        '
        'lbl_outcome_date
        '
        Me.lbl_outcome_date.AutoSize = True
        Me.lbl_outcome_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_outcome_date.Location = New System.Drawing.Point(711, 33)
        Me.lbl_outcome_date.Name = "lbl_outcome_date"
        Me.lbl_outcome_date.Size = New System.Drawing.Size(113, 16)
        Me.lbl_outcome_date.TabIndex = 29
        Me.lbl_outcome_date.Text = "Datum Odjezdu"
        '
        'lbl_income_date
        '
        Me.lbl_income_date.AutoSize = True
        Me.lbl_income_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_income_date.Location = New System.Drawing.Point(711, -1)
        Me.lbl_income_date.Name = "lbl_income_date"
        Me.lbl_income_date.Size = New System.Drawing.Size(112, 16)
        Me.lbl_income_date.TabIndex = 30
        Me.lbl_income_date.Text = "Datum Příjezdu"
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(1052, 2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(74, 44)
        Me.btn_submit.TabIndex = 31
        Me.btn_submit.Text = "Načíst Data"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'dud_date_binding
        '
        Me.dud_date_binding.Enabled = False
        Me.dud_date_binding.Items.Add("AND")
        Me.dud_date_binding.Items.Add("OR")
        Me.dud_date_binding.Location = New System.Drawing.Point(776, 14)
        Me.dud_date_binding.Name = "dud_date_binding"
        Me.dud_date_binding.Size = New System.Drawing.Size(51, 20)
        Me.dud_date_binding.TabIndex = 32
        '
        'frm_gate_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 562)
        Me.Controls.Add(Me.dud_date_binding)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.lbl_income_date)
        Me.Controls.Add(Me.lbl_outcome_date)
        Me.Controls.Add(Me.cb_outcome_mark)
        Me.Controls.Add(Me.cb_income_mark)
        Me.Controls.Add(Me.dt_outcome_date_filter)
        Me.Controls.Add(Me.cb_all_records)
        Me.Controls.Add(Me.btn_destination)
        Me.Controls.Add(Me.lbl_destination)
        Me.Controls.Add(Me.txt_destination)
        Me.Controls.Add(Me.btn_clear_carrier_name)
        Me.Controls.Add(Me.lbl_carrier_name)
        Me.Controls.Add(Me.txt_carrier_name)
        Me.Controls.Add(Me.lbl_keyboard_help)
        Me.Controls.Add(Me.btx_carrier_filter_clear)
        Me.Controls.Add(Me.lbl_carrier_filter)
        Me.Controls.Add(Me.txt_carrier_filter)
        Me.Controls.Add(Me.btn_clear_document_filter)
        Me.Controls.Add(Me.btn_clear_spz)
        Me.Controls.Add(Me.tb_document_filter)
        Me.Controls.Add(Me.lbl_document_filter)
        Me.Controls.Add(Me.lbl_spz_filter)
        Me.Controls.Add(Me.tb_spz_filter)
        Me.Controls.Add(Me.dt_income_date_filter)
        Me.Controls.Add(Me.lbl_gate_filter)
        Me.Controls.Add(Me.cb_gate_filter)
        Me.Controls.Add(Me.dgw_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frm_gate_history"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historie Provozu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgw_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatewayRecordBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.App_PORTERDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgw_list As System.Windows.Forms.DataGridView
    Friend WithEvents Gateway_RecordTableAdapter As BRANA_EV.App_PORTERDataSetTableAdapters.Gateway_RecordTableAdapter
    Friend WithEvents cb_gate_filter As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_gate_filter As System.Windows.Forms.Label
    Friend WithEvents dt_income_date_filter As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_spz_filter As System.Windows.Forms.TextBox
    Friend WithEvents lbl_spz_filter As System.Windows.Forms.Label
    Friend WithEvents lbl_document_filter As System.Windows.Forms.Label
    Friend WithEvents tb_document_filter As System.Windows.Forms.TextBox
    Friend WithEvents btn_clear_spz As System.Windows.Forms.Button
    Friend WithEvents btn_clear_document_filter As System.Windows.Forms.Button
    Friend WithEvents btx_carrier_filter_clear As System.Windows.Forms.Button
    Friend WithEvents lbl_carrier_filter As System.Windows.Forms.Label
    Friend WithEvents txt_carrier_filter As System.Windows.Forms.TextBox
    Friend WithEvents App_PORTERDataSet1 As BRANA_EV.App_PORTERDataSet
    Friend WithEvents GatewayRecordBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_keyboard_help As System.Windows.Forms.Label
    Friend WithEvents BranaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DopravceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PříjezdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ČasPříjezduDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdjezdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ČasOdjezduDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DokumentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picture1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents picture2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IDZáznamuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoznamkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carrier_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents destination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_clear_carrier_name As System.Windows.Forms.Button
    Friend WithEvents lbl_carrier_name As System.Windows.Forms.Label
    Friend WithEvents txt_carrier_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_destination As System.Windows.Forms.Button
    Friend WithEvents lbl_destination As System.Windows.Forms.Label
    Friend WithEvents txt_destination As System.Windows.Forms.TextBox
    Friend WithEvents cb_all_records As System.Windows.Forms.CheckBox
    Friend WithEvents dt_outcome_date_filter As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_income_mark As System.Windows.Forms.ComboBox
    Friend WithEvents cb_outcome_mark As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_outcome_date As System.Windows.Forms.Label
    Friend WithEvents lbl_income_date As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents dud_date_binding As System.Windows.Forms.DomainUpDown
End Class
