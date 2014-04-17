<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmodifcollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmodifcollection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboModifC = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMdesc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nom de la collection a modifier"
        '
        'cboModifC
        '
        Me.cboModifC.FormattingEnabled = True
        Me.cboModifC.Location = New System.Drawing.Point(15, 25)
        Me.cboModifC.Name = "cboModifC"
        Me.cboModifC.Size = New System.Drawing.Size(310, 21)
        Me.cboModifC.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "description"
        '
        'txtMdesc
        '
        Me.txtMdesc.Location = New System.Drawing.Point(12, 104)
        Me.txtMdesc.Multiline = True
        Me.txtMdesc.Name = "txtMdesc"
        Me.txtMdesc.Size = New System.Drawing.Size(313, 114)
        Me.txtMdesc.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMcode
        '
        Me.txtMcode.Location = New System.Drawing.Point(12, 65)
        Me.txtMcode.Name = "txtMcode"
        Me.txtMcode.Size = New System.Drawing.Size(313, 20)
        Me.txtMcode.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "modfiier le code"
        '
        'frmmodifcollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(337, 274)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMcode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboModifC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmodifcollection"
        Me.Text = "modifcollection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboModifC As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMdesc As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
