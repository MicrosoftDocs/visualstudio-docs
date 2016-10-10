---
title: "How to: Delete Records in a Database"
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
ms.assetid: d74d2130-9732-4648-abea-241059c4a372
caps.latest.revision: 11
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
# How to: Delete Records in a Database
To delete records from a database, use the `TableAdapter.Update` method or the `TableAdapter.Delete` method. Or, if your application does not use TableAdapters, you can use command objects to delete records from a database (for example, <xref:System.Data.SqlClient.SqlCommand.ExecuteNonQuery?qualifyHint=False>).  
  
 The `TableAdapter.Update` method is typically used when your application uses datasets to store data, whereas the `TableAdapter.Delete` method is typically used when your application uses objects to store data.  
  
 If your TableAdapter does not have a `Delete` method, it means either the TableAdapter is configured to use stored procedures, or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the [Dataset Designer](../VS_raddata/Creating-and-Editing-Typed-Datasets.md) and then save the dataset to regenerate the TableAdapter. If the TableAdapter still does not have a `Delete` method, then the table probably does not provide enough schema information to distinguish between individual rows (for example, no primary key is set on the table).  
  
## Delete Records Using TableAdapters  
 TableAdapters provide different ways to delete records from a database depending on the requirements of your application.  
  
 If your application uses datasets to store data you can simply delete records from the desired <xref:System.Data.DataTable?qualifyHint=False> in the <xref:System.Data.DataSet?qualifyHint=False>, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method takes any changes in the data table and sends those changes to the database (including inserted, updated, and deleted records).  
  
#### To delete records from a database using the TableAdapter.Update method  
  
-   Delete records from the desired <xref:System.Data.DataTable?qualifyHint=False> by deleting <xref:System.Data.DataRow?qualifyHint=False> objects from the table. For more information, see [How to: Delete Rows in a DataTable](../Topic/How%20to:%20Delete%20Rows%20in%20a%20DataTable.md). After the rows are deleted from the <xref:System.Data.DataTable?qualifyHint=False>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in an entire <xref:System.Data.DataSet?qualifyHint=False>, a <xref:System.Data.DataTable?qualifyHint=False>, an array of <xref:System.Data.DataRow?qualifyHint=False>s, or a single <xref:System.Data.DataRow?qualifyHint=False>. The following code shows how to delete a record from a <xref:System.Data.DataTable?qualifyHint=False> and then call the `TableAdapter.Update` method to communicate the change and delete the row from the database. (This example uses the Northwind database's `Region` table.)  
  
     [!CODE [VbRaddataSaving#20](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#20)]  
  
 If your application uses objects to store the data in your application, you can use the TableAdapter's DBDirect methods to delete data directly from the database. Calling the `Delete` method removes records from the database based on the parameter values passed in.  
  
#### To delete records from a database using the TableAdapter.Delete method  
  
-   Call the TableAdapter's `Delete` method, passing in the values for each column as parameters of the `Delete` method. (This example uses the Northwind database's `Region` table.)  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter you want to use.  
  
     [!CODE [VbRaddataSaving#21](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#21)]  
  
## Delete Records Using Command Objects  
 The following example deletes records directly from a database using command objects. For more information on using command objects to execute commands and stored procedures, see [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md).  
  
#### To delete records from a database using command objects  
  
-   Create a new command object, set its `Connection`, `CommandType`, and `CommandText` properties. (This example uses the Northwind database's `Region` table.)  
  
     [!CODE [VbRaddataSaving#22](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#22)]  
  
## .NET Framework Security  
 You must have access to the database you are trying to connect to, as well as permission to delete records from the desired table.  
  
## See Also  
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)   
 [Insert new records into a database](../VS_raddata/Insert-new-records-into-a-database.md)   
 [How to: Update Records in a Database](../VS_raddata/How-to--Update-Records-in-a-Database.md)   
 [Save data from an object to a database](../VS_raddata/Save-data-from-an-object-to-a-database.md)   
 [Overview of Data Applications in Visual Studio](../VS_raddata/Overview-of-Data-Applications-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)