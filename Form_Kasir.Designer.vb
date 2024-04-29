<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Kasir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_KasirParent = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Kasir_Logout = New System.Windows.Forms.Button()
        Me.Label_Kasir = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 66)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "KELOLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSAKSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_KasirParent
        '
        Me.Panel_KasirParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_KasirParent.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KasirParent.Name = "Panel_KasirParent"
        Me.Panel_KasirParent.Size = New System.Drawing.Size(635, 522)
        Me.Panel_KasirParent.TabIndex = 0
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_KasirParent)
        Me.SplitContainer1.Size = New System.Drawing.Size(873, 522)
        Me.SplitContainer1.SplitterDistance = 234
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button_Kasir_Logout)
        Me.Panel1.Controls.Add(Me.Label_Kasir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 522)
        Me.Panel1.TabIndex = 0
        '
        'Button_Kasir_Logout
        '
        Me.Button_Kasir_Logout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Kasir_Logout.BackColor = System.Drawing.Color.LightCoral
        Me.Button_Kasir_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Kasir_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Kasir_Logout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Kasir_Logout.Location = New System.Drawing.Point(28, 380)
        Me.Button_Kasir_Logout.Name = "Button_Kasir_Logout"
        Me.Button_Kasir_Logout.Size = New System.Drawing.Size(179, 32)
        Me.Button_Kasir_Logout.TabIndex = 2
        Me.Button_Kasir_Logout.Text = "Logout"
        Me.Button_Kasir_Logout.UseVisualStyleBackColor = False
        '
        'Label_Kasir
        '
        Me.Label_Kasir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Kasir.AutoSize = True
        Me.Label_Kasir.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Kasir.Location = New System.Drawing.Point(66, 20)
        Me.Label_Kasir.Name = "Label_Kasir"
        Me.Label_Kasir.Size = New System.Drawing.Size(102, 33)
        Me.Label_Kasir.TabIndex = 1
        Me.Label_Kasir.Text = "KASIR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.FoodXYZ_BalikLagi.My.Resources.Resources.Logo_Kasir
        Me.PictureBox1.Location = New System.Drawing.Point(42, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(889, 561)
        Me.Name = "Form_Kasir"
        Me.Text = "Food XYZ | Form Kasir"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_KasirParent As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Kasir_Logout As Button
    Friend WithEvents Label_Kasir As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
