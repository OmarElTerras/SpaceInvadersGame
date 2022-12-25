Public Class frmUsername

    Function Hello(ByVal name As String) As String
        Dim msg As String = "Hello " & name & "!"
        Return msg
    End Function

    Public Sub butEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEnter.Click
        Dim theMsg As String
        Dim theName As String

        Me.Hide()

        theName = rtbUsername.Text

        theMsg = Hello(theName)
        MsgBox(theMsg, MsgBoxStyle.Exclamation, "Welcome")

        frmLevel.Show()
    End Sub

    Private Sub frmUsername_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' this centers the form
        Centre(Me)
    End Sub
End Class