<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderClerk_Dashboard
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
        Me.CompletedQty = New System.Windows.Forms.Label()
        Me.PendingQty = New System.Windows.Forms.Label()
        Me.OrderQty = New System.Windows.Forms.Label()
        Me.CustQty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.OrderStatus = New System.Windows.Forms.Button()
        Me.OrderProducts = New System.Windows.Forms.Button()
        Me.OrderCustomer = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OrderDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ReportBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompletedQty
        '
        Me.CompletedQty.AutoSize = True
        Me.CompletedQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CompletedQty.Location = New System.Drawing.Point(537, 294)
        Me.CompletedQty.Name = "CompletedQty"
        Me.CompletedQty.Size = New System.Drawing.Size(28, 31)
        Me.CompletedQty.TabIndex = 79
        Me.CompletedQty.Text = "0"
        '
        'PendingQty
        '
        Me.PendingQty.AutoSize = True
        Me.PendingQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PendingQty.Location = New System.Drawing.Point(269, 294)
        Me.PendingQty.Name = "PendingQty"
        Me.PendingQty.Size = New System.Drawing.Size(28, 31)
        Me.PendingQty.TabIndex = 78
        Me.PendingQty.Text = "0"
        '
        'OrderQty
        '
        Me.OrderQty.AutoSize = True
        Me.OrderQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderQty.Location = New System.Drawing.Point(537, 186)
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Size = New System.Drawing.Size(28, 31)
        Me.OrderQty.TabIndex = 77
        Me.OrderQty.Text = "0"
        '
        'CustQty
        '
        Me.CustQty.AutoSize = True
        Me.CustQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustQty.Location = New System.Drawing.Point(269, 186)
        Me.CustQty.Name = "CustQty"
        Me.CustQty.Size = New System.Drawing.Size(28, 31)
        Me.CustQty.TabIndex = 76
        Me.CustQty.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(505, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 24)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Completed Orders"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(505, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Products"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(198, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Pending Orders"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(195, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Customers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(159, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Welcome [Name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Dashboard"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 68
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'OrderStatus
        '
        Me.OrderStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderStatus.Location = New System.Drawing.Point(9, 240)
        Me.OrderStatus.Name = "OrderStatus"
        Me.OrderStatus.Size = New System.Drawing.Size(117, 48)
        Me.OrderStatus.TabIndex = 66
        Me.OrderStatus.Text = "Status"
        Me.OrderStatus.UseVisualStyleBackColor = True
        '
        'OrderProducts
        '
        Me.OrderProducts.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderProducts.Location = New System.Drawing.Point(9, 186)
        Me.OrderProducts.Name = "OrderProducts"
        Me.OrderProducts.Size = New System.Drawing.Size(117, 48)
        Me.OrderProducts.TabIndex = 65
        Me.OrderProducts.Text = "Products"
        Me.OrderProducts.UseVisualStyleBackColor = True
        '
        'OrderCustomer
        '
        Me.OrderCustomer.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderCustomer.Location = New System.Drawing.Point(9, 132)
        Me.OrderCustomer.Name = "OrderCustomer"
        Me.OrderCustomer.Size = New System.Drawing.Size(117, 48)
        Me.OrderCustomer.TabIndex = 63
        Me.OrderCustomer.Text = "Customer"
        Me.OrderCustomer.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'OrderDashboard
        '
        Me.OrderDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderDashboard.Location = New System.Drawing.Point(9, 78)
        Me.OrderDashboard.Name = "OrderDashboard"
        Me.OrderDashboard.Size = New System.Drawing.Size(117, 48)
        Me.OrderDashboard.TabIndex = 61
        Me.OrderDashboard.Text = "Dashboard"
        Me.OrderDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 69
        Me.PictureBox3.TabStop = False
        '
        'ReportBtn
        '
        Me.ReportBtn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReportBtn.Location = New System.Drawing.Point(9, 294)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(117, 48)
        Me.ReportBtn.TabIndex = 80
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'OrderClerk_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.CompletedQty)
        Me.Controls.Add(Me.PendingQty)
        Me.Controls.Add(Me.OrderQty)
        Me.Controls.Add(Me.CustQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.OrderStatus)
        Me.Controls.Add(Me.OrderProducts)
        Me.Controls.Add(Me.OrderCustomer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.OrderDashboard)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "OrderClerk_Dashboard"
        Me.Text = "Order Clerk - Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CompletedQty As Label
    Friend WithEvents PendingQty As Label
    Friend WithEvents OrderQty As Label
    Friend WithEvents CustQty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As LinkLabel
    Friend WithEvents OrderStatus As Button
    Friend WithEvents OrderProducts As Button
    Friend WithEvents OrderCustomer As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OrderDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ReportBtn As Button
End Class
