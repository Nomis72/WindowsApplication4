<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifierGamme
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.richTxtDescG = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModifG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCollG = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description :"
        '
        'richTxtDescG
        '
        Me.richTxtDescG.Location = New System.Drawing.Point(32, 205)
        Me.richTxtDescG.Name = "richTxtDescG"
        Me.richTxtDescG.Size = New System.Drawing.Size(229, 91)
        Me.richTxtDescG.TabIndex = 3
        Me.richTxtDescG.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modifier le nom :"
        '
        'txtModifG
        '
        Me.txtModifG.Location = New System.Drawing.Point(161, 159)
        Me.txtModifG.Name = "txtModifG"
        Me.txtModifG.Size = New System.Drawing.Size(100, 20)
        Me.txtModifG.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sélectionner collection :"
        '
        'cboCollG
        '
        Me.cboCollG.FormattingEnabled = True
        Me.cboCollG.Location = New System.Drawing.Point(115, 132)
        Me.cboCollG.Name = "cboCollG"
        Me.cboCollG.Size = New System.Drawing.Size(121, 21)
        Me.cboCollG.TabIndex = 8
        '
        'modifierGamme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 328)
        Me.Controls.Add(Me.cboCollG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtModifG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.richTxtDescG)
        Me.Controls.Add(Me.Label2)
        Me.Name = "modifierGamme"
        Me.Text = "modifierGamme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents richTxtDescG As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtModifG As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCollG As System.Windows.Forms.ComboBox
End Class
