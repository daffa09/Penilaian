Imports MySql.Data.MySqlClient


Public Class TambahMapel

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox4.Text = ""

		ComboBox1.Enabled = False
		TextBox2.Enabled = False
		TextBox4.Enabled = False
		ComboBox1.Text = "-"
		ComboBox2.Text = "Guru Dengan Mapel"
		ComboBox1.Enabled = False

		btn_tambah.Enabled = True
		btn_delete.Enabled = True
		btn_search.Enabled = True
		btn_tambah.Text = "Tambah"
		btn_close.Text = "Close"

		DataGridView1.Enabled = True

	End Sub

	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		cmd = New MySqlCommand("SELECT * FROM mapel WHERE id_mapel IN (SELECT MAX(id_mapel) FROM mapel)", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If Not dr.HasRows Then

			urutanKode = "01"
			TextBox2.Text = urutanKode


		Else

			hitung = Microsoft.VisualBasic.Right(dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			TextBox2.Text = urutanKode

		End If

	End Sub


	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT mapel.id_mapel, guru.nama, mapel.mapel FROM mapel INNER JOIN guru ON guru.id_mapel=mapel.id_mapel", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "mapel")
		DataGridView1.DataSource = (ds.Tables("mapel"))
		DataGridView1.ReadOnly = True

	End Sub

	Sub munculDataGridViewTanpaMapel()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT idguru, nama, id_mapel FROM guru WHERE id_mapel=0", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "mapel")
		DataGridView1.DataSource = (ds.Tables("mapel"))
		DataGridView1.ReadOnly = True

	End Sub

	Sub comboboxGuru()

		Dim kosong = 0

		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM guru WHERE id_mapel=0", conn)
		dr = cmd.ExecuteReader

		Do While dr.Read() = True

			ComboBox1.Items.Add(dr.Item("nama"))

		Loop

		dr.Close()
		cmd.Dispose()
	End Sub

	Private Sub TambahMapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		ComboBox2.Items.Add("Guru Dengan Mapel")
		ComboBox2.Items.Add("Guru Tanpa Mapel")
		kondisiAwal()
		munculDataGridView()

	End Sub

	Private Sub TambahMapel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		Call koneksi()
		cmd = New MySqlCommand("SELECT mapel.id_mapel, guru.nama, mapel.mapel FROM mapel INNER JOIN guru ON guru.id_mapel=mapel.id_mapel WHERE nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR alamat='" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If TextBox1.Text = "" Then
			munculDataGridView()

		ElseIf dr.HasRows Then

			koneksi()
			da = New MySqlDataAdapter("SELECT mapel.id_mapel, guru.nama, mapel.mapel FROM mapel INNER JOIN guru ON guru.id_mapel=mapel.id_mapel WHERE nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR alamat='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "mapel")
			DataGridView1.DataSource = ds.Tables("mapel")


		Else
			MsgBox("Data tidak ditemukan")
			munculDataGridView()
			kondisiAwal()
		End If

	End Sub

	Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

		If btn_tambah.Text = "Tambah" Then

			btn_tambah.Text = "Save"
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			ComboBox1.Enabled = True
			DataGridView1.Enabled = False
			TextBox4.Enabled = True

			TextBox2.Text = ""
			ComboBox1.Text = "-"
			TextBox4.Text = ""

			comboboxGuru()
			autoNumeric()

		Else

			If TextBox2.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "-" Then
				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				Call koneksi()
				cmd = New MySqlCommand("SELECT idguru FROM guru WHERE nama='" & ComboBox1.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				Dim tangkapIdGuru = dr.Item("idguru")
				dr.Close()
				cmd.Dispose()

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksi()
					cmd = New MySqlCommand("INSERT INTO mapel VALUES('" & TextBox2.Text & "', '" & tangkapIdGuru & "', '" & TextBox4.Text & "')", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()
					cmd = New MySqlCommand("UPDATE guru SET id_mapel='" & TextBox2.Text & "' WHERE idguru='" & tangkapIdGuru & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()
					cmd = New MySqlCommand("CREATE TABLE `" & TextBox4.Text & "` (
											  `id` int(11) NOT NULL AUTO_INCREMENT,
											  `id_siswa` int(11) NOT NULL,
											  `id_mapel` int(11) NOT NULL DEFAULT " & TextBox2.Text & ",
											  `nilai_uh` int(11) DEFAULT 0,
											  `nilai_tugas` int(11) DEFAULT 0,
											  `nilai_uts` int(11) DEFAULT 0,
											  `nilai_uas` int(11) DEFAULT 0,
											  `rata_rata` varchar(5) DEFAULT '-',
											  `predikat` char(5) DEFAULT '-',
											  PRIMARY KEY (`id`)
											)", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
					MsgBox("Data gagal disimpan")
				End If


			End If

		End If
	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox2.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu hapus")
		Else

			btn_tambah.Enabled = False
			btn_close.Text = "Cancel"



			If TextBox2.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				Call koneksi()
				cmd = New MySqlCommand("SELECT idguru FROM guru WHERE nama='" & ComboBox1.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				Dim tangkapIdGuru = dr.Item("idguru")
				dr.Close()
				cmd.Dispose()

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					koneksi()
					cmd = New MySqlCommand("DELETE FROM mapel WHERE id_mapel='" & TextBox2.Text & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()
					cmd = New MySqlCommand("UPDATE guru SET id_mapel='0' WHERE idguru='" & tangkapIdGuru & "'", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If
	End Sub

	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

		If ComboBox2.Text = "Guru Dengan Mapel" Then
			kondisiAwal()
			munculDataGridView()

		Else

			munculDataGridViewTanpaMapel()

		End If
	End Sub


End Class