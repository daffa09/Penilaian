Imports MySql.Data.MySqlClient


Public Class UbahWalas

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""

		ComboBox1.Enabled = False
		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		ComboBox1.Text = "-"
		ComboBox2.Text = "Guru Dengan Walas"
		ComboBox1.Enabled = False

		btn_edit.Enabled = True
		btn_search.Enabled = True
		btn_edit.Text = "Edit"
		btn_close.Text = "Close"

		DataGridView1.Enabled = True

	End Sub

	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT guru.idguru, guru.nama, guru.no_telp, mapel.mapel, guru.alamat, guru.walas FROM guru INNER JOIN mapel ON guru.id_mapel = mapel.id_mapel WHERE guru.walas IS NOT NULL", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "guru")
		DataGridView1.DataSource = (ds.Tables("guru"))
		DataGridView1.ReadOnly = True

	End Sub

	Sub comboboxGuru()

		ComboBox1.Items.Add("10 Ipa")
		ComboBox1.Items.Add("10 Ips")
		ComboBox1.Items.Add("11 Ipa")
		ComboBox1.Items.Add("11 Ips")
		ComboBox1.Items.Add("12 Ipa")
		ComboBox1.Items.Add("12 Ips")

	End Sub

	Sub munculDataGridViewBukanWalas()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT guru.idguru, guru.nama, guru.no_telp, mapel.mapel, guru.alamat, guru.walas FROM guru INNER JOIN mapel ON guru.id_mapel = mapel.id_mapel WHERE guru.walas IS NULL", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "guru")
		DataGridView1.DataSource = (ds.Tables("guru"))
		DataGridView1.ReadOnly = True

	End Sub

	Private Sub UbahWalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ComboBox2.Items.Add("Guru Dengan Walas")
		ComboBox2.Items.Add("Guru Bukan Walas")
		kondisiAwal()
		comboboxGuru()
		munculDataGridView()
	End Sub

	Private Sub UbahWalas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

		If ComboBox2.Text = "Guru Dengan Walas" Then

			kondisiAwal()
			munculDataGridView()

		Else

			munculDataGridViewBukanWalas()

		End If

	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM guru", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If TextBox1.Text = "" Then
			munculDataGridView()

		ElseIf dr.HasRows Then

			koneksi()
			da = New MySqlDataAdapter("SELECT * FROM guru WHERE nama='" & TextBox1.Text & "' OR no_telp='" & TextBox1.Text & "'OR alamat='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "guru")
			DataGridView1.DataSource = ds.Tables("guru")


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
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

		If btn_edit.Text = "Edit" Then

			btn_edit.Text = "Save"
			btn_close.Text = "Cancel"

			ComboBox1.Enabled = True
			DataGridView1.Enabled = False

		Else

			If ComboBox1.Text = "-" Then
				MsgBox("Harap Pilih data guru dari tabel terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				Call koneksi()
				cmd = New MySqlCommand("SELECT * FROM guru WHERE idguru='" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				Label6.Text = dr.Item("idguru")
				dr.Close()
				cmd.Dispose()

				If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksi()
					cmd = New MySqlCommand("UPDATE guru SET walas='" & ComboBox1.Text & "' WHERE idguru=" & Label6.Text, conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()
					MsgBox("Data berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
					MsgBox("Data gagal disimpan")
				End If


			End If

		End If

	End Sub
End Class