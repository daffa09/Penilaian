Imports MySql.Data.MySqlClient
Imports System.Math

Public Class InputNilai

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""
		TextBox6.Text = ""
		TextBox7.Text = ""
		TextBox9.Text = ""
		TextBox8.Text = ""


		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False
		TextBox6.Enabled = False
		TextBox7.Enabled = False
		TextBox9.Enabled = False
		TextBox8.Enabled = False


		DataGridView1.Enabled = True

		btn_tambah.Enabled = True
		btn_search.Enabled = True
		btn_tambah.Text = "Insert"
		btn_close.Text = "Close"

	End Sub

	Sub dataGridMapel(mapel, textmapel)

		Call koneksi()
		da = New MySqlDataAdapter("SELECT siswa.id_siswa, siswa.nama, siswa.nis, siswa.kelas, " & mapel & ".nilai_uh, " & mapel & ".nilai_tugas, " & mapel & ".nilai_uts, " & mapel & ".nilai_uas, " & mapel & ".rata_rata, " & mapel & ".predikat, nilai.tgl_input FROM siswa 
									INNER JOIN " & mapel & " ON siswa.id_siswa=" & mapel & ".id_siswa 
									INNER JOIN nilai ON nilai.id_nilai = siswa.id_nilai", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "nilai")
		DataGridView1.DataSource = (ds.Tables("nilai"))
		DataGridView1.ReadOnly = True
		Label7.Text = textmapel
		lblTangkapMapel2.Text = mapel
		da.Dispose()
		ds.Dispose()

	End Sub

	Sub munculDataGridView()

		Dim session = lblTangkapId.Text
		Call koneksi()
		cmd = New MySqlCommand("select * from guru where idguru = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If dr.Item("id_mapel") = 1 Then

			dataGridMapel("bhs_indonesia", "B. Indonesia")

		ElseIf dr.Item("id_mapel") = 2 Then

			dataGridMapel("ipa", "Ipa")

		ElseIf dr.Item("id_mapel") = 3 Then

			dataGridMapel("bhs_inggris", "B. Inggris")

		ElseIf dr.Item("id_mapel") = 4 Then

			dataGridMapel("matematika", "Matematika")

		Else
			MsgBox("Data tidak ditemukan!")
		End If

	End Sub

	Private Sub InputNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		kondisiAwal()
		munculDataGridView()
		ComboBox1.Items.Add("Semua Kelas")
		ComboBox1.Items.Add("10 Ipa")
		ComboBox1.Items.Add("10 Ips")
		ComboBox1.Items.Add("11 Ipa")
		ComboBox1.Items.Add("11 Ips")
		ComboBox1.Items.Add("12 Ipa")
		ComboBox1.Items.Add("12 Ips")


	End Sub

	Private Sub InputNilai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		If ComboBox1.Text = "Semua Kelas" Then
			kondisiAwal()
			munculDataGridView()

		Else

			Call koneksi()
			da = New MySqlDataAdapter("SELECT siswa.id_siswa, siswa.nama, siswa.nis, siswa.kelas, " & lblTangkapMapel2.Text & ".nilai_uh, " & lblTangkapMapel2.Text & ".nilai_tugas, " & lblTangkapMapel2.Text & ".nilai_uts, " & lblTangkapMapel2.Text & ".nilai_uas, nilai.tgl_input FROM siswa 
										INNER JOIN " & lblTangkapMapel2.Text & " ON siswa.id_siswa=" & lblTangkapMapel2.Text & ".id_siswa 
										INNER JOIN nilai ON nilai.id_siswa = siswa.id_siswa WHERE siswa.kelas= '" & ComboBox1.Text & "'", conn)
			ds = New DataSet
			ds.Clear()
			da.Fill(ds, "nilai")
			DataGridView1.DataSource = (ds.Tables("nilai"))
			DataGridView1.ReadOnly = True

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
				MainMenuGuru.Show()

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
				TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
				TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
				TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

		If btn_tambah.Text = "Insert" Then

			TextBox6.Text = ""
			TextBox7.Text = ""
			TextBox8.Text = ""
			TextBox9.Text = ""


			TextBox6.Enabled = True
			TextBox7.Enabled = True
			TextBox8.Enabled = True
			TextBox9.Enabled = True


			DataGridView1.Enabled = False

			btn_tambah.Enabled = True
			btn_search.Enabled = True
			btn_tambah.Text = "Save"
			btn_close.Text = "Cancel"

		Else

			If TextBox6.Text = "" Then
				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")
			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					UpdateNilai(lblTangkapMapel2.Text)
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
					MsgBox("Data gagal disimpan")
				End If

			End If

		End If
	End Sub

	Sub UpdateNilai(mapel)

		Dim rata As Integer
		Dim huruf As String

		Dim tugas As Double
		Dim uh As Double
		Dim uts As Double
		Dim uas As Double

		tugas = TextBox6.Text * 30 / 100
		uh = TextBox7.Text * 20 / 100
		uts = TextBox8.Text * 20 / 100
		uas = TextBox9.Text * 30 / 100

		rata = tugas + uh + uts + uas

		If rata >= 90 Then
			huruf = "A"
		ElseIf rata >= 80 Then
			huruf = "B"
		ElseIf rata >= 70 Then
			huruf = "C"
		ElseIf rata >= 60 Then
			huruf = "D"
		Else
			huruf = "E"
		End If

		Call koneksi()
		cmd = New MySqlCommand("UPDATE " & mapel & " SET nilai_uh=" & TextBox6.Text & ", nilai_tugas=" & TextBox7.Text & ", nilai_uts=" & TextBox8.Text & ", nilai_uas=" & TextBox9.Text & ", rata_rata=" & rata & ", predikat='" & huruf & "' WHERE id_siswa=" & TextBox2.Text, conn)
		cmd.ExecuteNonQuery()
		cmd.Dispose()
		cmd = New MySqlCommand("UPDATE nilai SET tgl_input='" & Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd") & "' WHERE id_siswa=" & TextBox2.Text, conn)
		cmd.ExecuteNonQuery()
		MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")

	End Sub
End Class