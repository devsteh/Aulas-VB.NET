﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(82, 49)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(98, 15)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Digite seu Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 81)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(175, 23)
        Me.txtNome.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(82, 138)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(181, 138)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "S&air"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 260)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Primeiro APP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnSair As Button


End Class
