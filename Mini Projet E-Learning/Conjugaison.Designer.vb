<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conjugaison
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
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(597, 38)
        Me.panel2.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conjugaison"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(12, 217)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(188, 17)
        Me.LinkLabel4.TabIndex = 73
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "4-Conjugaison-faire-en-anglais"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(12, 169)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(282, 17)
        Me.LinkLabel3.TabIndex = 72
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "3-Conjugaison-du-verbe-être-en-anglais-to-be"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 119)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(138, 17)
        Me.LinkLabel2.TabIndex = 71
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "2-Conjugaison-anglais"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 73)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(192, 17)
        Me.LinkLabel1.TabIndex = 70
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "1-Conjugaison-avoir-en-anglais"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mini_Projet_E_Learning.My.Resources.Resources.product_document_file_1512
        Me.PictureBox1.Location = New System.Drawing.Point(390, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 129)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Conjugaison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 304)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Conjugaison"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conjugaison"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
