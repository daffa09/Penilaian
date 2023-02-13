<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuWakepsek
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
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.lblTangkapId = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button4.Location = New System.Drawing.Point(111, 233)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(145, 42)
		Me.Button4.TabIndex = 7
		Me.Button4.Text = "Logout"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button2.Location = New System.Drawing.Point(111, 165)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(145, 42)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Ubah Walas"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button1.Location = New System.Drawing.Point(111, 35)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(145, 42)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Profile"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button3.Location = New System.Drawing.Point(111, 102)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(145, 45)
		Me.Button3.TabIndex = 6
		Me.Button3.Text = "Tambah Mapel"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'lblTangkapId
		'
		Me.lblTangkapId.AutoSize = True
		Me.lblTangkapId.Location = New System.Drawing.Point(297, 300)
		Me.lblTangkapId.Name = "lblTangkapId"
		Me.lblTangkapId.Size = New System.Drawing.Size(61, 15)
		Me.lblTangkapId.TabIndex = 56
		Me.lblTangkapId.Text = "TangkapId"
		Me.lblTangkapId.Visible = False
		'
		'MainMenuWakepsek
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(370, 324)
		Me.Controls.Add(Me.lblTangkapId)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Name = "MainMenuWakepsek"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Main Menu Wakepsek"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button4 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents lblTangkapId As Label
End Class
