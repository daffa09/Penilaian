Imports MySql.Data.MySqlClient


Public Class TambahUserMurid

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""
		TextBox6.Text = ""
		TextBox7.Text = ""
		TextBox7.Text = ""
		TextBox8.Text = ""
		DateTimePicker1.Value = Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd")

		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False
		TextBox6.Enabled = False
		TextBox7.Enabled = False
		TextBox7.Enabled = False
		TextBox8.Enabled = False

		DataGridView1.Enabled = True

		CheckBox1.Enabled = False
		DateTimePicker1.Enabled = False

		btn_tambah.Enabled = True
		btn_delete.Enabled = True
		btn_search.Enabled = True
		btn_tambah.Text = "Insert"
		btn_close.Text = "Close"

	End Sub

	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		cmd = New MySqlCommand("SELECT * FROM siswa WHERE id_siswa IN (SELECT MAX(id_siswa) FROM siswa)", conn)
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

		cmd.Dispose()
		dr.Close()


	End Sub

	Sub autoNumericNilai()

		Dim urutanKode As String
		Dim hitung As Long
		cmd = New MySqlCommand("SELECT * FROM nilai WHERE id_nilai IN (SELECT MAX(id_nilai) FROM nilai)", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If Not dr.HasRows Then

			urutanKode = "01"
			LblTangkapIdNilai.Text = urutanKode


		Else

			hitung = Microsoft.VisualBasic.Right(dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			LblTangkapIdNilai.Text = urutanKode

		End If

		cmd.Dispose()
		dr.Close()

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

	Private Sub TambahUserMurid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridView()
		TextBox8.PasswordChar = "*"
	End Sub

	Private Sub TambahUserMurid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked = True Then

			TextBox8.PasswordChar = ""

		Else

			TextBox8.PasswordChar = "*"


		End If
	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				TambahUsers.Show()

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
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
				DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(5).Value
				TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value


			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub

	Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

		If btn_tambah.Text = "Insert" Then

			btn_tambah.Text = "Save"
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True
			TextBox6.Enabled = True
			TextBox7.Enabled = True
			TextBox8.Enabled = True
			CheckBox1.Enabled = True
			DataGridView1.Enabled = False
			DateTimePicker1.Enabled = True

			TextBox2.Text = ""
			TextBox3.Text = ""
			TextBox4.Text = ""
			TextBox5.Text = ""
			TextBox6.Text = ""
			TextBox7.Text = ""
			TextBox8.Text = ""
			DateTimePicker1.Value = Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd")

			autoNumeric()
			autoNumericNilai()

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksi()
					cmd = New MySqlCommand("INSERT INTO siswa VALUES('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd") & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & LblTangkapIdNilai.Text & "')", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					inputMuridKemapel()
					WalasGuru(TextBox5.Text)

					cmd = New MySqlCommand("INSERT INTO nilai VALUES('" & LblTangkapIdNilai.Text & "', '" & lblTangkapIdGuru.Text & "', '" & TextBox2.Text & "', '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd") & "', '" & TextBox2.Text & "', '" & TextBox2.Text & "', '" & TextBox2.Text & "', '" & TextBox2.Text & "')", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If


			End If

		End If

	End Sub

	Sub WalasGuru(kelas)

		If kelas = "12 Ipa" Then
			lblTangkapIdGuru.Text = "4"

		ElseIf kelas = "12 Ips" Then
			lblTangkapIdGuru.Text = "1"

		ElseIf kelas = "11 Ipa" Then
			lblTangkapIdGuru.Text = "3"

		ElseIf kelas = "11 Ips" Then
			lblTangkapIdGuru.Text = "2"

		ElseIf kelas = "10 Ipa" Then
			lblTangkapIdGuru.Text = "5"

		ElseIf kelas = "10 Ips" Then
			lblTangkapIdGuru.Text = "6"

		Else
			MsgBox("data tidak ditemukan")
		End If

	End Sub

	Sub inputMuridKemapel()

		Call koneksi()
		Dim i As Long
		Dim mapel(3) As String
		mapel(0) = "bhs_indonesia"
		mapel(1) = "ipa"
		mapel(2) = "bhs_inggris"
		mapel(3) = "matematika"

		For i = 0 To UBound(mapel)

			cmd = New MySqlCommand("INSERT INTO " & mapel(i) & "(id_siswa) VALUES('" & TextBox2.Text & "')", conn)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

		Next

	End Sub

	Sub deleteMuridDarimapel()

		Call koneksi()
		Dim mapel(3) As String
		mapel(0) = "bhs_indonesia"
		mapel(1) = "ipa"
		mapel(2) = "bhs_inggris"
		mapel(3) = "matematika"

		For i = 0 To UBound(mapel)

			cmd = New MySqlCommand("DELETE FROM  " & mapel(i) & " WHERE id_siswa='" & TextBox2.Text & "'", conn)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

		Next

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu hapus")
		Else

			btn_tambah.Enabled = False
			btn_close.Text = "Cancel"



			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					koneksi()
					cmd = New MySqlCommand("DELETE FROM siswa WHERE id_siswa='" & TextBox2.Text & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					deleteMuridDarimapel()

					cmd = New MySqlCommand("DELETE FROM nilai WHERE id_siswa='" & TextBox2.Text & "'", conn)
					cmd.ExecuteNonQuery()

					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

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
End Class