﻿Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Tam ekran

        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Button2.Text = "Windowed S."
        Else
            Me.WindowState = FormWindowState.Normal
            Button2.Text = "FullScreen"
        End If
        t()

    End Sub
    Private Sub t()
        Dim x As Integer = Me.Width
        Dim y As Integer = Me.Height

        If Me.WindowState = FormWindowState.Maximized Then

            Dim y1 As Integer = y - 485 + 329

            Dim cx As Integer = x - 75 'kontrollü x
            Dim bx As Integer = (cx / 6) 'listbox x
            Dim vx As Integer = (cx / 6) * 2 'listview x


            '---------------

            ListBox2.Width = bx
            ListBox2.Left = x - ListBox2.Width - 24

            ListBox2.Height = y1

            '---------------

            ListView2.Width = vx
            ListView2.Height = y1

            ListView2.Left = ListBox2.Left - ListView2.Width - 15

            '---------------

            ListView1.Width = vx
            ListView1.Height = y1

            ListView1.Left = ListView2.Left - ListView1.Width - 15

            '---------------

            GroupBox1.Width = bx
            GroupBox1.Height = y1 + 5

            ListBox1.Width = bx
            ListBox1.Height = y1 - 13

        Else
            ListBox2.Location = New Point(620, 48)
            ListBox2.Size = New Size(137, 329)

            ListView2.Location = New Point(381, 48)
            ListView2.Size = New Size(220, 330)

            ListView1.Location = New Point(155, 48)
            ListView1.Size = New Size(220, 330)

            GroupBox1.Location = New Point(12, 43)
            GroupBox1.Size = New Size(137, 337)
            ListBox1.Location = New Point(0, 19)
            ListBox1.Size = New Size(137, 316)
        End If



    End Sub
End Class
