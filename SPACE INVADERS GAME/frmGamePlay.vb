Public Class frmGamePlay
    Dim MoveLeft, MoveRight As Boolean ' these are the boolean values that say if the ship moves to the right or left
    Dim moveAlien As Single = 47.5 ' this is the value the aliens move at
    Dim Aliens(9) As PictureBox ' these are the aliens in an array
    Dim Shot1, Shot2, Shot3 As Boolean ' these are the label shots that the player can shoot by pressing space
    Dim kill As Integer = 0 ' this is how many aliens have been killed
    Dim IntShip, IntShot As Single ' the integer of the ship and shot
    Dim EasterEgg, Alive As Boolean ' the easter egg and if the player is still alive or dead

    Sub ResetLocation()
        'reset the location of the shots and the aliens
        lblShot1.Location = lblRestartShot.Location
        lblShot2.Location = lblRestartShot.Location
        lblShot3.Location = lblRestartShot.Location

        picAlien1.Location = picReset.Location
        picAlien2.Location = picReset2.Location
        picAlien3.Location = picReset3.Location
        picAlien4.Location = picReset4.Location
        picAlien5.Location = picReset5.Location
        picAlien6.Location = picReset6.Location
        picAlien7.Location = picReset7.Location
        picAlien8.Location = picReset8.Location
        picAlien9.Location = picReset9.Location
        picAlien10.Location = picReset10.Location
    End Sub
    Public Sub frmGamePlay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'centers the form
        Centre(Me)
        Alive = True
        EasterEgg = False

        ' gives the control values for the other forms
        'transfers other forms values to this form
        lblName2.Text = frmLevel.txtU.Text
        lblName2.ForeColor = frmLevel.dlgColour.Color
        lblName2.Font = frmLevel.dlgFont.Font
        lblScore.Font = frmLevel.dlgFont.Font
        lblScoreGame.Font = frmLevel.dlgFont.Font
        lblScore.ForeColor = frmLevel.dlgColour.Color
        lblScoreGame.ForeColor = frmLevel.dlgColour.Color

        ' the ship is in a if and then 
        If frmLevel.rad1.Checked Then
            picShipGame.Image = My.Resources.ship
        ElseIf frmLevel.rad2.Checked Then
            picShipGame.Image = My.Resources.ship_2
        ElseIf frmLevel.rad3.Checked Then
            picShipGame.Image = My.Resources.ship3
        End If


        ' the backcolour of the game
        Select Case True
            Case frmLevel.cboBackcolour.Text = "Red"
                Me.BackColor = Color.Red
            Case frmLevel.cboBackcolour.Text = "Purple"
                Me.BackColor = Color.Purple
            Case frmLevel.cboBackcolour.Text = "Blue"
                Me.BackColor = Color.Blue
            Case frmLevel.cboBackcolour.Text = "GO CRAZY???"
                tmrFlash.Start()
        End Select


    End Sub

    Public Sub KeyboardDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'this is to control the keys and the space to make the boolean value true
        If e.KeyValue = Keys.Left Then
            MoveLeft = True
        ElseIf e.KeyValue = Keys.Right Then
            MoveRight = True
        ElseIf e.KeyValue = Keys.Space Then

            If Shot1 = False Then
                Shot1 = True
            ElseIf Shot1 = True And Shot2 = False Then
                Shot2 = True
            ElseIf Shot1 = True And Shot2 = True And Shot3 = False Then
                Shot3 = True
            End If

        End If

    End Sub

    Public Sub KeyboardUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'this is to control the keys and the space to make the boolean value False
        If e.KeyValue = Keys.Left Then
            MoveLeft = False
        ElseIf e.KeyValue = Keys.Right Then
            MoveRight = False
        ElseIf e.KeyValue = Keys.Space Then

            If Shot1 = False Then
                Shot1 = False
            ElseIf Shot1 = True And Shot2 = False Then
                Shot2 = False
            ElseIf Shot1 = True And Shot2 = True And Shot3 = False Then
                Shot3 = False
            End If

        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        AlienArray()
    End Sub

    Public Sub AlienArray()
        ' this is to call each value in the array
        Aliens(0) = picAlien1
        Aliens(1) = picAlien2
        Aliens(2) = picAlien3
        Aliens(3) = picAlien4
        Aliens(4) = picAlien5
        Aliens(5) = picAlien6
        Aliens(6) = picAlien7
        Aliens(7) = picAlien8
        Aliens(8) = picAlien9
        Aliens(9) = picAlien10
    End Sub

    Public Sub moveAliens()
        ' this changes the speed of the aliens depending on the selected difficulty
        If frmLevel.cboDifficulty.SelectedItem = "Easy" Then
            tmrMove.Interval = 150
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Medium" Then
            tmrMove.Interval = 100
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Hard" Then
            tmrMove.Interval = 10
        Else
            moveAlien = 100
        End If

        ' this makes the aliens move
        For i = 0 To 9
            Aliens(i).Left = Aliens(i).Left + moveAlien

            'this makes the ship stop and turn into an explostion when the person dies
            If Aliens(i).Bounds.IntersectsWith(picShipGame.Bounds) Then
                tmrMove.Stop()
                picShipGame.Image = My.Resources.explosion
                Alive = False

                MsgBox("GAME OVER")
                Me.Hide()
                frmScore.Show()
                '  frmSpaceIn()
            End If
        Next
        'this moves the aliens closer to the ship
        If picAlien5.Left > Me.Width - picAlien5.Width Then
            moveAlien = moveAlien * -1
            For i = 0 To 9
                Aliens(i).Top = Aliens(i).Top + 25
            Next
        End If
        If picAlien1.Left < 0 Then
            moveAlien = moveAlien * -1
            For i = 0 To 9
                Aliens(i).Top = Aliens(i).Top + 25
            Next
        End If

    End Sub

    Public Sub moveShot()
        ' the shots speed depending on the difficuly
        If frmLevel.cboDifficulty.SelectedItem = "Easy" Then
            IntShot = 35
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Medium" Then
            IntShot = 25
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Hard" Then
            IntShot = 10
        End If

        'this moves the shot
        If Shot1 = True Then
            Beep()
            lblShot1.Show()
            lblShot1.Top = lblShot1.Top - IntShot

            If lblShot1.Top < 0 Then
                Shot1 = False
                lblShot1.Location = lblRestartShot.Location
            End If
            ' this kills the aliens
            For i = 0 To 9
                If lblShot1.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    Beep()
                    Shot1 = False
                    lblShot1.Location = lblRestartShot.Location
                    Aliens(i).Top = Aliens(i).Top + 1000
                    ' Aliens(i).Visible() = False
                    kill = kill + 1
                    lblScoreGame.Text = lblScoreGame.Text + 1
                End If

            Next

        End If

        'same as shot one
        If Shot2 = True Then
            Beep()
            lblShot2.Show()
            lblShot2.Top = lblShot2.Top - IntShot

            If lblShot2.Top < 0 Then
                Shot2 = False
                lblShot2.Location = lblRestartShot.Location
            End If

            For i = 0 To 9

                If lblShot2.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    Beep()
                    Shot2 = False
                    lblShot2.Location = lblRestartShot.Location
                    Aliens(i).Top = Aliens(i).Top + 1000
                    '    Aliens(i).Visible() = False
                    kill = kill + 1
                    lblScoreGame.Text = lblScoreGame.Text + 1
                End If

            Next

        End If


        'same as shot one
        If Shot3 = True Then
            Beep()
            lblShot3.Show()
            lblShot3.Top = lblShot3.Top - IntShot

            If lblShot3.Top < 0 Then
                Shot3 = False
                lblShot3.Location = lblRestartShot.Location
            End If

            For i = 0 To 9
                If lblShot3.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    Beep()
                    Shot3 = False
                    lblShot3.Location = lblRestartShot.Location
                    Aliens(i).Top = Aliens(i).Top + 1000
                    '    Aliens(i).Visible() = False
                    kill = kill + 1
                    lblScoreGame.Text = lblScoreGame.Text + 1
                End If

            Next

        End If

        ' (1) when you kill 10 aliens you go to the next level
        If kill = 10 Then
            tmrMove.Stop()
            kill = 11
            MsgBox("You beat the first level!")

            IntShip = IntShip - 7
            IntShot = IntShot - 7

            ResetLocation()

            tmrMove.Start()
            ' same as (1)
        ElseIf kill = 21 Then
            tmrMove.Stop()
            kill = 22
            MsgBox("You beat the second level!")


            IntShip = IntShip - 7
            IntShot = IntShot - 7
            ResetLocation()
            tmrMove.Start()
            ' same as (1)
        ElseIf kill = 32 Then
            tmrMove.Stop()
            kill = 33
            MsgBox("You beat the third level!")
            MsgBox("You are in endless mode now!")
           
            IntShip = IntShip - 5
            IntShot = IntShot - 5

            ResetLocation()

            tmrMove.Start()
        End If

        ' makes the game endless and makes the game harder
        If kill = 43 Then
            kill = 33
            moveAlien = moveAlien + 15
            IntShip = IntShip - 3
            IntShot = IntShot - 3
            tmrMove.Stop()
            ResetLocation()
            tmrMove.Start()
        End If



    End Sub

    Public Sub tmrShipMove_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick
        ' this is the speed of the ship depending on the difficulty
        If frmLevel.cboDifficulty.SelectedItem = "Easy" Then
            IntShip = 30
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Medium" Then
            IntShip = 30
        ElseIf frmLevel.cboDifficulty.SelectedItem = "Hard" Then
            IntShip = 20
        End If

        ' this moves the shot so that it is always at the tip of the ship
        ' this moves the ship left and right
        If MoveLeft = True Then

            picShipGame.Left = picShipGame.Left - IntShip
            lblRestartShot.Left = lblRestartShot.Left - IntShip

            If Shot1 = False Then
                lblShot1.Left = lblShot1.Left - IntShip
            End If

            If Shot2 = False Then
                lblShot2.Left = lblShot2.Left - IntShip
            End If

            If Shot3 = False Then
                lblShot3.Left = lblShot3.Left - IntShip
            End If

        ElseIf MoveRight = True Then

            picShipGame.Left = picShipGame.Left + IntShip
            lblRestartShot.Left = lblRestartShot.Left + IntShip

            If Shot1 = False Then
                lblShot1.Left = lblShot1.Left + IntShip
            End If

            If Shot2 = False Then
                lblShot2.Left = lblShot2.Left + IntShip
            End If

            If Shot3 = False Then
                lblShot3.Left = lblShot3.Left + IntShip
            End If

        End If
        ' this calls the previous subroutines
        moveAliens()
        moveShot()

    End Sub


    Private Sub picShipGame_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShipGame.MouseHover
        ' you cant find easter egg more than once
        'stop game and add points to score
        ' add to score

        If EasterEgg = False Then
            tmrMove.Stop()
            MsgBox("You found a hidden EASTER EGG vy hovering over the ship! You get 5 bonus points added to your score!")
            tmrMove.Start()
            lblScoreGame.Text = lblScoreGame.Text + 5
            EasterEgg = True
        End If

    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick
        ' this makes the backround randimize colours
        Randomize()

        Dim theColor As Color
        Dim R, G, B As Integer

        R = Int(Rnd() * 255)
        G = Int(Rnd() * 255)
        B = Int(Rnd() * 255)

        theColor = Color.FromArgb(255, R, G, B)

        Me.BackColor = theColor
    End Sub
End Class