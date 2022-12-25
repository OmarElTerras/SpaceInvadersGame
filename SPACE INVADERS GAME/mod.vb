Module module1
    Public Sub Centre(ByRef theForm)
        theForm.Left = (My.Computer.Screen.Bounds.Width - theForm.Width) \ 2
        theForm.Top = (My.Computer.Screen.Bounds.Height - theForm.Height) \ 2
    End Sub
End Module
