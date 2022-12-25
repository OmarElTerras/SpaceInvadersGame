Public Class frmLevel

    Public Sub butStart2_Click(sender As System.Object, e As System.EventArgs) Handles butStart2.Click
        ' this starts the game
        Me.Hide()
        MsgBox("Good Luck!")
        frmGamePlay.Show()
    End Sub

    Private Sub txtU_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtU.DoubleClick
        ' this shows the dialog box
        dlgFont.ShowDialog()
        lblName2.Font = dlgFont.Font
    End Sub

    Public Sub txtU_TextChanged(sender As Object, e As System.EventArgs) Handles txtU.TextChanged
        ' the textchanged event that makes the label equal to the textbox
        lblName2.Text = txtU.Text
    End Sub

    Private Sub cboDifficulty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDifficulty.Click
        ' changes the speed depending on the difficulty selected
        butStart2.Visible = True
        If cboDifficulty.SelectedIndex = 1 Then
            frmGamePlay.tmrMove.Interval = 100
        ElseIf cboDifficulty.SelectedIndex = 2 Then
            frmGamePlay.tmrMove.Interval = 50
        ElseIf cboDifficulty.SelectedIndex = 3 Then
            frmGamePlay.tmrMove.Interval = 10
        End If
    End Sub

    Private Sub chkBackColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShip.Click
        'shows the groupbox
        gpbShip.Show()
    End Sub

    Private Sub lblName2_DoubleClick1(sender As Object, e As System.EventArgs) Handles lblName2.DoubleClick
        'shows colour diaglog and changes the colour of the name label
        dlgColour.ShowDialog()
        lblName2.ForeColor = dlgColour.Color
    End Sub

    Private Sub ShipSpeedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmBackground.Click
        'shows the backround colour combo box
        tsmBackground.Checked = True
        cboBackcolour.Show()
    End Sub

    Private Sub txtU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtU.Click
        'clears text box
        txtU.Text = ""
    End Sub

    Private Sub ShotSpeedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmScore.Click
        'sends message for instructions
        tsmScore.Checked = True
        MsgBox("To change the font colour on the game form, double click your name label. Also, double click text box to change font.")
    End Sub

    Private Sub frmLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' centers form
        Centre(Me)
        lblName2.Text = "<< Type Name - Your Name will appear hear"
    End Sub

    Private Sub gpbShip_GotFocus(sender As Object, e As System.EventArgs) Handles gpbShip.GotFocus
        chkShip.Visible = False
    End Sub

    Private Sub frmLevel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Size = New Size(670, 430)
    End Sub

    Private Sub cboDifficulty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDifficulty.GotFocus
        ' if the control has focus then its red and font is white 
        cboDifficulty.BackColor = Color.Red
        cboDifficulty.ForeColor = Color.White
    End Sub

    Private Sub cboDifficulty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDifficulty.LostFocus
        ' if the control has lost focus then its blue
        cboDifficulty.BackColor = Color.Blue
    End Sub

    Private Sub txtU_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtU.GotFocus
        ' if the control has focus then its red and font is white 
        txtU.BackColor = Color.Red
        txtU.ForeColor = Color.White
    End Sub

    Private Sub txtU_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtU.LostFocus
        ' if the control has lost focus then its blue
        txtU.BackColor = Color.Blue
    End Sub
End Class