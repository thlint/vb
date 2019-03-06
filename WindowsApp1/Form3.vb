Public Class Form3
    Private Enum Sports As Integer
        voleyball = 0
        baseball = 1
        gandball = 3
        football = 2
    End Enum
    Private mySport As Sports
    Private Sub Analyze_Click(sender As Object, e As EventArgs) Handles Analyze.Click
        AnalyzeSport(mySport)
    End Sub

    Private Sub ComboSports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSports.SelectedIndexChanged
        If ComboSports.SelectedIndex <> -1 Then
            mySport = ComboSports.SelectedIndex
        End If

    End Sub

    Private Sub AnalyzeSport(ByVal sportslist As Sports)
        Select Case sportslist
            Case Is = Sports.voleyball
                MessageBox.Show("Вы выбрали волейбол")
            Case Is = Sports.baseball
                MessageBox.Show("Вы выбрали бейсбол")
            Case Is = Sports.gandball
                MessageBox.Show("Вы выбрали гандбол")
            Case Is = Sports.football
                MessageBox.Show("Вы выбрали футбол")
            Case Else
                MsgBox("Не выбран ни один спорт")
        End Select
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class