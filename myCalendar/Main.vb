Public Class Main
    Public myEvents(364, 3) As String
    Dim myEvent As String
    Dim myDate As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        For allEv = 0 To 364
            myEvents(allEv, 0) = ""
            myEvents(allEv, 1) = ""
            myEvents(allEv, 2) = "false"
            myEvents(allEv, 3) = -1
        Next allEv
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelClock.Text = TimeOfDay.ToString("hh\:mm\:ss")
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBoxDate.Text = MonthCalendar1.SelectionEnd.ToString("dd/MM/yyyy")
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        addMyEvent()
    End Sub

    Private Sub TextBoxDate_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDate.TextChanged
        showMyEvent()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        DeleteMyEvent()
    End Sub


    Public Function addMyEvent()
        myEvent = TextBoxEvent.Text
        myDate = TextBoxDate.Text

        Dim flag As Boolean = True
        Dim allEv As Integer = 0
        While (flag = True) And (allEv < 364)
            If myEvent.Length > 0 And myDate.Length > 0 Then
                If myEvents(allEv, 2) = "false" Then
                    myEvents(allEv, 0) = myEvent
                    myEvents(allEv, 1) = myDate
                    myEvents(allEv, 2) = "true"
                    myEvents(allEv, 3) = allEv
                    ListBoxMyEvents.Items.Add(myEvents(allEv, 0))
                    MsgBox("Η εργασία δημιουργήθηκε με επιτυχία!", MsgBoxStyle.Information, "Δημιουργία εργασίας")
                    flag = False
                ElseIf myEvents(allEv, 1) = myDate Then
                    myEvents(allEv, 0) = myEvent
                    myEvents(allEv, 3) = allEv
                    ListBoxMyEvents.Items.Item(allEv) = myEvents(allEv, 0)
                    MsgBox("Η εργασία τροποποιήθηκε με επιτυχία!", MsgBoxStyle.Information, "Τροποποιήση εργασίας")
                    flag = False
                End If
            ElseIf myEvent.Length = 0 Or myDate.Length = 0 Then
                MsgBox("Συμπληρώστε τα κατάλληλα πεδία! ", MsgBoxStyle.Exclamation, "Δημιουργία εργασίας")
                Exit While
            End If
                allEv += 1
        End While

    End Function


    Public Function showMyEvent()
        myDate = TextBoxDate.Text

        Dim flag As Boolean = True
        Dim allEv As Integer = 0

        While (flag = True) And (allEv < 364)
            If myDate = myEvents(allEv, 1) Then
                If myEvents(allEv, 3) <> -1 Then
                    ListBoxMyEvents.SetSelected(myEvents(allEv, 3), True)
                    flag = False
                End If
            Else
                TextBoxEvent.Text = ""
            End If
            allEv += 1
        End While

    End Function

    Public Function DeleteMyEvent()
        Dim selectedIndex = -1
        selectedIndex = ListBoxMyEvents.SelectedIndex
        If selectedIndex <> -1 Then
            Select Case MsgBox("Θέλετε να γίνει διαγραφή;", MsgBoxStyle.YesNo, "Διαγραφή εργασίας")
                Case MsgBoxResult.Yes
                    ListBoxMyEvents.Items.RemoveAt(selectedIndex)
                    myEvents(selectedIndex, 0) = ""
                    myEvents(selectedIndex, 1) = ""
                    myEvents(selectedIndex, 2) = "false"
                    myEvents(selectedIndex, 3) = -1
                    MsgBox("Η διαγραφή της εργασίας έγινε με επιτυχία!", MsgBoxStyle.Information, "Διαγραφή εργασίας")
                Case MsgBoxResult.No
                    MsgBox("Η εργασία δεν θα διαγραφεί!", MsgBoxStyle.Information, "Διαγραφή εργασίας")
            End Select
        ElseIf selectedIndex = -1 Then
            MsgBox("Επιλέξτε την εργασία που θέλετε να διαγράψετε! ", MsgBoxStyle.Critical, "Διαγραφή εργασίας")
        End If
    End Function

    Private Sub ListBoxMyEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMyEvents.SelectedIndexChanged
        Dim flag As Boolean = True
        Dim allEv As Integer = 0
        While (flag = True) And (allEv < 364)
            If ListBoxMyEvents.SelectedIndex = myEvents(allEv, 3) Then
                TextBoxEvent.Text = myEvents(allEv, 0)
                TextBoxDate.Text = myEvents(allEv, 1)
                flag = False
            Else
                myEvent = ""
                myDate = ""
            End If
            allEv += 1
        End While
    End Sub


    Private Sub ΠληροφορίεςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΠληροφορίεςToolStripMenuItem.Click
        Dim newForm = New About()
        newForm.Show()
    End Sub

    Private Sub ΈξοδοςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΈξοδοςToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ΑναλογικόToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΑναλογικόToolStripMenuItem.Click
        Dim newForm = New AnalogClock()
        newForm.Show()
    End Sub

    Private Sub ΨηφιακόToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΨηφιακόToolStripMenuItem.Click
        Dim newForm = New DigitClock()
        newForm.Show()
    End Sub

    Private Sub PictureBoxHelp_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxHelp.MouseHover
        LabelHelp.Visible = True
    End Sub

    Private Sub PictureBoxHelp_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxHelp.MouseLeave
        LabelHelp.Visible = False
    End Sub

    Private Sub PictureBoxHelp2_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxHelp2.MouseHover
        TextBoxDate.Text = "DD/MM/YYYY"
        TextBoxEvent.Text = "Τίτλος"
    End Sub

    Private Sub PictureBoxHelp2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxHelp2.MouseLeave
        TextBoxDate.Text = ""
        TextBoxEvent.Text = ""
    End Sub
End Class

