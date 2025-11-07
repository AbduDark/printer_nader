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
        Me.txtPrintLength = New System.Windows.Forms.TextBox()
        Me.txtPrintWidth = New System.Windows.Forms.TextBox()
        Me.txtPrintTemp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtWideBarWidth = New System.Windows.Forms.TextBox()
        Me.txtNarrowBarWidth = New System.Windows.Forms.TextBox()
        Me.txtBarcodeY = New System.Windows.Forms.TextBox()
        Me.txtBarcodeX2 = New System.Windows.Forms.TextBox()
        Me.txtBarcodeX1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPrinterName = New System.Windows.Forms.TextBox()
        Me.chkPrintMode = New System.Windows.Forms.CheckBox()
        Me.btnOpenPrint = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtHashSize = New System.Windows.Forms.TextBox()
        Me.txtNumberSize = New System.Windows.Forms.TextBox()
        Me.txtNumberY = New System.Windows.Forms.TextBox()
        Me.txtNumberX = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblPreviewNumber2 = New System.Windows.Forms.Label()
        Me.lblPreviewNumber1 = New System.Windows.Forms.Label()
        Me.btnNewPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.chkPrintBarcode = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        
        'GroupBox1 - مقاس الطباعة بالملم
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtPrintLength)
        Me.GroupBox1.Controls.Add(Me.txtPrintWidth)
        Me.GroupBox1.Controls.Add(Me.txtPrintTemp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(288, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مقاس الطباعة بالملم"
        
        'Label1 - حرارة الطباعة
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "حرارة الطباعة"
        
        'txtPrintTemp
        Me.txtPrintTemp.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPrintTemp.Location = New System.Drawing.Point(40, 32)
        Me.txtPrintTemp.Name = "txtPrintTemp"
        Me.txtPrintTemp.Size = New System.Drawing.Size(80, 25)
        Me.txtPrintTemp.TabIndex = 1
        Me.txtPrintTemp.Text = "15"
        Me.txtPrintTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label2 - العرض
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(210, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "العرض"
        
        'txtPrintWidth
        Me.txtPrintWidth.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPrintWidth.Location = New System.Drawing.Point(40, 69)
        Me.txtPrintWidth.Name = "txtPrintWidth"
        Me.txtPrintWidth.Size = New System.Drawing.Size(80, 25)
        Me.txtPrintWidth.TabIndex = 3
        Me.txtPrintWidth.Text = "40"
        Me.txtPrintWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label3 - الطول
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(210, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الطول"
        
        'txtPrintLength
        Me.txtPrintLength.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtPrintLength.Location = New System.Drawing.Point(40, 106)
        Me.txtPrintLength.Name = "txtPrintLength"
        Me.txtPrintLength.Size = New System.Drawing.Size(80, 25)
        Me.txtPrintLength.TabIndex = 5
        Me.txtPrintLength.Text = "25"
        Me.txtPrintLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'GroupBox2 - مقاسات الباركود
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtWideBarWidth)
        Me.GroupBox2.Controls.Add(Me.txtNarrowBarWidth)
        Me.GroupBox2.Controls.Add(Me.txtBarcodeY)
        Me.GroupBox2.Controls.Add(Me.txtBarcodeX2)
        Me.GroupBox2.Controls.Add(Me.txtBarcodeX1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(18, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(288, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مقاسات الباركود"
        
        'Label4 - ارتفاع
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(210, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ارتفاع"
        
        'Label5 - X
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "X"
        
        'txtBarcodeX1
        Me.txtBarcodeX1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtBarcodeX1.Location = New System.Drawing.Point(70, 32)
        Me.txtBarcodeX1.Name = "txtBarcodeX1"
        Me.txtBarcodeX1.Size = New System.Drawing.Size(60, 25)
        Me.txtBarcodeX1.TabIndex = 2
        Me.txtBarcodeX1.Text = "2"
        Me.txtBarcodeX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'txtBarcodeX2
        Me.txtBarcodeX2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtBarcodeX2.Location = New System.Drawing.Point(140, 32)
        Me.txtBarcodeX2.Name = "txtBarcodeX2"
        Me.txtBarcodeX2.Size = New System.Drawing.Size(60, 25)
        Me.txtBarcodeX2.TabIndex = 3
        Me.txtBarcodeX2.Text = "4"
        Me.txtBarcodeX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label6 - Y
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Y"
        
        'txtBarcodeY
        Me.txtBarcodeY.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtBarcodeY.Location = New System.Drawing.Point(70, 72)
        Me.txtBarcodeY.Name = "txtBarcodeY"
        Me.txtBarcodeY.Size = New System.Drawing.Size(60, 25)
        Me.txtBarcodeY.TabIndex = 5
        Me.txtBarcodeY.Text = "1"
        Me.txtBarcodeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label7 - Narrow Bar Width
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(135, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Narrow Bar Width"
        
        'txtNarrowBarWidth
        Me.txtNarrowBarWidth.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNarrowBarWidth.Location = New System.Drawing.Point(70, 117)
        Me.txtNarrowBarWidth.Name = "txtNarrowBarWidth"
        Me.txtNarrowBarWidth.Size = New System.Drawing.Size(60, 25)
        Me.txtNarrowBarWidth.TabIndex = 7
        Me.txtNarrowBarWidth.Text = "2"
        Me.txtNarrowBarWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label8 - Wide Bar Width
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(155, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Wide Bar Width"
        
        'txtWideBarWidth
        Me.txtWideBarWidth.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtWideBarWidth.Location = New System.Drawing.Point(70, 157)
        Me.txtWideBarWidth.Name = "txtWideBarWidth"
        Me.txtWideBarWidth.Size = New System.Drawing.Size(60, 25)
        Me.txtWideBarWidth.TabIndex = 9
        Me.txtWideBarWidth.Text = "4"
        Me.txtWideBarWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'GroupBox3 - الطابعة والوضع
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnOpenPrint)
        Me.GroupBox3.Controls.Add(Me.txtPrinterName)
        Me.GroupBox3.Controls.Add(Me.chkPrintMode)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(345, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(497, 65)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        
        'chkPrintMode - 2x1 checkbox
        Me.chkPrintMode.BackColor = System.Drawing.Color.Yellow
        Me.chkPrintMode.Checked = True
        Me.chkPrintMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintMode.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.chkPrintMode.ForeColor = System.Drawing.Color.Black
        Me.chkPrintMode.Location = New System.Drawing.Point(395, 23)
        Me.chkPrintMode.Name = "chkPrintMode"
        Me.chkPrintMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrintMode.Size = New System.Drawing.Size(85, 26)
        Me.chkPrintMode.TabIndex = 0
        Me.chkPrintMode.Text = "2x1"
        Me.chkPrintMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkPrintMode.UseVisualStyleBackColor = False
        
        'txtPrinterName
        Me.txtPrinterName.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtPrinterName.Location = New System.Drawing.Point(100, 23)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.Size = New System.Drawing.Size(280, 24)
        Me.txtPrinterName.TabIndex = 1
        Me.txtPrinterName.Text = "Xprinter XP-370B"
        Me.txtPrinterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'btnOpenPrint
        Me.btnOpenPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnOpenPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOpenPrint.ForeColor = System.Drawing.Color.White
        Me.btnOpenPrint.Location = New System.Drawing.Point(15, 18)
        Me.btnOpenPrint.Name = "btnOpenPrint"
        Me.btnOpenPrint.Size = New System.Drawing.Size(75, 35)
        Me.btnOpenPrint.TabIndex = 2
        Me.btnOpenPrint.Text = "فتح الطبعة"
        Me.btnOpenPrint.UseVisualStyleBackColor = False
        
        'GroupBox4 - معلومات إضافية
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtHashSize)
        Me.GroupBox4.Controls.Add(Me.txtNumberSize)
        Me.GroupBox4.Controls.Add(Me.txtNumberY)
        Me.GroupBox4.Controls.Add(Me.txtNumberX)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(345, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(497, 70)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        
        'Label9 - X
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(358, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "X"
        
        'txtNumberX
        Me.txtNumberX.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNumberX.Location = New System.Drawing.Point(383, 27)
        Me.txtNumberX.Name = "txtNumberX"
        Me.txtNumberX.Size = New System.Drawing.Size(90, 25)
        Me.txtNumberX.TabIndex = 1
        Me.txtNumberX.Text = "31"
        Me.txtNumberX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label10 - Y
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(260, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Y"
        
        'txtNumberY
        Me.txtNumberY.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNumberY.Location = New System.Drawing.Point(285, 27)
        Me.txtNumberY.Name = "txtNumberY"
        Me.txtNumberY.Size = New System.Drawing.Size(60, 25)
        Me.txtNumberY.TabIndex = 3
        Me.txtNumberY.Text = "7"
        Me.txtNumberY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label11 - Number Size
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(130, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 14)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Number Size"
        
        'txtNumberSize
        Me.txtNumberSize.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtNumberSize.Location = New System.Drawing.Point(215, 27)
        Me.txtNumberSize.Name = "txtNumberSize"
        Me.txtNumberSize.Size = New System.Drawing.Size(35, 25)
        Me.txtNumberSize.TabIndex = 5
        Me.txtNumberSize.Text = "47"
        Me.txtNumberSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'Label12 - # Size
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(30, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 14)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "# Size"
        
        'txtHashSize
        Me.txtHashSize.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtHashSize.Location = New System.Drawing.Point(80, 27)
        Me.txtHashSize.Name = "txtHashSize"
        Me.txtHashSize.Size = New System.Drawing.Size(35, 25)
        Me.txtHashSize.TabIndex = 7
        Me.txtHashSize.Text = ""
        Me.txtHashSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        
        'GroupBox5 - معاينة
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.lblPreviewNumber2)
        Me.GroupBox5.Controls.Add(Me.lblPreviewNumber1)
        Me.GroupBox5.Controls.Add(Me.btnNewPrint)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(345, 195)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox5.Size = New System.Drawing.Size(497, 255)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        
        'lblPreviewNumber1
        Me.lblPreviewNumber1.BackColor = System.Drawing.Color.White
        Me.lblPreviewNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviewNumber1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewNumber1.ForeColor = System.Drawing.Color.Black
        Me.lblPreviewNumber1.Location = New System.Drawing.Point(357, 25)
        Me.lblPreviewNumber1.Name = "lblPreviewNumber1"
        Me.lblPreviewNumber1.Size = New System.Drawing.Size(123, 90)
        Me.lblPreviewNumber1.TabIndex = 0
        Me.lblPreviewNumber1.Text = "1"
        Me.lblPreviewNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        'lblPreviewNumber2
        Me.lblPreviewNumber2.BackColor = System.Drawing.Color.White
        Me.lblPreviewNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviewNumber2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewNumber2.ForeColor = System.Drawing.Color.Black
        Me.lblPreviewNumber2.Location = New System.Drawing.Point(357, 125)
        Me.lblPreviewNumber2.Name = "lblPreviewNumber2"
        Me.lblPreviewNumber2.Size = New System.Drawing.Size(123, 90)
        Me.lblPreviewNumber2.TabIndex = 1
        Me.lblPreviewNumber2.Text = "50"
        Me.lblPreviewNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        'btnNewPrint
        Me.btnNewPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnNewPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNewPrint.FlatAppearance.BorderSize = 2
        Me.btnNewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPrint.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewPrint.ForeColor = System.Drawing.Color.White
        Me.btnNewPrint.Location = New System.Drawing.Point(20, 70)
        Me.btnNewPrint.Name = "btnNewPrint"
        Me.btnNewPrint.Size = New System.Drawing.Size(150, 90)
        Me.btnNewPrint.TabIndex = 2
        Me.btnNewPrint.Text = "طباعة جديد"
        Me.btnNewPrint.UseVisualStyleBackColor = False
        
        'chkPrintBarcode
        Me.chkPrintBarcode.AutoSize = True
        Me.chkPrintBarcode.Checked = True
        Me.chkPrintBarcode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintBarcode.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkPrintBarcode.ForeColor = System.Drawing.Color.White
        Me.chkPrintBarcode.Location = New System.Drawing.Point(700, 15)
        Me.chkPrintBarcode.Name = "chkPrintBarcode"
        Me.chkPrintBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkPrintBarcode.Size = New System.Drawing.Size(130, 21)
        Me.chkPrintBarcode.TabIndex = 5
        Me.chkPrintBarcode.Text = "طباعة الباركود"
        Me.chkPrintBarcode.UseVisualStyleBackColor = True
        
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 465)
        Me.Controls.Add(Me.chkPrintBarcode)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xprinter XP-370B - طباعة الباركود"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrintLength As TextBox
    Friend WithEvents txtPrintWidth As TextBox
    Friend WithEvents txtPrintTemp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtWideBarWidth As TextBox
    Friend WithEvents txtNarrowBarWidth As TextBox
    Friend WithEvents txtBarcodeY As TextBox
    Friend WithEvents txtBarcodeX2 As TextBox
    Friend WithEvents txtBarcodeX1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPrinterName As TextBox
    Friend WithEvents chkPrintMode As CheckBox
    Friend WithEvents btnOpenPrint As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtHashSize As TextBox
    Friend WithEvents txtNumberSize As TextBox
    Friend WithEvents txtNumberY As TextBox
    Friend WithEvents txtNumberX As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblPreviewNumber2 As Label
    Friend WithEvents lblPreviewNumber1 As Label
    Friend WithEvents btnNewPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents chkPrintBarcode As CheckBox

End Class
