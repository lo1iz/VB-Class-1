<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.N1 = New System.Windows.Forms.Label()
        Me.N2 = New System.Windows.Forms.Label()
        Me.RS = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.Tb2 = New System.Windows.Forms.TextBox()
        Me.Tb3 = New System.Windows.Forms.TextBox()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.DB = New System.Windows.Forms.Button()
        Me.Mo = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'N1
        '
        Me.N1.AutoSize = True
        Me.N1.Location = New System.Drawing.Point(40, 31)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(50, 13)
        Me.N1.TabIndex = 0
        Me.N1.Text = "Number1"
        '
        'N2
        '
        Me.N2.AutoSize = True
        Me.N2.Location = New System.Drawing.Point(40, 79)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(50, 13)
        Me.N2.TabIndex = 1
        Me.N2.Text = "Number2"
        '
        'RS
        '
        Me.RS.AutoSize = True
        Me.RS.Location = New System.Drawing.Point(40, 132)
        Me.RS.Name = "RS"
        Me.RS.Size = New System.Drawing.Size(37, 13)
        Me.RS.TabIndex = 2
        Me.RS.Text = "Result"
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(124, 31)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(165, 20)
        Me.Tb1.TabIndex = 3
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(124, 79)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(165, 20)
        Me.Tb2.TabIndex = 4
        '
        'Tb3
        '
        Me.Tb3.Location = New System.Drawing.Point(124, 129)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.ReadOnly = True
        Me.Tb3.Size = New System.Drawing.Size(165, 20)
        Me.Tb3.TabIndex = 5
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(330, 28)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(30, 25)
        Me.Plus.TabIndex = 6
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(381, 28)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(30, 25)
        Me.Minus.TabIndex = 7
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'DB
        '
        Me.DB.Location = New System.Drawing.Point(330, 76)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(30, 25)
        Me.DB.TabIndex = 8
        Me.DB.Text = "x"
        Me.DB.UseVisualStyleBackColor = True
        '
        'Mo
        '
        Me.Mo.Location = New System.Drawing.Point(381, 76)
        Me.Mo.Name = "Mo"
        Me.Mo.Size = New System.Drawing.Size(30, 25)
        Me.Mo.TabIndex = 9
        Me.Mo.Text = "/"
        Me.Mo.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(330, 124)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(81, 25)
        Me.Clear.TabIndex = 10
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 184)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Mo)
        Me.Controls.Add(Me.DB)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.RS)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.N1)
        Me.Name = "Form1"
        Me.Text = "Calculate Two Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents N1 As Label
    Friend WithEvents N2 As Label
    Friend WithEvents RS As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Tb1 As TextBox
    Friend WithEvents Tb2 As TextBox
    Friend WithEvents Tb3 As TextBox
    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents DB As Button
    Friend WithEvents Mo As Button
    Friend WithEvents Clear As Button
End Class
