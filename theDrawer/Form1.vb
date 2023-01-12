Public Class Form1
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

            Dim x1 As Integer = x - 785
            Dim y1 As Integer = y - 485

            Dim dx As Integer = x1 / 4



            ListBox2.Width = ListBox2.Width + dx
            ListBox2.Left = x - ListBox2.Width - 24

            ListBox2.Height = ListBox2.Height + y1
        Else
            ListBox2.Location = New Point(620, 48)
            ListBox2.Size = New Size(137, 329)
        End If



    End Sub
End Class
