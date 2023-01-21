Imports System.IO
Module Firstload

    Public Sub fl()

        Dim MainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\theDrawer DATA"

        If Not Directory.Exists(MainPath) Then
            Directory.CreateDirectory(MainPath)
            Dim msg As String
            'If My.Settings.Lang = "Tr" Then msg = "Uyarı, veri klasörü oluşturuldu." Else msg = "Warning, data folder has been created."
            msg = "Data folder has been created!"
            MsgBox(msg, MsgBoxStyle.Information)
        End If
        'Ana klasör MainPath


        If Not Directory.Exists(MainPath + "\Categories") Then
            Directory.CreateDirectory(MainPath + "\Categories")
        End If
        'Kategori klasörü MainPath

    End Sub

End Module
