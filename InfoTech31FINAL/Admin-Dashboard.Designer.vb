<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
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
        Me.SalesQty = New System.Windows.Forms.Label()
        Me.SuppliersQty = New System.Windows.Forms.Label()
        Me.OrderQty = New System.Windows.Forms.Label()
        Me.EmpQty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesQty
        '
        Me.SalesQty.AutoSize = True
        Me.SalesQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SalesQty.Location = New System.Drawing.Point(537, 301)
        Me.SalesQty.Name = "SalesQty"
        Me.SalesQty.Size = New System.Drawing.Size(28, 31)
        Me.SalesQty.TabIndex = 59
        Me.SalesQty.Text = "0"
        '
        'SuppliersQty
        '
        Me.SuppliersQty.AutoSize = True
        Me.SuppliersQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SuppliersQty.Location = New System.Drawing.Point(269, 301)
        Me.SuppliersQty.Name = "SuppliersQty"
        Me.SuppliersQty.Size = New System.Drawing.Size(28, 31)
        Me.SuppliersQty.TabIndex = 58
        Me.SuppliersQty.Text = "0"
        '
        'OrderQty
        '
        Me.OrderQty.AutoSize = True
        Me.OrderQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderQty.Location = New System.Drawing.Point(537, 193)
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Size = New System.Drawing.Size(28, 31)
        Me.OrderQty.TabIndex = 57
        Me.OrderQty.Text = "0"
        '
        'EmpQty
        '
        Me.EmpQty.AutoSize = True
        Me.EmpQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpQty.Location = New System.Drawing.Point(269, 193)
        Me.EmpQty.Name = "EmpQty"
        Me.EmpQty.Size = New System.Drawing.Size(28, 31)
        Me.EmpQty.TabIndex = 56
        Me.EmpQty.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(505, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(505, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 24)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Products"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(198, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Suppliers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(195, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Employees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(159, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Welcome [Name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Dashboard"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 48
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'AdminReport
        '
        Me.AdminReport.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminReport.Location = New System.Drawing.Point(9, 348)
        Me.AdminReport.Name = "AdminReport"
        Me.AdminReport.Size = New System.Drawing.Size(117, 48)
        Me.AdminReport.TabIndex = 47
        Me.AdminReport.Text = "Report"
        Me.AdminReport.UseVisualStyleBackColor = True
        '
        'AdminInventory
        '
        Me.AdminInventory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminInventory.Location = New System.Drawing.Point(9, 294)
        Me.AdminInventory.Name = "AdminInventory"
        Me.AdminInventory.Size = New System.Drawing.Size(117, 48)
        Me.AdminInventory.TabIndex = 46
        Me.AdminInventory.Text = "Inventory"
        Me.AdminInventory.UseVisualStyleBackColor = True
        '
        'AdminProducts
        '
        Me.AdminProducts.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminProducts.Location = New System.Drawing.Point(9, 240)
        Me.AdminProducts.Name = "AdminProducts"
        Me.AdminProducts.Size = New System.Drawing.Size(117, 48)
        Me.AdminProducts.TabIndex = 45
        Me.AdminProducts.Text = "Products"
        Me.AdminProducts.UseVisualStyleBackColor = True
        '
        'AdminSuppliers
        '
        Me.AdminSuppliers.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminSuppliers.Location = New System.Drawing.Point(9, 186)
        Me.AdminSuppliers.Name = "AdminSuppliers"
        Me.AdminSuppliers.Size = New System.Drawing.Size(117, 48)
        Me.AdminSuppliers.TabIndex = 44
        Me.AdminSuppliers.Text = "Suppliers"
        Me.AdminSuppliers.UseVisualStyleBackColor = True
        '
        'AdminEmployees
        '
        Me.AdminEmployees.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminEmployees.Location = New System.Drawing.Point(9, 132)
        Me.AdminEmployees.Name = "AdminEmployees"
        Me.AdminEmployees.Size = New System.Drawing.Size(117, 48)
        Me.AdminEmployees.TabIndex = 43
        Me.AdminEmployees.Text = "Employees"
        Me.AdminEmployees.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'AdminDashboard
        '
        Me.AdminDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminDashboard.Location = New System.Drawing.Point(9, 78)
        Me.AdminDashboard.Name = "AdminDashboard"
        Me.AdminDashboard.Size = New System.Drawing.Size(117, 48)
        Me.AdminDashboard.TabIndex = 41
        Me.AdminDashboard.Text = "Dashboard"
        Me.AdminDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'Admin_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SalesQty)
        Me.Controls.Add(Me.SuppliersQty)
        Me.Controls.Add(Me.OrderQty)
        Me.Controls.Add(Me.EmpQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "Admin_Dashboard"
        Me.Text = "Admin - Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalesQty As Label
    Friend WithEvents SuppliersQty As Label
    Friend WithEvents OrderQty As Label
    Friend WithEvents EmpQty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
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
End Class
