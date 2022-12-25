Public Class frmSpaceInvaders
    
    Public Sub tmrFlicker_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFlicker.Tick
        If lblTitle.Visible Then
            lblTitle.Visible = False
        Else
            lblTitle.Visible = True
        End If

    End Sub

    Public Sub butStart_Click(sender As System.Object, e As System.EventArgs) Handles butStart.Click
        ' when the start button is clickes the timer for the progress bar begins and the flickering title stops
        tmrProgress.Start()
        psbLoad.Visible = True
        tmrFlicker.Stop()
        lblTitle.Visible = True
    End Sub

    Public Sub butQuit_Click(sender As System.Object, e As System.EventArgs) Handles butQuit.Click
        ' this closes the program
        Me.Close()
    End Sub

    Public Sub tmrProgress_Tick(sender As System.Object, e As System.EventArgs) Handles tmrProgress.Tick
        ' this makes the progress bar add until it reaches 100 and then the form hides
        psbLoad.Value = psbLoad.Value + 5
        If psbLoad.Value = 100 Then
            Me.Hide()
            frmAccount.Show()
            tmrProgress.Stop()
        End If
    End Sub

    Private Sub frmSpaceInvaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' this centers the form
        Centre(Me)
    End Sub

    Private Sub butMiniGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCredit.Click
        ' this hides the form and shows the credit form
        Me.Hide()
        frmCredits.Show()
    End Sub

End Class
