Imports System.IO

Public Class frmScore
    Dim PlayerScore(4, 1) As String ' an array of the player and thier score

    Private Sub frmScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'centers the from
        Centre(Me)

        'creates rows and colums
        dgvScore.RowCount = 5
        dgvScore.ColumnCount = 2

        'creates the heignt and width of each cell
        For Row = 0 To 4
            dgvScore.Rows(Row).Height = 40

        Next

        For Col = 0 To 1
            dgvScore.Columns(Col).Width = 120
        Next

        'insters value for cells
        PlayerScore(0, 0) = "Name"
        PlayerScore(0, 1) = "Score"

        'displayes the players score
        PlayerScore(1, 0) = frmLevel.txtU.Text
        PlayerScore(1, 1) = frmGamePlay.lblScoreGame.Text

        'displayes the players score
        For i = 0 To 1
            For j = 0 To 1
                dgvScore.Rows(i).Cells(j).Value = PlayerScore(i, j)
            Next j
        Next i

    End Sub

    Private Sub frmScore_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' nonresizeable form
        Me.Size = New Size(700, 400)
    End Sub

    Private Sub butWouldYou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butWouldYou.Click
        ' when the button is clicked, then the other controls show
        butWouldYou.Hide()
        butRate.Show()
        Me.Size = New Size(750, 365)

        lblRating1.Show()
        lbl10.Show()
        lstRating.Show()
        hsbRating.Show()
        txtComment.Show()

    End Sub

    Private Sub txtComment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComment.Click
        'clears text
        txtComment.Text = ""
    End Sub

    Private Sub butRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRate.Click
        lstRating.Items.Add(txtComment.Text & " : " & hsbRating.Value)
        hsbRating.Enabled = False
        txtComment.Enabled = False
    End Sub

    Private Sub butEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEnd.Click
        'saves the score, name, comment, rating in the drive
        Dim FileWriter As StreamWriter
        Dim Results As DialogResult
        Results = dlgSave.ShowDialog
        If Results = DialogResult.OK Then
            FileWriter = New StreamWriter(dlgSave.FileName, False)
            FileWriter.Write("Player : " & frmLevel.txtU.Text & Chr(10) & Chr(13) & "Score : " & PlayerScore(1, 1) & Chr(10) & Chr(13) & "Comment : " & txtComment.Text & Chr(10) & Chr(13) & "Rating : " & hsbRating.Value & "/100")
            FileWriter.Close()
        End If
        'closes program
        Me.Close()
    End Sub

End Class