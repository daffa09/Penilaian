<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahMapel
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
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.btn_close = New System.Windows.Forms.Button()
		Me.btn_delete = New System.Windows.Forms.Button()
		Me.btn_tambah = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label9.Location = New System.Drawing.Point(411, 188)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(107, 20)
		Me.Label9.TabIndex = 111
		Me.Label9.Text = "Guru Mengajar"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(529, 220)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(178, 23)
		Me.TextBox4.TabIndex = 110
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(636, 307)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(95, 35)
		Me.btn_close.TabIndex = 108
		Me.btn_close.Text = "Close"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'btn_delete
		'
		Me.btn_delete.Location = New System.Drawing.Point(504, 307)
		Me.btn_delete.Name = "btn_delete"
		Me.btn_delete.Size = New System.Drawing.Size(95, 35)
		Me.btn_delete.TabIndex = 107
		Me.btn_delete.Text = "Delete"
		Me.btn_delete.UseVisualStyleBackColor = True
		'
		'btn_tambah
		'
		Me.btn_tambah.Location = New System.Drawing.Point(366, 307)
		Me.btn_tambah.Name = "btn_tambah"
		Me.btn_tambah.Size = New System.Drawing.Size(95, 35)
		Me.btn_tambah.TabIndex = 106
		Me.btn_tambah.Text = "Tambah"
		Me.btn_tambah.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(411, 223)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 20)
		Me.Label3.TabIndex = 95
		Me.Label3.Text = "Nama Mapel"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(411, 139)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 20)
		Me.Label2.TabIndex = 93
		Me.Label2.Text = "Id Mapel"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(529, 139)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(47, 23)
		Me.TextBox2.TabIndex = 92
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(185, 293)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(90, 32)
		Me.btn_search.TabIndex = 91
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(41, 298)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(137, 23)
		Me.TextBox1.TabIndex = 90
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(42, 126)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(327, 150)
		Me.DataGridView1.TabIndex = 89
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(236, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(311, 45)
		Me.Label1.TabIndex = 88
		Me.Label1.Text = "Form Tambah Mapel"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(529, 185)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(178, 23)
		Me.ComboBox1.TabIndex = 112
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(111, 97)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(143, 23)
		Me.ComboBox2.TabIndex = 113
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label4.Location = New System.Drawing.Point(42, 97)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(63, 20)
		Me.Label4.TabIndex = 114
		Me.Label4.Text = "Sort By :"
		'
		'TambahMapel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(769, 370)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_delete)
		Me.Controls.Add(Me.btn_tambah)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "TambahMapel"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Tambah Mapel"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label9 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents btn_close As Button
	Friend WithEvents btn_delete As Button
	Friend WithEvents btn_tambah As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label4 As Label
End Class
