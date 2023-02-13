Imports MySql.Data.MySqlClient


Public Class MainMenuSiswa
	Private Sub MainMenuSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub MainMenuSiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		If MsgBox("Anda yakin ingin keluar dari aplikasi ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Hide()
			Form1.Show()
		Else

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim session = lblTangkapId.Text
		Me.Hide()
		Call koneksi()
		cmd = New MySqlCommand("select * from siswa where id_siswa = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		If (dr.Read()) Then
			ProfileSiswa.TextBox1.Text = dr.Item("nama")
			ProfileSiswa.TextBox2.Text = dr.Item("nis")
			ProfileSiswa.TextBox3.Text = dr.Item("kelas")
			ProfileSiswa.TextBox4.Text = dr.Item("alamat")
			ProfileSiswa.TextBox5.Text = dr.Item("tgl_lahir")
			ProfileSiswa.TextBox6.Text = dr.Item("no_telp")
			ProfileSiswa.TextBox7.Text = dr.Item("password")
			ProfileSiswa.lblTangkapId.Text = dr.Item("id_siswa")
		Else
			MsgBox("masih kebuka")
		End If

		ProfileSiswa.Show()

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim session = lblTangkapId.Text
		Me.Hide()
		Call koneksi()
		cmd = New MySqlCommand("select * from siswa where id_siswa = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		If (dr.Read()) Then
			LihatNilai.lbl_nama_murid.Text = dr.Item("nama")
			LihatNilai.lbl_nis_murid.Text = dr.Item("nis")
			LihatNilai.lbl_kelas_murid.Text = dr.Item("kelas")
			LihatNilai.lbl_alamat_murid.Text = dr.Item("alamat")
			LihatNilai.lbl_tgl_lahir_murid.Text = dr.Item("tgl_lahir")
			LihatNilai.lbl_no_telp_murid.Text = dr.Item("no_telp")
			LihatNilai.lblTangkapId.Text = dr.Item("id_siswa")
			dr.Close()
			cmd.Dispose()
		Else
			MsgBox("masih kebuka")
		End If

		LihatNilai.Show()
	End Sub
End Class