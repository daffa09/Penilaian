Imports MySql.Data.MySqlClient


Public Class DataGuru

	Sub kondisiAwal()

		DataGridView1.Enabled = True
		TextBox1.Text = ""

	End Sub

	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT guru.idguru, guru.nama, mapel.mapel, guru.walas, guru.no_telp, guru.alamat FROM guru INNER JOIN mapel ON guru.id_mapel=mapel.id_mapel", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "guru")
		DataGridView1.DataSource = (ds.Tables("guru"))
		DataGridView1.ReadOnly = True

	End Sub

	Private Sub DataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridView()
	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		Call koneksi()
		cmd = New MySqlCommand("SELECT guru.idguru, guru.nama, guru.walas, mapel.mapel,guru.no_telp, guru.alamat FROM guru INNER JOIN mapel ON guru.id_mapel=mapel.id_mapel WHERE nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR alamat='" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If TextBox1.Text = "" Then
			munculDataGridView()

		ElseIf dr.HasRows Then

			koneksi()
			da = New MySqlDataAdapter("SELECT guru.idguru, guru.nama, guru.walas, mapel.mapel,guru.no_telp, guru.alamat FROM guru INNER JOIN mapel ON guru.id_mapel=mapel.id_mapel WHERE nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR alamat='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "guru")
			DataGridView1.DataSource = ds.Tables("guru")


		Else
			MsgBox("Data tidak ditemukan")
			munculDataGridView()
			kondisiAwal()
		End If

	End Sub

	Private Sub DataGuru_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				MainMenuWakepsek.Show()

			End If

		Else

			kondisiAwal()
			munculDataGridView()

		End If

	End Sub
End Class