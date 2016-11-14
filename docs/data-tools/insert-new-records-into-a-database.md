---
title: "Insert new records into a database | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
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
  - "TableAdapters, inserting new records into"
  - "data [Visual Studio], saving"
  - "databases, inserting new records into"
  - "records, inserting"
  - "saving data"
ms.assetid: ea118fff-69b1-4675-b79a-e33374377f04
caps.latest.revision: 11
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Insert new records into a database
To insert new records into a database, you can use the `TableAdapter.Update` method, or one of the TableAdapter's DBDirect methods (specifically the `TableAdapter.Insert` method). For more information, see [TableAdapter Overview](../data-tools/tableadapter-overview.md).  
  
 If your application doesn't use TableAdapters, you can use command objects (for example,  <xref:System.Data.SqlClient.SqlCommand>) to  insert new records in your database .  
  
 If your application uses datasets to store data, use the `TableAdapter.Update` method. The `Update` method sends all changes (updates, inserts, and deletes) to the database.  
  
 If your application uses objects to store data, or if you want finer control over creating new records in the database, use the `TableAdapter.Insert` method.  
  
 If your TableAdapter doesn't have an `Insert` method, it means that either the TableAdapter is configured to use stored procedures or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the [Dataset Designer](../data-tools/creating-and-editing-typed-datasets.md), and then save the dataset. This will regenerate the TableAdapter. If the TableAdapter still doesn't have an `Insert` method, then the table probably does not provide enough schema information to distinguish between individual rows (for example, there might be no primary key set on the table).  
  
## Insert new records by using TableAdapters  
 TableAdapters provide different ways to insert new records into a database, depending on the requirements of your application.  
  
 If your application uses datasets to store data, then you can simply add new records to the desired <xref:System.Data.DataTable> in the dataset, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method sends any changes in the <xref:System.Data.DataTable> to the database (including modified and deleted records).  
  
#### To insert new records into a database by using the TableAdapter.Update method  
  
1.  Add new records to the desired <xref:System.Data.DataTable> by creating a new <xref:System.Data.DataRow> and adding it to the <xref:System.Data.DataTable.Rows%2A> collection. For more information, see [How to: Add Rows to a DataTable](../Topic/How%20to:%20Add%20Rows%20to%20a%20DataTable.md).  
  
2.  After the new rows are added to the <xref:System.Data.DataTable>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in either an entire <xref:System.Data.DataSet>, a <xref:System.Data.DataTable>, an array of <xref:System.Data.DataRow>s, or a single <xref:System.Data.DataRow>.  
  
     The following code shows how to add a new record to a <xref:System.Data.DataTable> and then call the `TableAdapter.Update` method to save the new row to the database. (This example uses the `Region` table in the Northwind database.)  
  
     [!code-vb[VbRaddataSaving#14](../data-tools/codesnippet/VisualBasic/insert-new-records-into-a-database_1.vb)]
     [!code-cs[VbRaddataSaving#14](../data-tools/codesnippet/CSharp/insert-new-records-into-a-database_1.cs)]  
  
 If your application uses objects to store  data, you can use the `TableAdapter.Insert` method to create new rows directly in the database. The `Insert` method accepts the individual values for each column as parameters. Calling the method inserts a new record into the database with the parameter values passed in.  
  
 The following procedure uses the `Region` table in the Northwind database  as an example.  
  
#### To insert new records into a database by using the TableAdapter.Insert method  
  
-   Call the TableAdapter's `Insert` method, passing in the values for each column as parameters.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter you want to use.  
  
     [!code-vb[VbRaddataSaving#15](../data-tools/codesnippet/VisualBasic/insert-new-records-into-a-database_2.vb)]
     [!code-cs[VbRaddataSaving#15](../data-tools/codesnippet/CSharp/insert-new-records-into-a-database_2.cs)]  
  
## Insert new records by using command objects  
 The following example inserts new records directly into a database using command objects. For more information about using command objects to run commands and stored procedures, see [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md).  
  
 The following procedure uses the `Region` table in the Northwind database  as an example.  
  
#### To insert new records into a database by using command objects  
  
-   Create a new command object, and then set its `Connection`, `CommandType`, and `CommandText` properties.  
  
     [!code-vb[VbRaddataSaving#16](../data-tools/codesnippet/VisualBasic/insert-new-records-into-a-database_3.vb)]
     [!code-cs[VbRaddataSaving#16](../data-tools/codesnippet/CSharp/insert-new-records-into-a-database_3.cs)]  
  
## .NET Framework Security  
 You must have access to the database you are trying to connect to, as well as permission to perform inserts into the desired table.  
  
## See Also  
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)