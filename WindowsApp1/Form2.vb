Public Class Form2
    Private Structure Person
        Public FullName As String
        Dim Sex As Char 'Вместо уровня доступа полей структуры Public, Friend и Private можно писать Dim. Dim=Public
        Dim YearOfBirth As Byte
        Dim Address As String
        Dim Phone As Long
        ' Public LastName As String 'Вместо переменной сделаем свойства ниже
        Public Name As String
        Public Tel As String
        Public Email As String
        Public ReadOnly Property LastName() As String
            Get
                Return Name + " " + Tel
            End Get
        End Property
    End Structure

    Private objNewPerson As Person
    Private objPerson As Person

    'NewPerson.YearOfBirth = 1980


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B(100) As Integer, K As Byte
        For K = 0 To 100
            B(K) = K * 10
        Next
        MessageBox.Show(CType(B(10), String))
        Dim M() As String = {"Яблоко", "Груша", "Вишня"}
        For i As Integer = 0 To 2
            MessageBox.Show(M(i).ToString)
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnListCustomer_Click(sender As Object, e As EventArgs) Handles btnListCustomer.Click
        objNewPerson.Name = "Jim"
        objNewPerson.Tel = "2-02-02"
        objNewPerson.Email = "jones@mail.ru"

        DisplayPerson(objNewPerson)
    End Sub

    Private Sub DisplayPerson(ByVal cust As Person)
        TextLastName.Text = cust.LastName
        TextName.Text = cust.Name
        TextTel.Text = cust.Tel
        TextMail.Text = cust.Email
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        objPerson = objNewPerson
        objPerson.Tel = "3-05-05"
        DisplayPerson(objPerson)
    End Sub
End Class