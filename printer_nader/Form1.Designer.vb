<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumberTo = New System.Windows.Forms.TextBox()
        Me.txtNumberFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPrintBarcode = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBarWidth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBarHeight = New System.Windows.Forms.TextBox()
        Me.cmbPrinters = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        
        'GroupBox1
        Me.GroupBox1.Controls.Add(Me.txtNumberTo)
        Me.GroupBox1.Controls.Add(Me.txtNumberFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(400, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نطاق الأرقام"
        
        'Label1
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(320, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "من رقم:"
        
        'txtNumberFrom
        Me.txtNumberFrom.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNumberFrom.Location = New System.Drawing.Point(150, 32)
        Me.txtNumberFrom.Name = "txtNumberFrom"
        Me.txtNumberFrom.Size = New System.Drawing.Size(150, 25)
        Me.txtNumberFrom.TabIndex = 1
        Me.txtNumberFrom.Text = "1"
        Me.txtNumberFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label2
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(320, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "إلى رقم:"
        
        'txtNumberTo
        Me.txtNumberTo.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNumberTo.Location = New System.Drawing.Point(150, 72)
        Me.txtNumberTo.Name = "txtNumberTo"
        Me.txtNumberTo.Size = New System.Drawing.Size(150, 25)
        Me.txtNumberTo.TabIndex = 3
        Me.txtNumberTo.Text = "50"
        Me.txtNumberTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'GroupBox2
        Me.GroupBox2.Controls.Add(Me.chkPrintBarcode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBarWidth)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBarHeight)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(400, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "إعدادات الباركود"
        
        'chkPrintBarcode
        Me.chkPrintBarcode.AutoSize = True
        Me.chkPrintBarcode.Checked = True
        Me.chkPrintBarcode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintBarcode.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkPrintBarcode.Location = New System.Drawing.Point(220, 30)
        Me.chkPrintBarcode.Name = "chkPrintBarcode"
        Me.chkPrintBarcode.Size = New System.Drawing.Size(163, 21)
        Me.chkPrintBarcode.TabIndex = 0
        Me.chkPrintBarcode.Text = "طباعة الباركود"
        Me.chkPrintBarcode.UseVisualStyleBackColor = True
        
        'Label3
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(260, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ارتفاع الباركود:"
        
        'txtBarHeight
        Me.txtBarHeight.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtBarHeight.Location = New System.Drawing.Point(150, 67)
        Me.txtBarHeight.Name = "txtBarHeight"
        Me.txtBarHeight.Size = New System.Drawing.Size(90, 25)
        Me.txtBarHeight.TabIndex = 2
        Me.txtBarHeight.Text = "50"
        Me.txtBarHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label4
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(275, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "عرض الباركود:"
        
        'txtBarWidth
        Me.txtBarWidth.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtBarWidth.Location = New System.Drawing.Point(150, 107)
        Me.txtBarWidth.Name = "txtBarWidth"
        Me.txtBarWidth.Size = New System.Drawing.Size(90, 25)
        Me.txtBarWidth.TabIndex = 4
        Me.txtBarWidth.Text = "200"
        Me.txtBarWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label5
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(330, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "الطابعة:"
        
        'cmbPrinters
        Me.cmbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrinters.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbPrinters.FormattingEnabled = True
        Me.cmbPrinters.Location = New System.Drawing.Point(12, 317)
        Me.cmbPrinters.Name = "cmbPrinters"
        Me.cmbPrinters.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPrinters.Size = New System.Drawing.Size(300, 24)
        Me.cmbPrinters.TabIndex = 3
        
        'btnPreview
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Location = New System.Drawing.Point(225, 370)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(180, 45)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "معاينة قبل الطباعة"
        Me.btnPreview.UseVisualStyleBackColor = False
        
        'btnPrint
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(12, 370)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(200, 45)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = False
        
        'lblStatus
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(12, 430)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStatus.Size = New System.Drawing.Size(400, 20)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "جاهز للطباعة"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        'PrintPreviewDialog1
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = Nothing
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        
        'Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 461)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.cmbPrinters)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة الباركود - ملصقين لكل طبعة"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumberTo As TextBox
    Friend WithEvents txtNumberFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPrintBarcode As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBarWidth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBarHeight As TextBox
    Friend WithEvents cmbPrinters As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
