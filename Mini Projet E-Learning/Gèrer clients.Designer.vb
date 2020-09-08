<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gèrer_clients
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DIN = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NOM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PRENOM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Mini_Projet_E_Learning.My.Resources.Resources.Save_as
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(575, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Sauvgarder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Mini_Projet_E_Learning.My.Resources.Resources.Import
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(575, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 41)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Recharger"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DR
        '
        Me.DR.Location = New System.Drawing.Point(124, 32)
        Me.DR.Name = "DR"
        Me.DR.Size = New System.Drawing.Size(100, 22)
        Me.DR.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(269, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date du test"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DR)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DN)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DIN)
        Me.GroupBox2.Controls.Add(Me.ID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DT)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.NOM)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PRENOM)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 188)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saisir informations"
        '
        'DN
        '
        Me.DN.Location = New System.Drawing.Point(416, 52)
        Me.DN.Name = "DN"
        Me.DN.Size = New System.Drawing.Size(100, 22)
        Me.DN.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Le résultat du test"
        '
        'DIN
        '
        Me.DIN.Location = New System.Drawing.Point(416, 87)
        Me.DIN.Name = "DIN"
        Me.DIN.Size = New System.Drawing.Size(100, 22)
        Me.DIN.TabIndex = 10
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(124, 70)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(100, 22)
        Me.ID.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date de d'inscription"
        '
        'DT
        '
        Me.DT.Location = New System.Drawing.Point(416, 122)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(100, 22)
        Me.DT.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date de naissace"
        '
        'NOM
        '
        Me.NOM.Location = New System.Drawing.Point(124, 137)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(100, 22)
        Me.NOM.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nom"
        '
        'PRENOM
        '
        Me.PRENOM.Location = New System.Drawing.Point(124, 96)
        Me.PRENOM.Name = "PRENOM"
        Me.PRENOM.Size = New System.Drawing.Size(100, 22)
        Me.PRENOM.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 219)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Affichage informatons"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader1})
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(751, 194)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "prenom"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Nom"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Date de naissace"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 4
        Me.ColumnHeader5.Text = "Date de d'inscription"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 5
        Me.ColumnHeader6.Text = "Date du test"
        Me.ColumnHeader6.Width = 102
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 6
        Me.ColumnHeader7.Text = "Le résultat du test"
        Me.ColumnHeader7.Width = 110
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 0
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 51
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.Mini_Projet_E_Learning.My.Resources.Resources._Erase
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(575, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 45)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Supprimer "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Mini_Projet_E_Learning.My.Resources.Resources.Add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(575, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 45)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Saisir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Gèrer_clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 418)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Gèrer_clients"
        Me.Text = "Gèrer_clients"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DR As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DIN As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NOM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PRENOM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Button4 As Button
End Class
