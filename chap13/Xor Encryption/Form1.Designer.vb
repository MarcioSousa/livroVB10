<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertDateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenItem, Me.mnuCloseItem, Me.mnuSaveAsItem, Me.mnuInsertDateItem, Me.mnuExitItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuOpenItem
        '
        Me.mnuOpenItem.Name = "mnuOpenItem"
        Me.mnuOpenItem.Size = New System.Drawing.Size(200, 22)
        Me.mnuOpenItem.Text = "Open Encrypted File..."
        '
        'mnuCloseItem
        '
        Me.mnuCloseItem.Enabled = False
        Me.mnuCloseItem.Name = "mnuCloseItem"
        Me.mnuCloseItem.Size = New System.Drawing.Size(200, 22)
        Me.mnuCloseItem.Text = "Close"
        '
        'mnuSaveAsItem
        '
        Me.mnuSaveAsItem.Name = "mnuSaveAsItem"
        Me.mnuSaveAsItem.Size = New System.Drawing.Size(200, 22)
        Me.mnuSaveAsItem.Text = "Save Encrypted File As..."
        '
        'mnuInsertDateItem
        '
        Me.mnuInsertDateItem.Name = "mnuInsertDateItem"
        Me.mnuInsertDateItem.Size = New System.Drawing.Size(200, 22)
        Me.mnuInsertDateItem.Text = "Insert Date"
        '
        'mnuExitItem
        '
        Me.mnuExitItem.Name = "mnuExitItem"
        Me.mnuExitItem.Size = New System.Drawing.Size(200, 22)
        Me.mnuExitItem.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(24, 61)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(319, 225)
        Me.txtNote.TabIndex = 1
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(21, 33)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(254, 13)
        Me.lblNote.TabIndex = 2
        Me.lblNote.Text = "Type some text and then use Encryption commands."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 321)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Xor Encryption"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCloseItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAsItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInsertDateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents mnuOpenItem As System.Windows.Forms.ToolStripMenuItem

End Class
