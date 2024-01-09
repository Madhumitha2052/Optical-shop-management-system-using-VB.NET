Imports System.Data.SqlClient
Public Class Form25
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim dr As SqlDataReader
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=MADMI\SQLEXPRESS;Initial Catalog=os;Integrated Security=True;Pooling=False")
        con.Open()
        cmd = New SqlCommand("insert into os values ('" + TextBox1.Text + "','" + TextBox3.Text + "')", con)
        dr = cmd.ExecuteReader
        If TextBox2.Text = TextBox3.Text Then
            MsgBox("NEW USER ADDED")
            Form6.Show()
        Else
            MsgBox("CHECK THE PASSWORD")
        End If
        con.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Hide()
        Form2.Show()
    End Sub
End Class