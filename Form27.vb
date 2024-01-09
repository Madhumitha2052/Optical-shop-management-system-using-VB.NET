Public Class Form27

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Os13DataSet1.os13' table. You can move, or remove it, as needed.
        Me.Os13TableAdapter1.Fill(Me.Os13DataSet1.os13)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form28.show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Hide()
        Form5.Show()
    End Sub
End Class