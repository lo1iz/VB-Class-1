Public Class FrmSum
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btclear.Click
        Tbnum1.Text = ""
        Tbnum2.Text = ""
    End Sub

    Private Sub Tbnum1_TextChanged(sender As Object, e As EventArgs) Handles Tbnum1.TextChanged

    End Sub

    Private Sub Tbnum2_TextChanged(sender As Object, e As EventArgs) Handles Tbnum2.TextChanged

    End Sub

    Private Sub Btsum_Click(sender As Object, e As EventArgs) Handles Btsum.Click
        Dim num1 As Integer = Tbnum1.Text
        Dim num2 As Integer = Tbnum2.Text
        Dim sum As Integer = num1 + num2
        MessageBox.Show(sum, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FrmSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
