Public Class Form14

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Os8DataSet4.os8' table. You can move, or remove it, as needed.
        Me.Os8TableAdapter.Fill(Me.Os8DataSet4.os8)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form17.Hide()
        Form17.Show()
    End Sub
End Class