Public Class Frmvat
    Private Sub Tbprice_TextChanged(sender As Object, e As EventArgs) Handles Tbprice.TextChanged

    End Sub

    Private Sub Bt7p_Click(sender As Object, e As EventArgs) Handles Bt7p.Click
        Dim P As Integer = Tbprice.Text
        Dim seven As Integer = (P * 7) / 100
        Dim sum As Integer = P - seven
        Tbtotal.Text = Format(sum, "#,###.00 Baht")
    End Sub

    Private Sub Bt10p_Click(sender As Object, e As EventArgs) Handles Bt10p.Click
        Dim P As Integer = Tbprice.Text
        Dim ten As Integer = (P * 10) / 100
        Dim sum As Integer = P - ten
        Tbtotal.Text = Format(sum, "#,###.00 Baht")
    End Sub

    Private Sub Bt15p_Click(sender As Object, e As EventArgs) Handles Bt15p.Click
        Dim P As Integer = Tbprice.Text
        Dim fiftheen As Integer = (P * 15) / 100
        Dim sum As Integer = P - fiftheen
        Tbtotal.Text = Format(sum, "#,###.00 Baht")
    End Sub

    Private Sub Tbtotal_TextChanged(sender As Object, e As EventArgs) Handles Tbtotal.TextChanged

    End Sub
End Class
