<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuKepsek
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.lblTangkapId = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button1.Location = New System.Drawing.Point(131, 64)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(145, 42)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Profile"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button3.Location = New System.Drawing.Point(131, 130)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(145, 42)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Data Guru"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button2.Location = New System.Drawing.Point(131, 194)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(145, 42)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Data Murid"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button4.Location = New System.Drawing.Point(131, 262)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(145, 42)
		Me.Button4.TabIndex = 3
		Me.Button4.Text = "Logout"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'lblTangkapId
		'
		Me.lblTangkapId.AutoSize = True
		Me.lblTangkapId.Location = New System.Drawing.Point(351, 318)
		Me.lblTangkapId.Name = "lblTangkapId"
		Me.lblTangkapId.Size = New System.Drawing.Size(61, 15)
		Me.lblTangkapId.TabIndex = 55
		Me.lblTangkapId.Text = "TangkapId"
		Me.lblTangkapId.Visible = False
		'
		'MainMenuKepsek
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(424, 342)
		Me.Controls.Add(Me.lblTangkapId)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Name = "MainMenuKepsek"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Main Menu Kepsek"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents lblTangkapId As Label
End Class
