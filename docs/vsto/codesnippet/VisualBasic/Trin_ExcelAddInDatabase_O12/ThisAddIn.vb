Public Class ThisAddIn
    ' <Snippet1>
    Private addressListObject As Microsoft.Office.Tools.Excel.ListObject
    Private adventureWorksDataSet As AdventureWorksLTDataSet
    Private addressTableAdapter As AdventureWorksLTDataSetTableAdapters.AddressTableAdapter
    Private addressBindingSource As System.Windows.Forms.BindingSource
    ' </Snippet1>

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        ' <Snippet2> 
        Me.addressTableAdapter = New AdventureWorksLTDataSetTableAdapters.AddressTableAdapter()
        Me.adventureWorksDataSet = New AdventureWorksLTDataSet()
        Me.addressTableAdapter.Fill(Me.adventureWorksDataSet.Address)
        Me.addressBindingSource = New System.Windows.Forms.BindingSource()
        ' </Snippet2> 

        ' <Snippet3> 
        Dim worksheet As Excel.Worksheet = DirectCast(Me.Application.ActiveWorkbook.Worksheets(1), Excel.Worksheet)

        ' Create a workhseet host item.
        Dim extendedWorksheet As Worksheet = Globals.Factory.GetVstoObject(worksheet)

        ' </Snippet3> 

        ' <Snippet4> 
        Dim cell As Excel.Range = extendedWorksheet.Range("$A$1:$G$5", System.Type.Missing)
        Me.addressListObject = extendedWorksheet.Controls.AddListObject(cell, "list1")
        ' </Snippet4> 

        ' <Snippet5> 
        Me.addressBindingSource.DataSource = Me.adventureWorksDataSet.Address
        Me.addressListObject.AutoSetDataBoundColumnHeaders = True
        Me.addressListObject.SetDataBinding( _
            Me.addressBindingSource, "", "AddressID", "AddressLine1", _
            "AddressLine2", "City", "StateProvince", "CountryRegion", "PostalCode")
        ' </Snippet5> 
    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
