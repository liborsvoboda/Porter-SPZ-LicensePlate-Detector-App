Public Class form_carrier

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Try
            Me.Dial_carrierTableAdapter.GetData.AcceptChanges()
            Me.Dial_carrierTableAdapter.Update(Me.DialcarrierBindingSource.DataSource)
            'My.Forms.Main_form.lst_carrier.Text = CStr(Me.DataGridView1.Rows((Me.DataGridView1.CurrentRow.Index)).Cells(1).Value().ToString)
        Catch ex As Exception

        End Try

        My.Forms.Main_form.Controls.Owner.Enabled = True
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

        'My.Forms.Main_form.lst_carrier.SelectedIndex = Me.DataGridView1.CurrentRow.Index
        My.Forms.Main_form.lst_carrier.SelectedItem = Me.DataGridView1.Rows((Me.DataGridView1.CurrentRow.Index)).Cells(1).Value().ToString
        Me.Close()
        My.Forms.Main_form.Focus()
    End Sub


    Private Sub form_carrier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.Form_config.Hide()
        My.Forms.form_about.Hide()
        'TODO: Tento řádek načte data do tabulky 'Ds_dial_carrier.dial_carrier'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Dial_carrierTableAdapter.Fill(Me.Ds_dial_carrier.dial_carrier)

        Me.DataGridView1.Select()
        Me.DataGridView1.CurrentCell = Me.DataGridView1(1, Me.DataGridView1.NewRowIndex)
    End Sub


    Private Sub btn_only_close_Click(sender As Object, e As EventArgs) Handles btn_only_close.Click
        Try
            My.Forms.Main_form.lst_carrier.SelectedItem = Me.DataGridView1.Rows((Me.DataGridView1.CurrentRow.Index)).Cells(1).Value().ToString
        Catch ex As Exception

        End Try
        Me.Close()
        My.Forms.Main_form.Controls.Owner.Enabled = True
        My.Forms.Main_form.Focus()
    End Sub


    Private Sub form_carrier_escaped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If AscW(e.KeyChar) = 27 Then
            My.Forms.Main_form.Controls.Owner.Enabled = True
            Me.Close()
        End If
    End Sub


End Class