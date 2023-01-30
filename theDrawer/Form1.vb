Imports System.IO
Imports System.Threading
Imports theDrawer.Firstload
Public Class Form1

    Dim MainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\theDrawer DATA"
    Dim ct As Boolean 'gizleme butonu - ctrl
    Dim countdown As Integer = 0

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

            ListBox2.Location = New Point(635, 48)
            ListBox2.Size = New Size(137, 324)

            ListView2.Location = New Point(395, 48)
            ListView2.Size = New Size(237, 330)

            ListView1.Location = New Point(155, 48)
            ListView1.Size = New Size(237, 330)

            'GroupBox1.Location = New Point(12, 43)
            'GroupBox1.Size = New Size(137, 337)
            ListBox1.Location = New Point(12, 48)
            ListBox1.Size = New Size(137, 329)

            Button2.Location = New Point(682, 12)
            Button4.Location = New Point(697, 386)
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Gizleme
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
        'Ayarlar
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub RELOADS(mode As Integer)

        If mode = 1 Then 'LOOP reload
            'item + folder reload (listbox2)
            Try
                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString
                Dim f1 As Integer = My.Computer.FileSystem.GetFiles(CPath).Count
                Dim f2 As Integer = My.Computer.FileSystem.GetDirectories(CPath).Count
                Dim fsayisi As Integer = f1 + f2
                Dim isayisi As Integer = ListBox2.Items.Count

                If Not isayisi = fsayisi Then
                    ListBox2.Items.Clear()

                    For Each maddeler In My.Computer.FileSystem.GetFiles(CPath)
                        Dim sonuc As String = maddeler.Split("\").Last
                        ListBox2.Items.Add(sonuc)
                    Next
                    For Each maddeler In My.Computer.FileSystem.GetDirectories(CPath)
                        Dim sonuc As String = maddeler.Split("\").Last
                        ListBox2.Items.Add(sonuc)
                    Next
                End If
            Catch ex As Exception
            End Try

            '-----


            'item reload (listview1)
            Try
                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString
                Dim fsayisi As Integer = My.Computer.FileSystem.GetFiles(CPath).Count
                Dim isayisi As Integer = ListView1.Items.Count

                Dim di As New IO.DirectoryInfo(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\")
                If Not isayisi = fsayisi Then
                    imageList1.Images.Clear()
                    ListView1.Items.Clear()
                    ListView1.BeginUpdate()

                    fcontrol(0)

                    For Each fi As IO.FileInfo In di.GetFiles("*")

                        Dim icons As Icon = SystemIcons.WinLogo
                        Dim li As New ListViewItem(fi.Name, 1)

                        If Not (imageList1.Images.ContainsKey(fi.FullName)) Then
                            icons = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName)
                            imageList1.Images.Add(fi.FullName, icons)
                        End If

                        icons = Icon.ExtractAssociatedIcon(fi.FullName)
                        imageList1.Images.Add(icons)
                        ListView1.Items.Add(fi.Name, fi.FullName)
                        ListView1.EndUpdate()
                    Next
                End If
            Catch ex As Exception
            End Try

            '----------
            'folder reload (listview 2)
            Try
                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString
                Dim dsayisi As Integer = My.Computer.FileSystem.GetDirectories(CPath + "\").Count
                Dim odsayisi As Integer = ListView2.Items.Count
                If Not odsayisi = dsayisi Then
                    ListView2.Items.Clear()
                    For Each kats In My.Computer.FileSystem.GetDirectories(CPath)
                        Dim sonuc As String = kats.Split("\").Last
                        ListView2.Items.Add(sonuc, 0)
                    Next
                End If
            Catch ex As Exception
            End Try

            '----------
            'kategori reload (listbox1)
            Try
                Dim Kisimleri = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\")
                Dim Ksayisi = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\").Count
                If Not ListBox1.Items.Count = Ksayisi Then
                    ListBox1.Items.Clear()
                    For Each isim As String In Kisimleri
                        Dim result As String = Path.GetFileName(isim)
                        ListBox1.Items.Add(result)
                    Next
                End If
            Catch ex As Exception
            End Try

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------

        If mode = 2 Then 'CHANGE reload
            Try
                Dim CPath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString

                ListBox2.Items.Clear()

                For Each maddeler In My.Computer.FileSystem.GetFiles(CPath)
                    Dim sonuc As String = maddeler.Split("\").Last
                    ListBox2.Items.Add(sonuc)
                Next
                For Each maddeler In My.Computer.FileSystem.GetDirectories(CPath)
                    Dim sonuc As String = maddeler.Split("\").Last
                    ListBox2.Items.Add(sonuc)
                Next
                '----------
                Dim di As New IO.DirectoryInfo(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\")
                imageList1.Images.Clear()
                ListView1.Items.Clear()
                ListView1.BeginUpdate()

                For Each fi As IO.FileInfo In di.GetFiles("*")

                    Dim icons As Icon = SystemIcons.WinLogo
                    Dim li As New ListViewItem(fi.Name, 1)

                    If Not (imageList1.Images.ContainsKey(fi.FullName)) Then
                        icons = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName)
                        imageList1.Images.Add(fi.FullName, icons)
                    End If

                    icons = Icon.ExtractAssociatedIcon(fi.FullName)
                    imageList1.Images.Add(icons)
                    ListView1.Items.Add(fi.Name, fi.FullName)
                    ListView1.EndUpdate()
                Next

                '----------

                Dim dsayisi As Integer = My.Computer.FileSystem.GetDirectories(CPath + "\").Count
                Dim odsayisi As Integer = ListView2.Items.Count
                ListView2.Items.Clear()
                For Each kats In My.Computer.FileSystem.GetDirectories(CPath)
                    Dim sonuc As String = kats.Split("\").Last
                    ListView2.Items.Add(sonuc, 0)
                Next

            Catch ex As Exception
            End Try

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------

        If mode = 3 Then 'FULL reload
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            imageList1.Images.Clear()

            '----------
            'kategori reload (listbox1)

            Try
                Dim Kisimleri = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\")
                Dim Ksayisi = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\").Count
                For Each isim As String In Kisimleri
                    Dim result As String = Path.GetFileName(isim)
                    ListBox1.Items.Add(result)
                Next
            Catch ex As Exception
            End Try

        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Başlangıç

        Button6.Hide()

        Firstload.fl()

        Timer1.Start()
        KeyPreview = True
        ToolTip1.SetToolTip(Button5, "F5")

        sett()

        If My.Settings.way = "2" Then
            Button2.PerformClick()
        ElseIf My.Settings.way = "3" Then
            Button2.PerformClick()
            Button3.PerformClick()
        End If

        Timer2.Start()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Exit
        Application.Exit()
    End Sub

    Private Sub KlasörToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles KlasorToolStripMenuItem3.Click
        'Create Folder

        Dim name As String
        name = InputBox("Enter a folder name: ")

        Try
            Directory.CreateDirectory(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + name)
        Catch ex As Exception
            MsgBox("Error: code 1")
        End Try

    End Sub

    Private Sub DataLocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLocToolStripMenuItem.Click
        'Data Location
        Try
            Process.Start(MainPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '0,5 sn / 1
        RELOADS(1)

        If Not ListBox1.SelectedIndex >= 0 Then
            CategorieLocToolStripMenuItem.Enabled = False
            DosyaToolStripMenuItem1.Enabled = False
            KlasorToolStripMenuItem2.Enabled = False
            KlasorToolStripMenuItem3.Enabled = False
        Else
            CategorieLocToolStripMenuItem.Enabled = True
            DosyaToolStripMenuItem1.Enabled = True
            KlasorToolStripMenuItem2.Enabled = True
            KlasorToolStripMenuItem3.Enabled = True
        End If

        If Me.WindowState = FormWindowState.Normal Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If

        If My.Settings.rel = True Then
            My.Settings.rel = False
            sett()
        End If

    End Sub

    Private Sub fcontrol(a As Integer)
        Dim file As System.IO.StreamWriter

        If a = 0 Then
            Try
                Dim sayi As Integer = My.Computer.FileSystem.GetFiles(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\").Count
                Dim fils = My.Computer.FileSystem.GetFiles(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\")
                Dim name As String
                For Each nm As String In fils
                    name = Path.GetFileName(nm)
                Next

                If sayi = 1 Then
                    If name = ("DATA CONTROL.txt") Then
                        fcontrol(1)
                    Else
                        file = My.Computer.FileSystem.OpenTextFileWriter(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\DATA CONTROL.txt", True)
                        file.WriteLine("This file appears if there is 1 file in this category; if the number of files exceeds 1, it disappears.")
                        file.Close()
                        Debug.WriteLine("2")
                    End If
                End If
                '--------------------
                If sayi > 1 Then
                    Dim yup As Boolean = False
                    For Each dosya As String In fils
                        Dim sn As String = Path.GetFileName(dosya)

                        If sn = "DATA CONTROL.txt" Then
                            yup = True
                        End If
                    Next
                    If yup = True Then
                        fcontrol(1)
                    End If

                End If


            Catch ex As Exception
            End Try
            '----------------------------------------
        ElseIf a = 1 Then
            Try
                FileSystem.Kill((MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\DATA CONTROL.txt"))
                RELOADS(3)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        'dosya başlatma (listview1)
        ItemStart(ListView1.FocusedItem.Text, 0)
    End Sub

    Private Function ItemStart(item As String, smod As Integer)
        'item başlatma

        Try
            Dim lpath As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\"
            If smod = 0 Then
                Process.Start(lpath + item)
            ElseIf smod = 1 Then

                Dim path As String = lpath
                Dim Proc As String = "Explorer.exe"
                Dim Args As String =
       ControlChars.Quote &
       IO.Path.Combine(path, item) &
       ControlChars.Quote
                Process.Start(Proc, Args)
            End If

        Catch ex As Exception

            Try
                Dim myitem As String = MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + item

                Dim psi = New ProcessStartInfo With {.FileName = "C:\Windows\SysNative\cmd.exe", .Arguments = "/C start """" " + myitem, .UseShellExecute = True, .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden}
                Process.Start(psi)
            Catch exx As Exception
            End Try

        End Try


        Return item
    End Function

    Private Sub CategorieLocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieLocToolStripMenuItem.Click
        'Category Location
        Try
            Process.Start(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseDoubleClick
        'Klasör başlatma (listview2)
        ItemStart(ListView2.FocusedItem.Text, 1)
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        'Item başlatma, klasör/dosya (listbox2)
        ItemStart(ListBox2.SelectedItem.ToString, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Manuel reload
        RELOADS(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Silme

        Dim item
        Dim type As Integer
        Dim err As String
        Dim sure As String
        Dim hta As Boolean = False


        Try
            If ListView1.FocusedItem.Index >= 0 Then
                item = ListView1.FocusedItem.Text
                type = 0
                hta = True
            End If
        Catch ex As Exception
        End Try

        Try
            If ListView2.FocusedItem.Index >= 0 Then
                item = ListView2.FocusedItem.Text
                type = 1
                hta = True
            End If
        Catch ex As Exception
        End Try

        If Not hta = True Then
            Try
                If ListBox1.SelectedIndex >= 0 Then
                    item = ListBox1.SelectedItem.ToString
                    type = 2
                    sure = InputBox("Are you sure about delete the selected category? (y/n):")
                End If
            Catch ex As Exception
            End Try
        End If


        '----------

        Try
            If type = 2 Then
                'kategori
                If sure = "y" Then
                    Dim files As Integer = Directory.GetFiles(MainPath + "\Categories\" + item + "\").Count
                    Dim folders As Integer = Directory.GetDirectories(MainPath + "\Categories\" + item + "\").Count

                    If files > 0 Then
                        FileSystem.Kill(MainPath + "\Categories\" + item + "\*.*")
                    End If

                    If folders > 0 Then
                        For Each folder As String In Directory.GetDirectories(MainPath + "\Categories\" + item + "\")
                            Directory.Delete(folder)
                        Next
                    End If

                    Directory.Delete(MainPath + "\Categories\" + item)
                End If


            ElseIf type = 0 Then
                FileSystem.Kill(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + item)
            ElseIf type = 1 Then
                Directory.Delete(MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + item)
            End If
        Catch ex As Exception
            MsgBox("Please manually delete your files, folders or categories..")
        End Try

        RELOADS(3)
    End Sub

    Private Sub CategorieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieToolStripMenuItem.Click
        'Category oluşturma

        Dim name As String
        name = InputBox("Enter a category name: ")

        Try
            Directory.CreateDirectory(MainPath + "\Categories\" + name)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Kategori değişince - reload
        RELOADS(2)
    End Sub

    Private Sub DosyaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DosyaToolStripMenuItem1.Click
        'Dosya ekleme
        Try
            Dim d As New OpenFileDialog

            d.Multiselect = True
            d.ShowDialog()

            For Each file As String In d.FileNames
                Dim name = file.Split("\").Last
                My.Computer.FileSystem.MoveFile(file, MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + name)
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub KlasorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles KlasorToolStripMenuItem2.Click
        'Klasör ekleme
        Try
            Dim d As New FolderBrowserDialog
            Dim folder As String
            Dim nm As String

            d.ShowDialog()
            folder = d.SelectedPath
            nm = folder.Split("\").Last

            My.Computer.FileSystem.MoveDirectory(folder, MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + nm)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ListView1_GotFocus(sender As Object, e As EventArgs) Handles ListView1.GotFocus
        Try
            ListBox2.SelectedIndex = -1
            ListView2.FocusedItem.Checked = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView2_GotFocus(sender As Object, e As EventArgs) Handles ListView2.GotFocus
        Try
            ListView1.FocusedItem.Checked = False
            ListBox2.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListBox2_GotFocus(sender As Object, e As EventArgs) Handles ListBox2.GotFocus
        Try
            ListView1.FocusedItem.Checked = False
            ListView2.FocusedItem.Checked = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        'dosya başlatma - enter (listview1)
        If e.KeyCode = Keys.Enter Then
            ItemStart(ListView1.FocusedItem.Text, 0)
        End If
    End Sub

    Private Sub ListView2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView2.KeyDown
        'Klasör başlatma - enter (listview2)
        If e.KeyCode = Keys.Enter Then
            ItemStart(ListView2.FocusedItem.Text, 1)
        End If
    End Sub

    Private Sub ListBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox2.KeyDown
        'Item başlatma, klasör/dosya - enter (listbox2)
        If e.KeyCode = Keys.Enter Then
            ItemStart(ListBox2.SelectedItem.ToString, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Manuel reload - key code
        If e.KeyCode = Keys.F5 Then
            RELOADS(3)
        End If
    End Sub
    Private Sub sett()
        'customize app

        If My.Settings.style = vbNullString Then
            My.Settings.style = "dark"
        End If
        If My.Settings.way = vbNullString Then
            My.Settings.way = "1"
        End If

        '--------------------

        If My.Settings.style = "dark" Then
            Me.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
            ListBox1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
            ListView1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
            ListView2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
            ListBox2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)

            ListBox1.ForeColor = Color.White
            ListView1.ForeColor = Color.White
            ListView2.ForeColor = Color.White
            ListBox2.ForeColor = Color.White
        Else
            Me.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
            ListBox1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
            ListView1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
            ListView2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
            ListBox2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)

            ListBox1.ForeColor = Color.Black
            ListView1.ForeColor = Color.Black
            ListView2.ForeColor = Color.Black
            ListBox2.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'default kategoriyi seçme

        Try
            If Not My.Settings.ctgr = 0 Then
                Dim a As Integer = My.Settings.ctgr
                ListBox1.SelectedIndex = a - 1
            End If
        Catch ex As Exception
        End Try

        countdown = countdown + 1
        If countdown = 3 Then Timer2.Stop()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created By. 'NoPlayer.D'" + vbNewLine + "Version: " + Application.ProductVersion + vbNewLine + vbNewLine + vbNewLine + "Thank you for using my app..")
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        'Kategori ekleme
        Try
            Dim d As New FolderBrowserDialog
            Dim folder As String
            Dim nm As String


            d.ShowDialog()
            folder = d.SelectedPath
            nm = folder.Split("\").Last

            My.Computer.FileSystem.MoveDirectory(folder, MainPath + "\Categories\" + nm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        'Listview1 dosya - drag enter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        'Listview1 file - dragdrop
        Dim DroppedItems As String() = e.Data.GetData(DataFormats.FileDrop)

        For Each f In DroppedItems
            Dim myfile As String = f

            FName(myfile).ToString.Remove(FName(myfile).ToString.LastIndexOf("."))
            System.IO.File.Move(myfile, MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + FName(myfile))
        Next

    End Sub

    Public Function FName(path As String)
        'dosya ismini al
        Return System.IO.Path.GetFileName(path)
    End Function

    Private Sub ListView2_DragEnter(sender As Object, e As DragEventArgs) Handles ListView2.DragEnter
        'listview2 klasör - dragenter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub ListView2_DragDrop(sender As Object, e As DragEventArgs) Handles ListView2.DragDrop
        'listview2 klasör - dragdrop
        Dim DroppedItems As String() = e.Data.GetData(DataFormats.FileDrop)

        For Each f In DroppedItems
            Dim myfile As String = f
            Dim myname As String = f.Split("\").Last

            System.IO.Directory.Move(myfile, MainPath + "\Categories\" + ListBox1.SelectedItem.ToString + "\" + myname)
        Next

    End Sub
End Class
