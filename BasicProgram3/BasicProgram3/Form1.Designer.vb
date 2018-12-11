<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmvat
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
        Me.Lbprice = New System.Windows.Forms.Label()
        Me.Tbprice = New System.Windows.Forms.TextBox()
        Me.Lbvat = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Bt7p = New System.Windows.Forms.Button()
        Me.Bt10p = New System.Windows.Forms.Button()
        Me.Bt15p = New System.Windows.Forms.Button()
        Me.Tbtotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbprice
        '
        Me.Lbprice.AutoSize = True
        Me.Lbprice.Location = New System.Drawing.Point(15, 30)
        Me.Lbprice.Name = "Lbprice"
        Me.Lbprice.Size = New System.Drawing.Size(31, 13)
        Me.Lbprice.TabIndex = 0
        Me.Lbprice.Text = "Price"
        '
        'Tbprice
        '
        Me.Tbprice.Location = New System.Drawing.Point(76, 29)
        Me.Tbprice.Name = "Tbprice"
        Me.Tbprice.Size = New System.Drawing.Size(142, 20)
        Me.Tbprice.TabIndex = 1
        '
        'Lbvat
        '
        Me.Lbvat.AutoSize = True
        Me.Lbvat.Location = New System.Drawing.Point(15, 80)
        Me.Lbvat.Name = "Lbvat"
        Me.Lbvat.Size = New System.Drawing.Size(23, 13)
        Me.Lbvat.TabIndex = 2
        Me.Lbvat.Text = "Vat"
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(15, 119)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(31, 13)
        Me.LbTotal.TabIndex = 3
        Me.LbTotal.Text = "Total"
        '
        'Bt7p
        '
        Me.Bt7p.Location = New System.Drawing.Point(79, 77)
        Me.Bt7p.Name = "Bt7p"
        Me.Bt7p.Size = New System.Drawing.Size(37, 19)
        Me.Bt7p.TabIndex = 4
        Me.Bt7p.Text = "7%"
        Me.Bt7p.UseVisualStyleBackColor = True
        '
        'Bt10p
        '
        Me.Bt10p.Location = New System.Drawing.Point(122, 77)
        Me.Bt10p.Name = "Bt10p"
        Me.Bt10p.Size = New System.Drawing.Size(40, 19)
        Me.Bt10p.TabIndex = 5
        Me.Bt10p.Text = "10%"
        Me.Bt10p.UseVisualStyleBackColor = True
        '
        'Bt15p
        '
        Me.Bt15p.Location = New System.Drawing.Point(168, 77)
        Me.Bt15p.Name = "Bt15p"
        Me.Bt15p.Size = New System.Drawing.Size(40, 19)
        Me.Bt15p.TabIndex = 6
        Me.Bt15p.Text = "15%"
        Me.Bt15p.UseVisualStyleBackColor = True
        '
        'Tbtotal
        '
        Me.Tbtotal.Location = New System.Drawing.Point(76, 116)
        Me.Tbtotal.Name = "Tbtotal"
        Me.Tbtotal.ReadOnly = True
        Me.Tbtotal.Size = New System.Drawing.Size(142, 20)
        Me.Tbtotal.TabIndex = 7
        '
        'Frmvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 162)
        Me.Controls.Add(Me.Tbtotal)
        Me.Controls.Add(Me.Bt15p)
        Me.Controls.Add(Me.Bt10p)
        Me.Controls.Add(Me.Bt7p)
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.Lbvat)
        Me.Controls.Add(Me.Tbprice)
        Me.Controls.Add(Me.Lbprice)
        Me.Name = "Frmvat"
        Me.Text = "Vat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbprice As Label
    Friend WithEvents Tbprice As TextBox
    Friend WithEvents Lbvat As Label
    Friend WithEvents LbTotal As Label
    Friend WithEvents Bt7p As Button
    Friend WithEvents Bt10p As Button
    Friend WithEvents Bt15p As Button
    Friend WithEvents Tbtotal As TextBox
End Class
