---
title: "Insert new records into a database"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: ea118fff-69b1-4675-b79a-e33374377f04
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Insert new records into a database
To insert new records into a database, you can use the `TableAdapter.Update` method, or one of the TableAdapter's DBDirect methods (specifically the `TableAdapter.Insert` method). For more information, see [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md).  
  
 If your application doesn't use TableAdapters, you can use command objects (for example,  <xref:System.Data.SqlClient.SqlCommand?qualifyHint=False>) to  insert new records in your database .  
  
 If your application uses datasets to store data, use the `TableAdapter.Update` method. The `Update` method sends all changes (updates, inserts, and deletes) to the database.  
  
 If your application uses objects to store data, or if you want finer control over creating new records in the database, use the `TableAdapter.Insert` method.  
  
 If your TableAdapter doesn't have an `Insert` method, it means that either the TableAdapter is configured to use stored procedures or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the [Dataset Designer](../VS_raddata/Creating-and-Editing-Typed-Datasets.md), and then save the dataset. This will regenerate the TableAdapter. If the TableAdapter still doesn't have an `Insert` method, then the table probably does not provide enough schema information to distinguish between individual rows (for example, there might be no primary key set on the table).  
  
## Insert new records by using TableAdapters  
 TableAdapters provide different ways to insert new records into a database, depending on the requirements of your application.  
  
 If your application uses datasets to store data, then you can simply add new records to the desired <xref:System.Data.DataTable?qualifyHint=False> in the dataset, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method sends any changes in the <xref:System.Data.DataTable?qualifyHint=False> to the database (including modified and deleted records).  
  
#### To insert new records into a database by using the TableAdapter.Update method  
  
1.  Add new records to the desired <xref:System.Data.DataTable?qualifyHint=False> by creating a new <xref:System.Data.DataRow?qualifyHint=False> and adding it to the <xref:System.Data.DataTable.Rows?qualifyHint=False> collection. For more information, see [How to: Add Rows to a DataTable](../Topic/How%20to:%20Add%20Rows%20to%20a%20DataTable.md).  
  
2.  After the new rows are added to the <xref:System.Data.DataTable?qualifyHint=False>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in either an entire <xref:System.Data.DataSet?qualifyHint=False>, a <xref:System.Data.DataTable?qualifyHint=False>, an array of <xref:System.Data.DataRow?qualifyHint=False>s, or a single <xref:System.Data.DataRow?qualifyHint=False>.  
  
     The following code shows how to add a new record to a <xref:System.Data.DataTable?qualifyHint=False> and then call the `TableAdapter.Update` method to save the new row to the database. (This example uses the `Region` table in the Northwind database.)  
  
     [!CODE [VbRaddataSaving#14](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#14)]  
  
 If your application uses objects to store  data, you can use the `TableAdapter.Insert` method to create new rows directly in the database. The `Insert` method accepts the individual values for each column as parameters. Calling the method inserts a new record into the database with the parameter values passed in.  
  
 The following procedure uses the `Region` table in the Northwind database  as an example.  
  
#### To insert new records into a database by using the TableAdapter.Insert method  
  
-   Call the TableAdapter's `Insert` method, passing in the values for each column as parameters.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter you want to use.  
  
     [!CODE [VbRaddataSaving#15](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#15)]  
  
## Insert new records by using command objects  
 The following example inserts new records directly into a database using command objects. For more information about using command objects to run commands and stored procedures, see [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md).  
  
 The following procedure uses the `Region` table in the Northwind database  as an example.  
  
#### To insert new records into a database by using command objects  
  
-   Create a new command object, and then set its `Connection`, `CommandType`, and `CommandText` properties.  
  
     [!CODE [VbRaddataSaving#16](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#16)]  
  
## .NET Framework Security  
 You must have access to the database you are trying to connect to, as well as permission to perform inserts into the desired table.  
  
## See Also  
 [Save data back to the database](../VS_raddata/Save-data-back-to-the-database.md)