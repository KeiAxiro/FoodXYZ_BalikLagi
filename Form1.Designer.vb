<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Password = New System.Windows.Forms.Panel()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Panel_Username = New System.Windows.Forms.Panel()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label_Validation = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Tambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel_Login.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_Password.SuspendLayout()
        Me.Panel_Username.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Food XYZ"
        '
        'Panel_Login
        '
        Me.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Login.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel_Login.Location = New System.Drawing.Point(190, 246)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(300, 175)
        Me.Panel_Login.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Password, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Username, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82724!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95106!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82724!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95105!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.44341!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 175)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'Panel_Password
        '
        Me.Panel_Password.Controls.Add(Me.TextBox_Password)
        Me.Panel_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Password.Location = New System.Drawing.Point(3, 90)
        Me.Panel_Password.Name = "Panel_Password"
        Me.Panel_Password.Size = New System.Drawing.Size(294, 27)
        Me.Panel_Password.TabIndex = 2
        '
        'TextBox_Password
        '
        Me.TextBox_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Password.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(294, 26)
        Me.TextBox_Password.TabIndex = 1
        Me.TextBox_Password.Text = "kei"
        Me.TextBox_Password.UseSystemPasswordChar = True
        '
        'Panel_Username
        '
        Me.Panel_Username.Controls.Add(Me.TextBox_Username)
        Me.Panel_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Username.Location = New System.Drawing.Point(3, 30)
        Me.Panel_Username.Name = "Panel_Username"
        Me.Panel_Username.Size = New System.Drawing.Size(294, 27)
        Me.Panel_Username.TabIndex = 1
        '
        'TextBox_Username
        '
        Me.TextBox_Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Username.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(294, 26)
        Me.TextBox_Username.TabIndex = 0
        Me.TextBox_Username.Text = "kei"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button_Reset, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button_Login, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 123)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(294, 49)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Button_Reset
        '
        Me.Button_Reset.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Reset.FlatAppearance.BorderSize = 0
        Me.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(150, 3)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(141, 43)
        Me.Button_Reset.TabIndex = 3
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = False
        '
        'Button_Login
        '
        Me.Button_Login.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Login.FlatAppearance.BorderSize = 0
        Me.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Login.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(3, 3)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(141, 43)
        Me.Button_Login.TabIndex = 2
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = False
        '
        'Label_Validation
        '
        Me.Label_Validation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Validation.AutoSize = True
        Me.Label_Validation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Validation.Location = New System.Drawing.Point(193, 424)
        Me.Label_Validation.Name = "Label_Validation"
        Me.Label_Validation.Size = New System.Drawing.Size(0, 19)
        Me.Label_Validation.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.FoodXYZ_BalikLagi.My.Resources.Resources.Logo_Market
        Me.PictureBox1.Location = New System.Drawing.Point(263, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(352, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "GUDANG"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_KelolaUser_Tambah
        '
        Me.Button_KelolaUser_Tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KelolaUser_Tambah.BackColor = System.Drawing.Color.LightBlue
        Me.Button_KelolaUser_Tambah.FlatAppearance.BorderSize = 0
        Me.Button_KelolaUser_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_KelolaUser_Tambah.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Tambah.Location = New System.Drawing.Point(198, 4)
        Me.Button_KelolaUser_Tambah.Name = "Button_KelolaUser_Tambah"
        Me.Button_KelolaUser_Tambah.Size = New System.Drawing.Size(148, 30)
        Me.Button_KelolaUser_Tambah.TabIndex = 13
        Me.Button_KelolaUser_Tambah.Text = "ADMIN"
        Me.Button_KelolaUser_Tambah.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(504, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "KASR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_KelolaUser_Tambah)
        Me.Controls.Add(Me.Label_Validation)
        Me.Controls.Add(Me.Panel_Login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Food XYZ | Form Login"
        Me.Panel_Login.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel_Password.ResumeLayout(False)
        Me.Panel_Password.PerformLayout()
        Me.Panel_Username.ResumeLayout(False)
        Me.Panel_Username.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_Reset As Button
    Friend WithEvents Panel_Username As Panel
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Panel_Password As Panel
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label_Validation As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_KelolaUser_Tambah As Button
    Friend WithEvents Button2 As Button
End Class
