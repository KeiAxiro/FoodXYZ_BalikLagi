<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Gudang_KelolaBarang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_TipeUser = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_KelolaUser_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Edit = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Tambah = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 102)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipe User"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_TipeUser, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 102)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.31502!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(747, 230)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipe User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipe User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipe User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipe User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(377, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipe User"
        '
        'ComboBox_TipeUser
        '
        Me.ComboBox_TipeUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_TipeUser.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_TipeUser.FormattingEnabled = True
        Me.ComboBox_TipeUser.Location = New System.Drawing.Point(379, 116)
        Me.ComboBox_TipeUser.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBox_TipeUser.Name = "ComboBox_TipeUser"
        Me.ComboBox_TipeUser.Size = New System.Drawing.Size(362, 25)
        Me.ComboBox_TipeUser.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 40)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(361, 25)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(379, 40)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(362, 25)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 116)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(361, 25)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(379, 192)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(362, 25)
        Me.TextBox4.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(4, 190)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(365, 26)
        Me.DateTimePicker1.TabIndex = 12
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 334)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(464, 36)
        Me.TableLayoutPanel2.TabIndex = 4
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
        'UserControl_Gudang_KelolaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserControl_Gudang_KelolaBarang"
        Me.Size = New System.Drawing.Size(747, 526)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_TipeUser As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button_KelolaUser_Hapus As Button
    Friend WithEvents Button_KelolaUser_Edit As Button
    Friend WithEvents Button_KelolaUser_Tambah As Button
End Class
