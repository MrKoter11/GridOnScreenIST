<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridPictureBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridPictureBox))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemSmallGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMediumGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemLargeGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowSetupForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Grid On Screen"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Сетка на экране"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSmallGrid, Me.MenuItemMediumGrid, Me.MenuItemLargeGrid, Me.ToolStripSeparator1, Me.MinimiseToolStripMenuItem, Me.ShowSetupForm, Me.CToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 148)
        '
        'MenuItemSmallGrid
        '
        Me.MenuItemSmallGrid.Checked = True
        Me.MenuItemSmallGrid.CheckOnClick = True
        Me.MenuItemSmallGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemSmallGrid.Name = "MenuItemSmallGrid"
        Me.MenuItemSmallGrid.Size = New System.Drawing.Size(191, 22)
        Me.MenuItemSmallGrid.Text = "Малая сетка"
        '
        'MenuItemMediumGrid
        '
        Me.MenuItemMediumGrid.Checked = True
        Me.MenuItemMediumGrid.CheckOnClick = True
        Me.MenuItemMediumGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemMediumGrid.Name = "MenuItemMediumGrid"
        Me.MenuItemMediumGrid.Size = New System.Drawing.Size(191, 22)
        Me.MenuItemMediumGrid.Text = "Средняя сетка"
        '
        'MenuItemLargeGrid
        '
        Me.MenuItemLargeGrid.Checked = True
        Me.MenuItemLargeGrid.CheckOnClick = True
        Me.MenuItemLargeGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemLargeGrid.Name = "MenuItemLargeGrid"
        Me.MenuItemLargeGrid.Size = New System.Drawing.Size(191, 22)
        Me.MenuItemLargeGrid.Text = "Крупная сетка"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'MinimiseToolStripMenuItem
        '
        Me.MinimiseToolStripMenuItem.Name = "MinimiseToolStripMenuItem"
        Me.MinimiseToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MinimiseToolStripMenuItem.Text = "Свернуть/Развернуть"
        '
        'ShowSetupForm
        '
        Me.ShowSetupForm.Name = "ShowSetupForm"
        Me.ShowSetupForm.Size = New System.Drawing.Size(191, 22)
        Me.ShowSetupForm.Text = "Настройка..."
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(188, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExitToolStripMenuItem.Text = "Закрыть"
        '
        'ViewPictureBox
        '
        Me.ViewPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.ViewPictureBox.Name = "ViewPictureBox"
        Me.ViewPictureBox.Size = New System.Drawing.Size(483, 409)
        Me.ViewPictureBox.TabIndex = 2
        Me.ViewPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 3
        '
        'GridPictureBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(483, 409)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GridPictureBox"
        Me.Opacity = 0.2R
        Me.Text = "Сетка на экране"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Purple
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuItemSmallGrid As ToolStripMenuItem
    Friend WithEvents MenuItemMediumGrid As ToolStripMenuItem
    Friend WithEvents MenuItemLargeGrid As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MinimiseToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ViewPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowSetupForm As ToolStripMenuItem
End Class
