---
title: "How to: Delete Records in a Database | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "data [Visual Studio], saving"
  - "records, deleting"
  - "TableAdapter.Delete method"
  - "databases, deleting records"
  - "deleting data"
  - "TableAdapter.Update method"
  - "saving data"
ms.assetid: d74d2130-9732-4648-abea-241059c4a372
caps.latest.revision: 11
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Delete Records in a Database
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To delete records from a database, use the `TableAdapter.Update` method or the `TableAdapter.Delete` method. Or, if your application does not use TableAdapters, you can use command objects to delete records from a database (for example, <xref:System.Data.SqlClient.SqlCommand.ExecuteNonQuery%2A>).  
  
 The `TableAdapter.Update` method is typically used when your application uses datasets to store data, whereas the `TableAdapter.Delete` method is typically used when your application uses objects to store data.  
  
 If your TableAdapter does not have a `Delete` method, it means either the TableAdapter is configured to use stored procedures, or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the [Dataset Designer](../data-tools/creating-and-editing-typed-datasets.md) and then save the dataset to regenerate the TableAdapter. If the TableAdapter still does not have a `Delete` method, then the table probably does not provide enough schema information to distinguish between individual rows (for example, no primary key is set on the table).  
  
## Delete Records Using TableAdapters  
 TableAdapters provide different ways to delete records from a database depending on the requirements of your application.  
  
 If your application uses datasets to store data you can simply delete records from the desired <xref:System.Data.DataTable> in the <xref:System.Data.DataSet>, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method takes any changes in the data table and sends those changes to the database (including inserted, updated, and deleted records).  
  
#### To delete records from a database using the TableAdapter.Update method  
  
- Delete records from the desired <xref:System.Data.DataTable> by deleting <xref:System.Data.DataRow> objects from the table. For more information, see [How to: Delete Rows in a DataTable](http://msdn.microsoft.com/library/add481e5-08c7-4923-9276-f036ae29d31e). After the rows are deleted from the <xref:System.Data.DataTable>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in an entire <xref:System.Data.DataSet>, a <xref:System.Data.DataTable>, an array of <xref:System.Data.DataRow>s, or a single <xref:System.Data.DataRow>. The following code shows how to delete a record from a <xref:System.Data.DataTable> and then call the `TableAdapter.Update` method to communicate the change and delete the row from the database. (This example uses the Northwind database's `Region` table.)  
  
   [!code-csharp[VbRaddataSaving#20](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form5.cs#20)]
   [!code-vb[VbRaddataSaving#20](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form5.vb#20)]  
  
  If your application uses objects to store the data in your application, you can use the TableAdapter's DBDirect methods to delete data directly from the database. Calling the `Delete` method removes records from the database based on the parameter values passed in.  
  
#### To delete records from a database using the TableAdapter.Delete method  
  
-   Call the TableAdapter's `Delete` method, passing in the values for each column as parameters of the `Delete` method. (This example uses the Northwind database's `Region` table.)  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter you want to use.  
  
     [!code-csharp[VbRaddataSaving#21](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#21)]
     [!code-vb[VbRaddataSaving#21](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#21)]  
  
## Delete Records Using Command Objects  
 The following example deletes records directly from a database using command objects. For more information on using command objects to execute commands and stored procedures, see [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md).  
  
#### To delete records from a database using command objects  
  
-   Create a new command object, set its `Connection`, `CommandType`, and `CommandText` properties. (This example uses the Northwind database's `Region` table.)  
  
     [!code-csharp[VbRaddataSaving#22](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#22)]
     [!code-vb[VbRaddataSaving#22](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#22)]  
  
## .NET Framework Security  
 You must have access to the database you are trying to connect to, as well as permission to delete records from the desired table.  
  
## See Also  
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Insert new records into a database](../data-tools/insert-new-records-into-a-database.md)   
 [How to: Update Records in a Database](../data-tools/how-to-update-records-in-a-database.md)   
 [Save data from an object to a database](../data-tools/save-data-from-an-object-to-a-database.md)   
 [Overview of Data Applications in Visual Studio](../data-tools/overview-of-data-applications-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)