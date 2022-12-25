<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel))
        Me.mnuLevel = New System.Windows.Forms.MenuStrip()
        Me.cboDifficulty = New System.Windows.Forms.ToolStripComboBox()
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtU = New System.Windows.Forms.ToolStripTextBox()
        Me.butStart2 = New System.Windows.Forms.Button()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.dlgColour = New System.Windows.Forms.ColorDialog()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.ttpProperties = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkShip = New System.Windows.Forms.CheckBox()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.gpbShip = New System.Windows.Forms.GroupBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.cboBackcolour = New System.Windows.Forms.ComboBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.mnuLevel.SuspendLayout()
        Me.gpbShip.SuspendLayout()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuLevel
        '
        Me.mnuLevel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.mnuLevel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cboDifficulty, Me.tss1, Me.tsmCustomize, Me.tss2, Me.txtU})
        Me.mnuLevel.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevel.Name = "mnuLevel"
        Me.mnuLevel.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuLevel.Size = New System.Drawing.Size(873, 49)
        Me.mnuLevel.TabIndex = 0
        Me.mnuLevel.Text = "MenuStrip1"
        '
        'cboDifficulty
        '
        Me.cboDifficulty.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.cboDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cboDifficulty.Name = "cboDifficulty"
        Me.cboDifficulty.Size = New System.Drawing.Size(160, 45)
        Me.cboDifficulty.Text = "Difficulty"
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(6, 45)
        '
        'tsmCustomize
        '
        Me.tsmCustomize.Checked = True
        Me.tsmCustomize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmCustomize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmMenu})
        Me.tsmCustomize.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.tsmCustomize.Name = "tsmCustomize"
        Me.tsmCustomize.Size = New System.Drawing.Size(153, 45)
        Me.tsmCustomize.Text = "Customize"
        '
        'tsmMenu
        '
        Me.tsmMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBackground, Me.tsmScore})
        Me.tsmMenu.Name = "tsmMenu"
        Me.tsmMenu.Size = New System.Drawing.Size(174, 42)
        Me.tsmMenu.Text = "Colour"
        '
        'tsmBackground
        '
        Me.tsmBackground.Name = "tsmBackground"
        Me.tsmBackground.Size = New System.Drawing.Size(308, 42)
        Me.tsmBackground.Text = "Background"
        '
        'tsmScore
        '
        Me.tsmScore.Name = "tsmScore"
        Me.tsmScore.Size = New System.Drawing.Size(308, 42)
        Me.tsmScore.Text = "Scoreboard Name"
        '
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(6, 45)
        '
        'txtU
        '
        Me.txtU.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txtU.Name = "txtU"
        Me.txtU.Size = New System.Drawing.Size(185, 45)
        Me.txtU.Text = "Enter Name:"
        Me.txtU.ToolTipText = "Double Click to change the Font"
        '
        'butStart2
        '
        Me.butStart2.BackColor = System.Drawing.Color.MidnightBlue
        Me.butStart2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butStart2.ForeColor = System.Drawing.Color.White
        Me.butStart2.Location = New System.Drawing.Point(39, 357)
        Me.butStart2.Margin = New System.Windows.Forms.Padding(4)
        Me.butStart2.Name = "butStart2"
        Me.butStart2.Size = New System.Drawing.Size(796, 84)
        Me.butStart2.TabIndex = 10
        Me.butStart2.Text = "START GAME"
        Me.butStart2.UseVisualStyleBackColor = False
        Me.butStart2.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblInstructions.Location = New System.Drawing.Point(332, 479)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(0, 29)
        Me.lblInstructions.TabIndex = 12
        '
        'chkShip
        '
        Me.chkShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShip.ForeColor = System.Drawing.Color.White
        Me.chkShip.Location = New System.Drawing.Point(28, 50)
        Me.chkShip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShip.Name = "chkShip"
        Me.chkShip.Size = New System.Drawing.Size(275, 121)
        Me.chkShip.TabIndex = 0
        Me.chkShip.Text = "Would you like to change the Ship?"
        Me.chkShip.UseVisualStyleBackColor = True
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName2.ForeColor = System.Drawing.Color.Black
        Me.lblName2.Location = New System.Drawing.Point(571, 11)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(0, 17)
        Me.lblName2.TabIndex = 47
        '
        'gpbShip
        '
        Me.gpbShip.Controls.Add(Me.pic3)
        Me.gpbShip.Controls.Add(Me.pic2)
        Me.gpbShip.Controls.Add(Me.pic1)
        Me.gpbShip.Controls.Add(Me.rad3)
        Me.gpbShip.Controls.Add(Me.rad2)
        Me.gpbShip.Controls.Add(Me.rad1)
        Me.gpbShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbShip.ForeColor = System.Drawing.Color.White
        Me.gpbShip.Location = New System.Drawing.Point(39, 167)
        Me.gpbShip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpbShip.Name = "gpbShip"
        Me.gpbShip.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpbShip.Size = New System.Drawing.Size(796, 156)
        Me.gpbShip.TabIndex = 14
        Me.gpbShip.TabStop = False
        Me.gpbShip.Text = "Ship"
        Me.gpbShip.Visible = False
        '
        'pic3
        '
        Me.pic3.Image = Global.SPACE_INVADERS_GAME.My.Resources.Resources.ship3
        Me.pic3.Location = New System.Drawing.Point(651, 47)
        Me.pic3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(67, 69)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 6
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = Global.SPACE_INVADERS_GAME.My.Resources.Resources.ship_2
        Me.pic2.Location = New System.Drawing.Point(337, 47)
        Me.pic2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(67, 73)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 5
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.SPACE_INVADERS_GAME.My.Resources.Resources.ship
        Me.pic1.Location = New System.Drawing.Point(72, 47)
        Me.pic1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(67, 71)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 4
        Me.pic1.TabStop = False
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.ForeColor = System.Drawing.Color.Purple
        Me.rad3.Location = New System.Drawing.Point(608, 70)
        Me.rad3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(17, 16)
        Me.rad3.TabIndex = 3
        Me.rad3.TabStop = True
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.ForeColor = System.Drawing.Color.Blue
        Me.rad2.Location = New System.Drawing.Point(295, 78)
        Me.rad2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(17, 16)
        Me.rad2.TabIndex = 2
        Me.rad2.TabStop = True
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.ForeColor = System.Drawing.Color.Red
        Me.rad1.Location = New System.Drawing.Point(29, 76)
        Me.rad1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(17, 16)
        Me.rad1.TabIndex = 1
        Me.rad1.TabStop = True
        Me.rad1.UseVisualStyleBackColor = True
        '
        'cboBackcolour
        '
        Me.cboBackcolour.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboBackcolour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBackcolour.FormattingEnabled = True
        Me.cboBackcolour.Items.AddRange(New Object() {"Red", "Blue", "Purple", "GO CRAZY???"})
        Me.cboBackcolour.Location = New System.Drawing.Point(352, 84)
        Me.cboBackcolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBackcolour.Name = "cboBackcolour"
        Me.cboBackcolour.Size = New System.Drawing.Size(456, 46)
        Me.cboBackcolour.TabIndex = 52
        Me.cboBackcolour.Text = "Background Colour"
        Me.cboBackcolour.Visible = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 49)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 432)
        Me.Splitter1.TabIndex = 53
        Me.Splitter1.TabStop = False
        '
        'frmLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(873, 481)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.cboBackcolour)
        Me.Controls.Add(Me.gpbShip)
        Me.Controls.Add(Me.chkShip)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.butStart2)
        Me.Controls.Add(Me.mnuLevel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLevel
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level"
        Me.mnuLevel.ResumeLayout(False)
        Me.mnuLevel.PerformLayout()
        Me.gpbShip.ResumeLayout(False)
        Me.gpbShip.PerformLayout()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuLevel As System.Windows.Forms.MenuStrip
    Friend WithEvents cboDifficulty As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtU As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsmCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butStart2 As System.Windows.Forms.Button
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents dlgColour As System.Windows.Forms.ColorDialog
    Friend WithEvents tsmMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmBackground As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttpProperties As System.Windows.Forms.ToolTip
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents chkShip As System.Windows.Forms.CheckBox
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents gpbShip As System.Windows.Forms.GroupBox
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboBackcolour As System.Windows.Forms.ComboBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
End Class
