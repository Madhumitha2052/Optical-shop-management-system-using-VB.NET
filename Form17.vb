Imports System.Data.SqlClient

Public Class Form17
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub txtemployeeid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemployeeid.KeyPress
        If e.KeyChar = Chr(13) Then
            txtaddress.Focus()
        End If
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemployeeid.TextChanged
        
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=MADMI\SQLEXPRESS;Initial Catalog=os8;Integrated Security=True;Pooling=False")
        con.Open()
        cmd = New SqlCommand("insert into os8 values('" + txtemployeename.Text + "','" + txtemployeeid.Text + "','" + txtaddress.Text + "','" + txtphonenumber.Text + "','" + txtwork.Text + "','" + txtqualification.Text + "','" + txtexperience.Text + "','" + TextBox1.Text + "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("INSERTED")
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Hide()
        Form5.Show()
    End Sub

    Private Sub txtemployeename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemployeename.KeyPress
        If e.KeyChar = Chr(13) Then
            txtemployeeid.Focus()
        End If
    End Sub

    Private Sub txtemployeename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemployeename.TextChanged

    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtphonenumber.Focus()
        End If
    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtphonenumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphonenumber.KeyPress
        If e.KeyChar = Chr(13) Then
            txtwork.Focus()
        End If
    End Sub

    Private Sub txtphonenumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphonenumber.TextChanged

    End Sub

    Private Sub txtwork_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwork.KeyPress
        If e.KeyChar = Chr(13) Then
            txtqualification.Focus()
        End If
    End Sub

    Private Sub txtwork_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtwork.TextChanged

    End Sub

    Private Sub txtqualification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqualification.KeyPress
        If e.KeyChar = Chr(13) Then
            txtage.Focus()
        End If
    End Sub

    Private Sub txtqualification_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqualification.TextChanged

    End Sub

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtemployeename.Text = " "
        txtemployeeid.Text = " "
        txtaddress.Text = " "
        txtphonenumber.Text = " "
        txtwork.Text = " "
        txtqualification.Text = " "
        txtexperience.Text = " "
        TextBox1.Text = " "
        End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form14.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class