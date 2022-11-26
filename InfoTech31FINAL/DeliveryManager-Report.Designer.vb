<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryManager_Report
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
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.DeliveryStatus = New System.Windows.Forms.Button()
        Me.DeliveryOrder = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DeliveryDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DateToBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateFromBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportBtn
        '
        Me.ReportBtn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReportBtn.Location = New System.Drawing.Point(9, 240)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(117, 48)
        Me.ReportBtn.TabIndex = 164
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(227, 147)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(266, 23)
        Me.SearchTxt.TabIndex = 159
        '
        'ViewBtn
        '
        Me.ViewBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewBtn.Location = New System.Drawing.Point(662, 405)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(99, 34)
        Me.ViewBtn.TabIndex = 158
        Me.ViewBtn.Text = "View"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(159, 181)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(614, 216)
        Me.PictureBox4.TabIndex = 157
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(159, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Search:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 31)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Completed Delivery History"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Logout.Location = New System.Drawing.Point(9, 417)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(49, 17)
        Me.Logout.TabIndex = 153
        Me.Logout.TabStop = True
        Me.Logout.Text = "Logout"
        '
        'DeliveryStatus
        '
        Me.DeliveryStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryStatus.Location = New System.Drawing.Point(9, 186)
        Me.DeliveryStatus.Name = "DeliveryStatus"
        Me.DeliveryStatus.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryStatus.TabIndex = 152
        Me.DeliveryStatus.Text = "Status"
        Me.DeliveryStatus.UseVisualStyleBackColor = True
        '
        'DeliveryOrder
        '
        Me.DeliveryOrder.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryOrder.Location = New System.Drawing.Point(9, 132)
        Me.DeliveryOrder.Name = "DeliveryOrder"
        Me.DeliveryOrder.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryOrder.TabIndex = 151
        Me.DeliveryOrder.Text = "Orders"
        Me.DeliveryOrder.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox2.TabIndex = 150
        Me.PictureBox2.TabStop = False
        '
        'DeliveryDashboard
        '
        Me.DeliveryDashboard.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeliveryDashboard.Location = New System.Drawing.Point(9, 78)
        Me.DeliveryDashboard.Name = "DeliveryDashboard"
        Me.DeliveryDashboard.Size = New System.Drawing.Size(117, 48)
        Me.DeliveryDashboard.TabIndex = 149
        Me.DeliveryDashboard.Text = "Dashboard"
        Me.DeliveryDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 461)
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(127, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(676, 77)
        Me.PictureBox3.TabIndex = 154
        Me.PictureBox3.TabStop = False
        '
        'DateToBox
        '
        Me.DateToBox.FormattingEnabled = True
        Me.DateToBox.Location = New System.Drawing.Point(250, 112)
        Me.DateToBox.Name = "DateToBox"
        Me.DateToBox.Size = New System.Drawing.Size(121, 23)
        Me.DateToBox.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(159, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Date To:"
        '
        'DateFromBox
        '
        Me.DateFromBox.FormattingEnabled = True
        Me.DateFromBox.Location = New System.Drawing.Point(250, 82)
        Me.DateFromBox.Name = "DateFromBox"
        Me.DateFromBox.Size = New System.Drawing.Size(121, 23)
        Me.DateFromBox.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(159, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Date From:"
        '
        'DeliveryManager_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateToBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateFromBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReportBtn)
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
        Me.Name = "DeliveryManager_Report"
        Me.Text = "Delivery Manager - Report"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportBtn As Button
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents ViewBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As LinkLabel
    Friend WithEvents DeliveryStatus As Button
    Friend WithEvents DeliveryOrder As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DeliveryDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DateToBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateFromBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
