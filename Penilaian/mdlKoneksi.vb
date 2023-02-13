Imports MySql.Data.MySqlClient

Module mdlKoneksi
	Public conn As MySqlConnection
	Public da As MySqlDataAdapter
	Public ds As DataSet
	Public cmd As MySqlCommand
	Public dr As MySqlDataReader

	Public Sub koneksi()
		conn = New MySqlConnection("server=localhost; database=db_penilaian; uid=root; password=")
		conn.Open()
	End Sub
End Module
