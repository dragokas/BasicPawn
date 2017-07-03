﻿'BasicPawn
'Copyright(C) 2017 TheTimocop

'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with this program. If Not, see < http: //www.gnu.org/licenses/>.


Public Class UCProjectBrowser
    Public g_mFormMain As FormMain
    Public g_ClassProjectControl As ClassProjectControl

    Private g_mClipboardFiles As New List(Of String)

    Public Sub New(f As FormMain)
        g_mFormMain = f

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        g_ClassProjectControl = New ClassProjectControl(Me)
    End Sub

    Class ClassProjectControl
        Private g_mUCProjectBrowser As UCProjectBrowser

        Private g_sProjectFile As String = ""
        Private g_bProjectChanged As Boolean = False

        Public Shared g_sProjectExtension As String = ".bpproj"


        Public Sub New(f As UCProjectBrowser)
            g_mUCProjectBrowser = f
        End Sub

        Property m_ProjectFile As String
            Get
                Return g_sProjectFile
            End Get
            Set(value As String)
                If (g_sProjectFile.ToLower <> value.ToLower) Then
                    m_ProjectChanged = False
                End If

                g_sProjectFile = value

                If (Not m_ProjectOpened) Then
                    m_ProjectChanged = False
                End If

                UpdateStatusLabel()
            End Set
        End Property

        ReadOnly Property m_ProjectOpened As Boolean
            Get
                Return (Not String.IsNullOrEmpty(g_sProjectFile))
            End Get
        End Property

        Property m_ProjectChanged As Boolean
            Get
                Return g_bProjectChanged
            End Get
            Set(value As Boolean)
                g_bProjectChanged = value

                UpdateStatusLabel()
            End Set
        End Property

        Public Sub UpdateStatusLabel()
            g_mUCProjectBrowser.g_mFormMain.TabPage_ProjectBrowser.Text = g_mUCProjectBrowser.g_mFormMain.TabPage_ProjectBrowser.Text.TrimEnd("*"c) & If(m_ProjectChanged, "*", "")

            If (Not String.IsNullOrEmpty(g_sProjectFile)) Then
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.Text = String.Format("Project: {0}{1}", IO.Path.GetFileNameWithoutExtension(g_sProjectFile), If(m_ProjectChanged, "*", ""))
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.ToolTipText = g_sProjectFile
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.Visible = True
            Else
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.Visible = False
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.Text = ""
                g_mUCProjectBrowser.g_mFormMain.ToolStripStatusLabel_Project.ToolTipText = ""
            End If
        End Sub

        Public Sub AddFile(sFile As String)
            g_mUCProjectBrowser.ListView_ProjectFiles.Items.Add(New ListViewItem(New String() {IO.Path.GetFileName(sFile), sFile}))

            m_ProjectChanged = True
        End Sub

        Public Sub InsertFile(iIndex As Integer, sFile As String)
            g_mUCProjectBrowser.ListView_ProjectFiles.Items.Insert(iIndex, New ListViewItem(New String() {IO.Path.GetFileName(sFile), sFile}))

            m_ProjectChanged = True
        End Sub

        Public Sub RemoveFileAll(sFile As String)
            For i = g_mUCProjectBrowser.ListView_ProjectFiles.Items.Count - 1 To 0 Step -1
                If (GetFileAt(i).ToLower = sFile.ToLower) Then
                    g_mUCProjectBrowser.ListView_ProjectFiles.Items.RemoveAt(i)
                End If
            Next

            m_ProjectChanged = True
        End Sub

        Public Sub RemoveFileAt(iIndex As Integer)
            g_mUCProjectBrowser.ListView_ProjectFiles.Items.RemoveAt(iIndex)

            m_ProjectChanged = True
        End Sub

        Public Function GetFileAt(iIndex As Integer) As String
            Return g_mUCProjectBrowser.ListView_ProjectFiles.Items(iIndex).SubItems(1).Text
        End Function

        Public Function GetFilesCount() As Integer
            Return g_mUCProjectBrowser.ListView_ProjectFiles.Items.Count
        End Function

        Public Function GetFiles() As String()
            Dim mFileList As New List(Of String)

            For Each mListViewItem As ListViewItem In g_mUCProjectBrowser.ListView_ProjectFiles.Items
                mFileList.Add(mListViewItem.SubItems(1).Text)
            Next

            Return mFileList.ToArray
        End Function

        Public Function IsFileInProject(sFile As String) As Boolean
            For Each sProjectFile As String In GetFiles()
                If (sProjectFile.ToLower = sFile.ToLower) Then
                    Return True
                End If
            Next

            Return False
        End Function

        Public Sub ClearFiles()
            g_mUCProjectBrowser.ListView_ProjectFiles.Items.Clear()

            m_ProjectChanged = True
        End Sub


        Public Function PrompSaveProject(Optional bAlwaysPrompt As Boolean = False, Optional bAlwaysYes As Boolean = False) As Boolean
            If (Not bAlwaysPrompt AndAlso Not g_bProjectChanged) Then
                Return False
            End If

            Select Case (If(bAlwaysYes, DialogResult.Yes, MessageBox.Show("Do you want to save your project?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)))
                Case DialogResult.Yes
                    If (Not m_ProjectOpened) Then
                        Using i As New SaveFileDialog
                            i.Filter = String.Format("BasicPawn Project|*{0}", UCProjectBrowser.ClassProjectControl.g_sProjectExtension)
                            i.FileName = m_ProjectFile

                            If (i.ShowDialog = DialogResult.OK) Then
                                m_ProjectFile = i.FileName
                                SaveProject()

                                g_mUCProjectBrowser.g_mFormMain.g_mUCStartPage.g_mClassRecentItems.AddRecent(m_ProjectFile)
                                g_mUCProjectBrowser.g_mFormMain.ShowPingFlash()

                                Return False
                            Else
                                Return True
                            End If
                        End Using
                    Else
                        SaveProject()

                        g_mUCProjectBrowser.g_mFormMain.g_mUCStartPage.g_mClassRecentItems.AddRecent(m_ProjectFile)
                        g_mUCProjectBrowser.g_mFormMain.ShowPingFlash()

                        Return False
                    End If

                Case DialogResult.No
                    Return False

                Case Else
                    Return True

            End Select
        End Function

        Public Sub SaveProject()
            If (String.IsNullOrEmpty(g_sProjectFile)) Then
                Throw New ArgumentException("Project file path empty")
            End If

            IO.File.WriteAllText(g_sProjectFile, "")

            Dim mIniFile As New ClassIniFile(g_sProjectFile)

            For Each sFile As String In GetFiles()
                mIniFile.WriteKeyValue("Project", Guid.NewGuid.ToString, sFile)
            Next

            m_ProjectChanged = False
            g_mUCProjectBrowser.g_mFormMain.PrintInformation("[INFO]", "User saved project file: " & g_sProjectFile)
        End Sub

        Public Sub LoadProject(bAppend As Boolean)
            If (String.IsNullOrEmpty(g_sProjectFile) OrElse Not IO.File.Exists(g_sProjectFile)) Then
                Throw New ArgumentException("Project file not found")
            End If

            g_mUCProjectBrowser.g_mFormMain.PrintInformation("[INFO]", "User loaded project file: " & g_sProjectFile)

            If (Not bAppend) Then
                ClearFiles()
            End If

            Dim bDidAppend As Boolean = GetFilesCount() > 0

            Dim mIniFile As New ClassIniFile(g_sProjectFile)

            For Each iItem In mIniFile.ReadEverything
                If (iItem.sSection <> "Project") Then
                    Continue For
                End If

                AddFile(iItem.sValue)
                g_mUCProjectBrowser.g_mFormMain.PrintInformation("[INFO]", vbTab & "Loaded project file: " & iItem.sValue)
            Next

            m_ProjectChanged = bDidAppend
        End Sub

        Public Sub CloseProject()
            ClearFiles()
            m_ProjectFile = ""

            m_ProjectChanged = False
        End Sub
    End Class

    Private Sub ToolStripMenuItem_Open_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Open.Click
        Try
            If (ListView_ProjectFiles.SelectedItems.Count < 1) Then
                Return
            End If

            For Each mListViewItem As ListViewItem In ListView_ProjectFiles.SelectedItems
                Dim sFile As String = mListViewItem.SubItems(1).Text

                Dim bFound As Boolean = False
                For i = 0 To g_mFormMain.g_ClassTabControl.m_TabsCount - 1
                    If (Not g_mFormMain.g_ClassTabControl.m_Tab(i).m_IsUnsaved AndAlso g_mFormMain.g_ClassTabControl.m_Tab(i).m_File.ToLower = sFile.ToLower) Then
                        If (g_mFormMain.g_ClassTabControl.m_ActiveTabIndex <> i) Then
                            g_mFormMain.g_ClassTabControl.SelectTab(i)
                        End If

                        bFound = True
                        Exit For
                    End If
                Next
                If (bFound) Then
                    Continue For
                End If

                g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.AddTab(True)
                g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.OpenFileTab(g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.m_TabsCount - 1, sFile)
            Next

            g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.RemoveUnsavedTabsLeft()
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_ProjectSave_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_ProjectSave.Click
        Try
            If (String.IsNullOrEmpty(g_ClassProjectControl.m_ProjectFile)) Then
                Return
            End If

            g_ClassProjectControl.SaveProject()

            g_mFormMain.g_mUCStartPage.g_mClassRecentItems.AddRecent(g_ClassProjectControl.m_ProjectFile)
            g_mFormMain.ShowPingFlash()
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Cut_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Cut.Click
        Try
            If (ListView_ProjectFiles.SelectedItems.Count < 1) Then
                Return
            End If

            g_mClipboardFiles.Clear()

            For i = ListView_ProjectFiles.SelectedItems.Count - 1 To 0 Step -1
                Dim sFile As String = ListView_ProjectFiles.SelectedItems(i).SubItems(1).Text
                Dim iIndex As Integer = ListView_ProjectFiles.SelectedItems(i).Index

                g_mClipboardFiles.Add(sFile)

                g_ClassProjectControl.RemoveFileAt(iIndex)
            Next

            g_mClipboardFiles.Reverse()
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Copy_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Copy.Click
        Try
            If (ListView_ProjectFiles.SelectedItems.Count < 1) Then
                Return
            End If

            g_mClipboardFiles.Clear()

            For i = ListView_ProjectFiles.SelectedItems.Count - 1 To 0 Step -1
                Dim sFile As String = ListView_ProjectFiles.SelectedItems(i).SubItems(1).Text

                g_mClipboardFiles.Add(sFile)
            Next

            g_mClipboardFiles.Reverse()
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Paste_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Paste.Click
        Try
            If (ListView_ProjectFiles.SelectedItems.Count > 0) Then
                Dim iIndex As Integer = ListView_ProjectFiles.SelectedItems(0).Index

                For i = g_mClipboardFiles.Count - 1 To 0 Step -1
                    g_ClassProjectControl.InsertFile(iIndex, g_mClipboardFiles(i))
                Next
            Else
                For i = 0 To g_mClipboardFiles.Count - 1
                    g_ClassProjectControl.AddFile(g_mClipboardFiles(i))
                Next
            End If
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Exlcude_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Exlcude.Click
        Try
            If (ListView_ProjectFiles.SelectedItems.Count < 1) Then
                Return
            End If

            g_mClipboardFiles.Clear()

            For i = ListView_ProjectFiles.SelectedItems.Count - 1 To 0 Step -1
                Dim iIndex As Integer = ListView_ProjectFiles.SelectedItems(i).Index

                g_ClassProjectControl.RemoveFileAt(iIndex)
            Next
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ListView_ProjectFiles_DoubleClick(sender As Object, e As EventArgs) Handles ListView_ProjectFiles.DoubleClick
        Try
            If (ListView_ProjectFiles.SelectedItems.Count < 1) Then
                Return
            End If

            Dim sFile As String = ListView_ProjectFiles.SelectedItems(0).SubItems(1).Text

            For i = 0 To g_mFormMain.g_ClassTabControl.m_TabsCount - 1
                If (Not g_mFormMain.g_ClassTabControl.m_Tab(i).m_IsUnsaved AndAlso g_mFormMain.g_ClassTabControl.m_Tab(i).m_File.ToLower = sFile.ToLower) Then
                    If (g_mFormMain.g_ClassTabControl.m_ActiveTabIndex <> i) Then
                        g_mFormMain.g_ClassTabControl.SelectTab(i)
                    End If

                    Return
                End If
            Next

            g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.AddTab(True)
            g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.OpenFileTab(g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.m_TabsCount - 1, sFile)

            g_mFormMain.g_mUCStartPage.g_mFormMain.g_ClassTabControl.RemoveUnsavedTabsLeft()
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_AddTab_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_AddTab.Click
        Try
            If (g_mFormMain.g_ClassTabControl.m_ActiveTab.m_IsUnsaved) Then
                Return
            End If

            g_ClassProjectControl.AddFile(g_mFormMain.g_ClassTabControl.m_ActiveTab.m_File)
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_AddNewTabs_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_AddNewTabs.Click
        Try
            For i = 0 To g_mFormMain.g_ClassTabControl.m_TabsCount - 1
                If (g_mFormMain.g_ClassTabControl.m_Tab(i).m_IsUnsaved) Then
                    Continue For
                End If

                If (g_ClassProjectControl.IsFileInProject(g_mFormMain.g_ClassTabControl.m_Tab(i).m_File)) Then
                    Continue For
                End If

                g_ClassProjectControl.AddFile(g_mFormMain.g_ClassTabControl.m_Tab(i).m_File)
            Next
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_AddAllTabs_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_AddAllTabs.Click
        Try
            For i = 0 To g_mFormMain.g_ClassTabControl.m_TabsCount - 1
                If (g_mFormMain.g_ClassTabControl.m_Tab(i).m_IsUnsaved) Then
                    Continue For
                End If

                g_ClassProjectControl.AddFile(g_mFormMain.g_ClassTabControl.m_Tab(i).m_File)
            Next
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_AddFiles_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_AddFiles.Click
        Try
            Using i As New OpenFileDialog
                i.Filter = "All supported files|*.sp;*.inc;*.sma|SourcePawn|*.sp|Include|*.inc|Pawn (Not fully supported)|*.pwn;*.p|AMX Mod X|*.sma|All files|*.*"
                i.Multiselect = True

                If (i.ShowDialog = DialogResult.OK) Then
                    For Each sFile As String In i.FileNames
                        g_ClassProjectControl.AddFile(sFile)
                    Next
                End If
            End Using
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ContextMenuStrip_ProjectFiles_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_ProjectFiles.Opening
        ToolStripMenuItem_Open.Enabled = (ListView_ProjectFiles.SelectedItems.Count > 0)
        ToolStripMenuItem_ProjectSave.Enabled = (Not String.IsNullOrEmpty(g_ClassProjectControl.m_ProjectFile))

        ToolStripMenuItem_Cut.Enabled = (ListView_ProjectFiles.SelectedItems.Count > 0)
        ToolStripMenuItem_Copy.Enabled = (ListView_ProjectFiles.SelectedItems.Count > 0)
        ToolStripMenuItem_Paste.Enabled = (g_mClipboardFiles.Count > 0)

        ToolStripMenuItem_AddTab.Enabled = (Not g_mFormMain.g_ClassTabControl.m_ActiveTab.m_IsUnsaved)

        ToolStripMenuItem_Exlcude.Enabled = (ListView_ProjectFiles.SelectedItems.Count > 0)
    End Sub

    Private Sub ClassTextboxWatermark1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextboxWatermark_Search.PreviewKeyDown
        If (e.KeyCode <> Keys.Enter) Then
            Return
        End If

        Dim sSearchText As String = TextboxWatermark_Search.Text
        If (String.IsNullOrEmpty(sSearchText)) Then
            Return
        End If

        'Deselect everything
        For i = 0 To ListView_ProjectFiles.Items.Count - 1
            ListView_ProjectFiles.Items(i).Selected = False
        Next

        For i = 0 To ListView_ProjectFiles.Items.Count - 1
            If (ListView_ProjectFiles.Items(i).SubItems(0).Text.ToLower.Contains(sSearchText.ToLower)) Then
                ListView_ProjectFiles.Items(i).Selected = True
                ListView_ProjectFiles.Items(i).EnsureVisible()
            End If
        Next
    End Sub
End Class