Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Загружаем форму..."
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
End Class
