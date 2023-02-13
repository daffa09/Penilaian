Imports MySql.Data.MySqlClient


Public Class MainMenuAdmin
	Private Sub MainMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub MainMenuAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
		cmd = New MySqlCommand("select * from users where id_user = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		If (dr.Read()) Then
			ProfileAdmin.TextBox1.Text = dr.Item("nama")
			ProfileAdmin.TextBox2.Text = dr.Item("username")
			ProfileAdmin.TextBox3.Text = dr.Item("password")
			ProfileAdmin.TextBox4.Text = dr.Item("alamat")
			ProfileAdmin.TextBox5.Text = dr.Item("no_telp")
			ProfileAdmin.lblTangkapId.Text = dr.Item("id_user")
		Else
			MsgBox("masih kebuka")
		End If

		ProfileAdmin.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		TambahUsers.Show()
	End Sub
End Class