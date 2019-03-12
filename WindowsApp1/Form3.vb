Imports System.DirectoryServices

Public Class Form3
    Dim entry As New DirectoryEntry("LDAP://mirkwood.css-rzd.local/OU=Humans,OU=VLANs,DC=CSS-RZD,DC=local", "NBAH", "QwErTy123")
    Dim mySearcher As New DirectorySearcher(entry, "(memberOf=CN=ЦССНСИ,OU=Groups,DC=CSS-RZD,DC=local)")
    ' примеры фильтров https://bga68.livejournal.com/24636.html
    ' Create a SearchResultCollection object to hold a collection of SearchResults
    ' returned by the FindAll method.
    Dim result As SearchResultCollection = mySearcher.FindAll()

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
        MessageBox.Show("Найдено объектов в каталоге: " + result.Count.ToString)
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("sAMAccountName", 150)
        ListView1.Columns.Add("Name", 330)
        ListView1.FullRowSelect = True
        myList.View = View.Details
        myList.Columns.Add("сек.", 20)
        myList.Columns.Add("мс.", 30)
        myList.Columns.Add("тики = 0,1 мкс.", 200)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyTime As DateTime = DateTime.Now
        Dim myListField As ListViewItem = New ListViewItem({MyTime.Second, MyTime.Millisecond, MyTime.Ticks})
        myList.Items.Add(myListField)
        For Each MyUser As SearchResult In result
            Dim item As ListViewItem = New ListViewItem({MyUser.Properties("sAMAccountName")(0), MyUser.Properties("Name")(0)})
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class