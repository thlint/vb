Public Class MyDBForm2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MyDBForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1 'нужно чтобы клавиша ВВОД нажимала кнопку 1
        Me.CancelButton = Button2 'нужно чтобы клавиша ESC нажимала кнопку 2

    End Sub
End Class