'This form is a modified version of "PackingStation.vb" that allows the user to print the barcode labels instead of scanning them
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing


Public Class AlignPrinter
    Public pd As New PrintDialog()

    Private Sub AlignPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()
    End Sub

    'this creates the test file to test if the alignment matches up
    Private Sub CreateTestFile()
        Try
            Dim objReader As StreamReader = New StreamReader(LabelDirectory & "\PrintCommandsTemplate.txt")
            Dim OutputText As String = ""
            Do While objReader.Peek() <> -1
                'read all lines from the printcommandtemplate
                Dim ZPLline As String = objReader.ReadLine
                If ZPLline.Contains("^FO") Then
                    'the line has a field origin to be modified
                    Dim ZPLCommands As String() = ZPLline.Split("^"c)
                    Dim ZPLModifiedLine As String = ""
                    For Each ZPLCommand In ZPLCommands
                        If ZPLCommand.StartsWith("FO") Then
                            'read the field orgins command and adjust them
                            Dim ZPLParameters As String() = ZPLCommand.Remove(0, 2).Split(","c) 'removes the FO and splits the X and Y
                            Dim ZPLXOrigin As Integer = Convert.ToInt32(ZPLParameters(0)) + XAxisNumericUpDown.Value
                            Dim ZPLYOrigin As Integer = Convert.ToInt32(ZPLParameters(1)) + YAxisNumericUpDown.Value
                            ZPLModifiedLine = ZPLModifiedLine & "FO" & ZPLXOrigin & "," & ZPLYOrigin
                        Else
                            ZPLModifiedLine = ZPLModifiedLine & "^" & ZPLCommand
                        End If
                    Next
                    OutputText = OutputText & ZPLModifiedLine & vbNewLine
                Else
                    OutputText = OutputText & ZPLline & vbNewLine
                End If
            Loop
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\TESTPrintCommandsTemplate.txt", OutputText, False)
            objReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestButton.Click
        Try
            CreateTestFile()

            My.Computer.FileSystem.CopyFile(LabelDirectory & "\TESTPrintCommandsTemplate.txt", LabelDirectory & "\PrintCommands.txt", True)
            Dim fileReader As String
            'barcode
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#BARCODE#", "9999")
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Date
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#DATE#", DirectCast(Date.Now, Date).ToString("MMddyy"))
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Egg Size
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#SIZE#", "99")
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Egg Color
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#COLOR#", "XX")
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Species
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#SPECIES#", "bearii")
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)
            'Product
            fileReader = My.Computer.FileSystem.ReadAllText(LabelDirectory & "\PrintCommands.txt").Replace("#PRODUCT#", "X9999")
            My.Computer.FileSystem.WriteAllText(LabelDirectory & "\PrintCommands.txt", fileReader, False)

            'print
            RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, LabelDirectory & "\PrintCommands.txt")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            CreateTestFile()
            My.Computer.FileSystem.CopyFile(LabelDirectory & "\TESTPrintCommandsTemplate.txt", LabelDirectory & "\PrintCommandsTemplate.txt", True) 'replaces the previous template file with the new one
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XAxisNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XAxisNumericUpDown.ValueChanged
        XInchLabel.Text = Math.Round(XAxisNumericUpDown.Value / 203, 3)
    End Sub

    Private Sub YAxisNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YAxisNumericUpDown.ValueChanged
        YInchLabel.Text = Math.Round(YAxisNumericUpDown.Value / 203, 3)
    End Sub
End Class