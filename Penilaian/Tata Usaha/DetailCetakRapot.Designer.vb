<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailCetakRapot
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btn_cetak = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.lblTangkapId = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lbl_nama_murid = New System.Windows.Forms.Label()
		Me.lbl_nis_murid = New System.Windows.Forms.Label()
		Me.lbl_kelas_murid = New System.Windows.Forms.Label()
		Me.lbl_alamat_murid = New System.Windows.Forms.Label()
		Me.lbl_tgl_lahir_murid = New System.Windows.Forms.Label()
		Me.lbl_tangkap_mapel = New System.Windows.Forms.Label()
		Me.lbl_uh = New System.Windows.Forms.Label()
		Me.lbl_tugas = New System.Windows.Forms.Label()
		Me.lbl_uts = New System.Windows.Forms.Label()
		Me.lbl_uas = New System.Windows.Forms.Label()
		Me.lbl_rata = New System.Windows.Forms.Label()
		Me.lbl_predikat = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.lbl_ttd_kepsek = New System.Windows.Forms.Label()
		Me.lbl_ttd_walas = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(59, 244)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(740, 218)
		Me.DataGridView1.TabIndex = 165
		'
		'btn_cetak
		'
		Me.btn_cetak.Location = New System.Drawing.Point(340, 689)
		Me.btn_cetak.Name = "btn_cetak"
		Me.btn_cetak.Size = New System.Drawing.Size(95, 35)
		Me.btn_cetak.TabIndex = 164
		Me.btn_cetak.Text = "Print"
		Me.btn_cetak.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(473, 689)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 35)
		Me.Button1.TabIndex = 173
		Me.Button1.Text = "Close"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
		'
		'lblTangkapId
		'
		Me.lblTangkapId.AutoSize = True
		Me.lblTangkapId.Location = New System.Drawing.Point(12, 709)
		Me.lblTangkapId.Name = "lblTangkapId"
		Me.lblTangkapId.Size = New System.Drawing.Size(61, 15)
		Me.lblTangkapId.TabIndex = 144
		Me.lblTangkapId.Text = "TangkapId"
		Me.lblTangkapId.Visible = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label7.Location = New System.Drawing.Point(157, 24)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(588, 40)
		Me.Label7.TabIndex = 145
		Me.Label7.Text = "Hasil Evaluasi Penilaian Akhir Semester Ganjil"
		Me.Label7.UseWaitCursor = True
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label12.Location = New System.Drawing.Point(30, 144)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(39, 25)
		Me.Label12.TabIndex = 146
		Me.Label12.Text = "Nis"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label13.Location = New System.Drawing.Point(30, 179)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(54, 25)
		Me.Label13.TabIndex = 147
		Me.Label13.Text = "kelas"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label14.Location = New System.Drawing.Point(30, 110)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(62, 25)
		Me.Label14.TabIndex = 148
		Me.Label14.Text = "Nama"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label15.Location = New System.Drawing.Point(496, 110)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(89, 25)
		Me.Label15.TabIndex = 149
		Me.Label15.Text = "Semester"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(496, 145)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(142, 25)
		Me.Label2.TabIndex = 151
		Me.Label2.Text = "Alamat Sekolah"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(165, 110)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(25, 25)
		Me.Label3.TabIndex = 152
		Me.Label3.Text = "="
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label4.Location = New System.Drawing.Point(165, 144)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(25, 25)
		Me.Label4.TabIndex = 153
		Me.Label4.Text = "="
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label5.Location = New System.Drawing.Point(165, 179)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(25, 25)
		Me.Label5.TabIndex = 154
		Me.Label5.Text = "="
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label6.Location = New System.Drawing.Point(631, 110)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(25, 25)
		Me.Label6.TabIndex = 155
		Me.Label6.Text = "="
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label8.Location = New System.Drawing.Point(631, 145)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(25, 25)
		Me.Label8.TabIndex = 156
		Me.Label8.Text = "="
		'
		'lbl_nama_murid
		'
		Me.lbl_nama_murid.AutoSize = True
		Me.lbl_nama_murid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_nama_murid.Location = New System.Drawing.Point(205, 110)
		Me.lbl_nama_murid.Name = "lbl_nama_murid"
		Me.lbl_nama_murid.Size = New System.Drawing.Size(113, 25)
		Me.lbl_nama_murid.TabIndex = 158
		Me.lbl_nama_murid.Text = "NamaMurid"
		'
		'lbl_nis_murid
		'
		Me.lbl_nis_murid.AutoSize = True
		Me.lbl_nis_murid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_nis_murid.Location = New System.Drawing.Point(205, 144)
		Me.lbl_nis_murid.Name = "lbl_nis_murid"
		Me.lbl_nis_murid.Size = New System.Drawing.Size(90, 25)
		Me.lbl_nis_murid.TabIndex = 159
		Me.lbl_nis_murid.Text = "NisMurid"
		'
		'lbl_kelas_murid
		'
		Me.lbl_kelas_murid.AutoSize = True
		Me.lbl_kelas_murid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_kelas_murid.Location = New System.Drawing.Point(205, 182)
		Me.lbl_kelas_murid.Name = "lbl_kelas_murid"
		Me.lbl_kelas_murid.Size = New System.Drawing.Size(107, 25)
		Me.lbl_kelas_murid.TabIndex = 160
		Me.lbl_kelas_murid.Text = "KelasMurid"
		'
		'lbl_alamat_murid
		'
		Me.lbl_alamat_murid.AutoSize = True
		Me.lbl_alamat_murid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_alamat_murid.Location = New System.Drawing.Point(671, 110)
		Me.lbl_alamat_murid.Name = "lbl_alamat_murid"
		Me.lbl_alamat_murid.Size = New System.Drawing.Size(49, 25)
		Me.lbl_alamat_murid.TabIndex = 161
		Me.lbl_alamat_murid.Text = "Satu"
		'
		'lbl_tgl_lahir_murid
		'
		Me.lbl_tgl_lahir_murid.AutoSize = True
		Me.lbl_tgl_lahir_murid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_tgl_lahir_murid.Location = New System.Drawing.Point(671, 145)
		Me.lbl_tgl_lahir_murid.Name = "lbl_tgl_lahir_murid"
		Me.lbl_tgl_lahir_murid.Size = New System.Drawing.Size(156, 25)
		Me.lbl_tgl_lahir_murid.TabIndex = 162
		Me.lbl_tgl_lahir_murid.Text = "Jl. Amd Radeon 5"
		'
		'lbl_tangkap_mapel
		'
		Me.lbl_tangkap_mapel.AutoSize = True
		Me.lbl_tangkap_mapel.Location = New System.Drawing.Point(774, 675)
		Me.lbl_tangkap_mapel.Name = "lbl_tangkap_mapel"
		Me.lbl_tangkap_mapel.Size = New System.Drawing.Size(84, 15)
		Me.lbl_tangkap_mapel.TabIndex = 166
		Me.lbl_tangkap_mapel.Text = "TangkapMapel"
		Me.lbl_tangkap_mapel.Visible = False
		'
		'lbl_uh
		'
		Me.lbl_uh.AutoSize = True
		Me.lbl_uh.Location = New System.Drawing.Point(774, 690)
		Me.lbl_uh.Name = "lbl_uh"
		Me.lbl_uh.Size = New System.Drawing.Size(68, 15)
		Me.lbl_uh.TabIndex = 167
		Me.lbl_uh.Text = "TangkapUH"
		Me.lbl_uh.Visible = False
		'
		'lbl_tugas
		'
		Me.lbl_tugas.AutoSize = True
		Me.lbl_tugas.Location = New System.Drawing.Point(781, 709)
		Me.lbl_tugas.Name = "lbl_tugas"
		Me.lbl_tugas.Size = New System.Drawing.Size(82, 15)
		Me.lbl_tugas.TabIndex = 168
		Me.lbl_tugas.Text = "TangkapTugas"
		Me.lbl_tugas.Visible = False
		'
		'lbl_uts
		'
		Me.lbl_uts.AutoSize = True
		Me.lbl_uts.Location = New System.Drawing.Point(703, 709)
		Me.lbl_uts.Name = "lbl_uts"
		Me.lbl_uts.Size = New System.Drawing.Size(68, 15)
		Me.lbl_uts.TabIndex = 169
		Me.lbl_uts.Text = "TangkapUts"
		Me.lbl_uts.Visible = False
		'
		'lbl_uas
		'
		Me.lbl_uas.AutoSize = True
		Me.lbl_uas.Location = New System.Drawing.Point(703, 689)
		Me.lbl_uas.Name = "lbl_uas"
		Me.lbl_uas.Size = New System.Drawing.Size(70, 15)
		Me.lbl_uas.TabIndex = 170
		Me.lbl_uas.Text = "TangkapUas"
		Me.lbl_uas.Visible = False
		'
		'lbl_rata
		'
		Me.lbl_rata.AutoSize = True
		Me.lbl_rata.Location = New System.Drawing.Point(746, 724)
		Me.lbl_rata.Name = "lbl_rata"
		Me.lbl_rata.Size = New System.Drawing.Size(74, 15)
		Me.lbl_rata.TabIndex = 171
		Me.lbl_rata.Text = "TangkapRata"
		Me.lbl_rata.Visible = False
		'
		'lbl_predikat
		'
		Me.lbl_predikat.AutoSize = True
		Me.lbl_predikat.Location = New System.Drawing.Point(679, 724)
		Me.lbl_predikat.Name = "lbl_predikat"
		Me.lbl_predikat.Size = New System.Drawing.Size(94, 15)
		Me.lbl_predikat.TabIndex = 172
		Me.lbl_predikat.Text = "TangkapPredikat"
		Me.lbl_predikat.Visible = False
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label9.Location = New System.Drawing.Point(49, 531)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(119, 42)
		Me.Label9.TabIndex = 175
		Me.Label9.Text = "Mengetahui/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orang Tua/Wali" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(696, 531)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 21)
		Me.Label1.TabIndex = 176
		Me.Label1.Text = "Wali Kelas"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label10.Location = New System.Drawing.Point(597, 470)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(202, 21)
		Me.Label10.TabIndex = 177
		Me.Label10.Text = "Disana, 30 September 2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label11.Location = New System.Drawing.Point(344, 531)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(202, 63)
		Me.Label11.TabIndex = 178
		Me.Label11.Text = "Mengetahui/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kepala Sekolah SMA Raizen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label16.Location = New System.Drawing.Point(56, 640)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(112, 21)
		Me.Label16.TabIndex = 179
		Me.Label16.Text = ".................................."
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lbl_ttd_kepsek
		'
		Me.lbl_ttd_kepsek.AutoSize = True
		Me.lbl_ttd_kepsek.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_ttd_kepsek.Location = New System.Drawing.Point(395, 640)
		Me.lbl_ttd_kepsek.Name = "lbl_ttd_kepsek"
		Me.lbl_ttd_kepsek.Size = New System.Drawing.Size(112, 21)
		Me.lbl_ttd_kepsek.TabIndex = 180
		Me.lbl_ttd_kepsek.Text = ".................................."
		Me.lbl_ttd_kepsek.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lbl_ttd_walas
		'
		Me.lbl_ttd_walas.AutoSize = True
		Me.lbl_ttd_walas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.lbl_ttd_walas.Location = New System.Drawing.Point(696, 640)
		Me.lbl_ttd_walas.Name = "lbl_ttd_walas"
		Me.lbl_ttd_walas.Size = New System.Drawing.Size(112, 21)
		Me.lbl_ttd_walas.TabIndex = 181
		Me.lbl_ttd_walas.Text = ".................................."
		Me.lbl_ttd_walas.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'DetailCetakRapot
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(845, 738)
		Me.Controls.Add(Me.lbl_ttd_walas)
		Me.Controls.Add(Me.lbl_ttd_kepsek)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.lbl_predikat)
		Me.Controls.Add(Me.lbl_rata)
		Me.Controls.Add(Me.lbl_uas)
		Me.Controls.Add(Me.lbl_uts)
		Me.Controls.Add(Me.lbl_tugas)
		Me.Controls.Add(Me.lbl_uh)
		Me.Controls.Add(Me.lbl_tangkap_mapel)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.btn_cetak)
		Me.Controls.Add(Me.lbl_tgl_lahir_murid)
		Me.Controls.Add(Me.lbl_alamat_murid)
		Me.Controls.Add(Me.lbl_kelas_murid)
		Me.Controls.Add(Me.lbl_nis_murid)
		Me.Controls.Add(Me.lbl_nama_murid)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.lblTangkapId)
		Me.Name = "DetailCetakRapot"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Detail Cetak Rapot"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents btn_cetak As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents PrintDocument1 As Printing.PrintDocument
	Friend WithEvents PrintDialog1 As PrintDialog
	Friend WithEvents lblTangkapId As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lbl_nama_murid As Label
	Friend WithEvents lbl_nis_murid As Label
	Friend WithEvents lbl_kelas_murid As Label
	Friend WithEvents lbl_alamat_murid As Label
	Friend WithEvents lbl_tgl_lahir_murid As Label
	Friend WithEvents lbl_tangkap_mapel As Label
	Friend WithEvents lbl_uh As Label
	Friend WithEvents lbl_tugas As Label
	Friend WithEvents lbl_uts As Label
	Friend WithEvents lbl_uas As Label
	Friend WithEvents lbl_rata As Label
	Friend WithEvents lbl_predikat As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents lbl_ttd_kepsek As Label
	Friend WithEvents lbl_ttd_walas As Label
End Class
