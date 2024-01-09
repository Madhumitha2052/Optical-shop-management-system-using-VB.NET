Imports System.Data.SqlClient
Public Class Form16
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        con = New SqlConnection("Data Source=MADMI\SQLEXPRESS;Initial Catalog=os7;Integrated Security=True;Pooling=False")
        con.Open()
        cmd = New SqlCommand("insert into os7 values('" + txtsalary.Text + "','" + txthrc.Text + "','" + txtdf.Text + "','" + txttf.Text + "','" + txtpf.Text + "','" + txtlic.Text + "','" + txtgpay.Text + "','" + txtdirector.Text + "','" + txtnpay.Text + "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("INSERTED")
        con.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txthrc.Focus()
            txthrc.Text = Val(txtsalary.Text) * 0.015
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalary.TextChanged

    End Sub

    Private Sub txthrc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthrc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdf.Focus()
            txtdf.Text = Val(txtsalary.Text) * 0.01
        End If
    End Sub

    Private Sub txthrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthrc.TextChanged

    End Sub

    Private Sub txtdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttf.Focus()
            txttf.Text = Val(txtsalary.Text) * 0.02
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdf.TextChanged

    End Sub

    Private Sub txttf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpf.Focus()
            txtpf.Text = Val(txtsalary.Text) * 0.1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttf.TextChanged

    End Sub

    Private Sub txtpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtlic.Focus()
            txtlic.Text = Val(txtsalary.Text) * 0.03
        End If
    End Sub

    Private Sub txtpf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpf.TextChanged

    End Sub

    Private Sub txtlic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlic.KeyPress
        If Asc(e.KeyChar) Then
            txtgpay.Focus()
            txtgpay.Text = Val(txtsalary.Text) + Val(txthrc.Text) + Val(txtdf.Text) + Val(txttf.Text)
        End If
    End Sub

    Private Sub txtlic_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlic.MouseHover

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlic.TextChanged

    End Sub

    Private Sub txtgpay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgpay.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdirector.Focus()
            txtdirector.Text = Val(txtpf.Text) + Val(txtlic.Text)
        End If
    End Sub

    Private Sub txtgpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgpay.TextChanged

    End Sub

    Private Sub txtdirector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdirector.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnpay.Focus()
            txtnpay.Text = Val(txtgpay.Text) - Val(txtdirector.Text)
        End If
    End Sub

    Private Sub txtdirector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdirector.TextChanged

    End Sub

    Private Sub txtnpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnpay.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form18.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form5.Hide()
        Form5.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtsalary.Text = " "
        txthrc.Text = " "
        txtdf.Text = " "
        txttf.Text = " "
        txtpf.Text = " "
        txtlic.Text = " "
        txtgpay.Text = " "
        txtdirector.Text = " "
        txtnpay.Text = " "
       End Sub
End Class