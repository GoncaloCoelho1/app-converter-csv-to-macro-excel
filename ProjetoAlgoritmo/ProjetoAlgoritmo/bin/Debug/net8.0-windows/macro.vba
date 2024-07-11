Sub AddData()
                                Dim ws As Worksheet
                                Set ws = ThisWorkbook.Sheets(1)
                                Dim nextRow As Long
                                nextRow = ws.Cells(ws.Rows.Count, 1).End(xlUp).Row + 1

                                ws.Cells(nextRow, 1).Value = "123"
ws.Cells(nextRow, 2).Value = "123"
ws.Cells(nextRow, 3).Value = "hospital da luz"
ws.Cells(nextRow, 4).Value = "456"
ws.Cells(nextRow, 5).Value = "123"
ws.Cells(nextRow, 6).Value = "5"
nextRow = nextRow + 1
ws.Cells(nextRow, 1).Value = "125"
ws.Cells(nextRow, 2).Value = "125"
ws.Cells(nextRow, 3).Value = "hospital CUF"
ws.Cells(nextRow, 4).Value = "454"
ws.Cells(nextRow, 5).Value = "126"
ws.Cells(nextRow, 6).Value = "6"
nextRow = nextRow + 1
ws.Cells(nextRow, 1).Value = "126"
ws.Cells(nextRow, 2).Value = "126"
ws.Cells(nextRow, 3).Value = "hospital santa maria"
ws.Cells(nextRow, 4).Value = "458"
ws.Cells(nextRow, 5).Value = "129"
ws.Cells(nextRow, 6).Value = "7"
nextRow = nextRow + 1
End Sub