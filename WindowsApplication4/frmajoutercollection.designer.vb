<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmajoutercollection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescC = New System.Windows.Forms.TextBox()
        Me.btnAjoutG = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtACode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom de la collection"
        '
        'txtNomC
        '
        Me.txtNomC.Location = New System.Drawing.Point(177, 42)
        Me.txtNomC.Name = "txtNomC"
        Me.txtNomC.Size = New System.Drawing.Size(100, 20)
        Me.txtNomC.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descrpition de la collection :"
        '
        'txtDescC
        '
        Me.txtDescC.Location = New System.Drawing.Point(16, 118)
        Me.txtDescC.Multiline = True
        Me.txtDescC.Name = "txtDescC"
        Me.txtDescC.Size = New System.Drawing.Size(299, 128)
        Me.txtDescC.TabIndex = 3
        '
        'btnAjoutG
        '
        Me.btnAjoutG.Location = New System.Drawing.Point(101, 252)
        Me.btnAjoutG.Name = "btnAjoutG"
        Me.btnAjoutG.Size = New System.Drawing.Size(143, 47)
        Me.btnAjoutG.TabIndex = 4
        Me.btnAjoutG.Text = "Valider"
        Me.btnAjoutG.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "nouveau code"
        '
        'txtACode
        '
        Me.txtACode.Location = New System.Drawing.Point(177, 11)
        Me.txtACode.Name = "txtACode"
        Me.txtACode.Size = New System.Drawing.Size(100, 20)
        Me.txtACode.TabIndex = 6
        '
        'frmajoutercollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 311)
        Me.Controls.Add(Me.txtACode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAjoutG)
        Me.Controls.Add(Me.txtDescC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmajoutercollection"
        Me.Text = "ajoutercollection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescC As System.Windows.Forms.TextBox
    Friend WithEvents btnAjoutG As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtACode As System.Windows.Forms.TextBox
End Class
