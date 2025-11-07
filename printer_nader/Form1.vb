Imports System.Drawing.Printing
Imports ZXing
Imports ZXing.Common
Imports ZXing.Windows.Compatibility

Public Class Form1
    Private currentNumbers As List(Of Integer)
    Private currentPairIndex As Integer
    Private printWithBarcode As Boolean
    Private barcodeWidth As Integer
    Private barcodeHeight As Integer
    Private numberX As Single
    Private numberY As Single
    Private numberSize As Integer
    Private hashSize As Integer
    Private printTemp As Integer
    Private printWidth As Integer
    Private printLength As Integer
    Private barcodeX1 As Integer
    Private barcodeX2 As Integer
    Private barcodeY As Integer
    Private narrowBarWidth As Integer
    Private wideBarWidth As Integer
    Private printMode As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentNumbers = New List(Of Integer)()
        UpdatePreviewNumbers(1, 50)
    End Sub

    Private Sub UpdatePreviewNumbers(num1 As Integer, num2 As Integer)
        lblPreviewNumber1.Text = num1.ToString()
        lblPreviewNumber2.Text = num2.ToString()
    End Sub

    Private Sub btnNewPrint_Click(sender As Object, e As EventArgs) Handles btnNewPrint.Click
        If Not ValidateInput() Then Return

        PreparePrintData()
        
        Try
            If Not String.IsNullOrWhiteSpace(txtPrinterName.Text) Then
                PrintDocument1.PrinterSettings.PrinterName = txtPrinterName.Text
            End If

            Dim labelsPerPage As Integer = If(printMode = "2x1", 2, 1)
            Dim totalPages As Integer = CInt(Math.Ceiling(currentNumbers.Count / labelsPerPage))
            
            Dim result As DialogResult = MessageBox.Show(
                String.Format("سيتم طباعة {0} ملصق على {1} صفحة ({2}). هل تريد المتابعة؟", 
                              currentNumbers.Count, 
                              totalPages,
                              printMode),
                "تأكيد الطباعة",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                PrintDocument1.Print()
                MessageBox.Show("تمت الطباعة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في الطباعة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpenPrint_Click(sender As Object, e As EventArgs) Handles btnOpenPrint.Click
        If Not ValidateInput() Then Return

        PreparePrintData()
        
        Try
            If Not String.IsNullOrWhiteSpace(txtPrinterName.Text) Then
                PrintDocument1.PrinterSettings.PrinterName = txtPrinterName.Text
            End If

            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("خطأ في المعاينة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        If Not Integer.TryParse(txtPrintTemp.Text, printTemp) OrElse printTemp <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لحرارة الطباعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrintTemp.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtPrintWidth.Text, printWidth) OrElse printWidth <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة للعرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrintWidth.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtPrintLength.Text, printLength) OrElse printLength <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة للطول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrintLength.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBarcodeX1.Text, barcodeX1) OrElse barcodeX1 <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ X الأولى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBarcodeX1.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBarcodeX2.Text, barcodeX2) OrElse barcodeX2 <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ X الثانية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBarcodeX2.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBarcodeY.Text, barcodeY) OrElse barcodeY <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ Y", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBarcodeY.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtNarrowBarWidth.Text, narrowBarWidth) OrElse narrowBarWidth <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ Narrow Bar Width", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNarrowBarWidth.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtWideBarWidth.Text, wideBarWidth) OrElse wideBarWidth <= 0 Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ Wide Bar Width", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWideBarWidth.Focus()
            Return False
        End If

        Dim tempX, tempY As Single
        If Not Single.TryParse(txtNumberX.Text, tempX) Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لموضع الرقم X", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberX.Focus()
            Return False
        End If
        numberX = tempX

        If Not Single.TryParse(txtNumberY.Text, tempY) Then
            MessageBox.Show("الرجاء إدخال قيمة صحيحة لموضع الرقم Y", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberY.Focus()
            Return False
        End If
        numberY = tempY

        If Not Integer.TryParse(txtNumberSize.Text, numberSize) OrElse numberSize <= 0 Then
            MessageBox.Show("الرجاء إدخال حجم خط صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberSize.Focus()
            Return False
        End If

        If Not String.IsNullOrWhiteSpace(txtHashSize.Text) Then
            If Not Integer.TryParse(txtHashSize.Text, hashSize) OrElse hashSize <= 0 Then
                MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ # Size", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtHashSize.Focus()
                Return False
            End If
        Else
            hashSize = 0
        End If

        printMode = If(chkPrintMode.Checked, "2x1", "1x1")

        If String.IsNullOrWhiteSpace(txtPrinterName.Text) Then
            MessageBox.Show("الرجاء إدخال اسم الطابعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrinterName.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub PreparePrintData()
        currentNumbers.Clear()
        currentPairIndex = 0
        
        Dim num1 As Integer
        Dim num2 As Integer
        
        If Integer.TryParse(lblPreviewNumber1.Text, num1) AndAlso Integer.TryParse(lblPreviewNumber2.Text, num2) Then
            If num1 <= num2 Then
                For i As Integer = num1 To num2
                    currentNumbers.Add(i)
                Next
            Else
                MessageBox.Show("الرقم الأول يجب أن يكون أصغر من أو يساوي الرقم الأخير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                For i As Integer = 1 To 50
                    currentNumbers.Add(i)
                Next
            End If
        Else
            For i As Integer = 1 To 50
                currentNumbers.Add(i)
            Next
        End If

        printWithBarcode = chkPrintBarcode.Checked
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.PageUnit = GraphicsUnit.Millimeter
        
        Dim labelWidth As Single = CSng(printWidth)
        Dim labelHeight As Single = CSng(printLength)
        Dim marginLeft As Single = 6.0F
        Dim marginTop As Single = 6.0F
        Dim spacing As Single = 2.0F

        Dim labelsPerPage As Integer = If(printMode = "2x1", 2, 1)
        Dim firstLabelIndex As Integer = currentPairIndex * labelsPerPage
        Dim secondLabelIndex As Integer = firstLabelIndex + 1

        If firstLabelIndex < currentNumbers.Count Then
            DrawLabel(e.Graphics, currentNumbers(firstLabelIndex), marginLeft, marginTop, labelWidth, labelHeight)
        End If

        If labelsPerPage = 2 AndAlso secondLabelIndex < currentNumbers.Count Then
            DrawLabel(e.Graphics, currentNumbers(secondLabelIndex), marginLeft, marginTop + labelHeight + spacing, labelWidth, labelHeight)
        End If

        currentPairIndex += 1
        e.HasMorePages = (currentPairIndex * labelsPerPage) < currentNumbers.Count
    End Sub

    Private Sub DrawLabel(g As Graphics, number As Integer, x As Single, y As Single, width As Single, height As Single)
        Dim numberText As String = number.ToString()
        
        Dim numberFont As New Font("Arial", numberSize, FontStyle.Bold)
        
        Dim actualNumberX As Single = x + numberX
        Dim actualNumberY As Single = y + numberY
        g.DrawString(numberText, numberFont, Brushes.Black, actualNumberX, actualNumberY)

        If hashSize > 0 Then
            Dim hashFont As New Font("Arial", hashSize, FontStyle.Regular)
            g.DrawString("#", hashFont, Brushes.Black, actualNumberX - 10, actualNumberY)
            hashFont.Dispose()
        End If

        If printWithBarcode Then
            Try
                Dim barcodeWidthMm As Single = Math.Abs(CSng(barcodeX2 - barcodeX1))
                Dim barcodeHeightMm As Single = 10.0F
                
                Dim barcodeWidthPixels As Integer = CInt(barcodeWidthMm * 3)
                Dim barcodeHeightPixels As Integer = CInt(barcodeHeightMm * 3)
                
                Dim barcodeImage As Bitmap = GenerateBarcode(numberText, barcodeWidthPixels, barcodeHeightPixels)
                
                Dim actualBarcodeX As Single = x + CSng(barcodeX1)
                Dim actualBarcodeY As Single = y + CSng(barcodeY)
                
                g.DrawImage(barcodeImage, actualBarcodeX, actualBarcodeY, barcodeWidthMm, barcodeHeightMm)
            Catch ex As Exception
                Dim errorFont As New Font("Arial", 8)
                g.DrawString("خطأ في الباركود", errorFont, Brushes.Red, x + 10, y + 50)
                errorFont.Dispose()
            End Try
        End If

        numberFont.Dispose()
    End Sub

    Private Function GenerateBarcode(text As String, width As Integer, height As Integer) As Bitmap
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.CODE_128
        
        Dim options As New EncodingOptions()
        options.Width = width
        options.Height = height
        options.Margin = 0
        options.PureBarcode = False
        
        If narrowBarWidth > 0 AndAlso wideBarWidth > 0 Then
            Dim ratio As Double = CDbl(wideBarWidth) / CDbl(narrowBarWidth)
            Dim effectiveWidth As Integer = CInt(width * ratio / 3)
            options.Width = effectiveWidth
        End If
        
        writer.Options = options
        
        Dim barcodeBitmap As Bitmap = writer.Write(text)
        Return barcodeBitmap
    End Function

    Private Sub lblPreviewNumber1_Click(sender As Object, e As EventArgs) Handles lblPreviewNumber1.Click
        Dim input As String = InputBox("أدخل الرقم الأول:", "تعديل الرقم", lblPreviewNumber1.Text)
        If Not String.IsNullOrWhiteSpace(input) Then
            Dim num As Integer
            If Integer.TryParse(input, num) Then
                lblPreviewNumber1.Text = num.ToString()
            Else
                MessageBox.Show("الرجاء إدخال رقم صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub lblPreviewNumber2_Click(sender As Object, e As EventArgs) Handles lblPreviewNumber2.Click
        Dim input As String = InputBox("أدخل الرقم الأخير:", "تعديل الرقم", lblPreviewNumber2.Text)
        If Not String.IsNullOrWhiteSpace(input) Then
            Dim num As Integer
            If Integer.TryParse(input, num) Then
                lblPreviewNumber2.Text = num.ToString()
            Else
                MessageBox.Show("الرجاء إدخال رقم صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class
