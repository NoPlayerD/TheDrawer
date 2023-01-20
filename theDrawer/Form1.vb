Public Class Form1

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
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
End Class
