<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Employees_Update
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
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PositionBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LNameTxt = New System.Windows.Forms.TextBox()
        Me.MNameTxt = New System.Windows.Forms.TextBox()
        Me.FNameTxt = New System.Windows.Forms.TextBox()
        Me.EmpNoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(394, 471)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 64
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProceedBtn
        '
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProceedBtn.Location = New System.Drawing.Point(289, 471)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(99, 34)
        Me.ProceedBtn.TabIndex = 63
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = True
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(37, 409)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(148, 23)
        Me.PasswordTxt.TabIndex = 62
        Me.PasswordTxt.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(37, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Password"
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Location = New System.Drawing.Point(37, 351)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(148, 23)
        Me.UsernameTxt.TabIndex = 60
        Me.UsernameTxt.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(37, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Username"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(37, 244)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(456, 72)
        Me.AddressTxt.TabIndex = 58
        Me.AddressTxt.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Address"
        '
        'PositionBox
        '
        Me.PositionBox.FormattingEnabled = True
        Me.PositionBox.Location = New System.Drawing.Point(37, 188)
        Me.PositionBox.Name = "PositionBox"
        Me.PositionBox.Size = New System.Drawing.Size(148, 23)
        Me.PositionBox.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(37, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Position"
        '
        'LNameTxt
        '
        Me.LNameTxt.Location = New System.Drawing.Point(345, 132)
        Me.LNameTxt.Name = "LNameTxt"
        Me.LNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.LNameTxt.TabIndex = 54
        Me.LNameTxt.Text = "Last Name"
        '
        'MNameTxt
        '
        Me.MNameTxt.Location = New System.Drawing.Point(191, 132)
        Me.MNameTxt.Name = "MNameTxt"
        Me.MNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.MNameTxt.TabIndex = 53
        Me.MNameTxt.Text = "Middle Name"
        '
        'FNameTxt
        '
        Me.FNameTxt.Location = New System.Drawing.Point(37, 132)
        Me.FNameTxt.Name = "FNameTxt"
        Me.FNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.FNameTxt.TabIndex = 52
        Me.FNameTxt.Text = "First Name"
        '
        'EmpNoLabel
        '
        Me.EmpNoLabel.AutoSize = True
        Me.EmpNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpNoLabel.Location = New System.Drawing.Point(148, 77)
        Me.EmpNoLabel.Name = "EmpNoLabel"
        Me.EmpNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.EmpNoLabel.TabIndex = 51
        Me.EmpNoLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Employee No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(128, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Employee Detail Update"
        '
        'Admin_Employees_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 523)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UsernameTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PositionBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LNameTxt)
        Me.Controls.Add(Me.MNameTxt)
        Me.Controls.Add(Me.FNameTxt)
        Me.Controls.Add(Me.EmpNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin_Employees_Update"
        Me.Text = "Update Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents ProceedBtn As Button
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PositionBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LNameTxt As TextBox
    Friend WithEvents MNameTxt As TextBox
    Friend WithEvents FNameTxt As TextBox
    Friend WithEvents EmpNoLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
