<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextTel = New System.Windows.Forms.TextBox()
        Me.TextMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnListCustomer = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Циклы"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextLastName
        '
        Me.TextLastName.Location = New System.Drawing.Point(87, 44)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(301, 20)
        Me.TextLastName.TabIndex = 1
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(87, 70)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(301, 20)
        Me.TextName.TabIndex = 2
        '
        'TextTel
        '
        Me.TextTel.Location = New System.Drawing.Point(87, 96)
        Me.TextTel.Name = "TextTel"
        Me.TextTel.Size = New System.Drawing.Size(301, 20)
        Me.TextTel.TabIndex = 3
        '
        'TextMail
        '
        Me.TextMail.Location = New System.Drawing.Point(87, 122)
        Me.TextMail.Name = "TextMail"
        Me.TextMail.Size = New System.Drawing.Size(301, 20)
        Me.TextMail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Фамилия:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Имя:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Тел:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Почта:"
        '
        'btnListCustomer
        '
        Me.btnListCustomer.Location = New System.Drawing.Point(193, 157)
        Me.btnListCustomer.Name = "btnListCustomer"
        Me.btnListCustomer.Size = New System.Drawing.Size(161, 23)
        Me.btnListCustomer.TabIndex = 9
        Me.btnListCustomer.Text = "Данные пользователя"
        Me.btnListCustomer.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(193, 208)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(161, 23)
        Me.btnNewUser.TabIndex = 10
        Me.btnNewUser.Text = "Новый пользователь"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnListCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextMail)
        Me.Controls.Add(Me.TextTel)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextLastName)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextTel As TextBox
    Friend WithEvents TextMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnListCustomer As Button
    Friend WithEvents btnNewUser As Button
End Class
