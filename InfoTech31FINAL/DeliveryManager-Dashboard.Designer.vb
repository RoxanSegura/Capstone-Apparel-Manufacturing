<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryManager_Dashboard
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
        Me.NoQty = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.DeliveryOrder = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DeliveryDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.YesQty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeliveryStatus = New System.Windows.Forms.Button()
        Me.ReportBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoQty
        '
        Me.NoQty.AutoSize = True
        Me.NoQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoQty.Location = New System.Drawing.Point(214, 186)
        Me.NoQty.Name = "NoQty"
        Me.NoQty.Size = New System.Drawing.Size(28, 31)
        Me.NoQty.TabIndex = 111
        Me.NoQty.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(182, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "In-Transit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(159, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Welcome [Name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Dashboard"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 104
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'DeliveryOrder
        '
        Me.DeliveryOrder.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryOrder.Location = New System.Drawing.Point(9, 132)
        Me.DeliveryOrder.Name = "DeliveryOrder"
        Me.DeliveryOrder.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryOrder.TabIndex = 101
        Me.DeliveryOrder.Text = "Delivery"
        Me.DeliveryOrder.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 99
        Me.PictureBox2.TabStop = False
        '
        'DeliveryDashboard
        '
        Me.DeliveryDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryDashboard.Location = New System.Drawing.Point(9, 78)
        Me.DeliveryDashboard.Name = "DeliveryDashboard"
        Me.DeliveryDashboard.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryDashboard.TabIndex = 98
        Me.DeliveryDashboard.Text = "Dashboard"
        Me.DeliveryDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 105
        Me.PictureBox3.TabStop = False
        '
        'YesQty
        '
        Me.YesQty.AutoSize = True
        Me.YesQty.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YesQty.Location = New System.Drawing.Point(533, 186)
        Me.YesQty.Name = "YesQty"
        Me.YesQty.Size = New System.Drawing.Size(28, 31)
        Me.YesQty.TabIndex = 113
        Me.YesQty.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(501, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 24)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Completed Deliveries"
        '
        'DeliveryStatus
        '
        Me.DeliveryStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryStatus.Location = New System.Drawing.Point(9, 186)
        Me.DeliveryStatus.Name = "DeliveryStatus"
        Me.DeliveryStatus.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryStatus.TabIndex = 102
        Me.DeliveryStatus.Text = "Status"
        Me.DeliveryStatus.UseVisualStyleBackColor = True
        '
        'ReportBtn
        '
        Me.ReportBtn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReportBtn.Location = New System.Drawing.Point(9, 240)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(117, 48)
        Me.ReportBtn.TabIndex = 131
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'DeliveryManager_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.YesQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NoQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.DeliveryStatus)
        Me.Controls.Add(Me.DeliveryOrder)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DeliveryDashboard)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "DeliveryManager_Dashboard"
        Me.Text = "Delivery Manager - Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoQty As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As LinkLabel
    Friend WithEvents DeliveryOrder As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DeliveryDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents YesQty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DeliveryStatus As Button
    Friend WithEvents ReportBtn As Button
End Class
