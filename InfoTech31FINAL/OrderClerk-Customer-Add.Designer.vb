<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderClerk_Customer_Add
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
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ProceedBtn = New System.Windows.Forms.Button()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.CusNoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LandLineNumTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LandLineAreaTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(394, 380)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 64
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProceedBtn
        '
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProceedBtn.Location = New System.Drawing.Point(289, 380)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(99, 34)
        Me.ProceedBtn.TabIndex = 63
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = True
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(267, 285)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(148, 23)
        Me.MobileTxt.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(37, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Mobile Contact Number:"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(37, 191)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(456, 72)
        Me.AddressTxt.TabIndex = 58
        Me.AddressTxt.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Address"
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(37, 132)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(330, 23)
        Me.NameTxt.TabIndex = 52
        Me.NameTxt.Text = "Business Name"
        '
        'CusNoLabel
        '
        Me.CusNoLabel.AutoSize = True
        Me.CusNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CusNoLabel.Location = New System.Drawing.Point(148, 77)
        Me.CusNoLabel.Name = "CusNoLabel"
        Me.CusNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.CusNoLabel.TabIndex = 51
        Me.CusNoLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Business Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Customer No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(134, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Customer Registration"
        '
        'LandLineNumTxt
        '
        Me.LandLineNumTxt.Location = New System.Drawing.Point(257, 316)
        Me.LandLineNumTxt.Name = "LandLineNumTxt"
        Me.LandLineNumTxt.Size = New System.Drawing.Size(99, 23)
        Me.LandLineNumTxt.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Land Line Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(217, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "(+63) -"
        '
        'LandLineAreaTxt
        '
        Me.LandLineAreaTxt.Location = New System.Drawing.Point(185, 316)
        Me.LandLineAreaTxt.Name = "LandLineAreaTxt"
        Me.LandLineAreaTxt.Size = New System.Drawing.Size(56, 23)
        Me.LandLineAreaTxt.TabIndex = 68
        '
        'OrderClerk_Customer_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 448)
        Me.Controls.Add(Me.LandLineAreaTxt)
        Me.Controls.Add(Me.LandLineNumTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.MobileTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.CusNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "OrderClerk_Customer_Add"
        Me.Text = "Add New Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents ProceedBtn As Button
    Friend WithEvents MobileTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents CusNoLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LandLineNumTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LandLineAreaTxt As TextBox
End Class
