<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Admin_Logout = New System.Windows.Forms.Button()
        Me.Button_Admin_KelolaLaporan = New System.Windows.Forms.Button()
        Me.Button_Admin_KelolaUser = New System.Windows.Forms.Button()
        Me.Label_Admin = New System.Windows.Forms.Label()
        Me.Panel_AdminParent = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_AdminParent)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 511)
        Me.SplitContainer1.SplitterDistance = 234
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Button_Admin_Logout)
        Me.Panel1.Controls.Add(Me.Button_Admin_KelolaLaporan)
        Me.Panel1.Controls.Add(Me.Button_Admin_KelolaUser)
        Me.Panel1.Controls.Add(Me.Label_Admin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 511)
        Me.Panel1.TabIndex = 0
        '
        'Button_Admin_Logout
        '
        Me.Button_Admin_Logout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Admin_Logout.BackColor = System.Drawing.Color.LightCoral
        Me.Button_Admin_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Admin_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Admin_Logout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_Logout.Location = New System.Drawing.Point(30, 390)
        Me.Button_Admin_Logout.Name = "Button_Admin_Logout"
        Me.Button_Admin_Logout.Size = New System.Drawing.Size(179, 32)
        Me.Button_Admin_Logout.TabIndex = 2
        Me.Button_Admin_Logout.Text = "Logout"
        Me.Button_Admin_Logout.UseVisualStyleBackColor = False
        '
        'Button_Admin_KelolaLaporan
        '
        Me.Button_Admin_KelolaLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Admin_KelolaLaporan.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Admin_KelolaLaporan.FlatAppearance.BorderSize = 0
        Me.Button_Admin_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Admin_KelolaLaporan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaLaporan.Location = New System.Drawing.Point(30, 352)
        Me.Button_Admin_KelolaLaporan.Name = "Button_Admin_KelolaLaporan"
        Me.Button_Admin_KelolaLaporan.Size = New System.Drawing.Size(179, 32)
        Me.Button_Admin_KelolaLaporan.TabIndex = 2
        Me.Button_Admin_KelolaLaporan.Text = "Kelola Laporan"
        Me.Button_Admin_KelolaLaporan.UseVisualStyleBackColor = False
        '
        'Button_Admin_KelolaUser
        '
        Me.Button_Admin_KelolaUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Admin_KelolaUser.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Admin_KelolaUser.FlatAppearance.BorderSize = 0
        Me.Button_Admin_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Admin_KelolaUser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaUser.Location = New System.Drawing.Point(30, 314)
        Me.Button_Admin_KelolaUser.Name = "Button_Admin_KelolaUser"
        Me.Button_Admin_KelolaUser.Size = New System.Drawing.Size(179, 32)
        Me.Button_Admin_KelolaUser.TabIndex = 2
        Me.Button_Admin_KelolaUser.Text = "Kelola User"
        Me.Button_Admin_KelolaUser.UseVisualStyleBackColor = False
        '
        'Label_Admin
        '
        Me.Label_Admin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Admin.AutoSize = True
        Me.Label_Admin.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Admin.Location = New System.Drawing.Point(64, 19)
        Me.Label_Admin.Name = "Label_Admin"
        Me.Label_Admin.Size = New System.Drawing.Size(111, 33)
        Me.Label_Admin.TabIndex = 1
        Me.Label_Admin.Text = "ADMIN"
        '
        'Panel_AdminParent
        '
        Me.Panel_AdminParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_AdminParent.Location = New System.Drawing.Point(0, 0)
        Me.Panel_AdminParent.Name = "Panel_AdminParent"
        Me.Panel_AdminParent.Size = New System.Drawing.Size(546, 511)
        Me.Panel_AdminParent.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.FoodXYZ_BalikLagi.My.Resources.Resources.Admin_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(45, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAdmin"
        Me.Text = "Food XYZ | Form Admin"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Admin As Label
    Friend WithEvents Button_Admin_Logout As Button
    Friend WithEvents Button_Admin_KelolaLaporan As Button
    Friend WithEvents Button_Admin_KelolaUser As Button
    Friend WithEvents Panel_AdminParent As Panel
End Class
