<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_record_note
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
        Me.btn_only_close = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.txt_history_note = New System.Windows.Forms.TextBox()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.lbl_ingoing_date = New System.Windows.Forms.Label()
        Me.txt_date_in = New System.Windows.Forms.TextBox()
        Me.txt_spz_in = New System.Windows.Forms.TextBox()
        Me.lbl_spz_in = New System.Windows.Forms.Label()
        Me.txt_dodl_in = New System.Windows.Forms.TextBox()
        Me.lbl_dodl_in = New System.Windows.Forms.Label()
        Me.lbl_ingoing = New System.Windows.Forms.Label()
        Me.txt_carrier_in = New System.Windows.Forms.TextBox()
        Me.lbl_carrier_in = New System.Windows.Forms.Label()
        Me.txt_name_in = New System.Windows.Forms.TextBox()
        Me.lbl_name_in = New System.Windows.Forms.Label()
        Me.txt_way_target_in = New System.Windows.Forms.TextBox()
        Me.lbl_way_target_in = New System.Windows.Forms.Label()
        Me.txt_time_in = New System.Windows.Forms.TextBox()
        Me.lbl_time_in = New System.Windows.Forms.Label()
        Me.txt_time_out = New System.Windows.Forms.TextBox()
        Me.lbl_time_out = New System.Windows.Forms.Label()
        Me.txt_way_target_out = New System.Windows.Forms.TextBox()
        Me.lbl_way_target_out = New System.Windows.Forms.Label()
        Me.txt_name_out = New System.Windows.Forms.TextBox()
        Me.lbl_name_out = New System.Windows.Forms.Label()
        Me.txt_carrier_out = New System.Windows.Forms.TextBox()
        Me.lbl_carrier_out = New System.Windows.Forms.Label()
        Me.txt_dodl_out = New System.Windows.Forms.TextBox()
        Me.lbl_dodl_out = New System.Windows.Forms.Label()
        Me.txt_spz_out = New System.Windows.Forms.TextBox()
        Me.lbl_spz_out = New System.Windows.Forms.Label()
        Me.txt_date_out = New System.Windows.Forms.TextBox()
        Me.lbl_date_out = New System.Windows.Forms.Label()
        Me.lbl_outgoing = New System.Windows.Forms.Label()
        Me.lbl_note_history = New System.Windows.Forms.Label()
        Me.txt_gate_in = New System.Windows.Forms.TextBox()
        Me.lbl_gate_in = New System.Windows.Forms.Label()
        Me.txt_gate_out = New System.Windows.Forms.TextBox()
        Me.lbl_gate_out = New System.Windows.Forms.Label()
        Me.lbl_status_in = New System.Windows.Forms.Label()
        Me.lbl_status_out = New System.Windows.Forms.Label()
        Me.btn_income_savebtn_income_save = New System.Windows.Forms.Button()
        Me.bnt_outgoing_save = New System.Windows.Forms.Button()
        Me.txt_outgoing_id = New System.Windows.Forms.TextBox()
        Me.txt_incoming_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_only_close
        '
        Me.btn_only_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_only_close.Location = New System.Drawing.Point(5, 430)
        Me.btn_only_close.Name = "btn_only_close"
        Me.btn_only_close.Size = New System.Drawing.Size(94, 23)
        Me.btn_only_close.TabIndex = 4
        Me.btn_only_close.Text = "Zavřít"
        Me.btn_only_close.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Location = New System.Drawing.Point(628, 430)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(142, 23)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Uložit Poznámku a Zavřít"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'txt_note
        '
        Me.txt_note.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_note.Location = New System.Drawing.Point(-1, 177)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(771, 103)
        Me.txt_note.TabIndex = 5
        '
        'txt_history_note
        '
        Me.txt_history_note.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_history_note.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_history_note.Location = New System.Drawing.Point(-1, 302)
        Me.txt_history_note.Multiline = True
        Me.txt_history_note.Name = "txt_history_note"
        Me.txt_history_note.ReadOnly = True
        Me.txt_history_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_history_note.Size = New System.Drawing.Size(771, 122)
        Me.txt_history_note.TabIndex = 6
        '
        'lbl_note
        '
        Me.lbl_note.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_note.Location = New System.Drawing.Point(1, 154)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(92, 20)
        Me.lbl_note.TabIndex = 7
        Me.lbl_note.Text = "Poznámka"
        '
        'lbl_ingoing_date
        '
        Me.lbl_ingoing_date.AutoSize = True
        Me.lbl_ingoing_date.Location = New System.Drawing.Point(8, 39)
        Me.lbl_ingoing_date.Name = "lbl_ingoing_date"
        Me.lbl_ingoing_date.Size = New System.Drawing.Size(58, 13)
        Me.lbl_ingoing_date.TabIndex = 9
        Me.lbl_ingoing_date.Text = "Datum Př.:"
        '
        'txt_date_in
        '
        Me.txt_date_in.Location = New System.Drawing.Point(5, 55)
        Me.txt_date_in.Name = "txt_date_in"
        Me.txt_date_in.ReadOnly = True
        Me.txt_date_in.Size = New System.Drawing.Size(69, 20)
        Me.txt_date_in.TabIndex = 10
        '
        'txt_spz_in
        '
        Me.txt_spz_in.Location = New System.Drawing.Point(175, 55)
        Me.txt_spz_in.Name = "txt_spz_in"
        Me.txt_spz_in.ReadOnly = True
        Me.txt_spz_in.Size = New System.Drawing.Size(89, 20)
        Me.txt_spz_in.TabIndex = 12
        '
        'lbl_spz_in
        '
        Me.lbl_spz_in.AutoSize = True
        Me.lbl_spz_in.Location = New System.Drawing.Point(205, 39)
        Me.lbl_spz_in.Name = "lbl_spz_in"
        Me.lbl_spz_in.Size = New System.Drawing.Size(28, 13)
        Me.lbl_spz_in.TabIndex = 11
        Me.lbl_spz_in.Text = "SPZ"
        '
        'txt_dodl_in
        '
        Me.txt_dodl_in.Location = New System.Drawing.Point(270, 55)
        Me.txt_dodl_in.Name = "txt_dodl_in"
        Me.txt_dodl_in.Size = New System.Drawing.Size(127, 20)
        Me.txt_dodl_in.TabIndex = 14
        '
        'lbl_dodl_in
        '
        Me.lbl_dodl_in.AutoSize = True
        Me.lbl_dodl_in.Location = New System.Drawing.Point(300, 39)
        Me.lbl_dodl_in.Name = "lbl_dodl_in"
        Me.lbl_dodl_in.Size = New System.Drawing.Size(67, 13)
        Me.lbl_dodl_in.TabIndex = 13
        Me.lbl_dodl_in.Text = "Dodací Listy"
        '
        'lbl_ingoing
        '
        Me.lbl_ingoing.AutoSize = True
        Me.lbl_ingoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_ingoing.Location = New System.Drawing.Point(1, 9)
        Me.lbl_ingoing.Name = "lbl_ingoing"
        Me.lbl_ingoing.Size = New System.Drawing.Size(63, 20)
        Me.lbl_ingoing.TabIndex = 8
        Me.lbl_ingoing.Text = "Příjezd"
        '
        'txt_carrier_in
        '
        Me.txt_carrier_in.Location = New System.Drawing.Point(403, 55)
        Me.txt_carrier_in.Name = "txt_carrier_in"
        Me.txt_carrier_in.ReadOnly = True
        Me.txt_carrier_in.Size = New System.Drawing.Size(127, 20)
        Me.txt_carrier_in.TabIndex = 16
        '
        'lbl_carrier_in
        '
        Me.lbl_carrier_in.AutoSize = True
        Me.lbl_carrier_in.Location = New System.Drawing.Point(433, 39)
        Me.lbl_carrier_in.Name = "lbl_carrier_in"
        Me.lbl_carrier_in.Size = New System.Drawing.Size(57, 13)
        Me.lbl_carrier_in.TabIndex = 15
        Me.lbl_carrier_in.Text = "Přepravce"
        '
        'txt_name_in
        '
        Me.txt_name_in.Location = New System.Drawing.Point(536, 55)
        Me.txt_name_in.Name = "txt_name_in"
        Me.txt_name_in.ReadOnly = True
        Me.txt_name_in.Size = New System.Drawing.Size(124, 20)
        Me.txt_name_in.TabIndex = 18
        '
        'lbl_name_in
        '
        Me.lbl_name_in.AutoSize = True
        Me.lbl_name_in.Location = New System.Drawing.Point(575, 39)
        Me.lbl_name_in.Name = "lbl_name_in"
        Me.lbl_name_in.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name_in.TabIndex = 17
        Me.lbl_name_in.Text = "Jméno"
        '
        'txt_way_target_in
        '
        Me.txt_way_target_in.Location = New System.Drawing.Point(666, 55)
        Me.txt_way_target_in.Name = "txt_way_target_in"
        Me.txt_way_target_in.ReadOnly = True
        Me.txt_way_target_in.Size = New System.Drawing.Size(103, 20)
        Me.txt_way_target_in.TabIndex = 20
        '
        'lbl_way_target_in
        '
        Me.lbl_way_target_in.AutoSize = True
        Me.lbl_way_target_in.Location = New System.Drawing.Point(696, 39)
        Me.lbl_way_target_in.Name = "lbl_way_target_in"
        Me.lbl_way_target_in.Size = New System.Drawing.Size(49, 13)
        Me.lbl_way_target_in.TabIndex = 19
        Me.lbl_way_target_in.Text = "Cíl Cesty"
        '
        'txt_time_in
        '
        Me.txt_time_in.Location = New System.Drawing.Point(80, 55)
        Me.txt_time_in.Name = "txt_time_in"
        Me.txt_time_in.ReadOnly = True
        Me.txt_time_in.Size = New System.Drawing.Size(89, 20)
        Me.txt_time_in.TabIndex = 22
        '
        'lbl_time_in
        '
        Me.lbl_time_in.AutoSize = True
        Me.lbl_time_in.Location = New System.Drawing.Point(90, 39)
        Me.lbl_time_in.Name = "lbl_time_in"
        Me.lbl_time_in.Size = New System.Drawing.Size(68, 13)
        Me.lbl_time_in.TabIndex = 21
        Me.lbl_time_in.Text = "Čas Příjezdu"
        '
        'txt_time_out
        '
        Me.txt_time_out.Location = New System.Drawing.Point(80, 130)
        Me.txt_time_out.Name = "txt_time_out"
        Me.txt_time_out.ReadOnly = True
        Me.txt_time_out.Size = New System.Drawing.Size(89, 20)
        Me.txt_time_out.TabIndex = 37
        '
        'lbl_time_out
        '
        Me.lbl_time_out.AutoSize = True
        Me.lbl_time_out.Location = New System.Drawing.Point(90, 114)
        Me.lbl_time_out.Name = "lbl_time_out"
        Me.lbl_time_out.Size = New System.Drawing.Size(67, 13)
        Me.lbl_time_out.TabIndex = 36
        Me.lbl_time_out.Text = "Čas Odjezdu"
        '
        'txt_way_target_out
        '
        Me.txt_way_target_out.Location = New System.Drawing.Point(666, 130)
        Me.txt_way_target_out.Name = "txt_way_target_out"
        Me.txt_way_target_out.ReadOnly = True
        Me.txt_way_target_out.Size = New System.Drawing.Size(103, 20)
        Me.txt_way_target_out.TabIndex = 35
        '
        'lbl_way_target_out
        '
        Me.lbl_way_target_out.AutoSize = True
        Me.lbl_way_target_out.Location = New System.Drawing.Point(696, 114)
        Me.lbl_way_target_out.Name = "lbl_way_target_out"
        Me.lbl_way_target_out.Size = New System.Drawing.Size(49, 13)
        Me.lbl_way_target_out.TabIndex = 34
        Me.lbl_way_target_out.Text = "Cíl Cesty"
        '
        'txt_name_out
        '
        Me.txt_name_out.Location = New System.Drawing.Point(536, 130)
        Me.txt_name_out.Name = "txt_name_out"
        Me.txt_name_out.ReadOnly = True
        Me.txt_name_out.Size = New System.Drawing.Size(124, 20)
        Me.txt_name_out.TabIndex = 33
        '
        'lbl_name_out
        '
        Me.lbl_name_out.AutoSize = True
        Me.lbl_name_out.Location = New System.Drawing.Point(575, 114)
        Me.lbl_name_out.Name = "lbl_name_out"
        Me.lbl_name_out.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name_out.TabIndex = 32
        Me.lbl_name_out.Text = "Jméno"
        '
        'txt_carrier_out
        '
        Me.txt_carrier_out.Location = New System.Drawing.Point(403, 130)
        Me.txt_carrier_out.Name = "txt_carrier_out"
        Me.txt_carrier_out.ReadOnly = True
        Me.txt_carrier_out.Size = New System.Drawing.Size(127, 20)
        Me.txt_carrier_out.TabIndex = 31
        '
        'lbl_carrier_out
        '
        Me.lbl_carrier_out.AutoSize = True
        Me.lbl_carrier_out.Location = New System.Drawing.Point(433, 114)
        Me.lbl_carrier_out.Name = "lbl_carrier_out"
        Me.lbl_carrier_out.Size = New System.Drawing.Size(57, 13)
        Me.lbl_carrier_out.TabIndex = 30
        Me.lbl_carrier_out.Text = "Přepravce"
        '
        'txt_dodl_out
        '
        Me.txt_dodl_out.Location = New System.Drawing.Point(270, 130)
        Me.txt_dodl_out.Name = "txt_dodl_out"
        Me.txt_dodl_out.Size = New System.Drawing.Size(127, 20)
        Me.txt_dodl_out.TabIndex = 29
        '
        'lbl_dodl_out
        '
        Me.lbl_dodl_out.AutoSize = True
        Me.lbl_dodl_out.Location = New System.Drawing.Point(300, 114)
        Me.lbl_dodl_out.Name = "lbl_dodl_out"
        Me.lbl_dodl_out.Size = New System.Drawing.Size(67, 13)
        Me.lbl_dodl_out.TabIndex = 28
        Me.lbl_dodl_out.Text = "Dodací Listy"
        '
        'txt_spz_out
        '
        Me.txt_spz_out.Location = New System.Drawing.Point(175, 130)
        Me.txt_spz_out.Name = "txt_spz_out"
        Me.txt_spz_out.ReadOnly = True
        Me.txt_spz_out.Size = New System.Drawing.Size(89, 20)
        Me.txt_spz_out.TabIndex = 27
        '
        'lbl_spz_out
        '
        Me.lbl_spz_out.AutoSize = True
        Me.lbl_spz_out.Location = New System.Drawing.Point(205, 114)
        Me.lbl_spz_out.Name = "lbl_spz_out"
        Me.lbl_spz_out.Size = New System.Drawing.Size(28, 13)
        Me.lbl_spz_out.TabIndex = 26
        Me.lbl_spz_out.Text = "SPZ"
        '
        'txt_date_out
        '
        Me.txt_date_out.Location = New System.Drawing.Point(5, 130)
        Me.txt_date_out.Name = "txt_date_out"
        Me.txt_date_out.ReadOnly = True
        Me.txt_date_out.Size = New System.Drawing.Size(69, 20)
        Me.txt_date_out.TabIndex = 25
        '
        'lbl_date_out
        '
        Me.lbl_date_out.AutoSize = True
        Me.lbl_date_out.Location = New System.Drawing.Point(8, 114)
        Me.lbl_date_out.Name = "lbl_date_out"
        Me.lbl_date_out.Size = New System.Drawing.Size(63, 13)
        Me.lbl_date_out.TabIndex = 24
        Me.lbl_date_out.Text = "Datum Odj.:"
        '
        'lbl_outgoing
        '
        Me.lbl_outgoing.AutoSize = True
        Me.lbl_outgoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_outgoing.Location = New System.Drawing.Point(1, 83)
        Me.lbl_outgoing.Name = "lbl_outgoing"
        Me.lbl_outgoing.Size = New System.Drawing.Size(65, 20)
        Me.lbl_outgoing.TabIndex = 23
        Me.lbl_outgoing.Text = "Odjezd"
        '
        'lbl_note_history
        '
        Me.lbl_note_history.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_note_history.AutoSize = True
        Me.lbl_note_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_note_history.Location = New System.Drawing.Point(1, 279)
        Me.lbl_note_history.Name = "lbl_note_history"
        Me.lbl_note_history.Size = New System.Drawing.Size(159, 20)
        Me.lbl_note_history.TabIndex = 38
        Me.lbl_note_history.Text = "Historie Poznámek"
        '
        'txt_gate_in
        '
        Me.txt_gate_in.Location = New System.Drawing.Point(666, 14)
        Me.txt_gate_in.Name = "txt_gate_in"
        Me.txt_gate_in.ReadOnly = True
        Me.txt_gate_in.Size = New System.Drawing.Size(103, 20)
        Me.txt_gate_in.TabIndex = 40
        '
        'lbl_gate_in
        '
        Me.lbl_gate_in.AutoSize = True
        Me.lbl_gate_in.Location = New System.Drawing.Point(582, 16)
        Me.lbl_gate_in.Name = "lbl_gate_in"
        Me.lbl_gate_in.Size = New System.Drawing.Size(78, 13)
        Me.lbl_gate_in.TabIndex = 39
        Me.lbl_gate_in.Text = "Brána Příjezdu"
        '
        'txt_gate_out
        '
        Me.txt_gate_out.Location = New System.Drawing.Point(666, 87)
        Me.txt_gate_out.Name = "txt_gate_out"
        Me.txt_gate_out.ReadOnly = True
        Me.txt_gate_out.Size = New System.Drawing.Size(103, 20)
        Me.txt_gate_out.TabIndex = 42
        '
        'lbl_gate_out
        '
        Me.lbl_gate_out.AutoSize = True
        Me.lbl_gate_out.Location = New System.Drawing.Point(582, 90)
        Me.lbl_gate_out.Name = "lbl_gate_out"
        Me.lbl_gate_out.Size = New System.Drawing.Size(77, 13)
        Me.lbl_gate_out.TabIndex = 41
        Me.lbl_gate_out.Text = "Brána Odjezdu"
        '
        'lbl_status_in
        '
        Me.lbl_status_in.AutoSize = True
        Me.lbl_status_in.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_in.ForeColor = System.Drawing.Color.Red
        Me.lbl_status_in.Location = New System.Drawing.Point(348, 10)
        Me.lbl_status_in.Name = "lbl_status_in"
        Me.lbl_status_in.Size = New System.Drawing.Size(124, 19)
        Me.lbl_status_in.TabIndex = 43
        Me.lbl_status_in.Text = "STORNOVÁN"
        Me.lbl_status_in.Visible = False
        '
        'lbl_status_out
        '
        Me.lbl_status_out.AutoSize = True
        Me.lbl_status_out.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_out.ForeColor = System.Drawing.Color.Red
        Me.lbl_status_out.Location = New System.Drawing.Point(348, 88)
        Me.lbl_status_out.Name = "lbl_status_out"
        Me.lbl_status_out.Size = New System.Drawing.Size(124, 19)
        Me.lbl_status_out.TabIndex = 44
        Me.lbl_status_out.Text = "STORNOVÁN"
        Me.lbl_status_out.Visible = False
        '
        'btn_income_savebtn_income_save
        '
        Me.btn_income_savebtn_income_save.Location = New System.Drawing.Point(270, 74)
        Me.btn_income_savebtn_income_save.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_income_savebtn_income_save.Name = "btn_income_savebtn_income_save"
        Me.btn_income_savebtn_income_save.Size = New System.Drawing.Size(44, 21)
        Me.btn_income_savebtn_income_save.TabIndex = 45
        Me.btn_income_savebtn_income_save.Text = "Uložit"
        Me.btn_income_savebtn_income_save.UseVisualStyleBackColor = True
        '
        'bnt_outgoing_save
        '
        Me.bnt_outgoing_save.Location = New System.Drawing.Point(270, 149)
        Me.bnt_outgoing_save.Margin = New System.Windows.Forms.Padding(0)
        Me.bnt_outgoing_save.Name = "bnt_outgoing_save"
        Me.bnt_outgoing_save.Size = New System.Drawing.Size(44, 21)
        Me.bnt_outgoing_save.TabIndex = 46
        Me.bnt_outgoing_save.Text = "Uložit"
        Me.bnt_outgoing_save.UseVisualStyleBackColor = True
        '
        'txt_outgoing_id
        '
        Me.txt_outgoing_id.Location = New System.Drawing.Point(80, 87)
        Me.txt_outgoing_id.Name = "txt_outgoing_id"
        Me.txt_outgoing_id.ReadOnly = True
        Me.txt_outgoing_id.Size = New System.Drawing.Size(46, 20)
        Me.txt_outgoing_id.TabIndex = 47
        Me.txt_outgoing_id.Visible = False
        '
        'txt_incoming_id
        '
        Me.txt_incoming_id.Location = New System.Drawing.Point(80, 9)
        Me.txt_incoming_id.Name = "txt_incoming_id"
        Me.txt_incoming_id.ReadOnly = True
        Me.txt_incoming_id.Size = New System.Drawing.Size(46, 20)
        Me.txt_incoming_id.TabIndex = 48
        Me.txt_incoming_id.Visible = False
        '
        'form_record_note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_incoming_id)
        Me.Controls.Add(Me.txt_outgoing_id)
        Me.Controls.Add(Me.bnt_outgoing_save)
        Me.Controls.Add(Me.btn_income_savebtn_income_save)
        Me.Controls.Add(Me.lbl_status_out)
        Me.Controls.Add(Me.lbl_status_in)
        Me.Controls.Add(Me.txt_gate_out)
        Me.Controls.Add(Me.lbl_gate_out)
        Me.Controls.Add(Me.txt_gate_in)
        Me.Controls.Add(Me.lbl_gate_in)
        Me.Controls.Add(Me.lbl_note_history)
        Me.Controls.Add(Me.txt_time_out)
        Me.Controls.Add(Me.lbl_time_out)
        Me.Controls.Add(Me.txt_way_target_out)
        Me.Controls.Add(Me.lbl_way_target_out)
        Me.Controls.Add(Me.txt_name_out)
        Me.Controls.Add(Me.lbl_name_out)
        Me.Controls.Add(Me.txt_carrier_out)
        Me.Controls.Add(Me.lbl_carrier_out)
        Me.Controls.Add(Me.txt_dodl_out)
        Me.Controls.Add(Me.lbl_dodl_out)
        Me.Controls.Add(Me.txt_spz_out)
        Me.Controls.Add(Me.lbl_spz_out)
        Me.Controls.Add(Me.txt_date_out)
        Me.Controls.Add(Me.lbl_date_out)
        Me.Controls.Add(Me.lbl_outgoing)
        Me.Controls.Add(Me.txt_time_in)
        Me.Controls.Add(Me.lbl_time_in)
        Me.Controls.Add(Me.txt_way_target_in)
        Me.Controls.Add(Me.lbl_way_target_in)
        Me.Controls.Add(Me.txt_name_in)
        Me.Controls.Add(Me.lbl_name_in)
        Me.Controls.Add(Me.txt_carrier_in)
        Me.Controls.Add(Me.lbl_carrier_in)
        Me.Controls.Add(Me.txt_dodl_in)
        Me.Controls.Add(Me.lbl_dodl_in)
        Me.Controls.Add(Me.txt_spz_in)
        Me.Controls.Add(Me.lbl_spz_in)
        Me.Controls.Add(Me.txt_date_in)
        Me.Controls.Add(Me.lbl_ingoing_date)
        Me.Controls.Add(Me.lbl_ingoing)
        Me.Controls.Add(Me.lbl_note)
        Me.Controls.Add(Me.txt_history_note)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.btn_only_close)
        Me.Controls.Add(Me.btn_close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_record_note"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIE ZÁZNAMU - Založení Poznámky"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_only_close As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents txt_history_note As System.Windows.Forms.TextBox
    Friend WithEvents lbl_note As System.Windows.Forms.Label
    Friend WithEvents lbl_ingoing_date As System.Windows.Forms.Label
    Friend WithEvents txt_date_in As System.Windows.Forms.TextBox
    Friend WithEvents txt_spz_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_spz_in As System.Windows.Forms.Label
    Friend WithEvents txt_dodl_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dodl_in As System.Windows.Forms.Label
    Friend WithEvents lbl_ingoing As System.Windows.Forms.Label
    Friend WithEvents txt_carrier_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_carrier_in As System.Windows.Forms.Label
    Friend WithEvents txt_name_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name_in As System.Windows.Forms.Label
    Friend WithEvents txt_way_target_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_way_target_in As System.Windows.Forms.Label
    Friend WithEvents txt_time_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_time_in As System.Windows.Forms.Label
    Friend WithEvents txt_time_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_time_out As System.Windows.Forms.Label
    Friend WithEvents txt_way_target_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_way_target_out As System.Windows.Forms.Label
    Friend WithEvents txt_name_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name_out As System.Windows.Forms.Label
    Friend WithEvents txt_carrier_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_carrier_out As System.Windows.Forms.Label
    Friend WithEvents txt_dodl_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dodl_out As System.Windows.Forms.Label
    Friend WithEvents txt_spz_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_spz_out As System.Windows.Forms.Label
    Friend WithEvents txt_date_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_date_out As System.Windows.Forms.Label
    Friend WithEvents lbl_outgoing As System.Windows.Forms.Label
    Friend WithEvents lbl_note_history As System.Windows.Forms.Label
    Friend WithEvents txt_gate_in As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gate_in As System.Windows.Forms.Label
    Friend WithEvents txt_gate_out As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gate_out As System.Windows.Forms.Label
    Friend WithEvents lbl_status_in As System.Windows.Forms.Label
    Friend WithEvents lbl_status_out As System.Windows.Forms.Label
    Friend WithEvents btn_income_savebtn_income_save As System.Windows.Forms.Button
    Friend WithEvents bnt_outgoing_save As System.Windows.Forms.Button
    Friend WithEvents txt_outgoing_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_incoming_id As System.Windows.Forms.TextBox
End Class
