Imports System.Data.SqlClient
Public Class Form4
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim dr As SqlDataReader

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=MADMI\SQLEXPRESS;Initial Catalog=os;Integrated Security=True;Pooling=False")
        con.Open()
        cmd = New SqlCommand("select*from os where USERNAME='" + TextBox1.Text + "' and PASSWORD='" + TextBox2.Text + "'", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Timer1.Enabled = True
        Else
            MessageBox.Show("INVALID USER")
        End If
        con.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value = 100 Then
            Form6.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Hide()
        Form2.Show()
    End Sub
End Class