Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports System.Speech.Synthesis

'This module contains subs, functions, variables that are shared across the program
Public Module Common

    Public LabelDirectory As String = My.Application.Info.DirectoryPath & "\Label Printing" '\barcode.txt"
    'Public LabelDirectory As String = "\\Amerigo\public\STURGEON FOLDER\Mochi\Sturgeon Manager v1.0\Label Printing"

    'defines the type of reports
    Public Enum ReportType
        CaviarInvoiceReport = 1
        OtherInvoiceReport = 2
        ProductListingReport = 3
        CustomerList = 4
        CaviarPackingReport = 5
        OtherPackingReport = 6
        InventoryValue = 7
    End Enum

    'this makes a copy of the mdb file and saves it to the backup folder
    Public Sub BackUp(Optional ByVal CurrentDirectory As String = "")
        Try
            If CurrentDirectory = "" Then
                CurrentDirectory = My.Application.Info.DirectoryPath
            End If
            My.Computer.FileSystem.CopyFile(CurrentDirectory & "\SturgeonDB.mdb", CurrentDirectory & "\BackUp\BackUpDB " & Date.Now.ToString("MM-dd-yy-H-mm-ss") & ".mdb")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub DeletePastBackUp(ByVal Days As Integer)
        Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\BackUp\")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1
            Dim DateCreated As Date = BackUpTextToTime(dra.Name)
            If DateCreated < Date.Now.AddDays(Days) Then
                dra.Delete()
            End If
        Next
    End Sub

    'this loops through rows of data and finds the key to a given value
    Public Function IndexInDataRows(ByVal InputRows() As DataRow, ByVal ValueColumnName As String, ByVal IndexColumnName As String, ByVal Value As String) As Integer
        Try
            Dim I As Integer
            For I = 0 To InputRows.Count - 1
                If InputRows(I).Item(ValueColumnName) = Value Then
                    Return InputRows(I).Item(IndexColumnName)
                End If
            Next
        Catch ex As Exception
            Return -1
        End Try
        'MsgBox("Item Not Found!") 'debug
        Return -1
    End Function

    Public Function ValidateTextbox(ByRef InputTextBox As TextBox) As Boolean
        If InputTextBox.Text = "" Then
            InputTextBox.BackColor = Color.Red
            Return False
        Else
            InputTextBox.BackColor = Color.Lime
            Return True
        End If
    End Function

    Public Function ValidateCombobox(ByRef InputComboBox As ComboBox) As Boolean
        If InputComboBox.Text = "" Then
            InputComboBox.BackColor = Color.Red
            Return False
        Else
            InputComboBox.BackColor = Color.Lime
            Return True
        End If
    End Function

    Public Function ValidateDateTimePicker(ByRef InputDateTimePicker) As Boolean
        If IsNothing(InputDateTimePicker.Value()) Then
            InputDateTimePicker.BackColor = Color.Red
            Return False
        Else
            InputDateTimePicker.BackColor = Color.Lime
            Return True
        End If
    End Function

    'fuctionally determines the grade of caviar
    Public Function DetermineGrade(ByVal Firmness As String, ByVal EggSize As String) As String
        If IsNothing(Firmness) Or IsNothing(EggSize) Or Not IsNumeric(EggSize) Then
            Return ""
        ElseIf Firmness = "WET" Then
            Return "D"
        ElseIf Convert.ToDecimal(EggSize) < 2.4 And Not Firmness = "SOFT" Then
            Return "B"
        ElseIf Firmness = "SOFT" Then
            Return "C"
        Else
            Return "A"
        End If
    End Function

    'exports a datagridview's data to excel
    Public Sub ExcelExport(ByVal inputDataGridView As DataGridView, Optional ByVal ExportRowHeader As Boolean = False)
        Using (New WaitCursor) 'Load Hourglass

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer



            xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim Boldstyle As Microsoft.Office.Interop.Excel.Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("BoldStyle")
            Boldstyle.Font.Bold = True

            With xlWorkSheet
                For Each column As DataGridViewColumn In inputDataGridView.Columns
                    If ExportRowHeader Then
                        .Cells(1, column.Index + 2) = column.HeaderText
                    Else
                        .Cells(1, column.Index + 1) = column.HeaderText
                    End If
                Next
                For i = 1 To inputDataGridView.RowCount
                    If inputDataGridView.Rows(i - 1).IsNewRow Then 'skip displaying the new row
                        Continue For
                    End If
                    '.Cells(i + 1, 1) = inputDataGridView.Rows(i - 1).Cells("id").Value
                    If ExportRowHeader Then
                        .Cells(i + 1, 1) = inputDataGridView.Rows(i - 1).HeaderCell.FormattedValue
                        For j = 0 To inputDataGridView.Columns.Count - 1
                            .Cells(i + 1, j + 2) = inputDataGridView.Rows(i - 1).Cells(j).FormattedValue
                            If Not IsNothing(inputDataGridView.Rows(i - 1).Cells(j).Style.Font) AndAlso inputDataGridView.Rows(i - 1).Cells(j).Style.Font.Bold Then
                                .Cells(i + 1, j + 2).Style = "BoldStyle"
                            End If
                        Next
                    Else
                        For j = 0 To inputDataGridView.Columns.Count - 1
                            .Cells(i + 1, j + 1) = inputDataGridView.Rows(i - 1).Cells(j).FormattedValue
                            If Not IsNothing(inputDataGridView.Rows(i - 1).Cells(j).Style.Font) AndAlso inputDataGridView.Rows(i - 1).Cells(j).Style.Font.Bold Then
                                .Cells(i + 1, j + 1).Style = "BoldStyle"
                            End If
                        Next
                    End If
                Next
            End With
            xlApp.Visible = True
        End Using
        'xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'MsgBox("You can find the file D:\vbexcel.xlsx")
    End Sub

    'This function tests if a string has valid parentheses pairs
    Public Function MatchParentheses(ByVal InputString As String) As Boolean
        Dim myStack As New Stack()
        For Each element As Char In InputString
            If element = "("c Then
                myStack.Push("("c)
            ElseIf element = ")"c Then
                If myStack.Count = 0 Then ' ) reached with unmatched (
                    Return False
                Else
                    myStack.Pop()
                End If
            End If
        Next
        If myStack.Count = 0 Then
            Return True ' parens match
        Else
            Return False
        End If
    End Function

    'This function tests regularexpressions, regular expressions can be generated here http://www.jslab.dk/tools.regex.php
    Public Function ValidateTextFormatFailed(ByRef TextBoxToValidate As TextBox, ByVal Pattern As String, Optional ByVal Format As String = "")
        Try
            If TextBoxToValidate.Text = "" Then 'allow empty string to validate
                Return False
            End If

            Dim r As New Regex(Pattern)
            Dim m As Match = r.Match(TextBoxToValidate.Text)
            If m.Success Then
                Return False
            Else
                MsgBox("Text does not match anticipated format" & Format & "! Please reenter")
                TextBoxToValidate.SelectAll()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            TextBoxToValidate.SelectAll()
            Return True
        End Try
    End Function

    'This function tests regularexpressions for a datagridview, regular expressions can be generated here http://www.jslab.dk/tools.regex.php
    Public Function ValidateDataGridViewTextFormatFailed(ByRef myDataGridView As DataGridView, ByVal Pattern As String, Optional ByVal Format As String = "", Optional ByVal AllowNull As Boolean = True)
        Try
            Dim TextBoxToValidate As TextBox = DirectCast(myDataGridView.EditingControl, TextBox)
            If IsNothing(TextBoxToValidate) Then
                myDataGridView.BeginEdit(False)
                TextBoxToValidate = DirectCast(myDataGridView.EditingControl, TextBox)
            End If
            Try
                If TextBoxToValidate.Text = "" Then
                    If AllowNull Then
                        'allow empty string to validate
                        Return False
                    Else
                        MsgBox("This is a required value, please enter" & Format)
                        Return True
                    End If
                End If

                Dim r As New Regex(Pattern)
                Dim m As Match = r.Match(TextBoxToValidate.Text)
                If m.Success Then
                    Return False
                Else
                    MsgBox("Text does not match anticipated format" & Format & "! Please reenter")
                    TextBoxToValidate.SelectAll()
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                TextBoxToValidate.SelectAll()
                Return True
            End Try
        Catch ex As Exception
            Return False
        End Try
    End Function

    'this function validates a number range
    Public Function ValidateNumberFailed(ByRef TextBoxToValidate As TextBox, ByVal LowerBound As Double, ByVal UpperBound As Double)
        If TextBoxToValidate.Text = "" Then 'allow empty string to validate
            Return False
        End If
        If IsNumeric(TextBoxToValidate.Text) Then
            If Convert.ToDouble(TextBoxToValidate.Text) <= UpperBound And Convert.ToDouble(TextBoxToValidate.Text) >= LowerBound Then
                Return False
            Else
                MsgBox("Number entered is not valid. Please enter a number between " & LowerBound & " and " & UpperBound)
                TextBoxToValidate.SelectAll()
                Return True
            End If
        Else
            MsgBox("Number entered is not valid. Please enter a number between " & LowerBound & " and " & UpperBound)
            TextBoxToValidate.SelectAll()
            Return True
        End If
    End Function

    'this function validates a number range for a datagridview
    Public Function ValidateEditingDataGridViewNumber(ByRef myDataGridView As DataGridView, ByVal LowerBound As Double, ByVal UpperBound As Double)
        Try
            Dim TextBoxToValidate As TextBox = DirectCast(myDataGridView.EditingControl, TextBox)
            If TextBoxToValidate.Text = "" Then 'allow empty string to validate
                Return "NULL"
            End If
            If IsNumeric(TextBoxToValidate.Text) Then
                If Convert.ToDouble(TextBoxToValidate.Text) <= UpperBound And Convert.ToDouble(TextBoxToValidate.Text) >= LowerBound Then
                    Return "VALID"
                Else
                    Return "OUT_OF_RANGE"
                End If
            Else
                MsgBox("Number entered is not valid. Please enter a number between " & LowerBound & " and " & UpperBound)
                TextBoxToValidate.SelectAll()
                Return "NOT_NUMBER"
            End If
        Catch ex As Exception
            Return "EXCEPTION"
        End Try
    End Function

    'this function validates a number range for any datagridview cell
    Public Function ValidateDataGridViewCellNumber(ByRef cell As DataGridViewCell, ByVal LowerBound As Double, ByVal UpperBound As Double)
        Try
            If cell.FormattedValue = "" Then 'allow empty string to validate
                Return "NULL"
            End If
            If IsNumeric(cell.FormattedValue) Then
                If Convert.ToDouble(cell.FormattedValue) <= UpperBound And Convert.ToDouble(cell.FormattedValue) >= LowerBound Then
                    Return "VALID"
                ElseIf Convert.ToDouble(cell.FormattedValue) > UpperBound Then
                    Return "HIGH"
                ElseIf Convert.ToDouble(cell.FormattedValue) < LowerBound Then
                    Return "LOW"
                Else
                    Return "OUT_OF_RANGE"
                End If
            Else
                Return "NOT_NUMBER"
            End If
        Catch ex As Exception
            Return "EXCEPTION"
        End Try
    End Function

    'this function converts the backup file names to an actual date
    Public Function BackUpTextToTime(ByVal input As String) As Date
        Return Date.Parse(input.Substring(9, 8) & " " & input.Substring(18, 8).Replace("-", ":"))
    End Function

    'this function formats all logical 10 digit phone numbers to (###) ###-####
    Public Function PhoneFormat(ByVal strPhoneNumber As String) As String
        If strPhoneNumber = "" Then
            Return ""
        End If
        ' Remove any style characters from the user input
        strPhoneNumber = Replace(strPhoneNumber, ")", "")
        strPhoneNumber = Replace(strPhoneNumber, "(", "")
        strPhoneNumber = Replace(strPhoneNumber, "-", "")
        strPhoneNumber = Replace(strPhoneNumber, ".", "")
        strPhoneNumber = Replace(strPhoneNumber, Space(1), "")

        Dim strFormatedNumber As String = CLng(strPhoneNumber).ToString("(###) ###-####")
        Return strFormatedNumber
    End Function

    'this sub allows text to be spoken by the text to speech functionality in windows
    Public Sub SpeakText(ByVal textToSpeak As String, Optional ByVal rate As Integer = 100)
        Dim synth As New SpeechSynthesizer
        Dim txt As String
        txt = "<speak version='1.0' xml:lang='en-US'>"
        txt &= "<prosody rate='" & rate & "%'>" 'speed up or slow down the rate
        txt &= textToSpeak
        txt &= "</prosody></speak>"
        synth.SpeakSsml(txt)
    End Sub

    'this sub separates the letter and the numbers in the caviar product code and sends it to be spoken
    Public Sub SpeakProductCode(ByVal ProductCode As String, Optional ByVal rate As Integer = 100)
        Dim num As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
        Dim chr As Char() = {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c, _
         "g"c, "h"c, "i"c, "j"c, "k"c, "l"c, _
         "m"c, "n"c, "o"c, "p"c, "q"c, "r"c, _
         "s"c, "t"c, "u"c, "v"c, "w"c, "x"c, _
         "y"c, "z"c, "A"c, "B"c, "C"c, "D"c, _
         "E"c, "F"c, "G"c, "H"c, "I"c, "J"c, _
         "K"c, "L"c, "M"c, "N"c, "O"c, "P"c, _
         "Q"c, "R"c, "S"c, "T"c, "U"c, "V"c, _
         "W"c, "X"c, "Y"c, "Z"c}
        Dim output As String = ""
        Dim snum As String() = ProductCode.Split(num)
        Dim schr As String() = ProductCode.Split(chr)
        Dim enu As IEnumerator = snum.GetEnumerator()
        Dim en As IEnumerator = schr.GetEnumerator()
        While enu.MoveNext()
            If Convert.ToString(enu.Current) <> "" Then
                output = output & Convert.ToString(enu.Current) & " "
            End If
        End While
        While en.MoveNext()
            If Convert.ToString(en.Current) <> "" Then
                output = output & Convert.ToInt32(Convert.ToString(en.Current)) & " "
            End If
        End While
        SpeakText(output, rate)
    End Sub

    Public Function GenerateGoogleMapsURL(ByVal Addr1 As String, ByVal Addr2 As String, ByVal Addr3 As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal Country As String) As String
        Addr1 = Addr1.Trim.Replace(" ", "+")
        Addr2 = Addr2.Trim.Replace(" ", "+")
        Addr3 = Addr3.Trim.Replace(" ", "+")
        City = City.Trim.Replace(" ", "+")
        State = State.Trim.Replace(" ", "+")
        Zip = Zip.Trim.Replace(" ", "+")
        Country = Country.Trim.Replace(" ", "+")

        Return "http://maps.googleapis.com/maps/api/geocode/xml?address=" & Addr1 & "+" & Addr2 & "+" & Addr3 & ",+" & City & ",+" & State & "&sensor=false"
    End Function


    Public Function GenerateUSPSURL(ByVal Addr1 As String, ByVal Addr2 As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal Country As String) As String
        Addr1 = Addr1.Trim.Replace(" ", "%20")
        Addr2 = Addr2.Trim.Replace(" ", "%20")
        City = City.Trim.Replace(" ", "%20")
        State = State.Trim.Replace(" ", "%20")
        'Zip = Zip.Trim.Replace(" ", "%20")
        'Country = Country.Trim.Replace(" ", "%20")
        Return "http://production.shippingapis.com/ShippingAPITest.dll?API=Verify&XML=<AddressValidateRequest%20USERID=" & """" & "338MOTEM1791" & """" & "><Address ID=" & """" & "0" & """" & "><Address1>" & Addr2 & "</Address1><Address2>" & Addr1 & "</Address2><City>" & City & "</City><State>" & State & "</State><Zip5></Zip5><Zip4></Zip4></Address></AddressValidateRequest>"
    End Function

    Public Sub PrintLabel(ByVal Item As DataRowView, ByVal Fish As DataRowView, ByVal ProductName As String, ByVal pd As PrintDialog)
        PrintLabelDirectInput(Item("PKBarcode"), DirectCast(Fish("Harvest Date"), Date), Fish("Eggsize"), Fish("Egg Color"), Fish("Species"), ProductName, pd)
    End Sub

    Public Sub PrintLabelDirectInput(ByVal Barcode As String, ByVal HarvestDate As Date, ByVal EggSize As Double, ByVal Color As String, ByVal Species As String, ByVal ProductName As String, ByVal pd As PrintDialog)
        'Try
        '    Dim objWriter As New System.IO.StreamWriter(LabelDirectory & "\barcode.txt")
        '    objWriter.Write(Item("PKBarcode"))
        '    objWriter.Close()

        '    objWriter = New System.IO.StreamWriter(LabelDirectory & "\harvest date.txt")
        '    objWriter.Write(DirectCast(DirectCast(Caviar_FishBindingSource.Current, DataRowView)("Harvest Date"), Date).ToString("d"))
        '    objWriter.Close()

        '    objWriter = New System.IO.StreamWriter(LabelDirectory & "\egg size.txt")
        '    objWriter.Write(DirectCast(Caviar_FishBindingSource.Current, DataRowView)("Eggsize"))
        '    objWriter.Close()

        '    objWriter = New System.IO.StreamWriter(LabelDirectory & "\egg color.txt")
        '    objWriter.Write(DirectCast(Caviar_FishBindingSource.Current, DataRowView)("Egg Color"))
        '    objWriter.Close()

        '    objWriter = New System.IO.StreamWriter(LabelDirectory & "\species.txt")
        '    objWriter.Write("A. " & DirectCast(Caviar_FishBindingSource.Current, DataRowView)("Species"))
        '    objWriter.Close()

        '    objWriter = New System.IO.StreamWriter(LabelDirectory & "\product code.txt")
        '    objWriter.Write(SturgeonDBDataSet.Products.FindByPKProductID(Item("FKProductID")).Item("Product Name"))
        '    objWriter.Close()

        '    'print with bartender
        '    Dim ProcessProperties As New ProcessStartInfo
        '    ProcessProperties.FileName = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Seagull\BarTender Suite\bartend.exe"
        '    ProcessProperties.WorkingDirectory = LabelDirectory
        '    ProcessProperties.Arguments = "label.btw /P /X"
        '    ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        '    Dim myProcess As Process = Process.Start(ProcessProperties)
        '    myProcess.WaitForExit()

        'Catch ex As Exception
        '    'vbNull to integer exception
        '    'MsgBox(ex.Message)
        'End Try

        Try
            My.Computer.FileSystem.CopyFile(LabelDirectory & "\PrintCommandsTemplate.txt", LabelDirectory & "\PrintCommands.txt", True)

            Dim fileReader As String
            'barcode
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#BARCODE#", Barcode)
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Date
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#DATE#", HarvestDate.ToString("MMddyy"))
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Egg Size
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#SIZE#", EggSize * 10)
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Egg Color
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#COLOR#", Color)
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Species
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#SPECIES#", Species)
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Product
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#PRODUCT#", ProductName)
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)

            'print
            RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, LabelDirectory & "\PrintCommands.txt")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetSampleProductName(ByVal ProductName As String)
        If Len(ProductName) = 5 Then
            Return ProductName.Substring(0, 1) & "S" & ProductName.Substring(1, 4)
        Else
            Return "ERROR"
        End If
    End Function

    Public Function GetProductNameFromSample(ByVal SampleName As String)
        If Len(SampleName) = 6 Then
            Return SampleName.Substring(0, 1) & SampleName.Substring(2, 4)
        Else
            Return "ERROR"
        End If
    End Function

    Public Function GetChartType(ByVal ChartType As String) As Windows.Forms.DataVisualization.Charting.SeriesChartType
        Select Case ChartType
            Case "pie"
                Return DataVisualization.Charting.SeriesChartType.Pie
            Case "bar"
                Return DataVisualization.Charting.SeriesChartType.Bar
            Case "line"
                Return DataVisualization.Charting.SeriesChartType.Line
        End Select
    End Function

    Public Function GetIntervalType(ByVal IntervalType As String) As Windows.Forms.DataVisualization.Charting.IntervalType
        Select Case IntervalType
            Case "year"
                Return DataVisualization.Charting.IntervalType.Years
            Case "month"
                Return DataVisualization.Charting.IntervalType.Months
            Case "week"
                Return DataVisualization.Charting.IntervalType.Weeks
            Case "day"
                Return DataVisualization.Charting.IntervalType.Days
            Case "number"
                Return DataVisualization.Charting.IntervalType.Number
            Case "string"
                Return DataVisualization.Charting.IntervalType.Number
        End Select
    End Function

    ''' <summary>  
    ''' Compare two DataTables and return a DataTable with DifferentRecords  
    ''' </summary>  
    ''' <param name="FirstDataTable">FirstDataTable</param>  
    ''' <param name="SecondDataTable">SecondDataTable</param>  
    ''' <returns>true or false</returns>  
    Public Function TablesEqual(ByVal FirstDataTable As DataTable, ByVal SecondDataTable As DataTable) As Boolean
        If FirstDataTable.Rows.Count <> SecondDataTable.Rows.Count Then
            Return False
        ElseIf FirstDataTable.Columns.Count <> SecondDataTable.Columns.Count Then
            Return False
        Else
            For i As Integer = 0 To FirstDataTable.Rows.Count - 1
                For j As Integer = 0 To FirstDataTable.Columns.Count - 1
                    If Not FirstDataTable.Rows(i)(j).Equals(SecondDataTable.Rows(i)(j)) Then
                        Return False
                    End If
                Next
            Next
        End If
        Return True
    End Function

    Public Function GetPastWeekDay(ByVal d As DayOfWeek, Optional ByVal StartDate As Date = Nothing) As Date
        If StartDate = DateTime.MinValue Then StartDate = Now
        For p As Integer = 0 To 6
            If StartDate.AddDays(-p).DayOfWeek = d Then Return StartDate.AddDays(-p)
        Next
    End Function

    Public Function GetThisWeekDay(ByVal d As DayOfWeek, Optional ByVal StartDate As Date = Nothing) As Date
        If StartDate = DateTime.MinValue Then StartDate = Now
        For p As Integer = 0 To 6
            If StartDate.AddDays(p).DayOfWeek = d Then Return StartDate.AddDays(p)
        Next
    End Function
End Module
