Imports MySql.Data.MySqlClient


Public Class ProfileTataUsaha
	Private Sub ProfileTataUsaha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBox3.PasswordChar = "*"

	End Sub

	Private Sub ProfileTataUsaha_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

			TextBox3.PasswordChar = ""

		Else

			TextBox3.PasswordChar = "*"


		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

			Me.Hide()
			MainMenuTataUsaha.Show()

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

			MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

		Else

			If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

				Call koneksi()
				cmd = New MySqlCommand("UPDATE users SET username='" & TextBox2.Text & "', password='" & TextBox3.Text & "', nama='" & TextBox1.Text & "', alamat='" & TextBox4.Text & "', no_telp='" & TextBox5.Text & "' WHERE id_user='" & lblTangkapId.Text & "'", conn)
				cmd.ExecuteNonQuery()
				MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
				Me.Hide()
				MainMenuTataUsaha.Show()

			ElseIf MsgBoxResult.Cancel Then
			End If

		End If
	End Sub
End Class