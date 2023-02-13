Imports MySql.Data.MySqlClient


Public Class MainMenuGuru
	Private Sub MainMenuGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub MainMenuGuru_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
		cmd = New MySqlCommand("select * from guru where idguru = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		If (dr.Read()) Then
			ProfileGuru.TextBox1.Text = dr.Item("nama")
			ProfileGuru.TextBox2.Text = dr.Item("username")
			ProfileGuru.TextBox3.Text = dr.Item("password")
			ProfileGuru.TextBox4.Text = dr.Item("alamat")
			ProfileGuru.TextBox5.Text = dr.Item("no_telp")
			ProfileGuru.lblTangkapId.Text = dr.Item("idguru")
		Else
			MsgBox("masih kebuka")
		End If

		ProfileGuru.Show()

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		DataKepsek.Show()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

		Dim session = lblTangkapId.Text
		Me.Hide()
		Call koneksi()
		cmd = New MySqlCommand("select * from guru where idguru = '" & session & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		Me.Hide()
		InputNilai.lblTangkapId.Text = dr.Item("idguru")
		InputNilai.Show()

	End Sub
End Class