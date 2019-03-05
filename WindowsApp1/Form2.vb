Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B(100) As Integer, K As Byte
        For K = 0 To 100
            B(K) = K * 10
        Next
        MessageBox.Show(CType(B(10), String))
        Dim M() As String = {"Яблоко", "Груша", "Вишня"}
        ' For dim i As Integer = 
    End Sub
End Class