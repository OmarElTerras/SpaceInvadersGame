Public Class frmAccount

    Public Sub butYes_Click(sender As System.Object, e As System.EventArgs) Handles butYes.Click
        ' if the player presses yes then it shows the form with the list of names
        Me.Hide()
        frmPreviousAccount.Show()
    End Sub

    Public Sub butNo_Click(sender As System.Object, e As System.EventArgs) Handles butNo.Click
        ' if no is clicked then the non-previous account form shows 
        Me.Hide()
        frmUsername.Show()
    End Sub

    Private Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' this centers the form
        Centre(Me)
    End Sub
End Class