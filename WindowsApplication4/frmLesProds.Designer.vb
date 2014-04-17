<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesProds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLesProds))
        Me.btnajouterprod = New System.Windows.Forms.Button()
        Me.btnmodifierprod = New System.Windows.Forms.Button()
        Me.btnSuprProd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnajouterprod
        '
        Me.btnajouterprod.Location = New System.Drawing.Point(12, 12)
        Me.btnajouterprod.Name = "btnajouterprod"
        Me.btnajouterprod.Size = New System.Drawing.Size(260, 23)
        Me.btnajouterprod.TabIndex = 0
        Me.btnajouterprod.Text = "ajouter"
        Me.btnajouterprod.UseVisualStyleBackColor = True
        '
        'btnmodifierprod
        '
        Me.btnmodifierprod.Location = New System.Drawing.Point(12, 41)
        Me.btnmodifierprod.Name = "btnmodifierprod"
        Me.btnmodifierprod.Size = New System.Drawing.Size(260, 23)
        Me.btnmodifierprod.TabIndex = 1
        Me.btnmodifierprod.Text = "modifier"
        Me.btnmodifierprod.UseVisualStyleBackColor = True
        '
        'btnSuprProd
        '
        Me.btnSuprProd.Location = New System.Drawing.Point(12, 70)
        Me.btnSuprProd.Name = "btnSuprProd"
        Me.btnSuprProd.Size = New System.Drawing.Size(260, 23)
        Me.btnSuprProd.TabIndex = 2
        Me.btnSuprProd.Text = "suprimmer"
        Me.btnSuprProd.UseVisualStyleBackColor = True
        '
        'frmLesProds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 100)
        Me.Controls.Add(Me.btnSuprProd)
        Me.Controls.Add(Me.btnmodifierprod)
        Me.Controls.Add(Me.btnajouterprod)
        Me.Name = "frmLesProds"
        Me.Text = "Les produits"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnajouterprod As System.Windows.Forms.Button
    Friend WithEvents btnmodifierprod As System.Windows.Forms.Button
    Friend WithEvents btnSuprProd As System.Windows.Forms.Button
End Class
