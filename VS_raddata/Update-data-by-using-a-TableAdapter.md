---
title: "Update data by using a TableAdapter"
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
ms.assetid: 5e32e10e-9bac-4969-9bdd-b8f6919d3516
caps.latest.revision: 15
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
# Update data by using a TableAdapter
After the data in your dataset has been modified and validated, you can send the updated data back to a databaseby calling the `Update` method of a [TableAdapter](../VS_raddata/TableAdapter-Overview.md). The `Update` method updates a single data table and runs the correct command (INSERT, UPDATE, or DELETE) based on the <xref:System.Data.DataRow.RowState?qualifyHint=False> of each data row in the table. When a dataset has related tables, Visual Studio generates a TableAdapterManager class that you  use to do the updates. The TableAdapterManager class ensures that updates are made in the correct order based on the foreign-key constraints that are defined in the database. When you use data-bound controls, the databinding architecture creates a member variable of the TableAdapterManager class called tableAdapterManager. For more information, see [Hierarchical Update Overview](../Topic/Hierarchical%20Update%20Overview.md).  
  
> [!NOTE]
>  When you try to update a data source with the contents of a dataset, you can get errors.To avoid errors, we recommend thatyou put the code that calls the adapter's `Update` method inside a `try`/`catch` block.  
  
 The exact procedure for updating a data source can vary depending on business needs, but  includes the following steps:  
  
1.  Call the adapter's `Update` method in a `try`/`catch` block.  
  
2.  If an exception is caught, locate the data row that caused the error. For more information, see [How to: Locate Rows that Have Errors](../Topic/How%20to:%20Locate%20Rows%20that%20Have%20Errors.md).  
  
3.  Reconcile the problem in the data row (programmatically if you can, or by presenting the invalid row to the user for modification), and then try the update again (<xref:System.Data.DataRow.HasErrors?qualifyHint=False>, <xref:System.Data.DataTable.GetErrors?qualifyHint=False>).  
  
## Savedata to a database  
 Call the `Update` method of a TableAdapter. Pass the name of the data table that contains the values to be written to the database.  
  
#### To update a database by using a TableAdapter  
  
-   Enclose the TableAdapter's`Update` method in a `try`/`catch` block. The following example shows how to  update  the contents of the `Customers` table in `NorthwindDataSet` from within a `try`/`catch` block .  
  
     [!CODE [VbRaddataSaving#9](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#9)]  
  
## See Also  
 [Save data back to the database](../VS_raddata/Save-data-back-to-the-database.md)