<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class azilanti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.datum_rođenja = New System.Windows.Forms.DateTimePicker()
        Me.datum_dolaska = New System.Windows.Forms.DateTimePicker()
        Me.datum_odlaska = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "UPIŠI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OČISTI"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nacionalnost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Prezime"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Datum rođenja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Datum dolaska"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Datum odlaska"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Status"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(169, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(169, 223)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(145, 20)
        Me.TextBox7.TabIndex = 15
        '
        'datum_rođenja
        '
        Me.datum_rođenja.CustomFormat = "yyyy-MM-dd"
        Me.datum_rođenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datum_rođenja.Location = New System.Drawing.Point(169, 125)
        Me.datum_rođenja.MaxDate = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.datum_rođenja.Name = "datum_rođenja"
        Me.datum_rođenja.Size = New System.Drawing.Size(145, 20)
        Me.datum_rođenja.TabIndex = 16
        Me.datum_rođenja.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'datum_dolaska
        '
        Me.datum_dolaska.CustomFormat = "yyyy-MM-dd"
        Me.datum_dolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datum_dolaska.Location = New System.Drawing.Point(169, 156)
        Me.datum_dolaska.MaxDate = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.datum_dolaska.Name = "datum_dolaska"
        Me.datum_dolaska.Size = New System.Drawing.Size(145, 20)
        Me.datum_dolaska.TabIndex = 17
        Me.datum_dolaska.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'datum_odlaska
        '
        Me.datum_odlaska.CustomFormat = "yyyy-MM-dd"
        Me.datum_odlaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datum_odlaska.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.datum_odlaska.Location = New System.Drawing.Point(169, 186)
        Me.datum_odlaska.MaxDate = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.datum_odlaska.Name = "datum_odlaska"
        Me.datum_odlaska.Size = New System.Drawing.Size(145, 20)
        Me.datum_odlaska.TabIndex = 18
        Me.datum_odlaska.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(540, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "POVRATAK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'azilanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 356)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.datum_odlaska)
        Me.Controls.Add(Me.datum_dolaska)
        Me.Controls.Add(Me.datum_rođenja)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "azilanti"
        Me.Text = "Evidencija azilanata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents datum_rođenja As System.Windows.Forms.DateTimePicker
    Friend WithEvents datum_dolaska As System.Windows.Forms.DateTimePicker
    Friend WithEvents datum_odlaska As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
