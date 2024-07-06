Imports System.Diagnostics.Tracing
Imports System.Reflection
Imports GridOnScreenIST.GridPictureBox 'Импорт пространста имен из основной формы
Public Class SetupForm

    Public Sub UpVarForSetupForm()

        'Импорт значений из основной формы

        Me.SGSize.Value = GridPictureBox.SGSizeMesh
        Me.SGValSize.Text = GridPictureBox.SGSizeMesh.ToString
        Me.MGSize.Value = GridPictureBox.MGSizeMesh
        Me.MGValSize.Text = GridPictureBox.MGSizeMesh.ToString
        Me.LGSize.Value = GridPictureBox.LGSizeMesh
        Me.LGValSize.Text = GridPictureBox.LGSizeMesh.ToString
        Me.SGLineThick.Value = GridPictureBox.Pen1.Width
        Me.SGValThick.Text = GridPictureBox.Pen1.Width.ToString
        Me.MGLineThick.Value = GridPictureBox.Pen2.Width
        Me.MGValThick.Text = GridPictureBox.Pen2.Width.ToString
        Me.LGLineThick.Value = GridPictureBox.Pen3.Width
        Me.LGValThick.Text = GridPictureBox.Pen3.Width.ToString
        Me.MeOpacity.Value = GridPictureBox.Opacity * 10
        Me.MeValOpacity.Text = GridPictureBox.Opacity.ToString
    End Sub


    Private Sub SGSetColor_Click(sender As Object, e As EventArgs) Handles SGSetColor.Click

        If SGColor.ShowDialog = DialogResult.OK Then
            GridPictureBox.Pen1.Color = SGColor.Color
            GridPictureBox.ViewPictureBox.Invalidate()
        End If




    End Sub

    Private Sub MGSetColor_Click(sender As Object, e As EventArgs) Handles MGSetColor.Click

        If SGColor.ShowDialog = DialogResult.OK Then
            GridPictureBox.Pen2.Color = SGColor.Color
            GridPictureBox.ViewPictureBox.Invalidate()
        End If


    End Sub

    Private Sub LGSetColor_Click(sender As Object, e As EventArgs) Handles LGSetColor.Click

        If SGColor.ShowDialog = DialogResult.OK Then
            GridPictureBox.Pen3.Color = SGColor.Color
            GridPictureBox.ViewPictureBox.Invalidate()
        End If


    End Sub

    Private Sub SGSize_Scroll(sender As Object, e As EventArgs) Handles SGSize.Scroll
        GridPictureBox.SGSizeMesh = SGSize.Value
        Me.SGValSize.Text = GridPictureBox.SGSizeMesh

        SGSize.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub MGSize_Scroll(sender As Object, e As EventArgs) Handles MGSize.Scroll
        GridPictureBox.MGSizeMesh = MGSize.Value
        Me.MGValSize.Text = GridPictureBox.MGSizeMesh

        MGSize.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub LGSize_Scroll(sender As Object, e As EventArgs) Handles LGSize.Scroll
        GridPictureBox.LGSizeMesh = LGSize.Value
        Me.LGValSize.Text = GridPictureBox.LGSizeMesh

        LGSize.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub SGLineThick_Scroll(sender As Object, e As EventArgs) Handles SGLineThick.Scroll
        GridPictureBox.Pen1.Width = SGLineThick.Value
        Me.SGValThick.Text = GridPictureBox.Pen1.Width

        SGValThick.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub MGLineThick_Scroll(sender As Object, e As EventArgs) Handles MGLineThick.Scroll
        GridPictureBox.Pen2.Width = MGLineThick.Value
        Me.MGValThick.Text = GridPictureBox.Pen2.Width

        MGValThick.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub LGLineThick_Scroll(sender As Object, e As EventArgs) Handles LGLineThick.Scroll
        GridPictureBox.Pen3.Width = LGLineThick.Value
        Me.LGValThick.Text = GridPictureBox.Pen3.Width

        LGValThick.Invalidate()

        GridPictureBox.ViewPictureBox.Invalidate()
    End Sub

    Private Sub MeOpacity_Scroll(sender As Object, e As EventArgs) Handles MeOpacity.Scroll
        GridPictureBox.Opacity = MeOpacity.Value / 10
        Me.MeValOpacity.Text = GridPictureBox.Opacity.ToString
        MeValOpacity.Invalidate()
    End Sub

    Private Sub ResettoDefault_Click(sender As Object, e As EventArgs) Handles resettoDefault.Click
        'Возврат к значениям по умолчанию Цвета и Толщины
        GridPictureBox.Pen1.Color = Color.FromArgb(255, 68, 68)
        GridPictureBox.Pen1.Width = 1
        GridPictureBox.Pen2.Color = Color.FromArgb(255, 0, 0, 255)
        GridPictureBox.Pen2.Width = 2
        GridPictureBox.Pen3.Color = Color.FromArgb(255, 0, 255, 0)
        GridPictureBox.Pen3.Width = 4
        'Возврат к значениям по умолчанию размеров ячейки сетки
        GridPictureBox.SGSizeMesh = 25
        GridPictureBox.MGSizeMesh = 100
        GridPictureBox.LGSizeMesh = 400

        GridPictureBox.Opacity = 0.2



        GridPictureBox.ViewPictureBox.Invalidate()
        UpVarForSetupForm()
        Me.Refresh()
        'Me.Close()
    End Sub


End Class