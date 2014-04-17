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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDeb))
        Me.BtnAColec = New System.Windows.Forms.Button()
        Me.btnMColec = New System.Windows.Forms.Button()
        Me.btnSColec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAColec
        '
        Me.BtnAColec.Location = New System.Drawing.Point(12, 12)
        Me.BtnAColec.Name = "BtnAColec"
        Me.BtnAColec.Size = New System.Drawing.Size(289, 23)
        Me.BtnAColec.TabIndex = 0
        Me.BtnAColec.Text = "ajouter une collection"
        Me.BtnAColec.UseVisualStyleBackColor = True
        '
        'btnMColec
        '
        Me.btnMColec.Location = New System.Drawing.Point(12, 41)
        Me.btnMColec.Name = "btnMColec"
        Me.btnMColec.Size = New System.Drawing.Size(289, 23)
        Me.btnMColec.TabIndex = 1
        Me.btnMColec.Text = "modier une collection"
        Me.btnMColec.UseVisualStyleBackColor = True
        '
        'btnSColec
        '
        Me.btnSColec.Location = New System.Drawing.Point(12, 70)
        Me.btnSColec.Name = "btnSColec"
        Me.btnSColec.Size = New System.Drawing.Size(289, 23)
        Me.btnSColec.TabIndex = 2
        Me.btnSColec.Text = "supprimer une collection"
        Me.btnSColec.UseVisualStyleBackColor = True
        '
        'FormDeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(336, 103)
        Me.Controls.Add(Me.btnSColec)
        Me.Controls.Add(Me.btnMColec)
        Me.Controls.Add(Me.BtnAColec)
        Me.Name = "FormDeb"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAColec As System.Windows.Forms.Button
    Friend WithEvents btnMColec As System.Windows.Forms.Button
    Friend WithEvents btnSColec As System.Windows.Forms.Button

End Class
