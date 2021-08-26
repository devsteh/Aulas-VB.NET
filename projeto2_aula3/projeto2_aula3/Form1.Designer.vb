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
        Me.lblIdade1 = New System.Windows.Forms.Label()
        Me.lblIdade2 = New System.Windows.Forms.Label()
        Me.tbtIdade1 = New System.Windows.Forms.TextBox()
        Me.tbtIdade2 = New System.Windows.Forms.TextBox()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdade1
        '
        Me.lblIdade1.AutoSize = True
        Me.lblIdade1.Location = New System.Drawing.Point(39, 56)
        Me.lblIdade1.Name = "lblIdade1"
        Me.lblIdade1.Size = New System.Drawing.Size(129, 15)
        Me.lblIdade1.TabIndex = 0
        Me.lblIdade1.Text = "Digite a primeira idade:"
        '
        'lblIdade2
        '
        Me.lblIdade2.AutoSize = True
        Me.lblIdade2.Location = New System.Drawing.Point(39, 100)
        Me.lblIdade2.Name = "lblIdade2"
        Me.lblIdade2.Size = New System.Drawing.Size(130, 15)
        Me.lblIdade2.TabIndex = 1
        Me.lblIdade2.Text = "Digite a segunda idade:"
        '
        'tbtIdade1
        '
        Me.tbtIdade1.Location = New System.Drawing.Point(209, 56)
        Me.tbtIdade1.Name = "tbtIdade1"
        Me.tbtIdade1.Size = New System.Drawing.Size(100, 23)
        Me.tbtIdade1.TabIndex = 2
        '
        'tbtIdade2
        '
        Me.tbtIdade2.Location = New System.Drawing.Point(209, 100)
        Me.tbtIdade2.Name = "tbtIdade2"
        Me.tbtIdade2.Size = New System.Drawing.Size(100, 23)
        Me.tbtIdade2.TabIndex = 3
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(116, 179)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(113, 39)
        Me.btnComparar.TabIndex = 4
        Me.btnComparar.Text = "Comprar Idades"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(116, 234)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(113, 37)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "Limpar Dados"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 338)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.tbtIdade2)
        Me.Controls.Add(Me.tbtIdade1)
        Me.Controls.Add(Me.lblIdade2)
        Me.Controls.Add(Me.lblIdade1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdade1 As Label
    Friend WithEvents lblIdade2 As Label
    Friend WithEvents tbtIdade1 As TextBox
    Friend WithEvents tbtIdade2 As TextBox
    Friend WithEvents btnComparar As Button
    Friend WithEvents btnLimpar As Button
End Class
