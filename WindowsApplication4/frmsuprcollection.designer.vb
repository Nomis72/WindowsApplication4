<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuprcollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsuprcollection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSuprC = New System.Windows.Forms.ComboBox()
        Me.btnSuprC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom de la collection"
        '
        'cboSuprC
        '
        Me.cboSuprC.FormattingEnabled = True
        Me.cboSuprC.Location = New System.Drawing.Point(145, 22)
        Me.cboSuprC.Name = "cboSuprC"
        Me.cboSuprC.Size = New System.Drawing.Size(94, 21)
        Me.cboSuprC.TabIndex = 1
        '
        'btnSuprC
        '
        Me.btnSuprC.Location = New System.Drawing.Point(72, 62)
        Me.btnSuprC.Name = "btnSuprC"
        Me.btnSuprC.Size = New System.Drawing.Size(132, 55)
        Me.btnSuprC.TabIndex = 2
        Me.btnSuprC.Text = "supprimer"
        Me.btnSuprC.UseVisualStyleBackColor = True
        '
        'frmsuprcollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 133)
        Me.Controls.Add(Me.btnSuprC)
        Me.Controls.Add(Me.cboSuprC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmsuprcollection"
        Me.Text = "Supprimer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSuprC As System.Windows.Forms.ComboBox
    Friend WithEvents btnSuprC As System.Windows.Forms.Button
End Class
