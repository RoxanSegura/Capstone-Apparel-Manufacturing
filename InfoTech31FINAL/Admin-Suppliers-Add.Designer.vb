<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Suppliers_Add
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
        Me.ContactTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SNameTxt = New System.Windows.Forms.TextBox()
        Me.SupNoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(394, 343)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 64
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProceedBtn
        '
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProceedBtn.Location = New System.Drawing.Point(289, 343)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(99, 34)
        Me.ProceedBtn.TabIndex = 63
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = True
        '
        'ContactTxt
        '
        Me.ContactTxt.Location = New System.Drawing.Point(91, 298)
        Me.ContactTxt.Name = "ContactTxt"
        Me.ContactTxt.Size = New System.Drawing.Size(167, 23)
        Me.ContactTxt.TabIndex = 60
        Me.ContactTxt.Text = "9123456780"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(37, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Contact No."
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(37, 190)
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
        Me.Label6.Location = New System.Drawing.Point(37, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Address"
        '
        'SNameTxt
        '
        Me.SNameTxt.Location = New System.Drawing.Point(37, 132)
        Me.SNameTxt.Name = "SNameTxt"
        Me.SNameTxt.Size = New System.Drawing.Size(305, 23)
        Me.SNameTxt.TabIndex = 52
        Me.SNameTxt.Text = "Supplier Name"
        '
        'SupNoLabel
        '
        Me.SupNoLabel.AutoSize = True
        Me.SupNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SupNoLabel.Location = New System.Drawing.Point(148, 77)
        Me.SupNoLabel.Name = "SupNoLabel"
        Me.SupNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.SupNoLabel.TabIndex = 51
        Me.SupNoLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Supplier No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(134, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Supplier Registration"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(44, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "(+63)"
        '
        'Admin_Suppliers_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 400)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.ContactTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SNameTxt)
        Me.Controls.Add(Me.SupNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin_Suppliers_Add"
        Me.Text = "Add New Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents ProceedBtn As Button
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SNameTxt As TextBox
    Friend WithEvents SupNoLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
