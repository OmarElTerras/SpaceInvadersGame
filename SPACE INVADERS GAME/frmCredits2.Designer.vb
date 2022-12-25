<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredits2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCredits2))
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.dlgC = New System.Windows.Forms.ColorDialog()
        Me.dlgF = New System.Windows.Forms.FontDialog()
        Me.butReturn = New System.Windows.Forms.Button()
        Me.ttpControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.numSpeed = New System.Windows.Forms.NumericUpDown()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrUp
        '
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Location = New System.Drawing.Point(448, 511)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(308, 272)
        Me.lblCredits.TabIndex = 0
        Me.lblCredits.Text = resources.GetString("lblCredits.Text")
        Me.lblCredits.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ttpControls.SetToolTip(Me.lblCredits, "Click to change font")
        '
        'butReturn
        '
        Me.butReturn.Location = New System.Drawing.Point(12, 12)
        Me.butReturn.Name = "butReturn"
        Me.butReturn.Size = New System.Drawing.Size(63, 49)
        Me.butReturn.TabIndex = 1
        Me.butReturn.Text = "Return Home"
        Me.butReturn.UseVisualStyleBackColor = True
        '
        'numSpeed
        '
        Me.numSpeed.Location = New System.Drawing.Point(12, 77)
        Me.numSpeed.Name = "numSpeed"
        Me.numSpeed.Size = New System.Drawing.Size(63, 22)
        Me.numSpeed.TabIndex = 2
        '
        'frmCredits2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 422)
        Me.Controls.Add(Me.numSpeed)
        Me.Controls.Add(Me.butReturn)
        Me.Controls.Add(Me.lblCredits)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCredits2"
        Me.Text = "Credits"
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents dlgC As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgF As System.Windows.Forms.FontDialog
    Friend WithEvents butReturn As System.Windows.Forms.Button
    Friend WithEvents ttpControls As System.Windows.Forms.ToolTip
    Friend WithEvents numSpeed As System.Windows.Forms.NumericUpDown
End Class
