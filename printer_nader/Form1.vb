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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrinters()
        currentNumbers = New List(Of Integer)()
    End Sub

    Private Sub LoadPrinters()
        cmbPrinters.Items.Clear()
        For Each printer As String In PrinterSettings.InstalledPrinters
            cmbPrinters.Items.Add(printer)
        Next

        If cmbPrinters.Items.Count > 0 Then
            If Not String.IsNullOrEmpty(PrintDocument1.PrinterSettings.PrinterName) Then
                Dim index As Integer = cmbPrinters.FindStringExact(PrintDocument1.PrinterSettings.PrinterName)
                If index >= 0 Then
                    cmbPrinters.SelectedIndex = index
                Else
                    cmbPrinters.SelectedIndex = 0
                End If
            Else
                cmbPrinters.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If Not ValidateInput() Then Return

        PreparePrintData()
        
        Try
            If cmbPrinters.SelectedItem IsNot Nothing Then
                PrintDocument1.PrinterSettings.PrinterName = cmbPrinters.SelectedItem.ToString()
            End If

            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("خطأ في المعاينة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Not ValidateInput() Then Return

        PreparePrintData()
        
        Try
            If cmbPrinters.SelectedItem IsNot Nothing Then
                PrintDocument1.PrinterSettings.PrinterName = cmbPrinters.SelectedItem.ToString()
            End If

            Dim result As DialogResult = MessageBox.Show(
                String.Format("سيتم طباعة {0} ملصق على {1} صفحة. هل تريد المتابعة؟", 
                              currentNumbers.Count, 
                              Math.Ceiling(currentNumbers.Count / 2)),
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

    Private Function ValidateInput() As Boolean
        Dim fromNum, toNum As Integer

        If Not Integer.TryParse(txtNumberFrom.Text, fromNum) Then
            MessageBox.Show("الرجاء إدخال رقم صحيح في حقل 'من رقم'", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberFrom.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtNumberTo.Text, toNum) Then
            MessageBox.Show("الرجاء إدخال رقم صحيح في حقل 'إلى رقم'", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberTo.Focus()
            Return False
        End If

        If fromNum > toNum Then
            MessageBox.Show("رقم البداية يجب أن يكون أصغر من أو يساوي رقم النهاية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumberFrom.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBarWidth.Text, barcodeWidth) OrElse barcodeWidth <= 0 Then
            MessageBox.Show("الرجاء إدخال عرض صحيح للباركود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBarWidth.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBarHeight.Text, barcodeHeight) OrElse barcodeHeight <= 0 Then
            MessageBox.Show("الرجاء إدخال ارتفاع صحيح للباركود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBarHeight.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub PreparePrintData()
        currentNumbers.Clear()
        currentPairIndex = 0
        
        Dim fromNum As Integer = Integer.Parse(txtNumberFrom.Text)
        Dim toNum As Integer = Integer.Parse(txtNumberTo.Text)
        printWithBarcode = chkPrintBarcode.Checked

        For i As Integer = fromNum To toNum
            currentNumbers.Add(i)
        Next

        lblStatus.Text = String.Format("جاهز لطباعة {0} ملصق على {1} صفحة", 
                                       currentNumbers.Count, 
                                       Math.Ceiling(currentNumbers.Count / 2))
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim labelWidth As Single = 2.5F * 100
        Dim labelHeight As Single = 1.0F * 100
        Dim marginLeft As Single = 0.25F * 100
        Dim marginTop As Single = 0.25F * 100
        Dim spacing As Single = 0.1F * 100

        Dim firstLabelIndex As Integer = currentPairIndex * 2
        Dim secondLabelIndex As Integer = firstLabelIndex + 1

        If firstLabelIndex < currentNumbers.Count Then
            DrawLabel(e.Graphics, currentNumbers(firstLabelIndex), marginLeft, marginTop, labelWidth, labelHeight)
        End If

        If secondLabelIndex < currentNumbers.Count Then
            DrawLabel(e.Graphics, currentNumbers(secondLabelIndex), marginLeft, marginTop + labelHeight + spacing, labelWidth, labelHeight)
        End If

        currentPairIndex += 1
        e.HasMorePages = (currentPairIndex * 2) < currentNumbers.Count
    End Sub

    Private Sub DrawLabel(g As Graphics, number As Integer, x As Single, y As Single, width As Single, height As Single)
        Dim numberText As String = number.ToString()
        
        Dim numberFont As New Font("Arial", 28, FontStyle.Bold)
        Dim numberSize As SizeF = g.MeasureString(numberText, numberFont)
        
        Dim numberX As Single = x + 10
        Dim numberY As Single = y + 5
        g.DrawString(numberText, numberFont, Brushes.Black, numberX, numberY)

        If printWithBarcode Then
            Try
                Dim barcodeImage As Bitmap = GenerateBarcode(numberText, barcodeWidth, barcodeHeight)
                
                Dim barcodeX As Single = x + 10
                Dim barcodeY As Single = numberY + numberSize.Height + 5
                
                g.DrawImage(barcodeImage, barcodeX, barcodeY, barcodeWidth, barcodeHeight)
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
        
        writer.Options = options
        
        Dim barcodeBitmap As Bitmap = writer.Write(text)
        Return barcodeBitmap
    End Function

End Class
