<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviousAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviousAccount))
        Me.butEnter2 = New System.Windows.Forms.Button()
        Me.lblUsername2 = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'butEnter2
        '
        Me.butEnter2.BackColor = System.Drawing.Color.MidnightBlue
        Me.butEnter2.Enabled = False
        Me.butEnter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEnter2.ForeColor = System.Drawing.Color.White
        Me.butEnter2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butEnter2.Location = New System.Drawing.Point(333, 15)
        Me.butEnter2.Name = "butEnter2"
        Me.butEnter2.Size = New System.Drawing.Size(183, 61)
        Me.butEnter2.TabIndex = 8
        Me.butEnter2.Text = "Enter"
        Me.butEnter2.UseVisualStyleBackColor = False
        '
        'lblUsername2
        '
        Me.lblUsername2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblUsername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername2.ForeColor = System.Drawing.Color.White
        Me.lblUsername2.Location = New System.Drawing.Point(23, 29)
        Me.lblUsername2.Name = "lblUsername2"
        Me.lblUsername2.Size = New System.Drawing.Size(304, 47)
        Me.lblUsername2.TabIndex = 7
        Me.lblUsername2.Text = "Select your username :"
        Me.lblUsername2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstNames
        '
        Me.lstNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 25
        Me.lstNames.Items.AddRange(New Object() {"Omar", "Ali", "Nader", "Bara", "Saliba", "Raghd", "Mr.Waldon"})
        Me.lstNames.Location = New System.Drawing.Point(28, 98)
        Me.lstNames.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(488, 229)
        Me.lstNames.TabIndex = 9
        '
        'frmPreviousAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(545, 379)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.butEnter2)
        Me.Controls.Add(Me.lblUsername2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreviousAccount"
        Me.Text = "Space Invaders"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butEnter2 As System.Windows.Forms.Button
    Friend WithEvents lblUsername2 As System.Windows.Forms.Label
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
End Class
