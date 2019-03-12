' https://www.youtube.com/watch?v=FrfLsqYV-1Q
Imports System.Data.OleDb
Public Class MyDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefrecshGrid()
    End Sub

    Private Sub RefrecshGrid()
        Dim c As New OleDbCommand 'команда с запросом к БД
        c.Connection = conn ' к какой базе подключаться ( к какому коннектору)
        c.CommandText = "select * from Games" ' Текст запроса
        Dim da As New OleDbDataAdapter(c) 'Адаптер связан с командой а команда связана с коннектором
        Dim ds As New DataSet ' в этом объекте хранятся таблицы
        da.Fill(ds, "ИГРОКИ")
        Grid1.DataSource = ds
        Grid1.DataMember = "ИГРОКИ"
    End Sub

    Private Sub MyDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conn As System.Data.OleDb.OleDbConnection т.к. в первой строке прописан импорт, можем обращаться по короктому имени
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\ttt.accdb;Persist Security Info=False;"
        conn.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As New OleDbCommand
        c.Connection = conn 'conn теперь доступна из модуля
        Dim MyTime As DateTime = DateTime.Now
        c.CommandText = "insert into Players values('новый_логин" + MyTime.Millisecond.ToString + "','Иванов Иван Иванович')" '
        c.ExecuteNonQuery() 'Выполнить команду не получая ответ на запрос
    End Sub
End Class