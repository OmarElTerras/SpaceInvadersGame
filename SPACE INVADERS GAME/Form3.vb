Public Class frmCredits

    Private Sub tmrMoveUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveUp.Tick
        lblCredits.Top = lblCredits.Top - 2
    End Sub

    Private Sub frmCredits_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        dlgColour.ShowDialog()
        Me.BackColor = dlgColour.Color
    End Sub

    Private Sub frmCredits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Centre(Me)
    End Sub

    Private Sub lblCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCredits.Click
        dlgFont.ShowDialog()
        lblCredits.Font = dlgFont.Font
    End Sub

    Private Sub butMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMnu.Click
        Me.Hide()
        frmSpaceInvaders.Show()
    End Sub
End Class