
Public Class Sheet1


    ' This object is to allow Snippet6 to compile. This snippet assumes
    ' an existing ListObject.
    Private customerListObject As Microsoft.Office.Tools.Excel.ListObject
    
    
    Private Sub Sheet1_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup
        Try
            'ListObject_Metadata()
            'ListObject_SelectedIndex()
            'ListObject_Delete()
            'ListObject_Publish("URL")
            'ListObject_Resize()
            'ListObject_UpdateChanges()
            'ListObject_SetDataBinding()
            'ListObject_Application()
            'ListObject_BeforeAddDataBoundRow()
            'ListObject_BeforeDoubleClick()
            'ListObject_BeforeRightClick()
            'ListObject_Change()
            'ListObject_Creator()
            'ListObject_DataBindingFailure()
            'ListObject_DataBodyRange()
            'ListObject_DataBoundFormat()
            'ListObject_DataBoundFormatSettings()
            'ListObject_DataSourceAndMember()
            'ListObject_Deselected()
            'ListObject_ErrorAddDataBoundRow()
            'ListObject_HeaderRowRange()
            'ListObject_InsertRowRange()
            'ListObject_ListColumns()
            'ListObject_ListRows()
            'ListObject_OriginalDataRestored()
            'ListObject_Parent()
            'ListObject_QueryTable()
            'ListObject_Range()
            'ListObject_Selected()
            'ListObject_SelectionChange()
            'ListObject_SetDataBinding2()
            'ListObject_SetDataBinding3()
            'ListObject_SharePointURL()
            'ListObject_SourceType()
            'ListObject_TotalsRowRange()
            'ListObject_XmlMap()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    
    
    Private Sub Sheet1_Shutdown(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub
    
    
    
    ' This snippet uses Name and Tag.
    ' The following code example creates a ListObject
    ' on the current worksheet and then uses the Name 
    ' property to set the name of the ListObject to "Employees".
    '<Snippet1>
    Private Sub ListObject_Metadata() 
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "D4"), "Employees")

        List1.Name = "Employees"
        List1.Tag = "Employee data"

        MessageBox.Show("The list name is " + List1.Name.ToString() & _
            " and the tag is " & List1.Tag.ToString() + ".")

    End Sub

    '</Snippet1>

    ' This snippet uses AutoSelectRows, SelectedIndex, and SelectedIndexChanged.
    ' The following code example creates a ListObject 
    ' on the current worksheet and then uses the SelectedIndex 
    ' and AutoSelectRows properties to select the second row 
    ' by default and to specify that the entire row is selected 
    ' when the user clicks a row. The code example also creates 
    ' an event handler for the SelectedIndexChanged event that 
    ' displays a message box whenever a new row is selected.
    '<Snippet2>
    WithEvents SelectedIndexList As Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_SelectedIndex()
        SelectedIndexList = _
            Me.Controls.AddListObject(Me.Range("A1", "D4"), _
            "SelectedIndexList")
	SelectedIndexList.AutoSelectRows = True
        SelectedIndexList.SelectedIndex = 2
    End Sub


    Private Sub List1_SelectedIndexChanged(ByVal sender As Object, _
        ByVal e As EventArgs) Handles SelectedIndexList.SelectedIndexChanged
        MessageBox.Show("Selected index has changed.")
    End Sub

    '</Snippet2>

    ' The following code example creates a ListObject 
    ' on the current worksheet and then displays a 
    ' message box that asks the user whether to 
    ' delete the ListObject. If the user accepts, 
    ' then the Delete method is called to remove the ListObject.
    '<Snippet3>
    Private Sub ListObject_Delete()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "D4"), "List1")

        If DialogResult.Yes = MessageBox.Show("Delete the ListObject?", _
            "Test", MessageBoxButtons.YesNo) Then
            List1.Delete()
        End If

    End Sub

    '</Snippet3>

    ' This snippet uses Publish, SharePoint
    ' The following code example creates a 
    ' ListObject on the current worksheet and then 
    ' calls the Publish method to publish the 
    ' ListObject to a Web site that is running 
    ' Microsoft Windows SharePoint Services. This 
    ' example assumes that the SharePointURL parameter 
    ' identifies a valid URL to a Web site running 
    ' Microsoft Windows SharePoint Services. 
    '<Snippet4>
    Private Sub ListObject_Publish(ByVal SharePointURL As String)
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "D4"), _
            "Employees")

        ' Publish the list object to the SharePoint URL.
        Dim TargetParam() As Object = {SharePointURL, _
            "Employees", "Employee data"}
        List1.Publish(TargetParam, False)

    End Sub

    '</Snippet4>

    ' The following code example creates a ListObject 
    ' on the current worksheet and then calls the 
    ' Resize method to increase the size of the ListObject.
    '<Snippet5>
    Private Sub ListObject_Resize()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "D4"), "List1")

        If DialogResult.Yes = MessageBox.Show("Resize the ListObject?", _
            "Test", MessageBoxButtons.YesNo) Then
            List1.Resize(Me.Range("A1", "H4"))
        End If

    End Sub

    '</Snippet5>

    ' The following code example uses the UpdateChanges 
    ' method to submit changes to an existing ListObject 
    ' to a Web site that is running Microsoft Windows 
    ' SharePoint Services. This example assumes that 
    ' the worksheet contains a ListObject named customerListObject 
    ' that has already been published to a Web site 
    ' running Microsoft Windows SharePoint Services.
    '<Snippet6>
    Private Sub ListObject_UpdateChanges()
        Me.customerListObject.UpdateChanges( _
            Excel.XlListConflict.xlListConflictDialog)
    End Sub

    '</Snippet6>

    '<Snippet7>
    Private Sub ListObject_SetDataBinding()
        Dim Ages As Integer() = {32, 44, 28, 61}
        Dim Names As String() = {"Reggie", "Sally", _
            "Henry", "Christine"}

        ' Create a data table with two columns.
        Dim table = New DataTable()
        Dim column1 As New DataColumn("Names", GetType(String))
        Dim column2 As New DataColumn("Ages", GetType(Integer))
        table.Columns.Add(column1)
        table.Columns.Add(column2)

        ' Add the four rows of data to the table.
        Dim row As DataRow
        Dim i As Integer
        For i = 0 To 3
            row = table.NewRow()
            row("Names") = Names(i)
            row("Ages") = Ages(i)
            table.Rows.Add(row)
        Next i

        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "B4"), "List1")

        ' Bind the list object to the table.
        List1.SetDataBinding(table)

    End Sub

    '</Snippet7>

    ' The following code example gets the name and version of the 
    ' application that contains the list object and displays the
    ' information in a messagebox.
    '<Snippet8>
    Private Sub ListObject_Application()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "B2"), "List1")
        Dim applicationVersion As String = List1.Application.Name & _
            " " & List1.Application.Version
        MessageBox.Show(applicationVersion)

    End Sub

    '</Snippet8>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then creates a BeforeAddDataBoundRow event handler.
    ' To test the event, manually add a new row to the list
    ' object on sheet 1. The event handler removes the row
    ' and displays a message.
    '<Snippet9>
    WithEvents BeforeAddDataBoundRowList As _
        Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_BeforeAddDataBoundRow()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        dt.Columns.Add(New DataColumn("LastName"))
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        BeforeAddDataBoundRowList = _
            Me.Controls.AddListObject(Me.Range("A1"), _
            "BeforeAddDataBoundRowList")

        ' Bind the list object to the DataTable.
        BeforeAddDataBoundRowList.AutoSetDataBoundColumnHeaders = True
        BeforeAddDataBoundRowList.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")
    End Sub


    Private Sub List1_BeforeAddDataBoundRow(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs) _
        Handles BeforeAddDataBoundRowList.BeforeAddDataBoundRow
        e.Cancel = True
        MessageBox.Show("This data is read-only.")

    End Sub
    '</Snippet9>

    ' The following code example creates a list object and
    ' a BeforeDoubleClick event handler. When the list object
    ' is double-clicked, a message is displayed that
    ' indicates whether the list object is bound to data.
    '<Snippet10>
    WithEvents List2 As Microsoft.Office.Tools.Excel.ListObject

    Private Sub ListObject_BeforeDoubleClick()
        List2 = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "List2")
    End Sub


    Sub List2_BeforeDoubleClick(ByVal Target As _
        Microsoft.Office.Interop.Excel.Range, ByRef Cancel As Boolean) _
        Handles List2.BeforeDoubleClick
        MessageBox.Show("Data binding is " & List2.IsBinding)

    End Sub
    '</Snippet10>

    ' The following code example creates a list object and
    ' a BeforeRightClick event handler. When the list object
    ' is right-clicked, a message is displayed that
    ' indicates whether the list object is bound to data.
    '<Snippet11>
    WithEvents List3 As Microsoft.Office.Tools.Excel.ListObject

    Private Sub ListObject_BeforeRightClick()
        List3 = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "List3")
    End Sub


    Sub List3_BeforeRightClick(ByVal Target As _
        Microsoft.Office.Interop.Excel.Range, _
        ByRef Cancel As Boolean) Handles List3.BeforeRightClick
        MessageBox.Show("Data binding is " & List3.IsBinding)
        Cancel = True
    End Sub

    '</Snippet11>

    ' The following code example creates a list object and
    ' a Change event handler. To raise the Change event, add
    ' text to one of the cells in the list object and then 
    ' press ENTER.
    '<Snippet12>
    WithEvents ChangeList As Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_Change()
        ChangeList = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "ChangeList")
    End Sub


    Sub List1_Change(ByVal targetRange As _
        Microsoft.Office.Interop.Excel.Range, _
        ByVal changedRanges As Microsoft.Office.Tools.Excel.ListRanges) _
        Handles ChangeList.Change

        Dim cellAddress As String = targetRange.Address( _
            ReferenceStyle:=Excel.XlReferenceStyle.xlA1)

        Select Case changedRanges
            Case Microsoft.Office.Tools.Excel.ListRanges.DataBodyRange
                MsgBox("The cells at range " & cellAddress & _
                    " in the data body changed.")
            Case Microsoft.Office.Tools.Excel.ListRanges.HeaderRowRange
                MsgBox("The cells at range " & cellAddress & _
                    " in the header row changed.")
            Case Microsoft.Office.Tools.Excel.ListRanges.TotalsRowRange
                MsgBox("The cells at range " & cellAddress & _
                    " in the totals row changed.")
            Case Else
                MsgBox("The cells at range " & cellAddress & _
                    " changed.")
        End Select
    End Sub
    '</Snippet12>

    ' The following code example creates a list object and checks
    ' whether the creator code matches Excel. If the creator code
    ' matches, the code displays a message box.
    '<Snippet13>
    Private Sub ListObject_Creator()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")
        If List1.Creator = Excel.XlCreator.xlCreatorCode Then
            MessageBox.Show( _
                "This list object was created in Microsoft Office Excel.")
        End If

    End Sub
    '</Snippet13>

    ' The following code example creates a list object and adds
    ' an event handler for the DataBindingFailure event. If List1
    ' is bound to a data source and then the binding fails, the event
    ' is caught and a message appears showing the state of the 
    ' binding.
    '<Snippet14>
    WithEvents List4 As Microsoft.Office.Tools.Excel.ListObject

    Private Sub ListObject_DataBindingFailure()
        List4 = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "List4")
    End Sub


    Private Sub List4_DataBindingFailure(ByVal sender As Object, _
        ByVal e As EventArgs) Handles List4.DataBindingFailure
        MessageBox.Show("Data binding is " & _
        List4.IsBinding)
    End Sub

    '</Snippet14>

    ' The following code example creates a list object and then
    ' shows the number of rows that are available for data.
    '<Snippet15>
    Private Sub ListObject_DataBodyRange()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")
        Dim List1BodyRange As Excel.Range = List1.DataBodyRange
        Dim numberOfRows As Integer = List1BodyRange.Rows.Count
        MessageBox.Show("The DataBodyRange of list1 has " & _
            numberOfRows.ToString() & " rows.")

    End Sub

    '</Snippet15>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then uses an xlRangeAutoFormat value to format the
    ' list object.
    '<Snippet16>
    Private Sub ListObject_DataBoundFormat()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        dt.Columns.Add(New DataColumn("LastName"))
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range( _
            "A1"), "List1")

        ' Bind the list object to the DataTable.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")

        ' Add a format to the list object.
        List1.DataBoundFormat = _
            Excel.XlRangeAutoFormat.xlRangeAutoFormatList2

    End Sub

    '</Snippet16>
    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then sets the FormatSettings to apply to the list
    ' object and uses an xlRangeAutoFormat value to supply
    ' the format.
    '<Snippet17>
    Private Sub ListObject_DataBoundFormatSettings()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        dt.Columns.Add(New DataColumn("LastName"))
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range( _
            "A1"), "List1")

        ' Bind the list object to the DataTable.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")

        ' Specify the format settings that you want to include.
        ' In this example, only the Font and Pattern 
        ' settings are applied.
        List1.DataBoundFormatSettings = _
            Microsoft.Office.Tools.Excel.FormatSettings.Font Or _
            Microsoft.Office.Tools.Excel.FormatSettings.Pattern

        ' Add a format to the list object.
        List1.DataBoundFormat = _
            Excel.XlRangeAutoFormat.xlRangeAutoFormatList2

    End Sub

    '</Snippet17>

    ' The following code example creates a DataSet with two
    ' DataTables and populates one of the tables with data.
    ' The code then sets the DataSource and DataMember
    ' properties of the list object to bind to the table
    ' that contains data.
    '<Snippet18>
    Private Sub ListObject_DataSourceAndMember()
        ' Create a DataSet and two DataTables.
        Dim ordersDataSet As New DataSet("ordersDataSet")
        Dim tableCustomers As New DataTable("Customers")
        Dim tableProducts As New DataTable("Products")
        ordersDataSet.Tables.Add(tableCustomers)
        ordersDataSet.Tables.Add(tableProducts)

        ' Add a data to the Customers DataTable.
        tableCustomers.Columns.Add(New DataColumn("LastName"))
        tableCustomers.Columns.Add(New DataColumn("FirstName"))
        Dim dr As DataRow = tableCustomers.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        tableCustomers.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range( _
            "A1"), "Customers")

        ' Bind the list object to the Customers table.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.DataSource = ordersDataSet
        List1.DataMember = "Customers"

    End Sub

    '</Snippet18>
    ' For ListObject_DataSource, see the preceding snippet.

    ' The following code example creates a list object and
    ' a Deselected event handler. When the list object is
    ' selected and then an object outside of the list object
    ' is selected, a message is displayed that indicates
    ' that the selection has changed.
    '<Snippet19>
    WithEvents DeselectedList As Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_Deselected()
        DeselectedList = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "DeselectedList")
    End Sub

    Sub List1_Deselected(ByVal Target As _
        Microsoft.Office.Interop.Excel.Range) Handles DeselectedList.Deselected
        MessageBox.Show("The list object is no longer selected.")
    End Sub

    '</Snippet19>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then creates an ErrorAddDataBoundRow event handler.
    ' To test the event, manually add a new row to the list
    ' and enter the last name "Chan" and a first name. The 
    ' event handler displays a message.
    '<Snippet20>
    WithEvents ErrorAddDataBoundRowList As _
        Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_ErrorAddDataBoundRow()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        Dim lastName As New DataColumn("LastName")
        dt.Columns.Add(lastName)
        dt.Columns.Add(New DataColumn("FirstName"))

        Dim myUC As New UniqueConstraint("CustConstraint", _
            lastName)
        dt.Constraints.Add(myUC)

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        ErrorAddDataBoundRowList = _
            Me.Controls.AddListObject(Me.Range("A1"), _
            "ErrorAddDataBoundRowList")

        ' Bind the list object to the DataTable.
        ErrorAddDataBoundRowList.AutoSetDataBoundColumnHeaders = True
        ErrorAddDataBoundRowList.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")
    End Sub


    Private Sub List1_ErrorAddDataBoundRow(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Excel.ErrorAddDataBoundRowEventArgs) _
        Handles ErrorAddDataBoundRowList.ErrorAddDataBoundRow
        MessageBox.Show("Last names must be unique.")

    End Sub

    '</Snippet20>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then gets the range that contains the header row
    ' and changes the header row font to bold.
    '<Snippet21>
    Private Sub ListObject_HeaderRowRange()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        dt.Columns.Add(New DataColumn("LastName"))
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1"), _
            "List1")

        ' Bind the list object to the DataTable.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")

        ' Get the header row range and set the font to bold.
        Dim headerRow As Excel.Range = List1.HeaderRowRange
        headerRow.Cells.Font.Bold = True

    End Sub

    '</Snippet21>

    ' The following code example creates a list object, 
    ' gets the range that contains the insert row, and
    ' then displays a message showing how many cells the
    ' insert row contains.
    '<Snippet22>
    Private Sub ListObject_InsertRowRange()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")

        Dim insertRow As Excel.Range = List1.InsertRowRange
        MessageBox.Show("The insert row contains " & _
            insertRow.Cells.Count.ToString() & " cells.")
    End Sub

    '</Snippet22>

    ' The following code example creates a list object, 
    ' gets the collection of columns, and then displays
    ' a message showing how many columns the list object
    ' contains.
    '<Snippet23>
    Private Sub ListObject_ListColumns()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")

        Dim List1Columns As Excel.ListColumns = List1.ListColumns
        MessageBox.Show("The list object contains " & _
            List1Columns.Count.ToString() & " columns.")
    End Sub

    '</Snippet23>

    ' The following code example creates a list object, 
    ' gets the collection of rows, and then displays
    ' a message showing how many rows the list object
    ' contains.
    '<Snippet24>
    Private Sub ListObject_ListRows()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")

        Dim List1Rows As Excel.ListRows = List1.ListRows
        MessageBox.Show("The list object contains " & _
            List1Rows.Count.ToString() & " rows.")
    End Sub

    '</Snippet24>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then creates an OriginalDataRestored event handler.
    ' To test the event, right-click a column letter above 
    ' the list object on sheet 1 and then click Delete in 
    ' the shortcut menu. The event handler replaces the 
    ' column and column header data and displays a message
    ' each time.
    '<Snippet25>
    WithEvents OriginalDataRestoredList As _
        Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_OriginalDataRestored()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        Dim lastName As New DataColumn("LastName")
        dt.Columns.Add(lastName)
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add two new rows to the DataTable.
        Dim dr1 As DataRow = dt.NewRow()
        dr1("LastName") = "Chan"
        dr1("FirstName") = "Gareth"
        dt.Rows.Add(dr1)
        Dim dr2 As DataRow = dt.NewRow()
        dr2("LastName") = "Nitsche"
        dr2("FirstName") = "Sonja"
        dt.Rows.Add(dr2)

        ' Create a list object.
        OriginalDataRestoredList = Me.Controls.AddListObject( _
            Me.Range("A1"), "OriginalDataRestoredList")

        ' Bind the list object to the DataTable.
        OriginalDataRestoredList.AutoSetDataBoundColumnHeaders = True
        OriginalDataRestoredList.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")
    End Sub

    Private Sub List1_OriginalDataRestored(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Excel.OriginalDataRestoredEventArgs) _
        Handles OriginalDataRestoredList.OriginalDataRestored
        MessageBox.Show("This data is bound to a data source and " & _
        "will be restored. This change is: " & e.ChangeType.ToString() & _
        ". The reason is: " & e.ChangeReason.ToString() + ".")
    End Sub

    '</Snippet25>

    ' The following code example creates a list object and
    ' then displays the name of the list object's parent 
    ' object in a message.
    '<Snippet26>
    Private Sub ListObject_Parent()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")

        Dim List1Parent As Excel.Worksheet = _
            CType(List1.Parent, Excel.Worksheet)
        MessageBox.Show("The parent of List1 is " & _
            List1Parent.Name.ToString())
    End Sub

    '</Snippet26>

    ' The following code example uses the QueryTable 
    ' property to refresh the query table that intersects 
    ' a list object. This code example assumes that 
    ' the current worksheet contains a list object 
    ' named customerListObject that is intersected by 
    ' a query table.
    '<Snippet27>
    Private Sub ListObject_QueryTable()
        Me.customerListObject.QueryTable.Refresh()
    End Sub

    '</Snippet27>

    ' The following code example creates a list object
    ' and then displays a message showing how many cells
    ' are in the range to which the list object applies.
    '<Snippet28>
    Private Sub ListObject_Range()
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "C4"), "List1")

        MessageBox.Show("The list object contains " & _
            List1.Range.Cells.Count.ToString() & " cells.")
    End Sub

    '</Snippet28>

    ' The following code example creates a list object
    ' and then creates an event handler for the Selected
    ' event. To test the event handler, ensure that the 
    ' list object is not selected, and then select it.
    '<Snippet29>
    WithEvents SelectedList As Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_Selected()
        SelectedList = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "List1")
    End Sub

    Sub List1_Selected(ByVal Target As _
        Microsoft.Office.Interop.Excel.Range) Handles SelectedList.Selected
        MessageBox.Show("The list object has been selected.")
    End Sub

    '</Snippet29>

    ' The following code example creates a list object
    ' and then creates an event handler for the
    ' SelectionChange event. To test the event handler,
    ' select a cell in the list object and then select
    ' a different cell in the list object.
    '<Snippet30>
    WithEvents SelectionChangeList As Microsoft.Office.Tools.Excel.ListObject
    Private Sub ListObject_SelectionChange()
        SelectionChangeList = Me.Controls.AddListObject( _
            Me.Range("A1", "C4"), "SelectionChangeList")
    End Sub


    Sub List1_SelectionChange(ByVal Target As _
        Microsoft.Office.Interop.Excel.Range) _
        Handles SelectionChangeList.SelectionChange
        MessageBox.Show("The selection in the list object has changed.")
    End Sub

    '</Snippet30>

    ' The following code example creates a DataSet, a
    ' DataTable, and a list object. It then binds the
    ' list object to the DataSet and the DataTable.
    '<Snippet31>
    Private Sub ListObject_SetDataBinding2()
        Dim Ages As Integer() = {32, 44, 28, 61}
        Dim Names As String() = {"Reggie", "Sally", _
            "Henry", "Christine"}

        ' Create a data table with two columns.
        Dim ds As New DataSet()
        Dim table As DataTable = ds.Tables.Add("Customers")
        Dim column1 As New DataColumn("Names", GetType(String))
        Dim column2 As New DataColumn("Ages", GetType(Integer))
        table.Columns.Add(column1)
        table.Columns.Add(column2)

        ' Add the four rows of data to the table.
        Dim row As DataRow
        Dim i As Integer
        For i = 0 To 3
            row = table.NewRow()
            row("Names") = Names(i)
            row("Ages") = Ages(i)
            table.Rows.Add(row)
        Next i

        ' Create the list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "B4"), "List1")

        ' Bind the list object to the table.
        List1.SetDataBinding(ds, "Customers")

    End Sub

    '</Snippet31>

    ' The following code example creates a DataSet, a
    ' DataTable, and a list object. It then binds the
    ' list object to the DataSet and the DataTable, but
    ' only includes one of the two possible table 
    ' columns in the list object.
    '<Snippet32>
    Private Sub ListObject_SetDataBinding3()
        Dim Ages As Integer() = {32, 44, 28, 61}
        Dim Names As String() = {"Reggie", "Sally", _
            "Henry", "Christine"}

        ' Create a data table with two columns.
        Dim ds As New DataSet()
        Dim table As DataTable = ds.Tables.Add("Customers")
        Dim column1 As New DataColumn("Names", GetType(String))
        Dim column2 As New DataColumn("Ages", GetType(Integer))
        table.Columns.Add(column1)
        table.Columns.Add(column2)

        ' Add the four rows of data to the table.
        Dim row As DataRow
        Dim i As Integer
        For i = 0 To 3
            row = table.NewRow()
            row("Names") = Names(i)
            row("Ages") = Ages(i)
            table.Rows.Add(row)
        Next i

        ' Create the list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "B4"), "List1")

        ' Bind the list object to the table.
        Dim mappedColumn As String() = {"Names"}
        List1.SetDataBinding(ds, "Customers", mappedColumn)

    End Sub

    '</Snippet32>

    ' The following code example publishes a ListObject 
    ' to a Web site that is running Microsoft Windows 
    ' SharePoint Services. This example assumes that 
    ' there is a list object named customerListObject 
    ' on the current worksheet, and that the list object is
    ' linked to a SharePoint site. 
    '<Snippet33>
    Private Sub ListObject_SharePointURL()
        Dim TargetParam As String() = {customerListObject.SharePointURL, _
            "Customers", "Customer data"}
        customerListObject.Publish(TargetParam, False)
    End Sub

    '</Snippet33>

    ' The following code example creates a DataTable
    ' and a list object, and then binds the list object
    ' to the table. It then displays the source of the
    ' list in a message.
    '<Snippet34>
    Private Sub ListObject_SourceType()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Customers")
        dt.Columns.Add(New DataColumn("LastName"))
        dt.Columns.Add(New DataColumn("FirstName"))

        ' Add a new row to the DataTable.
        Dim dr As DataRow = dt.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        dt.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1"), _
            "List1")

        ' Bind the list object to the DataTable.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.SetDataBinding(ds, "Customers", _
            "LastName", "FirstName")

        ' Get the source type and display it in a message.
        MessageBox.Show("The source type of List1 is " & _
            List1.SourceType.ToString() & ".")
    End Sub

    '</Snippet34>

    ' The following code example creates a DataTable and a
    ' list object, and binds the list object to the table.
    ' It then gets the range that contains the Total row
    ' and changes the Total row font to italic.
    '<Snippet35>
    Private Sub ListObject_TotalsRowRange()
        ' Create a new DataSet and DataTable.
        Dim ds As New DataSet()
        Dim dt As DataTable = ds.Tables.Add("Sales")
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("Quarter1"))

        ' Add a new row to the DataTable.
        Dim dr1 As DataRow = dt.NewRow()
        dr1("Name") = "Sidney"
        dr1("Quarter1") = "150"
        dt.Rows.Add(dr1)
        Dim dr2 As DataRow = dt.NewRow()
        dr2("Name") = "Julia"
        dr2("Quarter1") = "175"
        dt.Rows.Add(dr2)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1"), "List1")

        ' Bind the list object to the DataTable.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.SetDataBinding(ds, "Sales", "Name", "Quarter1")
        List1.ShowTotals = True

        ' Get the header row range and set the font to bold.
        Dim totalRow As Excel.Range = List1.TotalsRowRange
        totalRow.Cells.Font.Italic = True
    End Sub
    
    '</Snippet35>
    
    ' The following code example displays the name of
    ' the XmlMap that is mapped to a list object. This
    ' example assumes that there is a list object named
    ' customerListObject on the current worksheet, and
    ' that the list object uses a schema map.
    '<Snippet36>
    Private Sub ListObject_XmlMap() 
        Dim customerXmlMap As Excel.XmlMap = _
            customerListObject.XmlMap
        MessageBox.Show("The current XmlMap for customerListObject is " & _
            customerXmlMap.Name.ToString() & ".")
    End Sub
    '</Snippet36>
    

End Class
