Public Class autoupdate
    Private Sub autoupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForUpdates()
    End Sub
    Public Sub CheckForUpdates()
        'Скачиваем, распаковываем, читаем. Если версия изменилась, будем качать новый exe файл. Иначе прога работает в штатном режиме
        Dim verfile As String = Application.StartupPath & "\version.txt" 'Путь к программе, откуда запущена и файл с версией
        Dim Curver As String = My.Application.Info.Version.ToString
        ' если файл был скачан ранее - удаляем его
        If My.Computer.FileSystem.FileExists(verfile) Then My.Computer.FileSystem.DeleteFile(verfile)
        My.Computer.Network.DownloadFile("http://portal2015.css-rzd.local:9999/version.txt", verfile) 'скачиваем новый файл из удаленного хранилища
        Dim LastVer As String = My.Computer.FileSystem.ReadAllText(verfile)
        If Not Curver = LastVer Then 'если текущая версия не равна последней версии
            If MsgBox("Доступно обновление" & vbCrLf & "Скачать?", vbYesNo) = MsgBoxResult.Yes Then 'Если в окошке нажата кнопка Yes
                Shell("updater.exe") 'Запускаем внешний файл updater.exe, который должен лежать в каталоге с нашей программой
            End If
        End If
    End Sub
End Class