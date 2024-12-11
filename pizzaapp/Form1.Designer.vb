<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Type = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Panel5 = New Panel()
        olives = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Label3 = New Label()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(234, 615)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Franklin Gothic Book", 12F)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(33, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 158)
        Button1.TabIndex = 0
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Location = New Point(234, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(658, 47)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel4.Controls.Add(RadioButton3)
        Panel4.Controls.Add(RadioButton2)
        Panel4.Controls.Add(RadioButton1)
        Panel4.Controls.Add(Type)
        Panel4.Location = New Point(253, 197)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(627, 125)
        Panel4.TabIndex = 3
        ' 
        ' Type
        ' 
        Type.AutoSize = True
        Type.Location = New Point(14, 19)
        Type.Name = "Type"
        Type.Size = New Size(123, 20)
        Type.TabIndex = 0
        Type.Text = "Type de la croute"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(385, 75)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 24)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(40, 75)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(121, 24)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(189, 75)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(121, 24)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(CheckBox4)
        Panel5.Controls.Add(CheckBox3)
        Panel5.Controls.Add(CheckBox2)
        Panel5.Controls.Add(olives)
        Panel5.Location = New Point(253, 355)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(627, 175)
        Panel5.TabIndex = 4
        ' 
        ' olives
        ' 
        olives.AutoSize = True
        olives.Location = New Point(139, 66)
        olives.Name = "olives"
        olives.Size = New Size(71, 24)
        olives.TabIndex = 0
        olives.Text = "Olives"
        olives.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(316, 66)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(86, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Poivrons"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(384, 107)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(122, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Champignons"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(81, 107)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(209, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Fromages supplementaires"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 20)
        Label3.TabIndex = 4
        Label3.Text = "Ingrédients supplèmentaires"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.FlatAppearance.BorderSize = 0
        Button2.ForeColor = Color.White
        Button2.Location = New Point(392, 552)
        Button2.Name = "Button2"
        Button2.Size = New Size(331, 51)
        Button2.TabIndex = 5
        Button2.Text = "Afficher la commande !"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.White
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(255, 21)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 20)
        Label1.TabIndex = 1
        Label1.Text = "La taille de la pizza"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Location = New Point(253, 69)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(627, 101)
        Panel3.TabIndex = 2
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(892, 615)
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormMain"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Type As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents olives As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel

End Class
