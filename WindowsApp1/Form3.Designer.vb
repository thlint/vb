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
        Me.SuspendLayout()
        '
        'ComboSports
        '
        Me.ComboSports.FormattingEnabled = True
        Me.ComboSports.Items.AddRange(New Object() {"Волейбол", "Бейсбол", "Футбол", "Гандбол"})
        Me.ComboSports.Location = New System.Drawing.Point(411, 46)
        Me.ComboSports.Name = "ComboSports"
        Me.ComboSports.Size = New System.Drawing.Size(280, 21)
        Me.ComboSports.TabIndex = 0
        '
        'Analyze
        '
        Me.Analyze.Location = New System.Drawing.Point(501, 116)
        Me.Analyze.Name = "Analyze"
        Me.Analyze.Size = New System.Drawing.Size(123, 29)
        Me.Analyze.TabIndex = 1
        Me.Analyze.Text = "AnalyzeSports"
        Me.Analyze.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Analyze)
        Me.Controls.Add(Me.ComboSports)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboSports As ComboBox
    Friend WithEvents Analyze As Button
End Class
