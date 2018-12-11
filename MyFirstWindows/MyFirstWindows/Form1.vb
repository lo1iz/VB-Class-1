Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Student ID: 58121057-2" + Environment.NewLine +
                        "Full name: Tanawat Chinprapinporn" + Environment.NewLine +
                        "Major/Branch: IT/IT" + Environment.NewLine +
                        "Grade: 2.54", "EZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        Me.Close()
    End Sub
End Class
