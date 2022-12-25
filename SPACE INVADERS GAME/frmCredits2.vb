Public Class frmCredits2
    Dim Int As Integer ' this is the integer at which the credit label moves up
    Private Sub frmCredits2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        ' when the form is double clicked then a colour dialog shows
        dlgC.ShowDialog()

        ' the backcolour changes to the selected colour
        Me.BackColor = dlgC.Color
    End Sub

    Private Sub frmCredits2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' the timer starts when the form loads
        tmrUp.Start()
    End Sub

    Private Sub tmrUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUp.Tick
        ' this code moves the label up
        lblCredits.Top = lblCredits.Top - Int
    End Sub

    Private Sub lblCredits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCredits.Click
        ' when the label is clicked a font dialog shows
        dlgF.ShowDialog()

        ' this changes the font of the label
        lblCredits.Font = dlgF.Font
    End Sub

    Private Sub butReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butReturn.Click
        ' this hides the form and shows the title again
        Me.Hide()
        frmSpaceInvaders.Show()
    End Sub

    Private Sub frmCredits2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' this makes it so the form cannot be made larger or smaller
        Me.Size = New Size(1200, 550)
    End Sub

    Private Sub numSpeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSpeed.ValueChanged
        ' this states that the value of the numeric up down is the integer that the label moves at
        Int = numSpeed.Value
    End Sub
End Class