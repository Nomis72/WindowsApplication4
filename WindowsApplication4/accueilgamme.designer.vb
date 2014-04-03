<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accueilgamme
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(30, 36)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "supprimer"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(157, 36)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(75, 23)
        Me.Button21.TabIndex = 1
        Me.Button21.Text = "ajouter"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(94, 65)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 24)
        Me.Button31.TabIndex = 2
        Me.Button31.Text = "modifier"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 132)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button11)
        Me.Name = "accueil"
        Me.Text = "accueil"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
End Class
