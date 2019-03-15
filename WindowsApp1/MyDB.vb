' https://www.youtube.com/watch?v=FrfLsqYV-1Q
Imports System.Data.OleDb
Public Class MyDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefrecshGrid()
    End Sub

    Private Sub RefrecshGrid()
        Dim c As New OleDbCommand("select * from Users") 'команда с запросом к БД
        c.Connection = conn ' к какой базе подключаться ( к какому коннектору)
        Dim da As New OleDbDataAdapter(c) 'Адаптер связан с командой а команда связана с коннектором
        Dim ds As New DataSet ' в этом объекте хранятся таблицы
        da.Fill(ds, "MSubjects") 'ds- а-ля локальная БД, VSbujects а-ля таблица - результат команды селект
        Grid1.DataSource = ds
        Grid1.DataMember = "Msubjects"
    End Sub

    Private Sub RefreshGridEvens()

    End Sub

    Private Sub MyDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conn As System.Data.OleDb.OleDbConnection т.к. в первой строке прописан импорт, можем обращаться по короктому имени
        ' открываем соединение
        conn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\ttt.accdb;Persist Security Info=False;")
        conn.Open()
        RefrecshGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyDate As DateTime
        Dim MyWinn, MyLoos As String
        Dim MyCount As Integer
        Dim r As DialogResult
        MyDBForm2.ShowDialog()
        MyDate = MyDBForm2.DateTimePicker1.Value
        MyWinn = MyDBForm2.ComboBox1.Text
        MyLoos = MyDBForm2.ComboBox2.Text
        MyCount = CInt(MyDBForm2.TextBox1.Text)
        r = MyDBForm2.DialogResult
        Form2.Close()

        If r <> DialogResult.OK Then
            Exit Sub
        End If

        Dim c As New OleDbCommand
        c.Connection = conn 'conn объявлена в модуле
        Dim MyTime As DateTime = DateTime.Now
        c.CommandText = "insert into Events values(#" & MyDate & "#, " & MyWinn & "','" & MyLoos & "'," & MyCount & ")"
        c.ExecuteNonQuery() 'Выполнить команду не получая ответ на запрос
        RefrecshGrid()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim email2delete As String
        Dim c As New OleDbCommand
        'Нужно значение столбца из выбранного поля нашего списка таблицы, из того поля, которое 
        c.Connection = conn 'conn теперь доступна из модуля
        Dim MyTime As DateTime = DateTime.Now
        email2delete = Grid1.CurrentRow.Cells("email").Value
        c.CommandText = "delete from Users where Email ='" & email2delete & "'"
        If MsgBox(c.CommandText, MsgBoxStyle.YesNo, "Удаление записи") = MsgBoxResult.Yes Then
            c.ExecuteNonQuery() 'Выполнить команду не получая ответ на запрос
            RefrecshGrid()
        End If
    End Sub
End Class