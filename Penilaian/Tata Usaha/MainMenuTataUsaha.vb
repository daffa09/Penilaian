Imports MySql.Data.MySqlClient


Public Class MainMenuTataUsaha
	Private Sub MainMenuTataUsaha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub MainMenuTataUsaha_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
			ProfileTataUsaha.TextBox1.Text = dr.Item("nama")
			ProfileTataUsaha.TextBox2.Text = dr.Item("username")
			ProfileTataUsaha.TextBox3.Text = dr.Item("password")
			ProfileTataUsaha.TextBox4.Text = dr.Item("alamat")
			ProfileTataUsaha.TextBox5.Text = dr.Item("no_telp")
			ProfileTataUsaha.lblTangkapId.Text = dr.Item("id_user")
		Else
			MsgBox("masih kebuka")
		End If

		ProfileTataUsaha.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		CetakRapot.Show()

	End Sub
End Class