<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmajouterproduit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmajouterproduit))
        Me.txtACode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAjoutG = New System.Windows.Forms.Button()
        Me.txtDescC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboColProd = New System.Windows.Forms.ComboBox()
        Me.cboGamProd = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtACode
        '
        Me.txtACode.Location = New System.Drawing.Point(12, 106)
        Me.txtACode.Name = "txtACode"
        Me.txtACode.Size = New System.Drawing.Size(299, 20)
        Me.txtACode.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "nouveau code"
        '
        'btnAjoutG
        '
        Me.btnAjoutG.Location = New System.Drawing.Point(12, 318)
        Me.btnAjoutG.Name = "btnAjoutG"
        Me.btnAjoutG.Size = New System.Drawing.Size(143, 47)
        Me.btnAjoutG.TabIndex = 11
        Me.btnAjoutG.Text = "Valider"
        Me.btnAjoutG.UseVisualStyleBackColor = True
        '
        'txtDescC
        '
        Me.txtDescC.Location = New System.Drawing.Point(12, 184)
        Me.txtDescC.Multiline = True
        Me.txtDescC.Name = "txtDescC"
        Me.txtDescC.Size = New System.Drawing.Size(299, 128)
        Me.txtDescC.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descrpition du produit :"
        '
        'txtNomC
        '
        Me.txtNomC.Location = New System.Drawing.Point(12, 145)
        Me.txtNomC.Name = "txtNomC"
        Me.txtNomC.Size = New System.Drawing.Size(299, 20)
        Me.txtNomC.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom du produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "collection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "gamme"
        '
        'cboColProd
        '
        Me.cboColProd.FormattingEnabled = True
        Me.cboColProd.Location = New System.Drawing.Point(12, 25)
        Me.cboColProd.Name = "cboColProd"
        Me.cboColProd.Size = New System.Drawing.Size(299, 21)
        Me.cboColProd.TabIndex = 16
        '
        'cboGamProd
        '
        Me.cboGamProd.FormattingEnabled = True
        Me.cboGamProd.Location = New System.Drawing.Point(12, 65)
        Me.cboGamProd.Name = "cboGamProd"
        Me.cboGamProd.Size = New System.Drawing.Size(299, 21)
        Me.cboGamProd.TabIndex = 17
        '
        'frmajouterproduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(325, 372)
        Me.Controls.Add(Me.cboGamProd)
        Me.Controls.Add(Me.cboColProd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtACode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAjoutG)
        Me.Controls.Add(Me.txtDescC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmajouterproduit"
        Me.Text = "frmajouterproduit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtACode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAjoutG As System.Windows.Forms.Button
    Friend WithEvents txtDescC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboColProd As System.Windows.Forms.ComboBox
    Friend WithEvents cboGamProd As System.Windows.Forms.ComboBox
End Class
