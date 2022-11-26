<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Products_Add
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
        Me.UnitPriceTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PNameTxt = New System.Windows.Forms.TextBox()
        Me.ProdNoLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CottonQty = New System.Windows.Forms.NumericUpDown()
        Me.LinenQty = New System.Windows.Forms.NumericUpDown()
        Me.RubberQty = New System.Windows.Forms.NumericUpDown()
        Me.PlasticQty = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProdQty = New System.Windows.Forms.NumericUpDown()
        CType(Me.CottonQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinenQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubberQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlasticQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(277, 479)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 34)
        Me.CancelBtn.TabIndex = 64
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProceedBtn
        '
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProceedBtn.Location = New System.Drawing.Point(172, 479)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(99, 34)
        Me.ProceedBtn.TabIndex = 63
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = True
        '
        'UnitPriceTxt
        '
        Me.UnitPriceTxt.Location = New System.Drawing.Point(36, 231)
        Me.UnitPriceTxt.Name = "UnitPriceTxt"
        Me.UnitPriceTxt.Size = New System.Drawing.Size(148, 23)
        Me.UnitPriceTxt.TabIndex = 60
        Me.UnitPriceTxt.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(36, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Unit Price"
        '
        'CategoryBox
        '
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(36, 176)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(162, 23)
        Me.CategoryBox.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(36, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Category"
        '
        'PNameTxt
        '
        Me.PNameTxt.Location = New System.Drawing.Point(36, 120)
        Me.PNameTxt.Name = "PNameTxt"
        Me.PNameTxt.Size = New System.Drawing.Size(340, 23)
        Me.PNameTxt.TabIndex = 52
        Me.PNameTxt.Text = "Product Name"
        '
        'ProdNoLabel
        '
        Me.ProdNoLabel.AutoSize = True
        Me.ProdNoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdNoLabel.Location = New System.Drawing.Point(147, 65)
        Me.ProdNoLabel.Name = "ProdNoLabel"
        Me.ProdNoLabel.Size = New System.Drawing.Size(16, 17)
        Me.ProdNoLabel.TabIndex = 51
        Me.ProdNoLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(36, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Product No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Product Registration"
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(214, 176)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.Size = New System.Drawing.Size(162, 23)
        Me.CategoryTxt.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(36, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Materials (in rolls)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(36, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Quantity"
        '
        'CottonQty
        '
        Me.CottonQty.Location = New System.Drawing.Point(40, 297)
        Me.CottonQty.Name = "CottonQty"
        Me.CottonQty.Size = New System.Drawing.Size(59, 23)
        Me.CottonQty.TabIndex = 73
        '
        'LinenQty
        '
        Me.LinenQty.Location = New System.Drawing.Point(40, 322)
        Me.LinenQty.Name = "LinenQty"
        Me.LinenQty.Size = New System.Drawing.Size(59, 23)
        Me.LinenQty.TabIndex = 74
        '
        'RubberQty
        '
        Me.RubberQty.Location = New System.Drawing.Point(40, 347)
        Me.RubberQty.Name = "RubberQty"
        Me.RubberQty.Size = New System.Drawing.Size(59, 23)
        Me.RubberQty.TabIndex = 75
        '
        'PlasticQty
        '
        Me.PlasticQty.Location = New System.Drawing.Point(40, 372)
        Me.PlasticQty.Name = "PlasticQty"
        Me.PlasticQty.Size = New System.Drawing.Size(59, 23)
        Me.PlasticQty.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(107, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Cotton"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(107, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Linen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(107, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Rubber"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(107, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Plastic"
        '
        'ProdQty
        '
        Me.ProdQty.Location = New System.Drawing.Point(40, 432)
        Me.ProdQty.Name = "ProdQty"
        Me.ProdQty.Size = New System.Drawing.Size(118, 23)
        Me.ProdQty.TabIndex = 81
        '
        'Admin_Products_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 536)
        Me.Controls.Add(Me.ProdQty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PlasticQty)
        Me.Controls.Add(Me.RubberQty)
        Me.Controls.Add(Me.LinenQty)
        Me.Controls.Add(Me.CottonQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.UnitPriceTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PNameTxt)
        Me.Controls.Add(Me.ProdNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin_Products_Add"
        Me.Text = "Add New Product"
        CType(Me.CottonQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinenQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubberQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlasticQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents ProceedBtn As Button
    Friend WithEvents UnitPriceTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CategoryBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PNameTxt As TextBox
    Friend WithEvents ProdNoLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CategoryTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CottonQty As NumericUpDown
    Friend WithEvents LinenQty As NumericUpDown
    Friend WithEvents RubberQty As NumericUpDown
    Friend WithEvents PlasticQty As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ProdQty As NumericUpDown
End Class
