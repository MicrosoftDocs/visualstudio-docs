---
title: "How to: Save Dataset Changes to a Database"
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
ms.assetid: c9970150-b71b-4c9d-a355-5efb6b510dca
caps.latest.revision: 14
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
# How to: Save Dataset Changes to a Database
After the data in your dataset has been modified and validated, you probably want to send the updated data back to a database. In order to send the modified data to a database, you call the `Update` method of a [TableAdapter](../VS_raddata/TableAdapter-Overview.md) or data adapter. The adapter's `Update` method updates a single data table and executes the correct command (INSERT, UPDATE, or DELETE) based on the <xref:System.Data.DataRow.RowState?qualifyHint=False> of each data row in the table.  
  
 When saving data in related tables, Visual Studio provides a TableAdapterManager component that assists in performing saves in the proper order based on the foreign-key constraints defined in the database. For more information, see [Hierarchical Update Overview](../Topic/Hierarchical%20Update%20Overview.md).  
  
> [!NOTE]
>  Because attempting to update a data source with the contents of a dataset can result in errors, you should place the code that calls the adapter's `Update` method inside of a `try`/`catch` block.  
  
 The exact procedure to update a data source can vary depending on your business needs, but your application should include the following steps:  
  
1.  Execute code that attempts sending updates to the database within a `try`/`catch` block.  
  
2.  If an exception is caught, locate the data row that caused the error. For more information, see [How to: Locate Rows that Have Errors](../Topic/How%20to:%20Locate%20Rows%20that%20Have%20Errors.md).  
  
3.  Reconcile the problem in the data row (programmatically if possible, or by presenting the invalid row to the user for modification), and then reattempt the update (<xref:System.Data.DataRow.HasErrors?qualifyHint=False> property, <xref:System.Data.DataTable.GetErrors?qualifyHint=False> method).  
  
## Saving Data to a Database  
 Call the `Update` method of a TableAdapter or data adapter, passing the name of the data table that contains the values to be written to the database. For more information on saving data from a single data table back to a database, see [Walkthrough: Saving Data to a Database (Single Table)](../Topic/Walkthrough:%20Saving%20Data%20to%20a%20Database%20\(Single%20Table\).md).  
  
#### To update a database with a dataset using a TableAdapter  
  
-   Enclose the `TableAdapter.Update` method inside a `try`/`catch` block. The following example shows how to attempt an update with the contents of the `Customers` table in the `NorthwindDataSet`.  
  
     [!CODE [VbRaddataSaving#9](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#9)]  
  
#### To update a database with a dataset using a data adapter  
  
-   Enclose the `DataAdapter.Update` method inside a `try`/`catch` block. The following example shows how to attempt an update to a data source with the contents of `Table1` in `DataSet1`.  
  
     [!CODE [VbRaddataSaving#26](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#26)]  
  
## Updating Two Related Tables in a Dataset  
 When updating related tables in a dataset, it is important to update in the proper sequence to reduce the chance of violating referential integrity constraints. The order of command execution will also follow the indices of the <xref:System.Data.DataRowCollection?qualifyHint=False> in the dataset. To prevent data integrity errors from being raised, the best practice is to update the database in the following sequence:  
  
1.  Child table: delete records.  
  
2.  Parent table: insert, update, and delete records.  
  
3.  Child table: insert and update records.  
  
 For detailed information on saving data from multiple tables, see [Save data to a database (multiple tables)](../VS_raddata/Save-data-to-a-database--multiple-tables-.md).  
  
 If you are updating two or more related tables, then you should include all the update logic within a transaction. A transaction is a process that assures all related changes to a database are successful before committing any changes. For more information see, [Transactions and Concurrency](../Topic/Transactions%20and%20Concurrency.md).  
  
#### To update two related tables using a TableAdapter  
  
1.  Create three temporary <xref:System.Data.DataTable?qualifyHint=False>s to hold the differing records.  
  
2.  Call the `Update` method for each subset of rows from within a `try`/`catch` block. If update errors occur, the suggested course of action is to branch off and resolve them.  
  
3.  Commit the changes from the dataset to the database.  
  
4.  Dispose of the temporary data tables to release the resources.  
  
     [!CODE [VbRaddataSaving#27](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#27)]  
  
#### To update two related tables using a Data Adapter  
  
-   Call the `Update` method of each data adapter.  
  
     The following example shows how to update a data source with a dataset that contains related tables. In order to follow the above sequence, three temporary <xref:System.Data.DataTable?qualifyHint=False>s will be created to hold the differing records. Then the `Update` method will be called for each subset of rows from within a `try`/`catch` block. If update errors occur, the suggested course of action is to branch off and resolve them. Then the dataset commits the changes. Finally, dispose of the temporary data tables to release the resources.  
  
     [!CODE [VbRaddataSaving#28](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#28)]  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)