<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Report_Purchase
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
        Me.DateToBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateFromBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.AdminReport = New System.Windows.Forms.Button()
        Me.AdminInventory = New System.Windows.Forms.Button()
        Me.AdminProducts = New System.Windows.Forms.Button()
        Me.AdminSuppliers = New System.Windows.Forms.Button()
        Me.AdminEmployees = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AdminDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateToBox
        '
        Me.DateToBox.FormattingEnabled = True
        Me.DateToBox.Location = New System.Drawing.Point(254, 118)
        Me.DateToBox.Name = "DateToBox"
        Me.DateToBox.Size = New System.Drawing.Size(121, 23)
        Me.DateToBox.TabIndex = 181
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(163, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Date To:"
        '
        'DateFromBox
        '
        Me.DateFromBox.FormattingEnabled = True
        Me.DateFromBox.Location = New System.Drawing.Point(254, 88)
        Me.DateFromBox.Name = "DateFromBox"
        Me.DateFromBox.Size = New System.Drawing.Size(121, 23)
        Me.DateFromBox.TabIndex = 179
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(163, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Date From:"
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(231, 150)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(266, 23)
        Me.SearchTxt.TabIndex = 177
        '
        'OrderBtn
        '
        Me.OrderBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderBtn.Location = New System.Drawing.Point(666, 409)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(99, 34)
        Me.OrderBtn.TabIndex = 176
        Me.OrderBtn.Text = "View"
        Me.OrderBtn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(163, 188)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(614, 208)
        Me.PictureBox4.TabIndex = 175
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(163, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Search:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 31)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Purchase Report"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 171
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'AdminReport
        '
        Me.AdminReport.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminReport.Location = New System.Drawing.Point(9, 348)
        Me.AdminReport.Name = "AdminReport"
        Me.AdminReport.Size = New System.Drawing.Size(117, 48)
        Me.AdminReport.TabIndex = 170
        Me.AdminReport.Text = "Report"
        Me.AdminReport.UseVisualStyleBackColor = True
        '
        'AdminInventory
        '
        Me.AdminInventory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminInventory.Location = New System.Drawing.Point(9, 294)
        Me.AdminInventory.Name = "AdminInventory"
        Me.AdminInventory.Size = New System.Drawing.Size(117, 48)
        Me.AdminInventory.TabIndex = 169
        Me.AdminInventory.Text = "Inventory"
        Me.AdminInventory.UseVisualStyleBackColor = True
        '
        'AdminProducts
        '
        Me.AdminProducts.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminProducts.Location = New System.Drawing.Point(9, 240)
        Me.AdminProducts.Name = "AdminProducts"
        Me.AdminProducts.Size = New System.Drawing.Size(117, 48)
        Me.AdminProducts.TabIndex = 168
        Me.AdminProducts.Text = "Products"
        Me.AdminProducts.UseVisualStyleBackColor = True
        '
        'AdminSuppliers
        '
        Me.AdminSuppliers.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminSuppliers.Location = New System.Drawing.Point(9, 186)
        Me.AdminSuppliers.Name = "AdminSuppliers"
        Me.AdminSuppliers.Size = New System.Drawing.Size(117, 48)
        Me.AdminSuppliers.TabIndex = 167
        Me.AdminSuppliers.Text = "Suppliers"
        Me.AdminSuppliers.UseVisualStyleBackColor = True
        '
        'AdminEmployees
        '
        Me.AdminEmployees.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminEmployees.Location = New System.Drawing.Point(9, 132)
        Me.AdminEmployees.Name = "AdminEmployees"
        Me.AdminEmployees.Size = New System.Drawing.Size(117, 48)
        Me.AdminEmployees.TabIndex = 166
        Me.AdminEmployees.Text = "Employees"
        Me.AdminEmployees.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 165
        Me.PictureBox2.TabStop = False
        '
        'AdminDashboard
        '
        Me.AdminDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminDashboard.Location = New System.Drawing.Point(9, 78)
        Me.AdminDashboard.Name = "AdminDashboard"
        Me.AdminDashboard.Size = New System.Drawing.Size(117, 48)
        Me.AdminDashboard.TabIndex = 164
        Me.AdminDashboard.Text = "Dashboard"
        Me.AdminDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 163
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 172
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(163, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 34)
        Me.Button1.TabIndex = 202
        Me.Button1.Text = "<< Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Admin_Report_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateToBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateFromBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.OrderBtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.AdminReport)
        Me.Controls.Add(Me.AdminInventory)
        Me.Controls.Add(Me.AdminProducts)
        Me.Controls.Add(Me.AdminSuppliers)
        Me.Controls.Add(Me.AdminEmployees)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.AdminDashboard)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Admin_Report_Purchase"
        Me.Text = "Admin - Purchase Report"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateToBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateFromBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents OrderBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As LinkLabel
    Friend WithEvents AdminReport As Button
    Friend WithEvents AdminInventory As Button
    Friend WithEvents AdminProducts As Button
    Friend WithEvents AdminSuppliers As Button
    Friend WithEvents AdminEmployees As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AdminDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
