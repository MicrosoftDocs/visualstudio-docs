---
title: "How to: Save Dataset Changes to a Database | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DbDataAdapter.Update"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "data [Visual Studio], saving"
  - "databases, updating"
  - "updating datasets, writing changes to data source"
ms.assetid: c9970150-b71b-4c9d-a355-5efb6b510dca
caps.latest.revision: 14
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Save Dataset Changes to a Database
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

After the data in your dataset has been modified and validated, you probably want to send the updated data back to a database. In order to send the modified data to a database, you call the `Update` method of a [TableAdapter](../data-tools/tableadapter-overview.md) or data adapter. The adapter's `Update` method updates a single data table and executes the correct command (INSERT, UPDATE, or DELETE) based on the <xref:System.Data.DataRow.RowState%2A> of each data row in the table.  
  
 When saving data in related tables, Visual Studio provides a TableAdapterManager component that assists in performing saves in the proper order based on the foreign-key constraints defined in the database. For more information, see [Hierarchical Update Overview](http://msdn.microsoft.com/library/c4f8e8b9-e4a5-4a02-8462-d03d1e8222d6).  
  
> [!NOTE]
>  Because attempting to update a data source with the contents of a dataset can result in errors, you should place the code that calls the adapter's `Update` method inside of a `try`/`catch` block.  
  
 The exact procedure to update a data source can vary depending on your business needs, but your application should include the following steps:  
  
1.  Execute code that attempts sending updates to the database within a `try`/`catch` block.  
  
2.  If an exception is caught, locate the data row that caused the error. For more information, see [How to: Locate Rows that Have Errors](http://msdn.microsoft.com/library/1fa907c5-fe66-4f29-a253-2b97b900050c).  
  
3.  Reconcile the problem in the data row (programmatically if possible, or by presenting the invalid row to the user for modification), and then reattempt the update (<xref:System.Data.DataRow.HasErrors%2A> property, <xref:System.Data.DataTable.GetErrors%2A> method).  
  
## Saving Data to a Database  
 Call the `Update` method of a TableAdapter or data adapter, passing the name of the data table that contains the values to be written to the database. For more information on saving data from a single data table back to a database, see [Walkthrough: Saving Data to a Database (Single Table)](http://msdn.microsoft.com/library/68befa96-7463-43e8-abcf-dc2f42ccd53d).  
  
#### To update a database with a dataset using a TableAdapter  
  
-   Enclose the `TableAdapter.Update` method inside a `try`/`catch` block. The following example shows how to attempt an update with the contents of the `Customers` table in the `NorthwindDataSet`.  
  
     [!code-csharp[VbRaddataSaving#9](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs#9)]
     [!code-vb[VbRaddataSaving#9](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb#9)]  
  
#### To update a database with a dataset using a data adapter  
  
-   Enclose the `DataAdapter.Update` method inside a `try`/`catch` block. The following example shows how to attempt an update to a data source with the contents of `Table1` in `DataSet1`.  
  
     [!code-csharp[VbRaddataSaving#26](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#26)]
     [!code-vb[VbRaddataSaving#26](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#26)]  
  
## Updating Two Related Tables in a Dataset  
 When updating related tables in a dataset, it is important to update in the proper sequence to reduce the chance of violating referential integrity constraints. The order of command execution will also follow the indices of the <xref:System.Data.DataRowCollection> in the dataset. To prevent data integrity errors from being raised, the best practice is to update the database in the following sequence:  
  
1. Child table: delete records.  
  
2. Parent table: insert, update, and delete records.  
  
3. Child table: insert and update records.  
  
   For detailed information on saving data from multiple tables, see [Save data to a database (multiple tables)](../data-tools/save-data-to-a-database-multiple-tables.md).  
  
   If you are updating two or more related tables, then you should include all the update logic within a transaction. A transaction is a process that assures all related changes to a database are successful before committing any changes. For more information see, [Transactions and Concurrency](http://msdn.microsoft.com/library/f46570de-9e50-4fe6-8710-a8c31fa8569b).  
  
#### To update two related tables using a TableAdapter  
  
1.  Create three temporary <xref:System.Data.DataTable>s to hold the differing records.  
  
2.  Call the `Update` method for each subset of rows from within a `try`/`catch` block. If update errors occur, the suggested course of action is to branch off and resolve them.  
  
3.  Commit the changes from the dataset to the database.  
  
4.  Dispose of the temporary data tables to release the resources.  
  
     [!code-csharp[VbRaddataSaving#27](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs#27)]
     [!code-vb[VbRaddataSaving#27](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb#27)]  
  
#### To update two related tables using a Data Adapter  
  
-   Call the `Update` method of each data adapter.  
  
     The following example shows how to update a data source with a dataset that contains related tables. In order to follow the above sequence, three temporary <xref:System.Data.DataTable>s will be created to hold the differing records. Then the `Update` method will be called for each subset of rows from within a `try`/`catch` block. If update errors occur, the suggested course of action is to branch off and resolve them. Then the dataset commits the changes. Finally, dispose of the temporary data tables to release the resources.  
  
     [!code-csharp[VbRaddataSaving#28](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs#28)]
     [!code-vb[VbRaddataSaving#28](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb#28)]  
  
## See Also  
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)