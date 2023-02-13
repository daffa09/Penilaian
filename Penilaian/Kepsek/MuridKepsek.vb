Imports MySql.Data.MySqlClient


Public Class MuridKepsek

	Sub kondisiAwal()

		DataGridView1.Enabled = True
		TextBox1.Text = ""

	End Sub

	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT * FROM siswa", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "siswa")
		DataGridView1.DataSource = (ds.Tables("siswa"))
		DataGridView1.ReadOnly = True
		DataGridView1.Columns(7).Visible = False

	End Sub

	Private Sub MuridKepsek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

	Private Sub MuridKepsek_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
				MainMenuKepsek.Show()

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
End Class