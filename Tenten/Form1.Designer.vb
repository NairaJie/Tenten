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
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtlahir = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.cmbagama = New System.Windows.Forms.ComboBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(159, 86)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(182, 20)
        Me.txtno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Peserta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hobi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Alamat"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(159, 126)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(182, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtlahir
        '
        Me.txtlahir.Location = New System.Drawing.Point(159, 165)
        Me.txtlahir.Name = "txtlahir"
        Me.txtlahir.Size = New System.Drawing.Size(182, 20)
        Me.txtlahir.TabIndex = 9
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(159, 316)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(182, 20)
        Me.txtalamat.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tanggal Lahir"
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(485, 172)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(200, 20)
        Me.dtplahir.TabIndex = 12
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(159, 201)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(68, 17)
        Me.rb1.TabIndex = 13
        Me.rb1.TabStop = True
        Me.rb1.Text = "Laki-Laki"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(273, 201)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(79, 17)
        Me.rb2.TabIndex = 14
        Me.rb2.TabStop = True
        Me.rb2.Text = "Perempuan"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "Protestan", "Katolik", "Hindu", "Budha", "Konghuchu", "Atheis"})
        Me.cmbagama.Location = New System.Drawing.Point(159, 237)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(182, 21)
        Me.cmbagama.TabIndex = 15
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(159, 278)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(62, 17)
        Me.cb1.TabIndex = 16
        Me.cb1.Text = "Menulis"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(273, 278)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(73, 17)
        Me.cb2.TabIndex = 17
        Me.cb2.Text = "Membaca"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "No Telepon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 19
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(471, 234)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(182, 20)
        Me.txtnotelp.TabIndex = 20
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(44, 376)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 21
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(144, 376)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 22
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(249, 376)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 23
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(350, 376)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 24
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(453, 376)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(553, 376)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 26
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'dgtampil
        '
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Location = New System.Drawing.Point(44, 447)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.Size = New System.Drawing.Size(623, 150)
        Me.dgtampil.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(279, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "BIODATA PESERTA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgtampil)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtlahir As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents cmbagama As ComboBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnotelp As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents dgtampil As DataGridView
    Friend WithEvents Label11 As Label
End Class
