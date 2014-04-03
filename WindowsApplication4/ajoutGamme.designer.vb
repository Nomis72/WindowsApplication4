<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajoutGamme
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
        Me.nomGamme = New System.Windows.Forms.Label()
        Me.txtNomG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescG = New System.Windows.Forms.RichTextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCollection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'nomGamme
        '
        Me.nomGamme.AutoSize = True
        Me.nomGamme.Location = New System.Drawing.Point(71, 90)
        Me.nomGamme.Name = "nomGamme"
        Me.nomGamme.Size = New System.Drawing.Size(141, 13)
        Me.nomGamme.TabIndex = 0
        Me.nomGamme.Text = "Nom de la nouvelle gamme :"
        '
        'txtNomG
        '
        Me.txtNomG.Location = New System.Drawing.Point(88, 106)
        Me.txtNomG.Name = "txtNomG"
        Me.txtNomG.Size = New System.Drawing.Size(100, 20)
        Me.txtNomG.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description :"
        '
        'txtDescG
        '
        Me.txtDescG.Location = New System.Drawing.Point(27, 145)
        Me.txtDescG.Name = "txtDescG"
        Me.txtDescG.Size = New System.Drawing.Size(231, 96)
        Me.txtDescG.TabIndex = 3
        Me.txtDescG.Text = ""
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(113, 247)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Valider"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sélectionner une collection :"
        '
        'cboCollection
        '
        Me.cboCollection.FormattingEnabled = True
        Me.cboCollection.Location = New System.Drawing.Point(88, 25)
        Me.cboCollection.Name = "cboCollection"
        Me.cboCollection.Size = New System.Drawing.Size(112, 21)
        Me.cboCollection.TabIndex = 6
        '
        'ajoutGamme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.cboCollection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtDescG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomG)
        Me.Controls.Add(Me.nomGamme)
        Me.Name = "ajoutGamme"
        Me.Text = "Ajouter une gamme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomGamme As System.Windows.Forms.Label
    Friend WithEvents txtNomG As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescG As System.Windows.Forms.RichTextBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCollection As System.Windows.Forms.ComboBox

End Class
