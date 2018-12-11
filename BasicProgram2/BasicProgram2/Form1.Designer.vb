<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbnum1 = New System.Windows.Forms.Label()
        Me.Lbnum2 = New System.Windows.Forms.Label()
        Me.Tbnum1 = New System.Windows.Forms.TextBox()
        Me.Tbnum2 = New System.Windows.Forms.TextBox()
        Me.Btsum = New System.Windows.Forms.Button()
        Me.Btclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbnum1
        '
        Me.Lbnum1.AutoSize = True
        Me.Lbnum1.Location = New System.Drawing.Point(12, 26)
        Me.Lbnum1.Name = "Lbnum1"
        Me.Lbnum1.Size = New System.Drawing.Size(50, 13)
        Me.Lbnum1.TabIndex = 0
        Me.Lbnum1.Text = "Number1"
        '
        'Lbnum2
        '
        Me.Lbnum2.AutoSize = True
        Me.Lbnum2.Location = New System.Drawing.Point(12, 56)
        Me.Lbnum2.Name = "Lbnum2"
        Me.Lbnum2.Size = New System.Drawing.Size(50, 13)
        Me.Lbnum2.TabIndex = 1
        Me.Lbnum2.Text = "Number2"
        '
        'Tbnum1
        '
        Me.Tbnum1.Location = New System.Drawing.Point(77, 26)
        Me.Tbnum1.Name = "Tbnum1"
        Me.Tbnum1.Size = New System.Drawing.Size(203, 20)
        Me.Tbnum1.TabIndex = 2
        '
        'Tbnum2
        '
        Me.Tbnum2.Location = New System.Drawing.Point(77, 56)
        Me.Tbnum2.Name = "Tbnum2"
        Me.Tbnum2.Size = New System.Drawing.Size(203, 20)
        Me.Tbnum2.TabIndex = 3
        '
        'Btsum
        '
        Me.Btsum.Location = New System.Drawing.Point(77, 118)
        Me.Btsum.Name = "Btsum"
        Me.Btsum.Size = New System.Drawing.Size(89, 28)
        Me.Btsum.TabIndex = 4
        Me.Btsum.Text = "Sum"
        Me.Btsum.UseVisualStyleBackColor = True
        '
        'Btclear
        '
        Me.Btclear.Location = New System.Drawing.Point(182, 119)
        Me.Btclear.Name = "Btclear"
        Me.Btclear.Size = New System.Drawing.Size(98, 27)
        Me.Btclear.TabIndex = 5
        Me.Btclear.Text = "Clear"
        Me.Btclear.UseVisualStyleBackColor = True
        '
        'FrmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 184)
        Me.Controls.Add(Me.Btclear)
        Me.Controls.Add(Me.Btsum)
        Me.Controls.Add(Me.Tbnum2)
        Me.Controls.Add(Me.Tbnum1)
        Me.Controls.Add(Me.Lbnum2)
        Me.Controls.Add(Me.Lbnum1)
        Me.Name = "FrmSum"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbnum1 As Label
    Friend WithEvents Lbnum2 As Label
    Friend WithEvents Tbnum1 As TextBox
    Friend WithEvents Tbnum2 As TextBox
    Friend WithEvents Btsum As Button
    Friend WithEvents Btclear As Button
End Class
