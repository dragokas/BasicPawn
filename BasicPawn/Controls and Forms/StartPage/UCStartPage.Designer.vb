﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCStartPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCStartPage))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_BasicPawnTitle = New System.Windows.Forms.Panel()
        Me.LinkLabel_NewTemplate = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_OpenNew = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Open = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_New = New System.Windows.Forms.LinkLabel()
        Me.Panel_FooterDarkControl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_FooterDarkControl2 = New System.Windows.Forms.Panel()
        Me.Panel_FooterDarkControl3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_DelayUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSmall_Close = New BasicPawn.ClassButtonSmallDelete()
        Me.ClassPictureBoxQuality1 = New BasicPawn.ClassPictureBoxQuality()
        Me.TabControl_RecentProjects = New BasicPawn.ClassTabControlColor()
        Me.TabPage_RecentFiles = New System.Windows.Forms.TabPage()
        Me.TabPage_RecentProjects = New System.Windows.Forms.TabPage()
        Me.RecentListBox_Files = New BasicPawn.ClassRecentListBox()
        Me.RecentListBox_Projects = New BasicPawn.ClassRecentListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel_BasicPawnTitle.SuspendLayout()
        CType(Me.ButtonSmall_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_RecentProjects.SuspendLayout()
        Me.TabPage_RecentFiles.SuspendLayout()
        Me.TabPage_RecentProjects.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_FooterDarkControl2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_FooterDarkControl3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 428)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel_BasicPawnTitle, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl_RecentProjects, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 428)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel_BasicPawnTitle
        '
        Me.Panel_BasicPawnTitle.Controls.Add(Me.ButtonSmall_Close)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.LinkLabel_NewTemplate)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.LinkLabel_OpenNew)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.LinkLabel_Open)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.LinkLabel_New)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.Panel_FooterDarkControl)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.ClassPictureBoxQuality1)
        Me.Panel_BasicPawnTitle.Controls.Add(Me.Label1)
        Me.Panel_BasicPawnTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_BasicPawnTitle.Location = New System.Drawing.Point(0, 0)
        Me.Panel_BasicPawnTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_BasicPawnTitle.Name = "Panel_BasicPawnTitle"
        Me.Panel_BasicPawnTitle.Size = New System.Drawing.Size(800, 64)
        Me.Panel_BasicPawnTitle.TabIndex = 0
        '
        'LinkLabel_NewTemplate
        '
        Me.LinkLabel_NewTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_NewTemplate.AutoSize = True
        Me.LinkLabel_NewTemplate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_NewTemplate.Location = New System.Drawing.Point(691, 47)
        Me.LinkLabel_NewTemplate.Name = "LinkLabel_NewTemplate"
        Me.LinkLabel_NewTemplate.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabel_NewTemplate.TabIndex = 8
        Me.LinkLabel_NewTemplate.TabStop = True
        Me.LinkLabel_NewTemplate.Text = "New from template"
        Me.ToolTip1.SetToolTip(Me.LinkLabel_NewTemplate, "Creates a new document from a template")
        '
        'LinkLabel_OpenNew
        '
        Me.LinkLabel_OpenNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_OpenNew.AutoSize = True
        Me.LinkLabel_OpenNew.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_OpenNew.Location = New System.Drawing.Point(456, 47)
        Me.LinkLabel_OpenNew.Name = "LinkLabel_OpenNew"
        Me.LinkLabel_OpenNew.Size = New System.Drawing.Size(106, 13)
        Me.LinkLabel_OpenNew.TabIndex = 7
        Me.LinkLabel_OpenNew.TabStop = True
        Me.LinkLabel_OpenNew.Text = "Open selected new"
        Me.ToolTip1.SetToolTip(Me.LinkLabel_OpenNew, "Closes all opened tabs and opens all selected projects")
        '
        'LinkLabel_Open
        '
        Me.LinkLabel_Open.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Open.AutoSize = True
        Me.LinkLabel_Open.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Open.Location = New System.Drawing.Point(568, 47)
        Me.LinkLabel_Open.Name = "LinkLabel_Open"
        Me.LinkLabel_Open.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel_Open.TabIndex = 6
        Me.LinkLabel_Open.TabStop = True
        Me.LinkLabel_Open.Text = "Open selected"
        Me.ToolTip1.SetToolTip(Me.LinkLabel_Open, "Opens all selected projects")
        '
        'LinkLabel_New
        '
        Me.LinkLabel_New.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_New.AutoSize = True
        Me.LinkLabel_New.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_New.Location = New System.Drawing.Point(655, 47)
        Me.LinkLabel_New.Name = "LinkLabel_New"
        Me.LinkLabel_New.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel_New.TabIndex = 5
        Me.LinkLabel_New.TabStop = True
        Me.LinkLabel_New.Text = "New"
        Me.ToolTip1.SetToolTip(Me.LinkLabel_New, "Creates a new empty document")
        '
        'Panel_FooterDarkControl
        '
        Me.Panel_FooterDarkControl.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_FooterDarkControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_FooterDarkControl.Location = New System.Drawing.Point(0, 63)
        Me.Panel_FooterDarkControl.Name = "Panel_FooterDarkControl"
        Me.Panel_FooterDarkControl.Size = New System.Drawing.Size(800, 1)
        Me.Panel_FooterDarkControl.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BasicPawn - StartPage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_FooterDarkControl2
        '
        Me.Panel_FooterDarkControl2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_FooterDarkControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_FooterDarkControl2.Location = New System.Drawing.Point(0, 514)
        Me.Panel_FooterDarkControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_FooterDarkControl2.Name = "Panel_FooterDarkControl2"
        Me.Panel_FooterDarkControl2.Size = New System.Drawing.Size(800, 1)
        Me.Panel_FooterDarkControl2.TabIndex = 1
        '
        'Panel_FooterDarkControl3
        '
        Me.Panel_FooterDarkControl3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_FooterDarkControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_FooterDarkControl3.Location = New System.Drawing.Point(0, 85)
        Me.Panel_FooterDarkControl3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_FooterDarkControl3.Name = "Panel_FooterDarkControl3"
        Me.Panel_FooterDarkControl3.Size = New System.Drawing.Size(800, 1)
        Me.Panel_FooterDarkControl3.TabIndex = 2
        '
        'Timer_DelayUpdate
        '
        '
        'ButtonSmall_Close
        '
        Me.ButtonSmall_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSmall_Close.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSmall_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSmall_Close.Image = CType(resources.GetObject("ButtonSmall_Close.Image"), System.Drawing.Image)
        Me.ButtonSmall_Close.Location = New System.Drawing.Point(780, 3)
        Me.ButtonSmall_Close.MaximumSize = New System.Drawing.Size(16, 16)
        Me.ButtonSmall_Close.MinimumSize = New System.Drawing.Size(16, 16)
        Me.ButtonSmall_Close.Name = "ButtonSmall_Close"
        Me.ButtonSmall_Close.Size = New System.Drawing.Size(16, 16)
        Me.ButtonSmall_Close.TabIndex = 9
        Me.ButtonSmall_Close.TabStop = False
        '
        'ClassPictureBoxQuality1
        '
        Me.ClassPictureBoxQuality1.Image = Global.BasicPawn.My.Resources.Resources.BasicPawn_NoText_PNGx64
        Me.ClassPictureBoxQuality1.Location = New System.Drawing.Point(3, 3)
        Me.ClassPictureBoxQuality1.m_HighQuality = True
        Me.ClassPictureBoxQuality1.Name = "ClassPictureBoxQuality1"
        Me.ClassPictureBoxQuality1.Size = New System.Drawing.Size(42, 42)
        Me.ClassPictureBoxQuality1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClassPictureBoxQuality1.TabIndex = 1
        Me.ClassPictureBoxQuality1.TabStop = False
        '
        'TabControl_RecentProjects
        '
        Me.TabControl_RecentProjects.Controls.Add(Me.TabPage_RecentFiles)
        Me.TabControl_RecentProjects.Controls.Add(Me.TabPage_RecentProjects)
        Me.TabControl_RecentProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_RecentProjects.Location = New System.Drawing.Point(0, 64)
        Me.TabControl_RecentProjects.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl_RecentProjects.Name = "TabControl_RecentProjects"
        Me.TabControl_RecentProjects.SelectedIndex = 0
        Me.TabControl_RecentProjects.Size = New System.Drawing.Size(800, 364)
        Me.TabControl_RecentProjects.TabIndex = 1
        '
        'TabPage_RecentFiles
        '
        Me.TabPage_RecentFiles.AutoScroll = True
        Me.TabPage_RecentFiles.Controls.Add(Me.RecentListBox_Files)
        Me.TabPage_RecentFiles.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_RecentFiles.Name = "TabPage_RecentFiles"
        Me.TabPage_RecentFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_RecentFiles.Size = New System.Drawing.Size(792, 338)
        Me.TabPage_RecentFiles.TabIndex = 0
        Me.TabPage_RecentFiles.Text = "Recent Files"
        Me.TabPage_RecentFiles.UseVisualStyleBackColor = True
        '
        'TabPage_RecentProjects
        '
        Me.TabPage_RecentProjects.AutoScroll = True
        Me.TabPage_RecentProjects.Controls.Add(Me.RecentListBox_Projects)
        Me.TabPage_RecentProjects.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_RecentProjects.Name = "TabPage_RecentProjects"
        Me.TabPage_RecentProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_RecentProjects.Size = New System.Drawing.Size(792, 338)
        Me.TabPage_RecentProjects.TabIndex = 1
        Me.TabPage_RecentProjects.Text = "Recent Projects"
        Me.TabPage_RecentProjects.UseVisualStyleBackColor = True
        '
        'RecentListBox_Files
        '
        Me.RecentListBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecentListBox_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentListBox_Files.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.RecentListBox_Files.FormattingEnabled = True
        Me.RecentListBox_Files.ItemHeight = 32
        Me.RecentListBox_Files.Location = New System.Drawing.Point(3, 3)
        Me.RecentListBox_Files.Name = "RecentListBox_Files"
        Me.RecentListBox_Files.Size = New System.Drawing.Size(786, 332)
        Me.RecentListBox_Files.TabIndex = 0
        '
        'RecentListBox_Projects
        '
        Me.RecentListBox_Projects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecentListBox_Projects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentListBox_Projects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.RecentListBox_Projects.FormattingEnabled = True
        Me.RecentListBox_Projects.ItemHeight = 32
        Me.RecentListBox_Projects.Location = New System.Drawing.Point(3, 3)
        Me.RecentListBox_Projects.Name = "RecentListBox_Projects"
        Me.RecentListBox_Projects.Size = New System.Drawing.Size(786, 332)
        Me.RecentListBox_Projects.TabIndex = 0
        '
        'UCStartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.BasicPawn.My.Resources.Resources.Bmp_Design
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UCStartPage"
        Me.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel_BasicPawnTitle.ResumeLayout(False)
        Me.Panel_BasicPawnTitle.PerformLayout()
        CType(Me.ButtonSmall_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_RecentProjects.ResumeLayout(False)
        Me.TabPage_RecentFiles.ResumeLayout(False)
        Me.TabPage_RecentProjects.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel_BasicPawnTitle As Panel
    Friend WithEvents ClassPictureBoxQuality1 As ClassPictureBoxQuality
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_FooterDarkControl As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_FooterDarkControl2 As Panel
    Friend WithEvents Panel_FooterDarkControl3 As Panel
    Friend WithEvents Timer_DelayUpdate As Timer
    Friend WithEvents LinkLabel_New As LinkLabel
    Friend WithEvents LinkLabel_Open As LinkLabel
    Friend WithEvents LinkLabel_OpenNew As LinkLabel
    Friend WithEvents TabControl_RecentProjects As ClassTabControlColor
    Friend WithEvents TabPage_RecentFiles As TabPage
    Friend WithEvents TabPage_RecentProjects As TabPage
    Friend WithEvents ButtonSmall_Close As ClassButtonSmallDelete
    Friend WithEvents LinkLabel_NewTemplate As LinkLabel
    Friend WithEvents RecentListBox_Files As ClassRecentListBox
    Friend WithEvents RecentListBox_Projects As ClassRecentListBox
End Class
