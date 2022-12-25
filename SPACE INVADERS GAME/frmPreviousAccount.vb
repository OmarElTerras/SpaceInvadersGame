Public Class frmPreviousAccount
    Dim theAccountPassword As String ' the passsword that is input in the input box

    Private Sub lstNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNames.SelectedIndexChanged
        ' enables the button
        butEnter2.Enabled = True
    End Sub

    Private Sub butEnter2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEnter2.Click
        'each name has code that does a loop until the password corresponds to the name
        If lstNames.Text = "Omar" Then
            Do Until theAccountPassword = "OmarOmar"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If


        If lstNames.Text = "Nader" Then
            Do Until theAccountPassword = "1"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

        If lstNames.Text = "Ali" Then
            Do Until theAccountPassword = "2"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

        If lstNames.Text = "Bara" Then
            Do Until theAccountPassword = "3"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

        If lstNames.Text = "Saliba" Then
            Do Until theAccountPassword = "4"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

        If lstNames.Text = "Raghd" Then
            Do Until theAccountPassword = "5"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

        If lstNames.Text = "Mr.Waldon" Then
            Do Until theAccountPassword = "ICS"
                theAccountPassword = InputBox("What is your password?", "PASSWORD", "Password Here")
            Loop
            Me.Hide()
            frmLevel.Show()
        End If

    End Sub

    Private Sub frmPreviousAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' centeres from
        Centre(Me)
    End Sub
End Class