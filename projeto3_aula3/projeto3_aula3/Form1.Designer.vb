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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbNomeAluno = New System.Windows.Forms.TextBox()
        Me.txbRgmAluno = New System.Windows.Forms.TextBox()
        Me.btnExibirAluno = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbTitulo = New System.Windows.Forms.TextBox()
        Me.txbRgmProf = New System.Windows.Forms.TextBox()
        Me.btnExibirProf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RGM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'txbNomeAluno
        '
        Me.txbNomeAluno.Location = New System.Drawing.Point(148, 88)
        Me.txbNomeAluno.Name = "txbNomeAluno"
        Me.txbNomeAluno.Size = New System.Drawing.Size(175, 23)
        Me.txbNomeAluno.TabIndex = 3
        '
        'txbRgmAluno
        '
        Me.txbRgmAluno.Location = New System.Drawing.Point(148, 128)
        Me.txbRgmAluno.Name = "txbRgmAluno"
        Me.txbRgmAluno.Size = New System.Drawing.Size(175, 23)
        Me.txbRgmAluno.TabIndex = 4
        '
        'btnExibirAluno
        '
        Me.btnExibirAluno.Location = New System.Drawing.Point(353, 88)
        Me.btnExibirAluno.Name = "btnExibirAluno"
        Me.btnExibirAluno.Size = New System.Drawing.Size(75, 23)
        Me.btnExibirAluno.TabIndex = 5
        Me.btnExibirAluno.Text = "Exibir"
        Me.btnExibirAluno.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Professor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Título:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nome:"
        '
        'txbTitulo
        '
        Me.txbTitulo.Location = New System.Drawing.Point(148, 237)
        Me.txbTitulo.Name = "txbTitulo"
        Me.txbTitulo.Size = New System.Drawing.Size(175, 23)
        Me.txbTitulo.TabIndex = 9
        '
        'txbRgmProf
        '
        Me.txbRgmProf.Location = New System.Drawing.Point(148, 295)
        Me.txbRgmProf.Name = "txbRgmProf"
        Me.txbRgmProf.Size = New System.Drawing.Size(175, 23)
        Me.txbRgmProf.TabIndex = 10
        '
        'btnExibirProf
        '
        Me.btnExibirProf.Location = New System.Drawing.Point(353, 231)
        Me.btnExibirProf.Name = "btnExibirProf"
        Me.btnExibirProf.Size = New System.Drawing.Size(75, 23)
        Me.btnExibirProf.TabIndex = 11
        Me.btnExibirProf.Text = "Exibir"
        Me.btnExibirProf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 341)
        Me.Controls.Add(Me.btnExibirProf)
        Me.Controls.Add(Me.txbRgmProf)
        Me.Controls.Add(Me.txbTitulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExibirAluno)
        Me.Controls.Add(Me.txbRgmAluno)
        Me.Controls.Add(Me.txbNomeAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sistema Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbNomeAluno As TextBox
    Friend WithEvents txbRgmAluno As TextBox
    Friend WithEvents btnExibirAluno As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbTitulo As TextBox
    Friend WithEvents txbRgmProf As TextBox
    Friend WithEvents btnExibirProf As Button



End Class
