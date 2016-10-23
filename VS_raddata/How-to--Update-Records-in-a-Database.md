---
title: "How to: Update Records in a Database"
ms.custom: na
ms.date: 09/17/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cdc8a8e4-a5fa-40dd-9221-97b8571d802a
caps.latest.revision: 10
manager: ghogen
robots: noindex,nofollow
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Update Records in a Database
You can use the `TableAdapter.Update` method to update (edit) records in a database. The `TableAdapter.Update` method provides several overloads that perform different operations depending on the parameters passed in. It is important to understand the results of calling these different method signatures.  
  
> [!NOTE]
>  If your application does not use TableAdapters, then you can use command objects to update records in your database (for example, <xref:System.Data.SqlClient.SqlCommand.ExecuteNonQuery?qualifyHint=False>). For more information on updating data with command objects, see "Update Records using Command Objects" below.  
  
 The following table describes the behavior of the various `TableAdapter.Update` methods:  
  
|Method|Description|  
|------------|-----------------|  
|`TableAdapter.Update(DataTable)`|Attempts to save all changes in the <xref:System.Data.DataTable?qualifyHint=False> to the database. (This includes removing any rows deleted from the table, adding rows inserted to the table, and updating any rows in the table that have changed.)|  
|`TableAdapter.Update(DataSet)`|Although the parameter takes a dataset, the TableAdapter attempts to save all changes in the TableAdapter's associated <xref:System.Data.DataTable?qualifyHint=False> to the database. (This includes removing any rows deleted from the table, adding rows inserted in the table, and updating any rows in the table that have changed.) **Note:**  A TableAdapter's associated <xref:System.Data.DataTable?qualifyHint=False> is the <xref:System.Data.DataTable?qualifyHint=False> created when the TableAdapter was originally configured.|  
|`TableAdapter.Update(DataRow)`|Attempts to save changes in the indicated <xref:System.Data.DataRow?qualifyHint=False> to the database.|  
|`TableAdapter.Update(DataRows())`|Attempts to save changes in any row in the array of <xref:System.Data.DataRow?qualifyHint=False>s to the database.|  
|`TableAdapter.Update("new column values", "original column values")`|Attempts to save changes in a single row that is identified by the original column values.|  
  
 You typically use the `TableAdapter.Update` method that takes a <xref:System.Data.DataSet?qualifyHint=False>, <xref:System.Data.DataTable?qualifyHint=False>, or <xref:System.Data.DataRow?qualifyHint=False>(s) when your application uses datasets exclusively to store data.  
  
 You typically use the `TableAdapter.Update` method that takes column values when your application uses objects to store data.  
  
 If your TableAdapter does not have an `Update` method that takes column values, then it means that either the TableAdapter is configured to use stored procedures or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the [Dataset Designer](../VS_raddata/Creating-and-Editing-Typed-Datasets.md) and then save the dataset to regenerate the TableAdapter. If the TableAdapter still does not have an `Update` method that takes column values, then the table probably does not provide enough schema information to distinguish between individual rows (for example, no primary key is set on the table).  
  
## Update Existing Records Using TableAdapters  
 TableAdapters provide different ways to update records in a database depending on the requirements of your application.  
  
 If your application uses datasets to store data, then you can simply update the records in the desired <xref:System.Data.DataTable?qualifyHint=False> and then call the `TableAdapter.Update` method and pass in either the <xref:System.Data.DataSet?qualifyHint=False>, <xref:System.Data.DataTable?qualifyHint=False>, <xref:System.Data.DataRow?qualifyHint=False>, or array of <xref:System.Data.DataRow?qualifyHint=False>s. The table above describes the different `Update` methods.  
  
#### To update records in a database with the TableAdapter.Update method that takes DataSet, DataTable, DataRow, or DataRows()  
  
1.  Edit records in the desired <xref:System.Data.DataTable?qualifyHint=False> by directly editing the <xref:System.Data.DataRow?qualifyHint=False> in the <xref:System.Data.DataTable?qualifyHint=False>. For more information, see [How to: Edit Rows in a DataTable](../Topic/How%20to:%20Edit%20Rows%20in%20a%20DataTable.md).  
  
2.  After the rows are edited in the <xref:System.Data.DataTable?qualifyHint=False>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in either an entire <xref:System.Data.DataSet?qualifyHint=False>, a <xref:System.Data.DataTable?qualifyHint=False>, an array of <xref:System.Data.DataRow?qualifyHint=False>s, or a single <xref:System.Data.DataRow?qualifyHint=False>.  
  
     The following code shows how to edit a record in a <xref:System.Data.DataTable?qualifyHint=False> and then call the `TableAdapter.Update` method to save the changes to the database. (This example uses the Northwind database Region table.)  
  
     [!CODE [VbRaddataSaving#17](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#17)]  
  
 If your application uses objects to store the data in your application, you can use the TableAdapter's `DBDirect` methods to send data from your objects directly to the database. These methods allow you to pass individual values for each column as method parameters. Calling this method updates an existing record in the database with the column values passed into the method.  
  
 The following procedure uses the Northwind `Region` table as an example.  
  
#### To update records in a database using the TableAdapter.Update method that takes column values  
  
-   Call the TableAdapter's `Update` method, passing in the new and original values for each column as parameters.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter you want to use.  
  
     [!CODE [VbRaddataSaving#18](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#18)]  
  
## Update Records Using Command Objects  
 The following example updates existing records directly in a database using command objects. For more information on using command objects to execute commands and stored procedures, see [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md).  
  
 The following procedure uses the Northwind `Region` table as an example.  
  
#### To update existing records in a database using command objects  
  
-   Create a new command object; set its `Connection`, `CommandType`, and `CommandText` properties; and then open a connection and execute the command.  
  
     [!CODE [VbRaddataSaving#19](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#19)]  
  
## .NET Framework Security  
 You must have access to the database you are trying to connect to, as well as permission to update records in the desired table.  
  
## See Also  
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)   
 [How to: Delete Records in a Database](../VS_raddata/How-to--Delete-Records-in-a-Database.md)   
 [Insert new records into a database](../VS_raddata/Insert-new-records-into-a-database.md)   
 [Save data from an object to a database](../VS_raddata/Save-data-from-an-object-to-a-database.md)   
 [Overview of Data Applications in Visual Studio](../VS_raddata/Overview-of-Data-Applications-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)