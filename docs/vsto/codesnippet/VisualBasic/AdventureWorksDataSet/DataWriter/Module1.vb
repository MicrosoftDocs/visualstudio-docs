'<Snippet1>
Imports Microsoft.VisualStudio.Tools.Applications
'</Snippet1>

Module Module1

    ' To test the InitializeCachedDataSet behavior: 
    ' 1. Run SQL Server (or Express) with AdventureWorksLT database. 
    '    Edit app.config in AdventureWorksDataSet as necessary to connect to your database instance.
    ' 2. Build AdventureWorksDataSet.
    ' 3. Comment out the Fill method call in the Startup event handler of AdventureWorksReport. 
    ' 4. Build AdventureWorksReport. Optionally run it to verify that the ListObject is empty.
    ' 5. In this code file below, uncomment InitializeCachedDataSet in Main.
    ' 6. In InitializeCachedDataSet, modify the workbook path as necessary.
    ' 7. Build and run DataWriter. 
    ' 8. Open AdventureWorksReport.xlsx from \bin folder. Verify ListObject now has data.

    ' To test the ModifyCachedDataSet behavior: 
    ' 1. Run SQL Server (or Express) with AdventureWorksLT database. 
    '    Edit app.config in AdventureWorksDataSet as necessary to connect to your database instance.
    ' 2. Build AdventureWorksDataSet.
    ' 3. Build and run AdventureWorksReport. Verify the ListObject has data.
    ' 4. Save and close workbook with same name and to the same location (that is, the \bin folder).
    ' 5. In this code file below, uncomment ModifyCachedDataSet in Main.
    ' 6. In ModifyCachedDataSet, modify the workbook path as necessary.
    ' 7. Build and run DataWriter. 
    ' 8. Open AdventureWorksReport.xlsx from \bin folder. Verify the ListPrices have changed.

    Sub Main()
        'InitializeCachedDataSet()
        'ModifyCachedDataSet()
        'ReadCachedDataSet()
    End Sub

    Private Sub InitializeCachedDataSet()
        '<Snippet2>
        '<Snippet3>
        Dim productDataSet As New AdventureWorksDataSet.AdventureWorksLTDataSet()
        Dim productTableAdapter As _
            New AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter()

        Dim workbookPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.MyDocuments) & _
            "\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx"
        Dim serverDocument1 As ServerDocument = Nothing
        '</Snippet3>

        '<Snippet4>
        Try
            productTableAdapter.Fill(productDataSet.Product)
            Console.WriteLine("The local dataset is filled.")

            serverDocument1 = New ServerDocument(workbookPath)
            Dim dataHostItem1 As CachedDataHostItem = _
                serverDocument1.CachedData.HostItems("AdventureWorksReport.Sheet1")
            Dim dataItem1 As CachedDataItem = dataHostItem1.CachedData("AdventureWorksLTDataSet")

            ' Initialize the worksheet dataset with the local dataset.
            If dataItem1 IsNot Nothing Then
                dataItem1.SerializeDataInstance(productDataSet)
                serverDocument1.Save()
                Console.WriteLine("The data is saved to the data cache.")
            Else
                Console.WriteLine("The data object is not found in the data cache.")
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Console.WriteLine(ex.Message)
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified workbook does not exist.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            Console.WriteLine(vbLf & vbLf & "Press Enter to close the application.")
            Console.ReadLine()
        End Try
        '</Snippet4>
        '</Snippet2>
    End Sub

    Private Sub ModifyCachedDataSet()
        '<Snippet5>
        '<Snippet6>
        Dim productDataSet As New AdventureWorksDataSet.AdventureWorksLTDataSet()
        Dim workbookPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.MyDocuments) & _
            "\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx"
        Dim serverDocument1 As ServerDocument = Nothing
        '</Snippet6>

        '<Snippet7>
        Try
            serverDocument1 = New ServerDocument(workbookPath)
            Dim dataHostItem1 As CachedDataHostItem = _
                serverDocument1.CachedData.HostItems("AdventureWorksReport.Sheet1")
            Dim dataItem1 As CachedDataItem = dataHostItem1.CachedData("AdventureWorksLTDataSet")

            If dataItem1 IsNot Nothing Then
                Console.WriteLine("Before reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())

                ' Read the cached data from the worksheet dataset into the local dataset.
                Dim schemaReader As New System.IO.StringReader(dataItem1.Schema)
                Dim xmlReader As New System.IO.StringReader(dataItem1.Xml)
                productDataSet.ReadXmlSchema(schemaReader)
                productDataSet.ReadXml(xmlReader)

                Console.WriteLine("After reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())

                ' Modify the prices of each product in the local dataset.
                Dim row As AdventureWorksDataSet.AdventureWorksLTDataSet.ProductRow
                For Each row In productDataSet.Product.Rows
                    If row.ProductCategoryID < 20 Then
                        row.ListPrice = row.ListPrice + row.ListPrice * 0.1
                    Else
                        row.ListPrice = row.ListPrice - row.ListPrice * 0.1
                    End If
                Next row

                ' Write the modified local dataset to the worksheet dataset using the DiffGram format.
                Dim stringIn As New System.Text.StringBuilder()
                Dim stringOut As New System.IO.StringWriter(stringIn)
                productDataSet.WriteXml(stringOut, System.Data.XmlWriteMode.DiffGram)
                dataItem1.Xml = stringIn.ToString()

                serverDocument1.Save()
                Console.WriteLine("The product prices have been modified.")
            Else
                Console.WriteLine("The data object is not found in the data cache.")
            End If
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified workbook does not exist.")
        Catch ex As System.Xml.XmlException
            Console.WriteLine("The data object has invalid XML information.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            Console.WriteLine(vbLf & vbLf & "Press Enter to close the application.")
            Console.ReadLine()
        End Try
        '</Snippet7>
        '</Snippet5>
    End Sub


    Private Sub ReadCachedDataSet()
        '<Snippet9>
        '<Snippet10>
        Dim productDataSet As New AdventureWorksDataSet.AdventureWorksLTDataSet()
        Dim workbookPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.MyDocuments) & _
            "\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx"
        Dim serverDocument1 As ServerDocument = Nothing
        '</Snippet10>

        '<Snippet11>
        Try
            serverDocument1 = New ServerDocument(workbookPath)
            Dim dataHostItem1 As CachedDataHostItem = _
                serverDocument1.CachedData.HostItems("AdventureWorksReport.Sheet1")
            Dim dataItem1 As CachedDataItem = dataHostItem1.CachedData("AdventureWorksLTDataSet")

            If dataItem1 IsNot Nothing Then
                Console.WriteLine("Before reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())

                ' Read the cached data from the worksheet dataset into the local dataset.
                Dim schemaReader As New System.IO.StringReader(dataItem1.Schema)
                Dim xmlReader As New System.IO.StringReader(dataItem1.Xml)
                productDataSet.ReadXmlSchema(schemaReader)
                productDataSet.ReadXml(xmlReader)

                Console.WriteLine("After reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())
            Else
                Console.WriteLine("The data object is not found in the data cache.")
            End If
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified workbook does not exist.")
        Catch ex As System.Xml.XmlException
            Console.WriteLine("The data object has invalid XML information.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            Console.WriteLine(vbLf & vbLf & "Press Enter to close the application.")
            Console.ReadLine()
        End Try
        '</Snippet11>
        '</Snippet9>
    End Sub

End Module

