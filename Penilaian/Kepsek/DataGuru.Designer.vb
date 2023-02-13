<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGuru
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
		Me.btn_close = New System.Windows.Forms.Button()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(317, 378)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(95, 35)
		Me.btn_close.TabIndex = 83
		Me.btn_close.Text = "Close"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(626, 94)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(90, 32)
		Me.btn_search.TabIndex = 82
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(482, 99)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(137, 23)
		Me.TextBox1.TabIndex = 81
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(35, 134)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(681, 217)
		Me.DataGridView1.TabIndex = 80
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(243, 27)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(279, 45)
		Me.Label1.TabIndex = 79
		Me.Label1.Text = "Data Seluruh Guru"
		'
		'DataGuru
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(773, 450)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "DataGuru"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DataGuru"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btn_close As Button
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
End Class
