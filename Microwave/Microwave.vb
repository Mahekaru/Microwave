Public Class frmMicrowave
    Private timer As String = ""
    Private minute As Integer
    Private second As Integer
    Private Open As Integer
    Private Start As Integer
    Private delay As Integer

    Private Sub pnlOne_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlOne.MouseClick
        displayTime(1)
    End Sub

    Private Sub pnlTwo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTwo.MouseClick
        displayTime(2)
    End Sub

    Private Sub pnlThree_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlThree.MouseClick
        displayTime(3)
    End Sub

    Private Sub pnlFour_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlFour.MouseClick
        displayTime(4)
    End Sub

    Private Sub pnlFive_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlFive.MouseClick
        displayTime(5)
    End Sub

    Private Sub pnlSix_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlSix.MouseClick
        displayTime(6)
    End Sub

    Private Sub pnlSeven_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlSeven.MouseClick
        displayTime(7)
    End Sub

    Private Sub pnlEight_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlEight.MouseClick
        displayTime(8)
    End Sub

    Private Sub pnlNine_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlNine.MouseClick
        displayTime(9)
    End Sub

    Private Sub pnlZero_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlZero.MouseClick
        displayTime(0)
    End Sub

    Private Sub pnlThirtySec_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlThirtySec.MouseClick
        'If Val(timer) >= "9970" Then
        '    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)

        'Else
        '    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
        '    timer = Val(timer) + "30"
        '    displayTime(timer)
        'End If

    End Sub
    Private Sub pnlMinute_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMinute.MouseClick
        'If Val(timer) >= "9900" Then
        '    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
        'Else
        '    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
        '    timer = Val(timer) + "100"
        '    displayTime(timer)
        'End If
    End Sub

    Sub displayTime(tmr)
        Dim display As String
        Dim distime As Integer
        distime = CInt(timer)

        distime += tmr

        Select Case timer.Count
            Case 4

            Case 3

            Case 2

            Case Else
        End Select

        'If timer.Length > 4 Then
        '    timer = timer.Substring(0, 4)
        'End If

        'display = timer.PadLeft(4, "0"c)

        'second = CInt(display.Substring(2))
        'minute = CInt(display.Substring(0, 2))

        'lblTimer.Text = String.Format("{0:D2}:{1:D2}", minute, second)
        'My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
    End Sub
    Sub VisibleOn()

        pnlStart.Visible = True
        pnlOne.Visible = True
        pnlTwo.Visible = True
        pnlThree.Visible = True
        pnlFour.Visible = True
        pnlFive.Visible = True
        pnlSix.Visible = True
        pnlSeven.Visible = True
        pnlEight.Visible = True
        pnlNine.Visible = True
        pnlZero.Visible = True
        pnlThirtySec.Visible = True
        pnlMinute.Visible = True
        pnlStart.Visible = True
        pnlCancel.Visible = True
        pnlOpen.Visible = True
    End Sub
    Sub VisibleOff()

        pnlOne.Visible = False
        pnlTwo.Visible = False
        pnlThree.Visible = False
        pnlFour.Visible = False
        pnlFive.Visible = False
        pnlSix.Visible = False
        pnlSeven.Visible = False
        pnlEight.Visible = False
        pnlNine.Visible = False
        pnlZero.Visible = False
        pnlThirtySec.Visible = False
        pnlMinute.Visible = False
        pnlStart.Visible = False
        'pnlCancel.Visible = False

    End Sub

    Private Sub pnlStart_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlStart.MouseClick
        If Start = 1 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources._Loop, AudioPlayMode.BackgroundLoop)
            Me.BackgroundImage = My.Resources.Microwave_On

            tmrTimer.Enabled = True
            tmrTime.Enabled = False
            VisibleOff()

            Start -= 1

        Else
            tmrTime.Enabled = False
            VisibleOff()

            If minute > 0 Then
                Start = 1

                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources._Loop, AudioPlayMode.BackgroundLoop)
                Me.BackgroundImage = My.Resources.Microwave_On
                timer = timer.PadLeft(4, "0"c)

                second = CInt(timer.Substring(2))
                minute = CInt(timer.Substring(0, 2))

                lblTimer.Text = String.Format("{0:d2}:{1:d2}", minute, second)

                timer = ""
                tmrTimer.Enabled = True
            ElseIf second > 0 Then
                Start = 1
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources._Loop, AudioPlayMode.BackgroundLoop)
                Me.BackgroundImage = My.Resources.Microwave_On
                timer = timer.PadLeft(4, "0"c)

                second = CInt(timer.Substring(2))
                minute = CInt(timer.Substring(0, 2))

                lblTimer.Text = String.Format("{0:d2}:{1:d2}", minute, second)

                timer = ""
                tmrTimer.Enabled = True
            Else

                tmrTime.Enabled = True

                VisibleOn()

                Start = 0
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
            End If
        End If
    End Sub

    Private Sub pnlCancel_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlCancel.MouseClick
        timer = ""
        Start = 0
        Open = 0
        minute = 0
        second = 0
        tmrTimer.Enabled = False

        Me.BackgroundImage = My.Resources.Microwave_Closed
        My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)

        tmrTime.Enabled = True

        VisibleOn()
    End Sub

    Private Sub pnlOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlOpen.Click
        Me.BackgroundImage = My.Resources.Microwave_Open
        My.Computer.Audio.Play(My.Resources.DoorOpen, AudioPlayMode.Background)

        VisibleOff()

        tmrTimer.Enabled = False
        pnlOpenMicrowave.Visible = True

        pnlCancel.Visible = False
        Open = 1
    End Sub

    Private Sub pnlOpenMicrowave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlOpenMicrowave.Click
        If Open = 1 Then
            Open -= 1
            pnlCancel.Visible = True
        End If

        If Start > 0 Then
            If minute > 0 Then
                Me.BackgroundImage = My.Resources.Microwave_Closed
                My.Computer.Audio.Play(My.Resources.DoorClose, AudioPlayMode.Background)

                VisibleOff()

                pnlStart.Visible = True
                pnlOpenMicrowave.Visible = False

            ElseIf second > 0 Then

                Me.BackgroundImage = My.Resources.Microwave_Closed
                My.Computer.Audio.Play(My.Resources.DoorClose, AudioPlayMode.Background)

                VisibleOff()

                pnlStart.Visible = True
                pnlOpenMicrowave.Visible = False
            Else
                Me.BackgroundImage = My.Resources.Microwave_Closed
                My.Computer.Audio.Play(My.Resources.DoorClose, AudioPlayMode.Background)

                VisibleOn()

                pnlStart.Visible = True
                pnlOpenMicrowave.Visible = False
            End If
        Else
            Me.BackgroundImage = My.Resources.Microwave_Closed
            My.Computer.Audio.Play(My.Resources.DoorClose, AudioPlayMode.Background)

            VisibleOn()

            ' pnlStart.Visible = True
            'pnlCancel.Visible = True
            pnlOpenMicrowave.Visible = False
        End If
    End Sub

    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        If Open = 1 Then
        Else
            Start = 1
            If second > 0 Then
                second -= 1
                lblTimer.Text = String.Format("{0:D2}:{1:D2}", minute, second)
            ElseIf minute > 0 Then
                minute -= 1
                second = 59
                lblTimer.Text = String.Format("{0:D2}:{1:D2}", minute, second)

            Else

                Me.BackgroundImage = My.Resources.Microwave_Closed
                tmrTimer.Enabled = False
                lblTimer.Text = "Done"

                VisibleOn()

                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)

                tmrDelay.Enabled = True

                Start = 0
            End If
        End If
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        If minute = 0 Then
            If second = 0 Then
                lblTimer.Text = TimeOfDay
            End If
        End If
    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        delay += 1
        If delay = 2 Then
            tmrDelay.Enabled = False
            tmrTime.Enabled = True
            delay = 0
        End If
    End Sub
End Class
