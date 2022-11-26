<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryManager_Orders
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
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.DeliveryStatus = New System.Windows.Forms.Button()
        Me.DeliveryOrder = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DeliveryDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.NoBtn = New System.Windows.Forms.RadioButton()
        Me.YesBtn = New System.Windows.Forms.RadioButton()
        Me.AllBtn = New System.Windows.Forms.RadioButton()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 31)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Pending Order List"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 119
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'DeliveryStatus
        '
        Me.DeliveryStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryStatus.Location = New System.Drawing.Point(9, 186)
        Me.DeliveryStatus.Name = "DeliveryStatus"
        Me.DeliveryStatus.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryStatus.TabIndex = 118
        Me.DeliveryStatus.Text = "Status"
        Me.DeliveryStatus.UseVisualStyleBackColor = True
        '
        'DeliveryOrder
        '
        Me.DeliveryOrder.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryOrder.Location = New System.Drawing.Point(9, 132)
        Me.DeliveryOrder.Name = "DeliveryOrder"
        Me.DeliveryOrder.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryOrder.TabIndex = 117
        Me.DeliveryOrder.Text = "Orders"
        Me.DeliveryOrder.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'DeliveryDashboard
        '
        Me.DeliveryDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryDashboard.Location = New System.Drawing.Point(9, 78)
        Me.DeliveryDashboard.Name = "DeliveryDashboard"
        Me.DeliveryDashboard.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryDashboard.TabIndex = 115
        Me.DeliveryDashboard.Text = "Dashboard"
        Me.DeliveryDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'NoBtn
        '
        Me.NoBtn.AutoSize = True
        Me.NoBtn.Location = New System.Drawing.Point(632, 88)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(58, 19)
        Me.NoBtn.TabIndex = 128
        Me.NoBtn.TabStop = True
        Me.NoBtn.Text = "Ealiest"
        Me.NoBtn.UseVisualStyleBackColor = True
        '
        'YesBtn
        '
        Me.YesBtn.AutoSize = True
        Me.YesBtn.Location = New System.Drawing.Point(696, 88)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(59, 19)
        Me.YesBtn.TabIndex = 127
        Me.YesBtn.TabStop = True
        Me.YesBtn.Text = "Oldest"
        Me.YesBtn.UseVisualStyleBackColor = True
        '
        'AllBtn
        '
        Me.AllBtn.AutoSize = True
        Me.AllBtn.Location = New System.Drawing.Point(587, 88)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.Size = New System.Drawing.Size(39, 19)
        Me.AllBtn.TabIndex = 126
        Me.AllBtn.TabStop = True
        Me.AllBtn.Text = "All"
        Me.AllBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(227, 90)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(266, 23)
        Me.SearchTxt.TabIndex = 125
        '
        'ViewBtn
        '
        Me.ViewBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewBtn.Location = New System.Drawing.Point(662, 405)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(99, 34)
        Me.ViewBtn.TabIndex = 124
        Me.ViewBtn.Text = "View"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(159, 120)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(614, 272)
        Me.PictureBox4.TabIndex = 123
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(159, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Search:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(546, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Sort:"
        '
        'ReportBtn
        '
        Me.ReportBtn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReportBtn.Location = New System.Drawing.Point(9, 240)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(117, 48)
        Me.ReportBtn.TabIndex = 130
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'DeliveryManager_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.AllBtn)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.DeliveryStatus)
        Me.Controls.Add(Me.DeliveryOrder)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DeliveryDashboard)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "DeliveryManager_Orders"
        Me.Text = "Delivery Manager - Pending Order List"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As LinkLabel
    Friend WithEvents DeliveryStatus As Button
    Friend WithEvents DeliveryOrder As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DeliveryDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NoBtn As RadioButton
    Friend WithEvents YesBtn As RadioButton
    Friend WithEvents AllBtn As RadioButton
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents ViewBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ReportBtn As Button
End Class
