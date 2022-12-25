<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsername
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsername))
        Me.butEnter = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.rtbUsername = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'butEnter
        '
        Me.butEnter.BackColor = System.Drawing.Color.MidnightBlue
        Me.butEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEnter.ForeColor = System.Drawing.Color.White
        Me.butEnter.Location = New System.Drawing.Point(453, 20)
        Me.butEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.butEnter.Name = "butEnter"
        Me.butEnter.Size = New System.Drawing.Size(244, 75)
        Me.butEnter.TabIndex = 5
        Me.butEnter.Text = "Enter"
        Me.butEnter.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(40, 37)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(405, 58)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Enter your username :"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtbUsername
        '
        Me.rtbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbUsername.Location = New System.Drawing.Point(48, 127)
        Me.rtbUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbUsername.Name = "rtbUsername"
        Me.rtbUsername.Size = New System.Drawing.Size(648, 64)
        Me.rtbUsername.TabIndex = 3
        Me.rtbUsername.Text = ""
        '
        'frmUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(760, 233)
        Me.Controls.Add(Me.butEnter)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.rtbUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Username"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butEnter As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents rtbUsername As System.Windows.Forms.RichTextBox
End Class
