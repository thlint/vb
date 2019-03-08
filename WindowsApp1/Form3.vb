Imports System.DirectoryServices

Public Class Form3
    'Dim dirs As DirectoryEntry = New DirectoryEntry("//" + "css-rzd.local", "NBAH", "QwErTy123", AuthenticationTypes.ReadonlyServer)
    'Dim DomainSearcher As DirectorySearcher = New DirectorySearcher(dirs)

    Dim entry As New DirectoryEntry("LDAP://mirkwood.css-rzd.local/OU=ITS,OU=Humans,OU=VLANs,DC=CSS-RZD,DC=local", "NBAH", "QwErTy123")
    Dim mySearcher As New DirectorySearcher(entry)
    ' Create a SearchResultCollection object to hold a collection of SearchResults
    ' returned by the FindAll method.
    '    Dim result As SearchResultCollection = mySearcher.FindAll()
    '   Dim resEnt1 As SearchResult

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
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("Name", 250)
        ListView1.Columns.Add("Guid", 230)
        ListView1.FullRowSelect = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For Each de As DirectoryEntry In entry.Children
            If (de.SchemaClassName = "user") Then
                Dim item As ListViewItem = New ListViewItem({de.Name, de.Path})
                ListView1.Items.Add(item)

            End If
        Next

    End Sub



End Class