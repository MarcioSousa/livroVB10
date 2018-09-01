Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Faculty2010DataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.Faculty2010DataSet.Faculty)

    End Sub

    Private Sub SortLastNamesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortLastNamesToolStripButton.Click
        Try
            Me.FacultyTableAdapter.SortLastNames(Me.Faculty2010DataSet.Faculty)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
