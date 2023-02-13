<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahUserStaff
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.btn_tambah = New System.Windows.Forms.Button()
		Me.btn_delete = New System.Windows.Forms.Button()
		Me.btn_close = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(243, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(285, 45)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Form Tambah Staff"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(44, 93)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(681, 150)
		Me.DataGridView1.TabIndex = 1
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(44, 266)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(137, 23)
		Me.TextBox1.TabIndex = 2
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(188, 261)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(90, 32)
		Me.btn_search.TabIndex = 3
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(463, 271)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(46, 23)
		Me.TextBox2.TabIndex = 4
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(375, 274)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 20)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Id User"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(375, 320)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(49, 20)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Nama"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(463, 317)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(178, 23)
		Me.TextBox3.TabIndex = 6
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label4.Location = New System.Drawing.Point(375, 365)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(75, 20)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Username"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(463, 362)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(178, 23)
		Me.TextBox4.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label5.Location = New System.Drawing.Point(375, 409)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(70, 20)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Password"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(463, 406)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(178, 23)
		Me.TextBox5.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label6.Location = New System.Drawing.Point(375, 462)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(43, 20)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "Level"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label7.Location = New System.Drawing.Point(375, 508)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(57, 20)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "Alamat"
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(463, 505)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(178, 23)
		Me.TextBox6.TabIndex = 14
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label8.Location = New System.Drawing.Point(375, 551)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(61, 20)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "No Telp"
		'
		'TextBox7
		'
		Me.TextBox7.Location = New System.Drawing.Point(463, 548)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(178, 23)
		Me.TextBox7.TabIndex = 16
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(463, 459)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(153, 23)
		Me.ComboBox1.TabIndex = 34
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(463, 433)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(103, 19)
		Me.CheckBox1.TabIndex = 33
		Me.CheckBox1.Text = "Show Pasword"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'btn_tambah
		'
		Me.btn_tambah.Location = New System.Drawing.Point(276, 634)
		Me.btn_tambah.Name = "btn_tambah"
		Me.btn_tambah.Size = New System.Drawing.Size(95, 35)
		Me.btn_tambah.TabIndex = 35
		Me.btn_tambah.Text = "Tambah"
		Me.btn_tambah.UseVisualStyleBackColor = True
		'
		'btn_delete
		'
		Me.btn_delete.Location = New System.Drawing.Point(414, 634)
		Me.btn_delete.Name = "btn_delete"
		Me.btn_delete.Size = New System.Drawing.Size(95, 35)
		Me.btn_delete.TabIndex = 36
		Me.btn_delete.Text = "Delete"
		Me.btn_delete.UseVisualStyleBackColor = True
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(546, 634)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(95, 35)
		Me.btn_close.TabIndex = 37
		Me.btn_close.Text = "Close"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'TambahUserStaff
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(786, 698)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_delete)
		Me.Controls.Add(Me.btn_tambah)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.TextBox7)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "TambahUserStaff"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Tambah User"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents btn_tambah As Button
	Friend WithEvents btn_delete As Button
	Friend WithEvents btn_close As Button
End Class
