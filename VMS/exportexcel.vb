Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Module exportexcel
    Public Sub dgvtoexcel(ByVal DGV As DataGridView)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        export()

        For i = 0 To DGV.RowCount - 1
            For j = 0 To DGV.ColumnCount - 1
                For k As Integer = 1 To DGV.Columns.Count
                    xlWorkSheet.Cells(1, k) = DGV.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGV(j, i).Value.ToString()
                Next
            Next
        Next

        If downloadpath = "" Then
            Exit Sub
        Else
            xlWorkSheet.SaveAs(downloadpath & "\report_export.xlsx")

        End If

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("DOWNLOAD SUCCESSFUL: You can find the file at " & downloadpath)

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Public downloadpath As String

    Public Function export()
        Dim folderDlg As New FolderBrowserDialog

        folderDlg.ShowNewFolderButton = True

        If (folderDlg.ShowDialog() = DialogResult.OK) Then

            downloadpath = folderDlg.SelectedPath

            Dim root As Environment.SpecialFolder = folderDlg.RootFolder

        End If
    End Function
End Module
