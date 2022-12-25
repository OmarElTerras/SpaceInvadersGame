Public Class frmCredits

    Private Sub frmMinigame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' this centers the form
        Centre(Me)
    End Sub

    Private Sub lblLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        ' this hides the form when the link is clicked and shows the credit form
        frmCredits2.Show()
        Me.Hide()
    End Sub
End Class