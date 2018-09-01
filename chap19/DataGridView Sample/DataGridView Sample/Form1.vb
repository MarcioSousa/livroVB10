Public Class Form1

    Private Sub FacultyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacultyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Faculty2010DataSet)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Faculty2010DataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.Faculty2010DataSet.Faculty)

    End Sub

End Class
