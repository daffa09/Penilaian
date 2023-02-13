<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(257, 203)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(103, 19)
		Me.CheckBox1.TabIndex = 31
		Me.CheckBox1.Text = "Show Pasword"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(333, 276)
		Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(124, 36)
		Me.Button2.TabIndex = 30
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(154, 276)
		Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(124, 36)
		Me.Button1.TabIndex = 29
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(117, 155)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(103, 30)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Password"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(257, 163)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(236, 23)
		Me.TextBox2.TabIndex = 27
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(117, 111)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(111, 30)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "Username"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(257, 119)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(236, 23)
		Me.TextBox1.TabIndex = 25
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(38, 33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(558, 51)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Aplikasi Penilaian SMA Raizen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(257, 237)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(153, 23)
		Me.ComboBox1.TabIndex = 32
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(618, 346)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
End Class
