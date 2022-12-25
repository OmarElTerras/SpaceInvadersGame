<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCredits))
        Me.tmrMoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.dlgColour = New System.Windows.Forms.ColorDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.butMnu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrMoveUp
        '
        Me.tmrMoveUp.Enabled = True
        '
        'lblCredits
        '
        Me.lblCredits.BackColor = System.Drawing.Color.Transparent
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.ForeColor = System.Drawing.Color.White
        Me.lblCredits.Location = New System.Drawing.Point(28, 598)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(806, 637)
        Me.lblCredits.TabIndex = 15
        Me.lblCredits.Text = "SPACE INVADERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLASS : ISC 3U1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TEACHER : MR. WALDON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROGRAMMER : OMAR EL" & _
            " TERRAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIRECTOR : OMAR EL TERRAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXECUTIVE DIRECTOR : OMAR EL TERRAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & _
            "VERYTHING ELSE : OMAR EL TERRAS"
        Me.lblCredits.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'butMnu
        '
        Me.butMnu.BackColor = System.Drawing.Color.MidnightBlue
        Me.butMnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butMnu.ForeColor = System.Drawing.Color.Cornsilk
        Me.butMnu.Location = New System.Drawing.Point(624, 25)
        Me.butMnu.Margin = New System.Windows.Forms.Padding(4)
        Me.butMnu.Name = "butMnu"
        Me.butMnu.Size = New System.Drawing.Size(259, 149)
        Me.butMnu.TabIndex = 16
        Me.butMnu.Text = "MAIN MENU"
        Me.butMnu.UseVisualStyleBackColor = False
        '
        'frmCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(896, 655)
        Me.Controls.Add(Me.butMnu)
        Me.Controls.Add(Me.lblCredits)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCredits"
        Me.Text = "CREDITS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrMoveUp As System.Windows.Forms.Timer
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents dlgColour As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents butMnu As System.Windows.Forms.Button
End Class
