Imports System.IO
Public Class Form2

    Dim MainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\theDrawer DATA"

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        My.Settings.rel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'geri butonu
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '0,5 sn / 1

        If My.Settings.style = "dark" Then
            RadioButton1.Checked = True
            Me.BackColor = Color.FromArgb(30, 30, 30)
            GroupBox1.ForeColor = Color.White
            GroupBox2.ForeColor = Color.White
            GroupBox3.ForeColor = Color.White
            GroupBox4.ForeColor = Color.White
        Else
            RadioButton2.Checked = True
            Me.BackColor = Color.FromArgb(224, 224, 224)
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            GroupBox3.ForeColor = Color.Black
            GroupBox4.ForeColor = Color.Black
        End If

        '--------------------

        If My.Settings.way = vbNullString Then
            My.Settings.way = "1"

            ComboBox2.SelectedIndex = 0
        ElseIf My.Settings.way = "1" And Not ComboBox2.SelectedIndex = 0 Then
            ComboBox2.SelectedIndex = 0
        ElseIf My.Settings.way = "2" And Not ComboBox2.SelectedIndex = 1 Then
            ComboBox2.SelectedIndex = 1
        ElseIf My.Settings.way = "3" And Not ComboBox2.SelectedIndex = 2 Then
            ComboBox2.SelectedIndex = 2
        End If

        '--------------------

        Try
            If Not My.Settings.ctgr = 0 And Not ComboBox1.SelectedIndex = My.Settings.ctgr - 1 Then
                ComboBox1.SelectedIndex = My.Settings.ctgr - 1
            End If
        Catch ex As Exception
        End Try

        category(1)

        Label2.Text = (TrackBar1.Value * 28) + 28
        Label4.Text = (TrackBar2.Value * 28) + 28
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'radio button 1 (dark style)

        My.Settings.style = "dark"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'radio button 2 (light style)

        My.Settings.style = "light"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'başlangıç

        TrackBar1.Value = (My.Settings.normal - 28) / 28
        TrackBar2.Value = (My.Settings.fulls - 28) / 28


        Timer1.Start()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'başlatma yolu değiştirme

        If ComboBox2.SelectedIndex = 0 Then
            My.Settings.way = "1"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            My.Settings.way = "2"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            My.Settings.way = "3"
        End If
    End Sub

    Private Sub category(mode As Integer)
        If mode = 1 Then 'LOOP reload
            Try
                Dim Kisimleri = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\")
                Dim Ksayisi = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\").Count
                If Not ComboBox1.Items.Count = Ksayisi Then
                    ComboBox1.Items.Clear()
                    For Each isim As String In Kisimleri
                        Dim result As String = Path.GetFileName(isim)
                        ComboBox1.Items.Add(result)
                    Next
                End If
            Catch ex As Exception
            End Try

        ElseIf mode = 2 Then 'FULL reload
            ComboBox1.Items.Clear()

            Try
                Dim Kisimleri = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\")
                Dim Ksayisi = My.Computer.FileSystem.GetDirectories(MainPath + "\Categories\").Count
                For Each isim As String In Kisimleri
                    Dim result As String = Path.GetFileName(isim)
                    ComboBox1.Items.Add(result)
                Next
            Catch ex As Exception
            End Try

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FULL reload
        category(2)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'default category

        My.Settings.ctgr = ComboBox1.SelectedIndex + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'default category clear

        My.Settings.ctgr = 0
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label2.Text = (TrackBar1.Value * 28) + 28
        My.Settings.normal = Label2.Text
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label4.Text = (TrackBar2.Value * 28) + 28
        My.Settings.fulls = Label4.Text
    End Sub
End Class