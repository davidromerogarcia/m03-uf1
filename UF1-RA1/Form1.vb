Public Class Form1
    Dim op1 As Integer
    Dim op2 As Integer
    Dim resultado As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sumabtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        resultado = op1 + op2
        Label1.Text = resultado.ToString

    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        resultado = op1 - op2
        Label1.Text = resultado.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
