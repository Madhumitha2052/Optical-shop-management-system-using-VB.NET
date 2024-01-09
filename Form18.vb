Public Class Form18

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Os7DataSet4.os7' table. You can move, or remove it, as needed.
        Me.Os7TableAdapter.Fill(Me.Os7DataSet4.os7)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form16.Hide()
        Form16.Show()
    End Sub
End Class