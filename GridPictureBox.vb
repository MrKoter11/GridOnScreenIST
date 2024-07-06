Public Class GridPictureBox

    'Общие для всех процедур программы переменные размеров толщины линий

    'Общие для всех процедур программы переменные цветов отрисовки
    Friend Pen1 As New Pen(Color.FromArgb(255, 68, 68), 1) 'Цвет мелкой сетки по умолчанию (Красный)
    Friend Pen2 As New Pen(Color.FromArgb(255, 0, 0, 255), 2) 'Цвет средней сетки по умолчанию (Зеленый)
    Friend Pen3 As New Pen(Color.FromArgb(255, 0, 255, 0), 4) 'Цвет крупной сетки по умолчанию (Синий)
    Friend Pen4 As New Pen(Color.GreenYellow, 4) 'Цвет для текста по умолчанию (Зелено-желтый)


    'Общие для всех процедур программы переменные размеров ячеек
    Friend SGSizeMesh As Integer = 25 ' Мелкая
    Friend MGSizeMesh As Integer = 100 ' Средняя
    Friend LGSizeMesh As Integer = 400 ' Крупная


    'Dim SetupForm As New Form



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    'Закрытие по пункту меню иконки в трее
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIcon1.Dispose()

        Close()
    End Sub
    'Процедура рисования сеток (линий), с обозначением размера и переменной цвета, а так же показ номеров

    Public Sub Repaint(ByVal g As Graphics)
        g.Clear(Me.TransparencyKey)
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit

        'Мелкая сетка
        If MenuItemSmallGrid.Checked Then
            DrawGrid(g, SGSizeMesh, Pen1, False)
        End If
        'Средняя сетка
        If MenuItemMediumGrid.Checked Then
            DrawGrid(g, MGSizeMesh, Pen2, True
              )
        End If
        'Крупная сетка
        If MenuItemLargeGrid.Checked Then
            DrawGrid(g, LGSizeMesh, Pen3, True)
        End If


    End Sub
    'Процедура рисования горизонтальных и вертикальных линий
    Public Sub DrawGrid(ByVal G As Graphics, ByVal Size As Integer, ByVal Pen As Pen, ByVal ShowNumbers As Boolean)
        Dim Height As Integer = ViewPictureBox.Height
        For X As Integer = 0 To ViewPictureBox.Width - 1 Step Size
            G.DrawLine(Pen, X, 0, X, Height - 1)
            If ShowNumbers And X <> 0 Then
                Dim S As String = X.ToString()

            End If
        Next

        Dim Width As Integer = ViewPictureBox.Width
        For Y As Integer = 0 To ViewPictureBox.Height - 1 Step Size
            G.DrawLine(Pen, 0, Y, Width - 1, Y)
            If ShowNumbers And Y <> 0 Then
                Dim S As String = Y.ToString()

            End If
        Next
    End Sub

    Public Sub DrawRect(ByVal G As Graphics, ByVal Width As Integer, ByVal Height As Integer, ByVal Pen As Pen)
        G.DrawRectangle(Pen, 0, 0, Width, Height)

        Dim S As String = Width.ToString() + "x" + Height.ToString()


    End Sub
    'Свертывание/Развертывание сетки по команде пункта меню иконки в трее
    Private Sub MinimiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimiseToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Minimized Then

            Me.ShowInTaskbar = True
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            Me.Show() : Me.Activate()
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        Else Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If

    End Sub
    'Свертывание/Развертывание сетки по двойному клику иконки в трее
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then

            Me.ShowInTaskbar = True
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            Me.Show() : Me.Activate()
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        Else Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If


    End Sub
    'Перерисовка сетки при переключение пунктов меню
    Public Sub MenuItemSmallGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSmallGrid.Click
        ViewPictureBox.Invalidate()
    End Sub

    Public Sub MenuItemLargeGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemLargeGrid.Click
        ViewPictureBox.Invalidate()
    End Sub
    Public Sub MenuItemMediumGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemMediumGrid.Click
        ViewPictureBox.Invalidate()
    End Sub
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
    Public Sub ViewPictureBox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ViewPictureBox.Paint
        Repaint(e.Graphics)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ViewPictureBox.Click

    End Sub

    Private Sub ShowSetupForm_Click(sender As Object, e As EventArgs) Handles ShowSetupForm.Click



        SetupForm.Show()
        SetupForm.UpVarForSetupForm()
    End Sub
End Class
