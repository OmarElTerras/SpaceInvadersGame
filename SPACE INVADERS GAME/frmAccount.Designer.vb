<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
        Me.lblPreviousAccount = New System.Windows.Forms.Label()
        Me.butNo = New System.Windows.Forms.Button()
        Me.butYes = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPreviousAccount
        '
        Me.lblPreviousAccount.BackColor = System.Drawing.Color.Black
        Me.lblPreviousAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPreviousAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousAccount.ForeColor = System.Drawing.Color.White
        Me.lblPreviousAccount.Location = New System.Drawing.Point(33, 38)
        Me.lblPreviousAccount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviousAccount.Name = "lblPreviousAccount"
        Me.lblPreviousAccount.Size = New System.Drawing.Size(367, 97)
        Me.lblPreviousAccount.TabIndex = 2
        Me.lblPreviousAccount.Text = "Do you have an exisiting account :"
        Me.lblPreviousAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'butNo
        '
        Me.butNo.BackColor = System.Drawing.Color.MidnightBlue
        Me.butNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butNo.ForeColor = System.Drawing.Color.White
        Me.butNo.Location = New System.Drawing.Point(599, 38)
        Me.butNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butNo.Name = "butNo"
        Me.butNo.Size = New System.Drawing.Size(175, 75)
        Me.butNo.TabIndex = 6
        Me.butNo.Text = "No"
        Me.butNo.UseVisualStyleBackColor = False
        '
        'butYes
        '
        Me.butYes.BackColor = System.Drawing.Color.MidnightBlue
        Me.butYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butYes.ForeColor = System.Drawing.Color.White
        Me.butYes.Location = New System.Drawing.Point(408, 38)
        Me.butYes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butYes.Name = "butYes"
        Me.butYes.Size = New System.Drawing.Size(183, 75)
        Me.butYes.TabIndex = 7
        Me.butYes.Text = "Yes"
        Me.butYes.UseVisualStyleBackColor = False
        '
        'lblHint
        '
        Me.lblHint.BackColor = System.Drawing.Color.Black
        Me.lblHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.White
        Me.lblHint.Location = New System.Drawing.Point(58, 157)
        Me.lblHint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(739, 48)
        Me.lblHint.TabIndex = 8
        Me.lblHint.Text = "*You have a premade account if you are in the ISC class"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(833, 236)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.butYes)
        Me.Controls.Add(Me.butNo)
        Me.Controls.Add(Me.lblPreviousAccount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPreviousAccount As System.Windows.Forms.Label
    Friend WithEvents butNo As System.Windows.Forms.Button
    Friend WithEvents butYes As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
End Class
