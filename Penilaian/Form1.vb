Imports MySql.Data.MySqlClient

Public Class Form1

	Sub bersihInput()
		TextBox1.Text = ""
		TextBox2.Text = ""
		ComboBox1.Text = "Level user.."
		TextBox2.PasswordChar = "*"
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bersihInput()
		ComboBox1.Items.Add("Staff")
		ComboBox1.Items.Add("Guru")
		ComboBox1.Items.Add("Murid")
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked = True Then

			TextBox2.PasswordChar = ""

		Else

			TextBox2.PasswordChar = "*"


		End If
	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar dari aplikasi ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Dispose()
		Else

		End If
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "Level user.." Then
			MsgBox("Harap isi semua data dengan benar,  dan isi level user dengan baik", MsgBoxStyle.Exclamation, "Perhatian!")
		Else

			If ComboBox1.Text = "Staff" Then

				Call koneksi()
				cmd = New MySqlCommand("Select * from users where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then
					If dr.Item("level") = "kepsek" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuKepsek.lblTangkapId.Text = dr.Item("id_user")
						MainMenuKepsek.Show()

					ElseIf dr.Item("level") = "wakepsek" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuWakepsek.lblTangkapId.Text = dr.Item("id_user")
						MainMenuWakepsek.Show()
					ElseIf dr.Item("level") = "admin" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuAdmin.lblTangkapId.Text = dr.Item("id_user")
						MainMenuAdmin.Show()
					ElseIf dr.Item("level") = "tata_usaha" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuTataUsaha.lblTangkapId.Text = dr.Item("id_user")
						MainMenuTataUsaha.Show()
					Else

						MsgBox("User Tidak Ditemukan!")
						bersihInput()
					End If
				Else
					MsgBox("User Tidak Ditemukan!")
					bersihInput()
				End If


			ElseIf ComboBox1.Text = "Guru" Then
				Call koneksi()
				cmd = New MySqlCommand("select * from guru where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then

					MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
					Me.Hide()
					bersihInput()
					MainMenuGuru.lblTangkapId.Text = dr.Item("idguru")
					MainMenuGuru.Show()

				Else
					MsgBox("User Tidak Ditemukan!")
					bersihInput()
				End If

			ElseIf ComboBox1.Text = "Murid" Then

				Call koneksi()
				cmd = New MySqlCommand("select * from siswa where nis = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then

					MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
					Me.Hide()
					bersihInput()
					MainMenuSiswa.lblTangkapId.Text = dr.Item("id_siswa")
					MainMenuSiswa.Show()

				Else
					MsgBox("User Tidak Ditemukan!")
					bersihInput()
				End If
			Else

				MsgBox("Username Atau Password Salah!!", MsgBoxStyle.Exclamation, "Perhatian!")
				bersihInput()
			End If
		End If

	End Sub

End Class
