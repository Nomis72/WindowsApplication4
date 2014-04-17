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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueilgamme))
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(12, 66)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(268, 23)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "supprimer une gamme"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(12, 7)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(268, 23)
        Me.Button21.TabIndex = 1
        Me.Button21.Text = "ajouter un gamme"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(12, 36)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(268, 24)
        Me.Button31.TabIndex = 2
        Me.Button31.Text = "modifier une gamme"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'accueilgamme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(292, 104)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button11)
        Me.Name = "accueilgamme"
        Me.Text = "accueil"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
End Class
