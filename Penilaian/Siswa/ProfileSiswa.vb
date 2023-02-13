Imports MySql.Data.MySqlClient


Public Class ProfileSiswa
	Private Sub ProfileSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBox7.PasswordChar = "*"
	End Sub

	Private Sub ProfileSiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

			TextBox7.PasswordChar = ""

		Else

			TextBox7.PasswordChar = "*"


		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

			Me.Hide()
			MainMenuSiswa.Show()

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then

			MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

		Else

			If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

				Call koneksi()
				cmd = New MySqlCommand("UPDATE siswa SET nama='" & TextBox1.Text & "', nis='" & TextBox2.Text & "', kelas='" & TextBox3.Text & "', alamat='" & TextBox4.Text & "', tgl_lahir='" & TextBox5.Text & "', no_telp='" & TextBox6.Text & "', password='" & TextBox7.Text & "' WHERE id_siswa='" & lblTangkapId.Text & "'", conn)
				cmd.ExecuteNonQuery()
				MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
				Me.Hide()
				MainMenuSiswa.Show()

			ElseIf MsgBoxResult.Cancel Then
			End If

		End If

	End Sub
End Class