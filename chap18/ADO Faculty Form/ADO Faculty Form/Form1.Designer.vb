﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Last_NameLabel As System.Windows.Forms.Label
        Me.Faculty2010DataSet = New ADO_Faculty_Form.Faculty2010DataSet()
        Me.FacultyBindingSource = New System.Windows.Forms.BindingSource()
        Me.FacultyTableAdapter = New ADO_Faculty_Form.Faculty2010DataSetTableAdapters.FacultyTableAdapter()
        Me.TableAdapterManager = New ADO_Faculty_Form.Faculty2010DataSetTableAdapters.TableAdapterManager()
        Me.FacultyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FacultyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SortLastNamesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SortLastNamesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Last_NameLabel = New System.Windows.Forms.Label()
        CType(Me.FacultyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacultyBindingNavigator.SuspendLayout()
        Me.SortLastNamesToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Faculty2010DataSet
        '
        Me.Faculty2010DataSet.DataSetName = "Faculty2010DataSet"
        Me.Faculty2010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacultyBindingSource
        '
        Me.FacultyBindingSource.DataMember = "Faculty"
        Me.FacultyBindingSource.DataSource = Me.Faculty2010DataSet
        '
        'FacultyTableAdapter
        '
        Me.FacultyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ADO_Faculty_Form.Faculty2010DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacultyBindingNavigator
        '
        Me.FacultyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacultyBindingNavigator.BindingSource = Me.FacultyBindingSource
        Me.FacultyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacultyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacultyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacultyBindingNavigatorSaveItem})
        Me.FacultyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacultyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacultyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacultyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacultyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacultyBindingNavigator.Name = "FacultyBindingNavigator"
        Me.FacultyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacultyBindingNavigator.Size = New System.Drawing.Size(289, 25)
        Me.FacultyBindingNavigator.TabIndex = 0
        Me.FacultyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FacultyBindingNavigatorSaveItem
        '
        Me.FacultyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacultyBindingNavigatorSaveItem.Enabled = False
        Me.FacultyBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacultyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacultyBindingNavigatorSaveItem.Name = "FacultyBindingNavigatorSaveItem"
        Me.FacultyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FacultyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(102, 82)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 1
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacultyBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(169, 79)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 2
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacultyBindingSource, "Business Phone", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(169, 105)
        Me.MaskedTextBox1.Mask = "(999) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Phone:"
        '
        'SortLastNamesToolStrip
        '
        Me.SortLastNamesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortLastNamesToolStripButton})
        Me.SortLastNamesToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SortLastNamesToolStrip.Name = "SortLastNamesToolStrip"
        Me.SortLastNamesToolStrip.Size = New System.Drawing.Size(111, 25)
        Me.SortLastNamesToolStrip.TabIndex = 5
        Me.SortLastNamesToolStrip.Text = "SortLastNamesToolStrip"
        '
        'SortLastNamesToolStripButton
        '
        Me.SortLastNamesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SortLastNamesToolStripButton.Name = "SortLastNamesToolStripButton"
        Me.SortLastNamesToolStripButton.Size = New System.Drawing.Size(90, 22)
        Me.SortLastNamesToolStripButton.Text = "SortLastNames"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 262)
        Me.Controls.Add(Me.SortLastNamesToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Me.FacultyBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FacultyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacultyBindingNavigator.ResumeLayout(False)
        Me.FacultyBindingNavigator.PerformLayout()
        Me.SortLastNamesToolStrip.ResumeLayout(False)
        Me.SortLastNamesToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Faculty2010DataSet As ADO_Faculty_Form.Faculty2010DataSet
    Friend WithEvents FacultyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacultyTableAdapter As ADO_Faculty_Form.Faculty2010DataSetTableAdapters.FacultyTableAdapter
    Friend WithEvents TableAdapterManager As ADO_Faculty_Form.Faculty2010DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacultyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacultyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SortLastNamesToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents SortLastNamesToolStripButton As System.Windows.Forms.ToolStripButton

End Class
