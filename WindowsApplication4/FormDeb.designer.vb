<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeb
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
        Me.BtnAColec = New System.Windows.Forms.Button()
        Me.btnMColec = New System.Windows.Forms.Button()
        Me.btnSColec = New System.Windows.Forms.Button()
        Me.btnAGamme = New System.Windows.Forms.Button()
        Me.btnAProd = New System.Windows.Forms.Button()
        Me.btnMGamme = New System.Windows.Forms.Button()
        Me.btnMProd = New System.Windows.Forms.Button()
        Me.btnSGamme = New System.Windows.Forms.Button()
        Me.btnSProd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAColec
        '
        Me.BtnAColec.Location = New System.Drawing.Point(12, 39)
        Me.BtnAColec.Name = "BtnAColec"
        Me.BtnAColec.Size = New System.Drawing.Size(146, 23)
        Me.BtnAColec.TabIndex = 0
        Me.BtnAColec.Text = "ajouter une collection"
        Me.BtnAColec.UseVisualStyleBackColor = True
        '
        'btnMColec
        '
        Me.btnMColec.Location = New System.Drawing.Point(176, 39)
        Me.btnMColec.Name = "btnMColec"
        Me.btnMColec.Size = New System.Drawing.Size(146, 23)
        Me.btnMColec.TabIndex = 1
        Me.btnMColec.Text = "modier une collection"
        Me.btnMColec.UseVisualStyleBackColor = True
        '
        'btnSColec
        '
        Me.btnSColec.Location = New System.Drawing.Point(339, 39)
        Me.btnSColec.Name = "btnSColec"
        Me.btnSColec.Size = New System.Drawing.Size(146, 23)
        Me.btnSColec.TabIndex = 2
        Me.btnSColec.Text = "supprimer une collection"
        Me.btnSColec.UseVisualStyleBackColor = True
        '
        'btnAGamme
        '
        Me.btnAGamme.Location = New System.Drawing.Point(12, 90)
        Me.btnAGamme.Name = "btnAGamme"
        Me.btnAGamme.Size = New System.Drawing.Size(146, 23)
        Me.btnAGamme.TabIndex = 3
        Me.btnAGamme.Text = "ajouter une gamme"
        Me.btnAGamme.UseVisualStyleBackColor = True
        '
        'btnAProd
        '
        Me.btnAProd.Location = New System.Drawing.Point(12, 145)
        Me.btnAProd.Name = "btnAProd"
        Me.btnAProd.Size = New System.Drawing.Size(146, 23)
        Me.btnAProd.TabIndex = 4
        Me.btnAProd.Text = "ajouter un produit"
        Me.btnAProd.UseVisualStyleBackColor = True
        '
        'btnMGamme
        '
        Me.btnMGamme.Location = New System.Drawing.Point(176, 90)
        Me.btnMGamme.Name = "btnMGamme"
        Me.btnMGamme.Size = New System.Drawing.Size(146, 23)
        Me.btnMGamme.TabIndex = 5
        Me.btnMGamme.Text = "modier une gamme"
        Me.btnMGamme.UseVisualStyleBackColor = True
        '
        'btnMProd
        '
        Me.btnMProd.Location = New System.Drawing.Point(176, 145)
        Me.btnMProd.Name = "btnMProd"
        Me.btnMProd.Size = New System.Drawing.Size(146, 23)
        Me.btnMProd.TabIndex = 6
        Me.btnMProd.Text = "modier un produit"
        Me.btnMProd.UseVisualStyleBackColor = True
        '
        'btnSGamme
        '
        Me.btnSGamme.Location = New System.Drawing.Point(339, 90)
        Me.btnSGamme.Name = "btnSGamme"
        Me.btnSGamme.Size = New System.Drawing.Size(146, 23)
        Me.btnSGamme.TabIndex = 7
        Me.btnSGamme.Text = "supprimer une gamme"
        Me.btnSGamme.UseVisualStyleBackColor = True
        '
        'btnSProd
        '
        Me.btnSProd.Location = New System.Drawing.Point(339, 145)
        Me.btnSProd.Name = "btnSProd"
        Me.btnSProd.Size = New System.Drawing.Size(146, 23)
        Me.btnSProd.TabIndex = 8
        Me.btnSProd.Text = "supprimer une collection"
        Me.btnSProd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 363)
        Me.Controls.Add(Me.btnSProd)
        Me.Controls.Add(Me.btnSGamme)
        Me.Controls.Add(Me.btnMProd)
        Me.Controls.Add(Me.btnMGamme)
        Me.Controls.Add(Me.btnAProd)
        Me.Controls.Add(Me.btnAGamme)
        Me.Controls.Add(Me.btnSColec)
        Me.Controls.Add(Me.btnMColec)
        Me.Controls.Add(Me.BtnAColec)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAColec As System.Windows.Forms.Button
    Friend WithEvents btnMColec As System.Windows.Forms.Button
    Friend WithEvents btnSColec As System.Windows.Forms.Button
    Friend WithEvents btnAGamme As System.Windows.Forms.Button
    Friend WithEvents btnAProd As System.Windows.Forms.Button
    Friend WithEvents btnMGamme As System.Windows.Forms.Button
    Friend WithEvents btnMProd As System.Windows.Forms.Button
    Friend WithEvents btnSGamme As System.Windows.Forms.Button
    Friend WithEvents btnSProd As System.Windows.Forms.Button

End Class
