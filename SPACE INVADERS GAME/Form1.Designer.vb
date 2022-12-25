<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceInvaders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpaceInvaders))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.butStart = New System.Windows.Forms.Button()
        Me.butQuit = New System.Windows.Forms.Button()
        Me.ttpButtons = New System.Windows.Forms.ToolTip(Me.components)
        Me.butCredit = New System.Windows.Forms.Button()
        Me.tmrFlicker = New System.Windows.Forms.Timer(Me.components)
        Me.psbLoad = New System.Windows.Forms.ProgressBar()
        Me.tmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(52, 46)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(952, 217)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "SPACE INVADERS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'butStart
        '
        Me.butStart.BackColor = System.Drawing.Color.MidnightBlue
        Me.butStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butStart.ForeColor = System.Drawing.Color.Cornsilk
        Me.butStart.Location = New System.Drawing.Point(69, 502)
        Me.butStart.Margin = New System.Windows.Forms.Padding(4)
        Me.butStart.Name = "butStart"
        Me.butStart.Size = New System.Drawing.Size(304, 155)
        Me.butStart.TabIndex = 9
        Me.butStart.Text = "START GAME"
        Me.ttpButtons.SetToolTip(Me.butStart, "Click to Begin the Game")
        Me.butStart.UseVisualStyleBackColor = False
        '
        'butQuit
        '
        Me.butQuit.BackColor = System.Drawing.Color.Indigo
        Me.butQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butQuit.ForeColor = System.Drawing.Color.Cornsilk
        Me.butQuit.Location = New System.Drawing.Point(713, 502)
        Me.butQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.butQuit.Name = "butQuit"
        Me.butQuit.Size = New System.Drawing.Size(316, 155)
        Me.butQuit.TabIndex = 10
        Me.butQuit.Text = "QUIT GAME"
        Me.ttpButtons.SetToolTip(Me.butQuit, "Click to Exit the Game")
        Me.butQuit.UseVisualStyleBackColor = False
        '
        'butCredit
        '
        Me.butCredit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.butCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCredit.ForeColor = System.Drawing.Color.Cornsilk
        Me.butCredit.Location = New System.Drawing.Point(397, 502)
        Me.butCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.butCredit.Name = "butCredit"
        Me.butCredit.Size = New System.Drawing.Size(308, 155)
        Me.butCredit.TabIndex = 12
        Me.butCredit.Text = "CREDITS"
        Me.ttpButtons.SetToolTip(Me.butCredit, "Click to see the creator")
        Me.butCredit.UseVisualStyleBackColor = False
        '
        'tmrFlicker
        '
        Me.tmrFlicker.Enabled = True
        Me.tmrFlicker.Interval = 300
        '
        'psbLoad
        '
        Me.psbLoad.Location = New System.Drawing.Point(142, 241)
        Me.psbLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.psbLoad.Name = "psbLoad"
        Me.psbLoad.Size = New System.Drawing.Size(797, 63)
        Me.psbLoad.TabIndex = 11
        Me.psbLoad.Visible = False
        '
        'tmrProgress
        '
        Me.tmrProgress.Interval = 75
        '
        'frmSpaceInvaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SPACE_INVADERS_GAME.My.Resources.Resources.BackGround_Space
        Me.ClientSize = New System.Drawing.Size(1081, 709)
        Me.Controls.Add(Me.butCredit)
        Me.Controls.Add(Me.psbLoad)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.butStart)
        Me.Controls.Add(Me.butQuit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSpaceInvaders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPACE INVADERS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents butStart As System.Windows.Forms.Button
    Friend WithEvents butQuit As System.Windows.Forms.Button
    Friend WithEvents ttpButtons As System.Windows.Forms.ToolTip
    Friend WithEvents tmrFlicker As System.Windows.Forms.Timer
    Friend WithEvents psbLoad As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrProgress As System.Windows.Forms.Timer
    Friend WithEvents butCredit As System.Windows.Forms.Button

End Class
