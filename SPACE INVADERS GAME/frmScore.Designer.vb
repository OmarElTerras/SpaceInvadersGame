<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScore))
        Me.dgvScore = New System.Windows.Forms.DataGridView()
        Me.butRate = New System.Windows.Forms.Button()
        Me.butWouldYou = New System.Windows.Forms.Button()
        Me.lstRating = New System.Windows.Forms.ListBox()
        Me.hsbRating = New System.Windows.Forms.HScrollBar()
        Me.lblRating1 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.butEnd = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvScore
        '
        Me.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScore.Location = New System.Drawing.Point(56, 43)
        Me.dgvScore.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvScore.Name = "dgvScore"
        Me.dgvScore.Size = New System.Drawing.Size(360, 329)
        Me.dgvScore.TabIndex = 0
        '
        'butRate
        '
        Me.butRate.Location = New System.Drawing.Point(469, 331)
        Me.butRate.Margin = New System.Windows.Forms.Padding(4)
        Me.butRate.Name = "butRate"
        Me.butRate.Size = New System.Drawing.Size(327, 41)
        Me.butRate.TabIndex = 1
        Me.butRate.Text = "Rate"
        Me.butRate.UseVisualStyleBackColor = True
        Me.butRate.Visible = False
        '
        'butWouldYou
        '
        Me.butWouldYou.Location = New System.Drawing.Point(469, 43)
        Me.butWouldYou.Margin = New System.Windows.Forms.Padding(4)
        Me.butWouldYou.Name = "butWouldYou"
        Me.butWouldYou.Size = New System.Drawing.Size(328, 329)
        Me.butWouldYou.TabIndex = 2
        Me.butWouldYou.Text = "Would you like to rate this game?"
        Me.butWouldYou.UseVisualStyleBackColor = True
        '
        'lstRating
        '
        Me.lstRating.FormattingEnabled = True
        Me.lstRating.ItemHeight = 16
        Me.lstRating.Location = New System.Drawing.Point(471, 180)
        Me.lstRating.Margin = New System.Windows.Forms.Padding(4)
        Me.lstRating.Name = "lstRating"
        Me.lstRating.Size = New System.Drawing.Size(324, 132)
        Me.lstRating.TabIndex = 4
        Me.lstRating.Visible = False
        '
        'hsbRating
        '
        Me.hsbRating.Location = New System.Drawing.Point(469, 43)
        Me.hsbRating.Maximum = 109
        Me.hsbRating.Name = "hsbRating"
        Me.hsbRating.Size = New System.Drawing.Size(327, 24)
        Me.hsbRating.TabIndex = 1
        Me.hsbRating.Visible = False
        '
        'lblRating1
        '
        Me.lblRating1.AutoSize = True
        Me.lblRating1.Location = New System.Drawing.Point(487, 84)
        Me.lblRating1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRating1.Name = "lblRating1"
        Me.lblRating1.Size = New System.Drawing.Size(16, 17)
        Me.lblRating1.TabIndex = 5
        Me.lblRating1.Text = "1"
        Me.lblRating1.Visible = False
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(749, 84)
        Me.lbl10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(24, 17)
        Me.lbl10.TabIndex = 6
        Me.lbl10.Text = "10"
        Me.lbl10.Visible = False
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(471, 133)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(325, 22)
        Me.txtComment.TabIndex = 7
        Me.txtComment.Text = "Rate this game!"
        Me.txtComment.Visible = False
        '
        'butEnd
        '
        Me.butEnd.Location = New System.Drawing.Point(362, 392)
        Me.butEnd.Name = "butEnd"
        Me.butEnd.Size = New System.Drawing.Size(140, 25)
        Me.butEnd.TabIndex = 8
        Me.butEnd.Text = "End Game"
        Me.butEnd.UseVisualStyleBackColor = True
        '
        'frmScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 432)
        Me.Controls.Add(Me.butEnd)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lblRating1)
        Me.Controls.Add(Me.hsbRating)
        Me.Controls.Add(Me.lstRating)
        Me.Controls.Add(Me.butWouldYou)
        Me.Controls.Add(Me.butRate)
        Me.Controls.Add(Me.dgvScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmScore"
        Me.Text = "Score"
        CType(Me.dgvScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvScore As System.Windows.Forms.DataGridView
    Friend WithEvents butRate As System.Windows.Forms.Button
    Friend WithEvents butWouldYou As System.Windows.Forms.Button
    Friend WithEvents lstRating As System.Windows.Forms.ListBox
    Friend WithEvents hsbRating As System.Windows.Forms.HScrollBar
    Friend WithEvents lblRating1 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents butEnd As System.Windows.Forms.Button
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
End Class
