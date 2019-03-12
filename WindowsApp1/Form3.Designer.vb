<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ComboSports = New System.Windows.Forms.ComboBox()
        Me.Analyze = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.myList = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ComboSports
        '
        Me.ComboSports.FormattingEnabled = True
        Me.ComboSports.Items.AddRange(New Object() {"Волейбол", "Бейсбол", "Футбол", "Гандбол"})
        Me.ComboSports.Location = New System.Drawing.Point(519, 46)
        Me.ComboSports.Name = "ComboSports"
        Me.ComboSports.Size = New System.Drawing.Size(172, 21)
        Me.ComboSports.TabIndex = 0
        '
        'Analyze
        '
        Me.Analyze.Location = New System.Drawing.Point(519, 116)
        Me.Analyze.Name = "Analyze"
        Me.Analyze.Size = New System.Drawing.Size(123, 29)
        Me.Analyze.TabIndex = 1
        Me.Analyze.Text = "AnalyzeSports"
        Me.Analyze.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(32, 166)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(592, 196)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(559, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'myList
        '
        Me.myList.Location = New System.Drawing.Point(32, 22)
        Me.myList.Name = "myList"
        Me.myList.Size = New System.Drawing.Size(481, 123)
        Me.myList.TabIndex = 4
        Me.myList.UseCompatibleStateImageBehavior = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.myList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Analyze)
        Me.Controls.Add(Me.ComboSports)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboSports As ComboBox
    Friend WithEvents Analyze As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents myList As ListView
End Class
