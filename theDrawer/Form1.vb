Imports System.IO
Imports theDrawer.Firstload
Public Class Form1

    Dim MainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\theDrawer DATA"
    Dim ct As Boolean 'gizleme butonu - ctrl

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Tam ekran

        If Me.WindowState = FormWindowState.Normal Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Button2.Text = "Windowed S."
        Else
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.WindowState = FormWindowState.Normal
            Button2.Text = "FullScreen"
        End If
        t(1)

    End Sub
    Private Sub t(mode As Integer)
        Dim x As Integer = Me.Width
        Dim y As Integer = Me.Height


        If Me.WindowState = FormWindowState.Maximized Then
            Dim y1 As Integer = y - 154
            Dim cx As Integer = x - 75 'kontrollü x


            If mode = 1 Then
                Dim bx As Integer = (cx / 6) 'listbox x
                Dim vx As Integer = (cx / 6) * 2 'listview x
                ListBox1.Show()
                '----------------
                ListBox2.Width = bx
                ListBox2.Left = x - ListBox2.Width - 24
                ListBox2.Height = y1 + 10
                '---------------
                ListView2.Width = vx
                ListView2.Height = y1
                ListView2.Left = ListBox2.Left - ListView2.Width - 15
                '---------------
                ListView1.Width = vx
                ListView1.Height = y1
                ListView1.Left = ListView2.Left - ListView1.Width - 15
                '---------------
                'GroupBox1.Width = bx
                'GroupBox1.Height = y1 + 5
                '---------------
                ListBox1.Width = bx
                ListBox1.Height = y1 + 10
                '---------------
                Button2.Left = ListBox2.Left + ListBox2.Width - Button2.Width
                Button4.Left = ListBox2.Left + ListBox2.Width - Button4.Width

            ElseIf mode = 2 Then
                Dim bx As Integer = (cx / 5)
                Dim vx As Integer = (cx / 5) * 2
                ListBox1.Hide()
                '----------------
                ListBox2.Width = bx
                ListBox2.Left = x - ListBox2.Width - 24
                ListBox2.Height = y1 + 10
                '---------------
                ListView2.Width = vx
                ListView2.Height = y1
                ListView2.Left = ListBox2.Left - ListView2.Width - 15
                '---------------
                ListView1.Width = vx
                ListView1.Height = y1
                ListView1.Left = Button1.Left 'ListView2.Left - ListView1.Width - 15
                ListView2.Left = ListView1.Left + ListView1.Width + 10
            End If
            Button6.Left = ListView1.Left
            Button6.Width = ListView1.Width * 2 + 15
            Button6.Show()

        Else

            ListBox1.Show()
            Button6.Hide()

            ListBox2.Location = New Point(620, 48)
            ListBox2.Size = New Size(137, 329)

            ListView2.Location = New Point(381, 48)
            ListView2.Size = New Size(220, 330)

            ListView1.Location = New Point(155, 48)
            ListView1.Size = New Size(220, 330)

            'GroupBox1.Location = New Point(12, 43)
            'GroupBox1.Size = New Size(137, 337)
            ListBox1.Location = New Point(12, 48)
            ListBox1.Size = New Size(137, 329)

            Button2.Location = New Point(667, 12)
            Button4.Location = New Point(682, 386)
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ct = False Then
            t(2)
            ct = True
            Exit Sub
        End If

        If ct = True Then
            t(1)
            ct = False
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button6.Hide()

        Firstload.fl()

        Timer1.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub KlasörToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles KlasörToolStripMenuItem3.Click

        Dim name As String
        name = InputBox("Enter a folder name: ")

        Try
            Directory.CreateDirectory(MainPath + "\Categories\" + name)
        Catch ex As Exception
            MsgBox("Error: code 1")
        End Try

    End Sub

    Private Sub DataLocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLocToolStripMenuItem.Click
        Process.Start(MainPath)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Reload("all")
    End Sub

    Private Function Reload(c As String)
        'reloads

        Try

            'item reload (listbox, listview)
            If c = "item" Then

                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString
                Dim fsayisi As Integer = My.Computer.FileSystem.GetFiles(CPath).Count
                Dim isayisi As Integer = ListBox2.Items.Count
                If Not isayisi = fsayisi Then
                    ListBox2.Items.Clear()
                    For Each maddeler In My.Computer.FileSystem.GetFiles(CPath)
                        Dim sonuc As String = maddeler.Split("\").Last
                        ListBox2.Items.Add(sonuc)
                    Next
                End If
                '--------------------------------------------------
                Dim di As New IO.DirectoryInfo(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\")
                If Not fsayisi = isayisi Then
                    ImageList1.Images.Clear()
                    ListView1.Items.Clear()
                    ListView1.BeginUpdate()
                    For Each fi As IO.FileInfo In di.GetFiles("*")

                        Dim icons As Icon = SystemIcons.WinLogo
                        Dim li As New ListViewItem(fi.Name, 1)

                        If Not (ImageList1.Images.ContainsKey(fi.FullName)) Then
                            icons = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName)
                            ImageList1.Images.Add(fi.FullName, icons)
                        End If

                        icons = Icon.ExtractAssociatedIcon(fi.FullName)
                        ImageList1.Images.Add(icons)
                        ListView1.Items.Add(fi.Name, fi.FullName)

                        ListView1.EndUpdate()
                    Next
                End If
            End If

            '----------------------------------------------------------------------------------------------------

            'klasör reload
            If c = "folder" Then

                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString
                Dim dsayisi As Integer = My.Computer.FileSystem.GetDirectories(CPath + "\").Count
                Dim odsayisi As Integer = ListView2.Items.Count
                If Not odsayisi = dsayisi Then
                    ListView2.Items.Clear()
                    For Each kats In My.Computer.FileSystem.GetDirectories(CPath)
                        Dim sonuc As String = kats.Split("\").Last
                        ListView2.Items.Add(sonuc)
                    Next
                End If
            End If

            '----------------------------------------------------------------------------------------------------

            'kategori reload
            If c = "category" Then
                Dim Kisimleri = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\")
                Dim Ksayisi = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\").Count
                If Not ListBox1.Items.Count = Ksayisi Then
                    ListBox1.Items.Clear()
                    For Each isim As String In Kisimleri
                        Dim result As String = Path.GetFileName(isim)
                        ListBox1.Items.Add(result)
                    Next
                End If
            End If

            '----------------------------------------------------------------------------------------------------

            If c = "all" Then
                Reload("item")
                Reload("category")
                Reload("folder")
            End If

        Catch ex As Exception
        End Try

        Return c
    End Function
End Class
