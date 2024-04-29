<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Admin_KelolaUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Telepon = New System.Windows.Forms.TextBox()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_TipeUser = New System.Windows.Forms.ComboBox()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_KelolaUser = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox_Cari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_KelolaUser_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Edit = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Tambah = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_KelolaUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(753, 83)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kelola User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Password, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Telepon, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Username, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Alamat, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_TipeUser, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Nama, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(736, 186)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Password.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(373, 154)
        Me.TextBox_Password.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(358, 25)
        Me.TextBox_Password.TabIndex = 11
        '
        'TextBox_Telepon
        '
        Me.TextBox_Telepon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Telepon.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Telepon.Location = New System.Drawing.Point(5, 154)
        Me.TextBox_Telepon.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Telepon.Name = "TextBox_Telepon"
        Me.TextBox_Telepon.Size = New System.Drawing.Size(358, 25)
        Me.TextBox_Telepon.TabIndex = 10
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Username.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(373, 93)
        Me.TextBox_Username.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(358, 25)
        Me.TextBox_Username.TabIndex = 9
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Alamat.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Alamat.Location = New System.Drawing.Point(373, 32)
        Me.TextBox_Alamat.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(358, 25)
        Me.TextBox_Alamat.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipe User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Password"
        '
        'ComboBox_TipeUser
        '
        Me.ComboBox_TipeUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_TipeUser.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_TipeUser.FormattingEnabled = True
        Me.ComboBox_TipeUser.Location = New System.Drawing.Point(5, 32)
        Me.ComboBox_TipeUser.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox_TipeUser.Name = "ComboBox_TipeUser"
        Me.ComboBox_TipeUser.Size = New System.Drawing.Size(358, 26)
        Me.ComboBox_TipeUser.TabIndex = 6
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Nama.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nama.Location = New System.Drawing.Point(5, 93)
        Me.TextBox_Nama.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(358, 25)
        Me.TextBox_Nama.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView_KelolaUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 439)
        Me.Panel1.TabIndex = 3
        '
        'DataGridView_KelolaUser
        '
        Me.DataGridView_KelolaUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaUser.Location = New System.Drawing.Point(10, 276)
        Me.DataGridView_KelolaUser.Name = "DataGridView_KelolaUser"
        Me.DataGridView_KelolaUser.Size = New System.Drawing.Size(734, 154)
        Me.DataGridView_KelolaUser.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox_Cari)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(10, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(462, 28)
        Me.Panel2.TabIndex = 4
        '
        'TextBox_Cari
        '
        Me.TextBox_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Cari.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox_Cari.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Cari.Location = New System.Drawing.Point(85, 0)
        Me.TextBox_Cari.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Cari.Name = "TextBox_Cari"
        Me.TextBox_Cari.Size = New System.Drawing.Size(377, 25)
        Me.TextBox_Cari.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cari User"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button_KelolaUser_Hapus, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button_KelolaUser_Edit, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button_KelolaUser_Tambah, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 202)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(464, 36)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Button_KelolaUser_Hapus
        '
        Me.Button_KelolaUser_Hapus.BackColor = System.Drawing.Color.LightBlue
        Me.Button_KelolaUser_Hapus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_KelolaUser_Hapus.FlatAppearance.BorderSize = 0
        Me.Button_KelolaUser_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_KelolaUser_Hapus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Hapus.Location = New System.Drawing.Point(311, 3)
        Me.Button_KelolaUser_Hapus.Name = "Button_KelolaUser_Hapus"
        Me.Button_KelolaUser_Hapus.Size = New System.Drawing.Size(150, 30)
        Me.Button_KelolaUser_Hapus.TabIndex = 6
        Me.Button_KelolaUser_Hapus.Text = "Hapus"
        Me.Button_KelolaUser_Hapus.UseVisualStyleBackColor = False
        '
        'Button_KelolaUser_Edit
        '
        Me.Button_KelolaUser_Edit.BackColor = System.Drawing.Color.LightBlue
        Me.Button_KelolaUser_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_KelolaUser_Edit.FlatAppearance.BorderSize = 0
        Me.Button_KelolaUser_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_KelolaUser_Edit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Edit.Location = New System.Drawing.Point(157, 3)
        Me.Button_KelolaUser_Edit.Name = "Button_KelolaUser_Edit"
        Me.Button_KelolaUser_Edit.Size = New System.Drawing.Size(148, 30)
        Me.Button_KelolaUser_Edit.TabIndex = 5
        Me.Button_KelolaUser_Edit.Text = "Edit"
        Me.Button_KelolaUser_Edit.UseVisualStyleBackColor = False
        '
        'Button_KelolaUser_Tambah
        '
        Me.Button_KelolaUser_Tambah.BackColor = System.Drawing.Color.LightBlue
        Me.Button_KelolaUser_Tambah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_KelolaUser_Tambah.FlatAppearance.BorderSize = 0
        Me.Button_KelolaUser_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_KelolaUser_Tambah.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Tambah.Location = New System.Drawing.Point(3, 3)
        Me.Button_KelolaUser_Tambah.Name = "Button_KelolaUser_Tambah"
        Me.Button_KelolaUser_Tambah.Size = New System.Drawing.Size(148, 30)
        Me.Button_KelolaUser_Tambah.TabIndex = 4
        Me.Button_KelolaUser_Tambah.Text = "Tambah"
        Me.Button_KelolaUser_Tambah.UseVisualStyleBackColor = False
        '
        'UserControl_Admin_KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UserControl_Admin_KelolaUser"
        Me.Size = New System.Drawing.Size(753, 522)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_KelolaUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_TipeUser As ComboBox
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents TextBox_Telepon As TextBox
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button_KelolaUser_Hapus As Button
    Friend WithEvents Button_KelolaUser_Edit As Button
    Friend WithEvents Button_KelolaUser_Tambah As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_Cari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView_KelolaUser As DataGridView
End Class
