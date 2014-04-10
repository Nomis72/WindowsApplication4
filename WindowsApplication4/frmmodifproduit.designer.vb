<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmodifproduit
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
        Me.cboMGamProd = New System.Windows.Forms.ComboBox()
        Me.cboColl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtACode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAjoutG = New System.Windows.Forms.Button()
        Me.txtDescC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboMProd = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboMGamProd
        '
        Me.cboMGamProd.FormattingEnabled = True
        Me.cboMGamProd.Location = New System.Drawing.Point(176, 60)
        Me.cboMGamProd.Name = "cboMGamProd"
        Me.cboMGamProd.Size = New System.Drawing.Size(121, 21)
        Me.cboMGamProd.TabIndex = 28
        '
        'cboColl
        '
        Me.cboColl.FormattingEnabled = True
        Me.cboColl.Location = New System.Drawing.Point(176, 24)
        Me.cboColl.Name = "cboColl"
        Me.cboColl.Size = New System.Drawing.Size(121, 21)
        Me.cboColl.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "gamme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "collection"
        '
        'txtACode
        '
        Me.txtACode.Location = New System.Drawing.Point(176, 136)
        Me.txtACode.Name = "txtACode"
        Me.txtACode.Size = New System.Drawing.Size(100, 20)
        Me.txtACode.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "nouveau code"
        '
        'btnAjoutG
        '
        Me.btnAjoutG.Location = New System.Drawing.Point(106, 346)
        Me.btnAjoutG.Name = "btnAjoutG"
        Me.btnAjoutG.Size = New System.Drawing.Size(143, 47)
        Me.btnAjoutG.TabIndex = 22
        Me.btnAjoutG.Text = "Valider"
        Me.btnAjoutG.UseVisualStyleBackColor = True
        '
        'txtDescC
        '
        Me.txtDescC.Location = New System.Drawing.Point(18, 212)
        Me.txtDescC.Multiline = True
        Me.txtDescC.Name = "txtDescC"
        Me.txtDescC.Size = New System.Drawing.Size(299, 128)
        Me.txtDescC.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Descrpition du produit :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "produit"
        '
        'cboMProd
        '
        Me.cboMProd.FormattingEnabled = True
        Me.cboMProd.Location = New System.Drawing.Point(176, 97)
        Me.cboMProd.Name = "cboMProd"
        Me.cboMProd.Size = New System.Drawing.Size(121, 21)
        Me.cboMProd.TabIndex = 30
        '
        'frmmodifproduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 471)
        Me.Controls.Add(Me.cboMProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboMGamProd)
        Me.Controls.Add(Me.cboColl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtACode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAjoutG)
        Me.Controls.Add(Me.txtDescC)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmmodifproduit"
        Me.Text = "frmmodifproduit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMGamProd As System.Windows.Forms.ComboBox
    Friend WithEvents cboColl As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtACode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAjoutG As System.Windows.Forms.Button
    Friend WithEvents txtDescC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMProd As System.Windows.Forms.ComboBox
End Class
