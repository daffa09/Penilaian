<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuridKepsek
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.btn_close = New System.Windows.Forms.Button()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(160, 105)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(146, 23)
		Me.ComboBox1.TabIndex = 78
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label9.Location = New System.Drawing.Point(37, 104)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(117, 20)
		Me.Label9.TabIndex = 77
		Me.Label9.Text = "Urut Berdasakan"
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(311, 383)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(95, 35)
		Me.btn_close.TabIndex = 76
		Me.btn_close.Text = "Close"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(620, 99)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(90, 32)
		Me.btn_search.TabIndex = 75
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(476, 104)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(137, 23)
		Me.TextBox1.TabIndex = 74
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(29, 139)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(681, 217)
		Me.DataGridView1.TabIndex = 73
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(284, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(179, 45)
		Me.Label1.TabIndex = 72
		Me.Label1.Text = "Data Murid"
		'
		'MuridKepsek
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(764, 450)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "MuridKepsek"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Data Murid"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents btn_close As Button
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
End Class
