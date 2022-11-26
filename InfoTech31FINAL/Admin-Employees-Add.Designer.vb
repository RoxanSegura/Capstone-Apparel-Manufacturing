<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Employees_Add
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmpNoLabel = New System.Windows.Forms.Label()
        Me.FNameTxt = New System.Windows.Forms.TextBox()
        Me.MNameTxt = New System.Windows.Forms.TextBox()
        Me.LNameTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PositionBox = New System.Windows.Forms.ComboBox()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProceedBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(133, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Employee Registration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(36, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Employee No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(36, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Name"
        '
        'EmpNoLabel
        '
        Me.EmpNoLabel.AutoSize = True
        Me.EmpNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpNoLabel.Location = New System.Drawing.Point(147, 77)
        Me.EmpNoLabel.Name = "EmpNoLabel"
        Me.EmpNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.EmpNoLabel.TabIndex = 34
        Me.EmpNoLabel.Text = "0"
        '
        'FNameTxt
        '
        Me.FNameTxt.Location = New System.Drawing.Point(36, 132)
        Me.FNameTxt.Name = "FNameTxt"
        Me.FNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.FNameTxt.TabIndex = 35
        Me.FNameTxt.Text = "First Name"
        '
        'MNameTxt
        '
        Me.MNameTxt.Location = New System.Drawing.Point(190, 132)
        Me.MNameTxt.Name = "MNameTxt"
        Me.MNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.MNameTxt.TabIndex = 36
        Me.MNameTxt.Text = "Middle Name"
        '
        'LNameTxt
        '
        Me.LNameTxt.Location = New System.Drawing.Point(344, 132)
        Me.LNameTxt.Name = "LNameTxt"
        Me.LNameTxt.Size = New System.Drawing.Size(148, 23)
        Me.LNameTxt.TabIndex = 37
        Me.LNameTxt.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(36, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Position"
        '
        'PositionBox
        '
        Me.PositionBox.FormattingEnabled = True
        Me.PositionBox.Items.AddRange(New Object() {"Order Clerk", "Purchase Officer", "Delivery Manager", "Delivery Courier"})
        Me.PositionBox.Location = New System.Drawing.Point(36, 188)
        Me.PositionBox.Name = "PositionBox"
        Me.PositionBox.Size = New System.Drawing.Size(148, 23)
        Me.PositionBox.TabIndex = 39
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(36, 244)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(456, 72)
        Me.AddressTxt.TabIndex = 41
        Me.AddressTxt.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(36, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Address"
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Location = New System.Drawing.Point(36, 351)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(148, 23)
        Me.UsernameTxt.TabIndex = 43
        Me.UsernameTxt.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(36, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Username"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(36, 409)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(148, 23)
        Me.PasswordTxt.TabIndex = 45
        Me.PasswordTxt.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(36, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Password"
        '
        'ProceedBtn
        '
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProceedBtn.Location = New System.Drawing.Point(288, 471)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(99, 34)
        Me.ProceedBtn.TabIndex = 46
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(393, 471)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 47
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Admin_Employees_Add
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
        Me.Name = "Admin_Employees_Add"
        Me.Text = "Add New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpNoLabel As Label
    Friend WithEvents FNameTxt As TextBox
    Friend WithEvents MNameTxt As TextBox
    Friend WithEvents LNameTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PositionBox As ComboBox
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ProceedBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
