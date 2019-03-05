Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Загружаем форму..."
        Dim D1, D2 As DateTime
        Dim DW, DW2 As String
        D1 = DateTime.Now
        D2 = D1.AddDays(100) 'Присвоение переменной D2 значения D1 + 100 дней
        Select Case D1.DayOfWeek
            Case DayOfWeek.Sunday
                DW = "Воскресенье"
            Case DayOfWeek.Monday
                DW = "Понедельние"
            Case DayOfWeek.Tuesday
                DW = "Вторник"
            Case DayOfWeek.Wednesday
                DW = "Среда"
            Case DayOfWeek.Thursday
                DW = "Четверг"
            Case DayOfWeek.Friday
                DW = "Пятница"
            Case DayOfWeek.Saturday
                DW = "Суббота"
        End Select
        DW2 = "Сейчас: " + CStr(D1) + vbCrLf + "Сегодня: " + DW + " " + CStr(DateTime.Today) + vbCrLf +
        "Текущее время: " + CStr(D1.Hour) + ":" + CStr(D1.Minute) + ":" + CStr(D1.Second) + vbCrLf +
        "В этом месяце " + CStr(DateTime.DaysInMonth(D1.Year, D1.Month)) + "дня(ей)" + vbCrLf +
        "через 100 дней будет " + CStr(D2.Date)
        Dim DW3 As String, Num As Integer
        Num = 74
        DW3 = CType(Num, String) 'Преобразуем число в строку
        MessageBox.Show(DW2 + vbCrLf + DW3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static Q As Integer = 0 'Объявление новой переменной Q
        Q = Q + 1
        Label1.Text = "Кнопка Количество нажата " + CStr(Q) + " раз"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Кнопка Дата нажата " + CStr(Now()), "Название окошечка даты", MessageBoxButtons.YesNo)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End 'Завершение работы приложения...
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub
End Class
