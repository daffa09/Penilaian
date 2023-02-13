Imports MySql.Data.MySqlClient


Public Class DetailCetakRapot


	Sub nilaiMapelIndo()

		Dim mapel As String = "bhs_indonesia"

		Call koneksi()
		cmd = New MySqlCommand("SELECT mapel.mapel, " & mapel & ".nilai_uh, " & mapel & ".nilai_tugas, " & mapel & ".nilai_uts, " & mapel & ".nilai_uas, " & mapel & ".rata_rata, " & mapel & ".predikat FROM " & mapel & " 
									INNER JOIN mapel ON " & mapel & ".id_mapel=mapel.id_mapel WHERE " & mapel & ".id_siswa = '" & lblTangkapId.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		lbl_tangkap_mapel.Text = dr.Item("mapel")
		lbl_uh.Text = dr.Item("nilai_uh")
		lbl_tugas.Text = dr.Item("nilai_tugas")
		lbl_uts.Text = dr.Item("nilai_uts")
		lbl_uas.Text = dr.Item("nilai_uas")
		lbl_rata.Text = dr.Item("rata_rata")
		lbl_predikat.Text = dr.Item("predikat")
		DataGridView1.Rows.Add(lbl_tangkap_mapel.Text, lbl_uh.Text, lbl_tugas.Text, lbl_uts.Text, lbl_uas.Text, lbl_rata.Text, lbl_predikat.Text)

	End Sub

	Sub nilaiMapelIpa()

		Dim mapel As String = "ipa"

		Call koneksi()
		cmd = New MySqlCommand("SELECT mapel.mapel, " & mapel & ".nilai_uh, " & mapel & ".nilai_tugas, " & mapel & ".nilai_uts, " & mapel & ".nilai_uas, " & mapel & ".rata_rata, " & mapel & ".predikat FROM " & mapel & " 
									INNER JOIN mapel ON " & mapel & ".id_mapel=mapel.id_mapel WHERE " & mapel & ".id_siswa = '" & lblTangkapId.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		lbl_tangkap_mapel.Text = dr.Item("mapel")
		lbl_uh.Text = dr.Item("nilai_uh")
		lbl_tugas.Text = dr.Item("nilai_tugas")
		lbl_uts.Text = dr.Item("nilai_uts")
		lbl_uas.Text = dr.Item("nilai_uas")
		lbl_rata.Text = dr.Item("rata_rata")
		lbl_predikat.Text = dr.Item("predikat")
		DataGridView1.Rows.Add(lbl_tangkap_mapel.Text, lbl_uh.Text, lbl_tugas.Text, lbl_uts.Text, lbl_uas.Text, lbl_rata.Text, lbl_predikat.Text)
	End Sub

	Sub nilaiMapelInggris()

		Dim mapel As String = "bhs_inggris"

		Call koneksi()
		cmd = New MySqlCommand("SELECT mapel.mapel, " & mapel & ".nilai_uh, " & mapel & ".nilai_tugas, " & mapel & ".nilai_uts, " & mapel & ".nilai_uas, " & mapel & ".rata_rata, " & mapel & ".predikat FROM " & mapel & " 
									INNER JOIN mapel ON " & mapel & ".id_mapel=mapel.id_mapel WHERE " & mapel & ".id_siswa = '" & lblTangkapId.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		lbl_tangkap_mapel.Text = dr.Item("mapel")
		lbl_uh.Text = dr.Item("nilai_uh")
		lbl_tugas.Text = dr.Item("nilai_tugas")
		lbl_uts.Text = dr.Item("nilai_uts")
		lbl_uas.Text = dr.Item("nilai_uas")
		lbl_rata.Text = dr.Item("rata_rata")
		lbl_predikat.Text = dr.Item("predikat")
		DataGridView1.Rows.Add(lbl_tangkap_mapel.Text, lbl_uh.Text, lbl_tugas.Text, lbl_uts.Text, lbl_uas.Text, lbl_rata.Text, lbl_predikat.Text)
	End Sub

	Sub nilaiMapelMatematika()

		Dim mapel As String = "matematika"

		Call koneksi()
		cmd = New MySqlCommand("SELECT mapel.mapel, " & mapel & ".nilai_uh, " & mapel & ".nilai_tugas, " & mapel & ".nilai_uts, " & mapel & ".nilai_uas, " & mapel & ".rata_rata, " & mapel & ".predikat FROM " & mapel & " 
									INNER JOIN mapel ON " & mapel & ".id_mapel=mapel.id_mapel WHERE " & mapel & ".id_siswa = '" & lblTangkapId.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		lbl_tangkap_mapel.Text = dr.Item("mapel")
		lbl_uh.Text = dr.Item("nilai_uh")
		lbl_tugas.Text = dr.Item("nilai_tugas")
		lbl_uts.Text = dr.Item("nilai_uts")
		lbl_uas.Text = dr.Item("nilai_uas")
		lbl_rata.Text = dr.Item("rata_rata")
		lbl_predikat.Text = dr.Item("predikat")
		DataGridView1.Rows.Add(lbl_tangkap_mapel.Text, lbl_uh.Text, lbl_tugas.Text, lbl_uts.Text, lbl_uas.Text, lbl_rata.Text, lbl_predikat.Text)
	End Sub

	Sub munculDataGridView()

		Call koneksi()

		With DataGridView1

			DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

			.ColumnCount = 7
			.Columns(0).Name = "Mata_Pelajaran"
			.Columns(1).Name = "Nilai UH"
			.Columns(2).Name = "Nilai Tugas"
			.Columns(3).Name = "Nilai UTS"
			.Columns(4).Name = "Nilai Uas"
			.Columns(5).Name = "Rata-rata"
			.Columns(6).Name = "Predikat"

			nilaiMapelIndo()
			nilaiMapelIpa()
			nilaiMapelInggris()
			nilaiMapelMatematika()

			DataGridView1.ReadOnly = True


		End With



		DataGridView1.ReadOnly = True



	End Sub


	Private Sub DetailCetakRapot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		munculDataGridView()

	End Sub

	Private Sub DetailCetakRapot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

	Private Sub printDocument1_PrintPage(ByVal sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs)
		e.Graphics.DrawString("Ampas", Me.Font, Brushes.Black, 0, 0)
	End Sub

	Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
		Dim d = PrintDialog1.ShowDialog()
		If d = Windows.Forms.DialogResult.OK Then
			PrintDocument1.Print()
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If Button1.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				CetakRapot.Show()

			End If

		Else

		End If
	End Sub
End Class