Imports MySql.Data.MySqlClient


Public Class LihatNilai

	'sub nilaimapel()

	'	call koneksi()
	'	dim i as long
	'	dim mapel(3) as string
	'	mapel(0) = "bhs_indonesia"
	'	mapel(1) = "ipa"
	'	mapel(2) = "bhs_inggris"
	'	mapel(3) = "matematika"

	'	try

	'		for i = 0 to ubound(mapel)

	'			cmd = new mysqlcommand("select mapel.mapel, " & mapel(i) & ".nilai_uh, " & mapel(i) & ".nilai_tugas, " & mapel(i) & ".nilai_uts, " & mapel(i) & ".nilai_uas, " & mapel(i) & ".rata_rata, " & mapel(i) & ".predikat from " & mapel(i) & " 
	'								inner join mapel on " & mapel(i) & ".id_mapel=mapel.id_mapel where " & mapel(i) & ".id_siswa = '" & lbltangkapid.text & "'", conn)
	'			dr = cmd.executereader
	'			dr.read()
	'			if (dr.read()) then

	'				lbl_tangkap_mapel.text = dr.item("mapel")
	'				lbl_uh.text = dr.item("nilai_uh")
	'				lbl_tugas.text = dr.item("nilai_tugas")
	'				lbl_uts.text = dr.item("nilai_uts")
	'				lbl_uas.text = dr.item("nilai_uas")
	'				lbl_rata.text = dr.item("rata_rata")
	'				lbl_predikat.text = dr.item("predikat")
	'				datagridview1.rows.add(lbl_tangkap_mapel.text, lbl_uh.text, lbl_tugas.text, lbl_uts.text, lbl_uas.text, lbl_rata.text, lbl_predikat.text)
	'				dr.close()
	'			else
	'				msgbox("masih terbuka, tutup dulu")
	'			end if
	'		next

	'	catch ex as exception
	'		msgbox(ex.tostring)
	'	end try

	'end sub

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

	Private Sub LihatNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		munculDataGridView()
	End Sub

	Private Sub LihatNilai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
				MainMenuSiswa.Show()

			End If

		Else



		End If
	End Sub
End Class