Public Class Form1
    Private Sub Tb1_TextChanged(sender As Object, e As EventArgs) Handles Tb1.TextChanged

    End Sub

    Private Sub Tb2_TextChanged(sender As Object, e As EventArgs) Handles Tb2.TextChanged

    End Sub

    Private Sub Tb3_TextChanged(sender As Object, e As EventArgs) Handles Tb3.TextChanged

    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        Dim num1 As Double = Tb1.Text
        Dim num2 As Double = Tb2.Text

        Dim sum As Double = num1 + num2
        Tb3.Text = sum
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        Dim num1 As Double = Tb1.Text
        Dim num2 As Double = Tb2.Text

        Dim sum As Double = num1 - num2
        Tb3.Text = sum
    End Sub

    Private Sub DB_Click(sender As Object, e As EventArgs) Handles DB.Click
        Dim num1 As Double = Tb1.Text
        Dim num2 As Double = Tb2.Text

        Dim sum As Double = num1 * num2
        Tb3.Text = sum
    End Sub

    Private Sub Mo_Click(sender As Object, e As EventArgs) Handles Mo.Click
        Dim num1 As Double = Tb1.Text
        Dim num2 As Double = Tb2.Text

        Dim sum As Double = num1 / num2
        Tb3.Text = sum
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Tb1.Text = ""
        Tb2.Text = ""
        Tb3.Text = ""
    End Sub
End Class
