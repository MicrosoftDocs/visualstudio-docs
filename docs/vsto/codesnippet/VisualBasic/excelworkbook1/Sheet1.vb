
Public Class Sheet1

    Private Sub Sheet1_Startup() Handles Me.Startup
        Test()
        SortRange()
    End Sub

    Private Sub Test()
        Globals.Sheet1.Range("A1").Value2 = "missspeling"

        '<Snippet1>
        Globals.Sheet1.CheckSpelling(ignoreUppercase:=True)
        '</Snippet1>

    End Sub

    Private Sub SortRange()

        ' Set some data in a range of cells.
        Dim rangeToSort As Excel.Range = Globals.Sheet1.Range("A1", "A5")
        rangeToSort("A1").Value2 = 30
        rangeToSort("A2").Value2 = 10
        rangeToSort("A3").Value2 = 20
        rangeToSort("A4").Value2 = 50
        rangeToSort("A5").Value2 = 40

        ' Sort the NamedRange.
        rangeToSort.Sort(rangeToSort.Cells,
            Excel.XlSortOrder.xlAscending,
            Orientation:=Excel.XlSortOrientation.xlSortColumns)
    End Sub

    Private Sub Sheet1_Shutdown() Handles Me.Shutdown

    End Sub

End Class
