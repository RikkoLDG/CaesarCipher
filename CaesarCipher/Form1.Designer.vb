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
        Me.components = New System.ComponentModel.Container()
        Me.outtxt = New System.Windows.Forms.RichTextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.cmbpilih = New System.Windows.Forms.ComboBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.lblpilihan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CoopName = New System.Windows.Forms.Label()
        Me.outputlbl = New System.Windows.Forms.Label()
        Me.inputlbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KELUARAPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblkey = New System.Windows.Forms.Label()
        Me.keytxt = New System.Windows.Forms.TextBox()
        Me.TITLELBL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.notif = New System.Windows.Forms.Label()
        Me.intxt = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gmbrnotif = New System.Windows.Forms.PictureBox()
        Me.minime = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gmbrnotif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outtxt
        '
        Me.outtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outtxt.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outtxt.Location = New System.Drawing.Point(12, 328)
        Me.outtxt.Name = "outtxt"
        Me.outtxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.outtxt.Size = New System.Drawing.Size(399, 123)
        Me.outtxt.TabIndex = 1
        Me.outtxt.Text = ""
        '
        'btnproses
        '
        Me.btnproses.BackColor = System.Drawing.Color.White
        Me.btnproses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproses.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnproses.ForeColor = System.Drawing.Color.Black
        Me.btnproses.Location = New System.Drawing.Point(11, 457)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(192, 40)
        Me.btnproses.TabIndex = 2
        Me.btnproses.Text = "button"
        Me.btnproses.UseVisualStyleBackColor = False
        '
        'cmbpilih
        '
        Me.cmbpilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpilih.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpilih.FormattingEnabled = True
        Me.cmbpilih.Location = New System.Drawing.Point(211, 295)
        Me.cmbpilih.Name = "cmbpilih"
        Me.cmbpilih.Size = New System.Drawing.Size(200, 25)
        Me.cmbpilih.TabIndex = 4
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.Location = New System.Drawing.Point(211, 457)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(201, 40)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'lblpilihan
        '
        Me.lblpilihan.AutoSize = True
        Me.lblpilihan.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lblpilihan.ForeColor = System.Drawing.Color.White
        Me.lblpilihan.Location = New System.Drawing.Point(137, 296)
        Me.lblpilihan.Name = "lblpilihan"
        Me.lblpilihan.Size = New System.Drawing.Size(66, 21)
        Me.lblpilihan.TabIndex = 6
        Me.lblpilihan.Text = "PILIHAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CoopName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 503)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 20)
        Me.Panel1.TabIndex = 7
        '
        'CoopName
        '
        Me.CoopName.AutoSize = True
        Me.CoopName.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.CoopName.ForeColor = System.Drawing.Color.White
        Me.CoopName.Location = New System.Drawing.Point(290, 3)
        Me.CoopName.Name = "CoopName"
        Me.CoopName.Size = New System.Drawing.Size(129, 15)
        Me.CoopName.TabIndex = 18
        Me.CoopName.Text = "LondongSoftware - 2018"
        '
        'outputlbl
        '
        Me.outputlbl.AutoSize = True
        Me.outputlbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputlbl.ForeColor = System.Drawing.Color.White
        Me.outputlbl.Location = New System.Drawing.Point(8, 296)
        Me.outputlbl.Name = "outputlbl"
        Me.outputlbl.Size = New System.Drawing.Size(42, 21)
        Me.outputlbl.TabIndex = 8
        Me.outputlbl.Text = "TEKS"
        '
        'inputlbl
        '
        Me.inputlbl.AutoSize = True
        Me.inputlbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputlbl.ForeColor = System.Drawing.Color.White
        Me.inputlbl.Location = New System.Drawing.Point(8, 134)
        Me.inputlbl.Name = "inputlbl"
        Me.inputlbl.Size = New System.Drawing.Size(42, 21)
        Me.inputlbl.TabIndex = 9
        Me.inputlbl.Text = "TEKS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.KELUARAPPToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.FileToolStripMenuItem.Text = "MENU"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NewToolStripMenuItem.Text = "FILE BARU"
        Me.NewToolStripMenuItem.ToolTipText = "Buat Proses Baru"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.OpenToolStripMenuItem.Text = "BUKA"
        Me.OpenToolStripMenuItem.ToolTipText = "Membuka File Teks"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'KELUARAPPToolStripMenuItem
        '
        Me.KELUARAPPToolStripMenuItem.Name = "KELUARAPPToolStripMenuItem"
        Me.KELUARAPPToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.KELUARAPPToolStripMenuItem.Text = "KELUAR APP"
        Me.KELUARAPPToolStripMenuItem.ToolTipText = "Keluar dan Tutup Aplikasi"
        '
        'lblkey
        '
        Me.lblkey.AutoSize = True
        Me.lblkey.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lblkey.ForeColor = System.Drawing.Color.White
        Me.lblkey.Location = New System.Drawing.Point(333, 134)
        Me.lblkey.Name = "lblkey"
        Me.lblkey.Size = New System.Drawing.Size(41, 21)
        Me.lblkey.TabIndex = 11
        Me.lblkey.Text = "*KEY"
        '
        'keytxt
        '
        Me.keytxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.keytxt.Location = New System.Drawing.Point(376, 132)
        Me.keytxt.MaxLength = 2
        Me.keytxt.Name = "keytxt"
        Me.keytxt.Size = New System.Drawing.Size(35, 25)
        Me.keytxt.TabIndex = 12
        '
        'TITLELBL
        '
        Me.TITLELBL.AutoSize = True
        Me.TITLELBL.BackColor = System.Drawing.Color.Transparent
        Me.TITLELBL.Font = New System.Drawing.Font("SAO UI", 32.0!)
        Me.TITLELBL.ForeColor = System.Drawing.Color.SpringGreen
        Me.TITLELBL.Location = New System.Drawing.Point(28, 50)
        Me.TITLELBL.Name = "TITLELBL"
        Me.TITLELBL.Size = New System.Drawing.Size(372, 52)
        Me.TITLELBL.TabIndex = 13
        Me.TITLELBL.Text = "Kriptografi Caesar Cipher"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 29)
        Me.ProgressBar1.Maximum = 200
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(656, 2)
        Me.ProgressBar1.TabIndex = 0
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif.ForeColor = System.Drawing.Color.White
        Me.notif.Location = New System.Drawing.Point(369, 140)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(39, 21)
        Me.notif.TabIndex = 16
        Me.notif.Text = "notif"
        Me.notif.Visible = False
        '
        'intxt
        '
        Me.intxt.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intxt.Location = New System.Drawing.Point(12, 164)
        Me.intxt.Name = "intxt"
        Me.intxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.intxt.Size = New System.Drawing.Size(399, 123)
        Me.intxt.TabIndex = 0
        Me.intxt.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox1.Image = Global.CaesarCipher.My.Resources.Resources.key1
        Me.PictureBox1.Location = New System.Drawing.Point(392, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'gmbrnotif
        '
        Me.gmbrnotif.BackColor = System.Drawing.Color.Gray
        Me.gmbrnotif.Image = Global.CaesarCipher.My.Resources.Resources.warning_triangle
        Me.gmbrnotif.Location = New System.Drawing.Point(178, 470)
        Me.gmbrnotif.Name = "gmbrnotif"
        Me.gmbrnotif.Size = New System.Drawing.Size(16, 16)
        Me.gmbrnotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gmbrnotif.TabIndex = 15
        Me.gmbrnotif.TabStop = False
        '
        'minime
        '
        Me.minime.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.minime.Image = Global.CaesarCipher.My.Resources.Resources.Expand_Arrow_2
        Me.minime.Location = New System.Drawing.Point(362, -1)
        Me.minime.Name = "minime"
        Me.minime.Size = New System.Drawing.Size(31, 29)
        Me.minime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minime.TabIndex = 17
        Me.minime.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.minime)
        Me.Controls.Add(Me.keytxt)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TITLELBL)
        Me.Controls.Add(Me.lblkey)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.inputlbl)
        Me.Controls.Add(Me.outputlbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblpilihan)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.cmbpilih)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.outtxt)
        Me.Controls.Add(Me.intxt)
        Me.Controls.Add(Me.gmbrnotif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kriptografi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gmbrnotif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outtxt As System.Windows.Forms.RichTextBox
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents cmbpilih As System.Windows.Forms.ComboBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents lblpilihan As System.Windows.Forms.Label
    Friend WithEvents outputlbl As System.Windows.Forms.Label
    Friend WithEvents inputlbl As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblkey As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KELUARAPPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keytxt As System.Windows.Forms.TextBox
    Friend WithEvents TITLELBL As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gmbrnotif As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents CoopName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents intxt As System.Windows.Forms.RichTextBox
    Friend WithEvents minime As System.Windows.Forms.PictureBox

End Class
