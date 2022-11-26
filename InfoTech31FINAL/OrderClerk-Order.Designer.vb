<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderClerk_Order
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
        Me.PaymentTypeBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SNoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MobileNoLabel = New System.Windows.Forms.Label()
        Me.LandLineLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texttext = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.QtyTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalTxt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaymentTypeBox
        '
        Me.PaymentTypeBox.FormattingEnabled = True
        Me.PaymentTypeBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.PaymentTypeBox.Location = New System.Drawing.Point(144, 241)
        Me.PaymentTypeBox.Name = "PaymentTypeBox"
        Me.PaymentTypeBox.Size = New System.Drawing.Size(121, 23)
        Me.PaymentTypeBox.TabIndex = 244
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(30, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 243
        Me.Label7.Text = "Payment Type:"
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(135, 546)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 242
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmBtn.Location = New System.Drawing.Point(30, 546)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(99, 34)
        Me.ConfirmBtn.TabIndex = 241
        Me.ConfirmBtn.Text = "Confirm"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 31)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Sales Order"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.AddressLabel.Location = New System.Drawing.Point(48, 143)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(63, 17)
        Me.AddressLabel.TabIndex = 228
        Me.AddressLabel.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(30, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 227
        Me.Label8.Text = "Address"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.NameLabel.Location = New System.Drawing.Point(158, 95)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(117, 17)
        Me.NameLabel.TabIndex = 226
        Me.NameLabel.Text = "Business Name "
        '
        'SNoLabel
        '
        Me.SNoLabel.AutoSize = True
        Me.SNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SNoLabel.Location = New System.Drawing.Point(157, 71)
        Me.SNoLabel.Name = "SNoLabel"
        Me.SNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.SNoLabel.TabIndex = 225
        Me.SNoLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(30, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Business Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "Sales Order No."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(524, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 599)
        Me.PictureBox1.TabIndex = 245
        Me.PictureBox1.TabStop = False
        '
        'MobileNoLabel
        '
        Me.MobileNoLabel.AutoSize = True
        Me.MobileNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.MobileNoLabel.Location = New System.Drawing.Point(161, 187)
        Me.MobileNoLabel.Name = "MobileNoLabel"
        Me.MobileNoLabel.Size = New System.Drawing.Size(88, 17)
        Me.MobileNoLabel.TabIndex = 250
        Me.MobileNoLabel.Text = "9123456789"
        '
        'LandLineLabel
        '
        Me.LandLineLabel.AutoSize = True
        Me.LandLineLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.LandLineLabel.Location = New System.Drawing.Point(109, 214)
        Me.LandLineLabel.Name = "LandLineLabel"
        Me.LandLineLabel.Size = New System.Drawing.Size(33, 17)
        Me.LandLineLabel.TabIndex = 249
        Me.LandLineLabel.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(30, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "Landline:"
        '
        'texttext
        '
        Me.texttext.AutoSize = True
        Me.texttext.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.texttext.Location = New System.Drawing.Point(122, 187)
        Me.texttext.Name = "texttext"
        Me.texttext.Size = New System.Drawing.Size(33, 17)
        Me.texttext.TabIndex = 247
        Me.texttext.Text = "+63"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(30, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 18)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Mobile No:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(28, 297)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(472, 196)
        Me.PictureBox2.TabIndex = 251
        Me.PictureBox2.TabStop = False
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(96, 270)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(169, 23)
        Me.SearchTxt.TabIndex = 253
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(28, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Search:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(543, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(245, 436)
        Me.PictureBox3.TabIndex = 254
        Me.PictureBox3.TabStop = False
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.Location = New System.Drawing.Point(430, 499)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(70, 34)
        Me.AddBtn.TabIndex = 255
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'QtyTxt
        '
        Me.QtyTxt.Location = New System.Drawing.Point(355, 504)
        Me.QtyTxt.Name = "QtyTxt"
        Me.QtyTxt.Size = New System.Drawing.Size(69, 23)
        Me.QtyTxt.TabIndex = 256
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(317, 507)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Qty"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(695, 515)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 17)
        Me.Label19.TabIndex = 260
        Me.Label19.Text = "P"
        '
        'TotalTxt
        '
        Me.TotalTxt.AutoSize = True
        Me.TotalTxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.TotalTxt.Location = New System.Drawing.Point(743, 515)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Size = New System.Drawing.Size(44, 17)
        Me.TotalTxt.TabIndex = 259
        Me.TotalTxt.Text = "00.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(627, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 258
        Me.Label9.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(543, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 31)
        Me.Label10.TabIndex = 261
        Me.Label10.Text = "Point of Sale"
        '
        'OrderClerk_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 592)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TotalTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.QtyTxt)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MobileNoLabel)
        Me.Controls.Add(Me.LandLineLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.texttext)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PaymentTypeBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OrderClerk_Order"
        Me.Text = "Sales Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaymentTypeBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents SNoLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MobileNoLabel As Label
    Friend WithEvents LandLineLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents texttext As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents QtyTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TotalTxt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
