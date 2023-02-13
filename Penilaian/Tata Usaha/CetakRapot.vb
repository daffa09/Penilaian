Imports MySql.Data.MySqlClient


Public Class CetakRapot

	Sub kondisiAwal()

		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False


		DataGridView1.Enabled = True
		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""


	End Sub

	Sub Kepsek()

		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM users WHERE id_user=1", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		DetailCetakRapot.lbl_ttd_kepsek.Text = dr.Item("nama")

	End Sub

	Sub WalasGuru(kelas)

		If kelas = "12 Ipa" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 2"

		ElseIf kelas = "12 Ips" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 1"

		ElseIf kelas = "11 Ipa" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 4"

		ElseIf kelas = "11 Ips" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 3"

		ElseIf kelas = "10 Ipa" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 6"

		ElseIf kelas = "10 Ips" Then
			DetailCetakRapot.lbl_ttd_walas.Text = "Guru 5"

		Else
			MsgBox("data tidak ditemukan")
		End If

	End Sub


	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT * FROM siswa", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "siswa")
		DataGridView1.DataSource = (ds.Tables("siswa"))
		DataGridView1.ReadOnly = True
		DataGridView1.Columns(0).Visible = False
		DataGridView1.Columns(7).Visible = False
		DataGridView1.Columns(8).Visible = False


	End Sub

	Private Sub CetakRapot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridView()
		ComboBox1.Items.Add("Berdasarkan Kelas")
		ComboBox1.Items.Add("10 Ipa")
		ComboBox1.Items.Add("10 Ips")
		ComboBox1.Items.Add("11 Ipa")
		ComboBox1.Items.Add("11 Ips")
		ComboBox1.Items.Add("12 Ipa")
		ComboBox1.Items.Add("12 Ips")
	End Sub

	Private Sub CetakRapot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi ini?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		Else
			Me.Hide()
			Form1.Show()
		End If
	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM siswa WHERE	nis='" & TextBox1.Text & "' OR nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR kelas='" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If TextBox1.Text = "" Then
			munculDataGridView()

		ElseIf dr.HasRows Then

			koneksi()
			da = New MySqlDataAdapter("SELECT * FROM siswa WHERE	nis='" & TextBox1.Text & "' OR nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR kelas='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "siswa")
			DataGridView1.DataSource = ds.Tables("siswa")
			DataGridView1.ReadOnly = True

		Else
			MsgBox("Data tidak ditemukan")
			munculDataGridView()
			kondisiAwal()
		End If
	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				MainMenuTataUsaha.Show()

			End If

		Else

			kondisiAwal()
			munculDataGridView()

		End If

	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

		If ComboBox1.Text = "Berdasarkan Kelas" Then
			kondisiAwal()
			munculDataGridView()

		Else

			Call koneksi()
			da = New MySqlDataAdapter("SELECT * FROM siswa WHERE kelas = '" & ComboBox1.Text & "'", conn)
			ds = New DataSet
			ds.Clear()
			da.Fill(ds, "siswa")
			DataGridView1.DataSource = (ds.Tables("siswa"))
			DataGridView1.ReadOnly = True

		End If
	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub



	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim session = TextBox2.Text
		Me.Hide()

		WalasGuru(TextBox5.Text)
		Kepsek()

		Call koneksi()
		cmd = New MySqlCommand("select * from siswa where id_siswa = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		If (dr.Read()) Then
			DetailCetakRapot.lbl_nama_murid.Text = dr.Item("nama")
			DetailCetakRapot.lbl_nis_murid.Text = dr.Item("nis")
			DetailCetakRapot.lbl_kelas_murid.Text = dr.Item("kelas")
			DetailCetakRapot.lbl_alamat_murid.Text = "Satu"
			DetailCetakRapot.lbl_tgl_lahir_murid.Text = "Jl. Amd Radeon 5"
			DetailCetakRapot.lblTangkapId.Text = dr.Item("id_siswa")
			dr.Close()
			cmd.Dispose()
		Else
			MsgBox("masih kebuka")
		End If

		DetailCetakRapot.Show()

	End Sub
End Class