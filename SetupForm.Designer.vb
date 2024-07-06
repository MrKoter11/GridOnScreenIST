<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim SGDescSize As System.Windows.Forms.Label
        Dim SGDescSizeLine As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.SGColor = New System.Windows.Forms.ColorDialog()
        Me.MGColor = New System.Windows.Forms.ColorDialog()
        Me.LGColor = New System.Windows.Forms.ColorDialog()
        Me.SGSetColor = New System.Windows.Forms.Button()
        Me.SGSize = New System.Windows.Forms.TrackBar()
        Me.SGValSize = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SGLineThick = New System.Windows.Forms.TrackBar()
        Me.SGValThick = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MGLineThick = New System.Windows.Forms.TrackBar()
        Me.MGValThick = New System.Windows.Forms.Label()
        Me.MGSetColor = New System.Windows.Forms.Button()
        Me.MGSize = New System.Windows.Forms.TrackBar()
        Me.MGValSize = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LGLineThick = New System.Windows.Forms.TrackBar()
        Me.LGValThick = New System.Windows.Forms.Label()
        Me.LGSetColor = New System.Windows.Forms.Button()
        Me.LGSize = New System.Windows.Forms.TrackBar()
        Me.LGValSize = New System.Windows.Forms.Label()
        Me.MeOpacity = New System.Windows.Forms.TrackBar()
        Me.MeValOpacity = New System.Windows.Forms.Label()
        Me.resettoDefault = New System.Windows.Forms.Button()
        SGDescSize = New System.Windows.Forms.Label()
        SGDescSizeLine = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SGSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SGLineThick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MGLineThick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LGLineThick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGDescSize
        '
        SGDescSize.AutoSize = True
        SGDescSize.Location = New System.Drawing.Point(109, 16)
        SGDescSize.Name = "SGDescSize"
        SGDescSize.Size = New System.Drawing.Size(143, 13)
        SGDescSize.TabIndex = 8
        SGDescSize.Text = "Размер ячейки в пикселях"
        '
        'SGDescSizeLine
        '
        SGDescSizeLine.AutoSize = True
        SGDescSizeLine.Location = New System.Drawing.Point(326, 11)
        SGDescSizeLine.Name = "SGDescSizeLine"
        SGDescSizeLine.Size = New System.Drawing.Size(86, 13)
        SGDescSizeLine.TabIndex = 11
        SGDescSizeLine.Text = "Толщина линии"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(326, 11)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 13)
        Label1.TabIndex = 11
        Label1.Text = "Толщина линии"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(109, 16)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(143, 13)
        Label4.TabIndex = 8
        Label4.Text = "Размер ячейки в пикселях"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(326, 11)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(86, 13)
        Label6.TabIndex = 11
        Label6.Text = "Толщина линии"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(109, 16)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(143, 13)
        Label8.TabIndex = 8
        Label8.Text = "Размер ячейки в пикселях"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(138, 285)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(137, 13)
        Label2.TabIndex = 13
        Label2.Text = "Прозрачность всех сеток"
        '
        'SGSetColor
        '
        Me.SGSetColor.Location = New System.Drawing.Point(6, 33)
        Me.SGSetColor.Name = "SGSetColor"
        Me.SGSetColor.Size = New System.Drawing.Size(75, 23)
        Me.SGSetColor.TabIndex = 0
        Me.SGSetColor.Text = "Цвет..."
        Me.SGSetColor.UseVisualStyleBackColor = True
        '
        'SGSize
        '
        Me.SGSize.Location = New System.Drawing.Point(123, 30)
        Me.SGSize.Maximum = 400
        Me.SGSize.Minimum = 20
        Me.SGSize.Name = "SGSize"
        Me.SGSize.Size = New System.Drawing.Size(105, 45)
        Me.SGSize.TabIndex = 3
        Me.SGSize.TickFrequency = 10
        Me.SGSize.Value = 20
        '
        'SGValSize
        '
        Me.SGValSize.AutoSize = True
        Me.SGValSize.Location = New System.Drawing.Point(233, 33)
        Me.SGValSize.Name = "SGValSize"
        Me.SGValSize.Size = New System.Drawing.Size(25, 13)
        Me.SGValSize.TabIndex = 6
        Me.SGValSize.Text = "100"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SGDescSizeLine)
        Me.GroupBox1.Controls.Add(Me.SGLineThick)
        Me.GroupBox1.Controls.Add(Me.SGValThick)
        Me.GroupBox1.Controls.Add(SGDescSize)
        Me.GroupBox1.Controls.Add(Me.SGSetColor)
        Me.GroupBox1.Controls.Add(Me.SGSize)
        Me.GroupBox1.Controls.Add(Me.SGValSize)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 81)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сетка 1"
        '
        'SGLineThick
        '
        Me.SGLineThick.Location = New System.Drawing.Point(307, 30)
        Me.SGLineThick.Maximum = 4
        Me.SGLineThick.Minimum = 1
        Me.SGLineThick.Name = "SGLineThick"
        Me.SGLineThick.Size = New System.Drawing.Size(105, 45)
        Me.SGLineThick.TabIndex = 9
        Me.SGLineThick.Value = 1
        '
        'SGValThick
        '
        Me.SGValThick.AutoSize = True
        Me.SGValThick.Location = New System.Drawing.Point(417, 32)
        Me.SGValThick.Name = "SGValThick"
        Me.SGValThick.Size = New System.Drawing.Size(13, 13)
        Me.SGValThick.TabIndex = 10
        Me.SGValThick.Text = "1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.MGLineThick)
        Me.GroupBox2.Controls.Add(Me.MGValThick)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.MGSetColor)
        Me.GroupBox2.Controls.Add(Me.MGSize)
        Me.GroupBox2.Controls.Add(Me.MGValSize)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 81)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Сетка 2"
        '
        'MGLineThick
        '
        Me.MGLineThick.Location = New System.Drawing.Point(307, 28)
        Me.MGLineThick.Maximum = 4
        Me.MGLineThick.Minimum = 1
        Me.MGLineThick.Name = "MGLineThick"
        Me.MGLineThick.Size = New System.Drawing.Size(105, 45)
        Me.MGLineThick.TabIndex = 9
        Me.MGLineThick.Value = 1
        '
        'MGValThick
        '
        Me.MGValThick.AutoSize = True
        Me.MGValThick.Location = New System.Drawing.Point(417, 32)
        Me.MGValThick.Name = "MGValThick"
        Me.MGValThick.Size = New System.Drawing.Size(13, 13)
        Me.MGValThick.TabIndex = 10
        Me.MGValThick.Text = "1"
        '
        'MGSetColor
        '
        Me.MGSetColor.Location = New System.Drawing.Point(6, 33)
        Me.MGSetColor.Name = "MGSetColor"
        Me.MGSetColor.Size = New System.Drawing.Size(75, 23)
        Me.MGSetColor.TabIndex = 0
        Me.MGSetColor.Text = "Цвет..."
        Me.MGSetColor.UseVisualStyleBackColor = True
        '
        'MGSize
        '
        Me.MGSize.Location = New System.Drawing.Point(123, 28)
        Me.MGSize.Maximum = 400
        Me.MGSize.Minimum = 20
        Me.MGSize.Name = "MGSize"
        Me.MGSize.Size = New System.Drawing.Size(105, 45)
        Me.MGSize.TabIndex = 3
        Me.MGSize.TickFrequency = 5
        Me.MGSize.Value = 20
        '
        'MGValSize
        '
        Me.MGValSize.AutoSize = True
        Me.MGValSize.Location = New System.Drawing.Point(233, 33)
        Me.MGValSize.Name = "MGValSize"
        Me.MGValSize.Size = New System.Drawing.Size(25, 13)
        Me.MGValSize.TabIndex = 6
        Me.MGValSize.Text = "100"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.LGLineThick)
        Me.GroupBox3.Controls.Add(Me.LGValThick)
        Me.GroupBox3.Controls.Add(Label8)
        Me.GroupBox3.Controls.Add(Me.LGSetColor)
        Me.GroupBox3.Controls.Add(Me.LGSize)
        Me.GroupBox3.Controls.Add(Me.LGValSize)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 81)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Сетка 3"
        '
        'LGLineThick
        '
        Me.LGLineThick.Location = New System.Drawing.Point(307, 28)
        Me.LGLineThick.Maximum = 4
        Me.LGLineThick.Minimum = 1
        Me.LGLineThick.Name = "LGLineThick"
        Me.LGLineThick.Size = New System.Drawing.Size(105, 45)
        Me.LGLineThick.TabIndex = 9
        Me.LGLineThick.Value = 1
        '
        'LGValThick
        '
        Me.LGValThick.AutoSize = True
        Me.LGValThick.Location = New System.Drawing.Point(417, 32)
        Me.LGValThick.Name = "LGValThick"
        Me.LGValThick.Size = New System.Drawing.Size(13, 13)
        Me.LGValThick.TabIndex = 10
        Me.LGValThick.Text = "1"
        '
        'LGSetColor
        '
        Me.LGSetColor.Location = New System.Drawing.Point(6, 33)
        Me.LGSetColor.Name = "LGSetColor"
        Me.LGSetColor.Size = New System.Drawing.Size(75, 23)
        Me.LGSetColor.TabIndex = 0
        Me.LGSetColor.Text = "Цвет..."
        Me.LGSetColor.UseVisualStyleBackColor = True
        '
        'LGSize
        '
        Me.LGSize.Location = New System.Drawing.Point(123, 28)
        Me.LGSize.Maximum = 400
        Me.LGSize.Minimum = 20
        Me.LGSize.Name = "LGSize"
        Me.LGSize.Size = New System.Drawing.Size(105, 45)
        Me.LGSize.TabIndex = 3
        Me.LGSize.TickFrequency = 5
        Me.LGSize.Value = 20
        '
        'LGValSize
        '
        Me.LGValSize.AutoSize = True
        Me.LGValSize.Location = New System.Drawing.Point(234, 32)
        Me.LGValSize.Name = "LGValSize"
        Me.LGValSize.Size = New System.Drawing.Size(25, 13)
        Me.LGValSize.TabIndex = 6
        Me.LGValSize.Text = "100"
        '
        'MeOpacity
        '
        Me.MeOpacity.Location = New System.Drawing.Point(153, 311)
        Me.MeOpacity.Minimum = 1
        Me.MeOpacity.Name = "MeOpacity"
        Me.MeOpacity.Size = New System.Drawing.Size(104, 45)
        Me.MeOpacity.TabIndex = 12
        Me.MeOpacity.Value = 1
        '
        'MeValOpacity
        '
        Me.MeValOpacity.AutoSize = True
        Me.MeValOpacity.Location = New System.Drawing.Point(266, 318)
        Me.MeValOpacity.Name = "MeValOpacity"
        Me.MeValOpacity.Size = New System.Drawing.Size(22, 13)
        Me.MeValOpacity.TabIndex = 12
        Me.MeValOpacity.Text = "0.2"
        '
        'resettoDefault
        '
        Me.resettoDefault.Location = New System.Drawing.Point(336, 285)
        Me.resettoDefault.Name = "resettoDefault"
        Me.resettoDefault.Size = New System.Drawing.Size(123, 46)
        Me.resettoDefault.TabIndex = 14
        Me.resettoDefault.Text = "Сброс" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "всех значений" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.resettoDefault.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 361)
        Me.Controls.Add(Me.resettoDefault)
        Me.Controls.Add(Me.MeValOpacity)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.MeOpacity)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SetupForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки сетки"
        Me.TopMost = True
        CType(Me.SGSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SGLineThick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MGLineThick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.LGLineThick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGColor As ColorDialog
    Friend WithEvents MGColor As ColorDialog
    Friend WithEvents LGColor As ColorDialog
    Friend WithEvents SGSetColor As Button
    Friend WithEvents SGSize As TrackBar
    Friend WithEvents SGValSize As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SGLineThick As TrackBar
    Friend WithEvents SGValThick As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MGLineThick As TrackBar
    Friend WithEvents MGValThick As Label
    Friend WithEvents MGSetColor As Button
    Friend WithEvents MGSize As TrackBar
    Friend WithEvents MGValSize As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LGLineThick As TrackBar
    Friend WithEvents LGValThick As Label
    Friend WithEvents LGSetColor As Button
    Friend WithEvents LGSize As TrackBar
    Friend WithEvents LGValSize As Label
    Friend WithEvents MeOpacity As TrackBar
    Friend WithEvents MeValOpacity As Label
    Friend WithEvents resettoDefault As Button
End Class
