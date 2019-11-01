---
title: "Update data by using a TableAdapter | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data [Visual Studio], saving"
  - "data [Visual Studio], TableAdapters"
  - "updating data, TableAdapters"
  - "TableAdapters, updating data"
  - "data [Visual Studio], updating"
  - "saving data"
ms.assetid: 5e32e10e-9bac-4969-9bdd-b8f6919d3516
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Update data by using a TableAdapter
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

After the data in your dataset has been modified and validated, you can send the updated data back to a databaseby calling the `Update` method of a TableAdapter. The `Update` method updates a single data table and runs the correct command (INSERT, UPDATE, or DELETE) based on the <xref:System.Data.DataRow.RowState%2A> of each data row in the table. When a dataset has related tables, Visual Studio generates a TableAdapterManager class that you  use to do the updates. The TableAdapterManager class ensures that updates are made in the correct order based on the foreign-key constraints that are defined in the database. When you use data-bound controls, the databinding architecture creates a member variable of the TableAdapterManager class called tableAdapterManager. For more information, see [Hierarchical Update Overview](https://msdn.microsoft.com/library/c4f8e8b9-e4a5-4a02-8462-d03d1e8222d6).

> [!NOTE]
> When you try to update a data source with the contents of a dataset, you can get errors.To avoid errors, we recommend thatyou put the code that calls the adapter's `Update` method inside a `try`/`catch` block.

 The exact procedure for updating a data source can vary depending on business needs, but  includes the following steps:

1. Call the adapter's `Update` method in a `try`/`catch` block.

2. If an exception is caught, locate the data row that caused the error. For more information, see [How to: Locate Rows that Have Errors](https://msdn.microsoft.com/library/1fa907c5-fe66-4f29-a253-2b97b900050c).

3. Reconcile the problem in the data row (programmatically if you can, or by presenting the invalid row to the user for modification), and then try the update again (<xref:System.Data.DataRow.HasErrors%2A>, <xref:System.Data.DataTable.GetErrors%2A>).

## Savedata to a database
 Call the `Update` method of a TableAdapter. Pass the name of the data table that contains the values to be written to the database.

#### To update a database by using a TableAdapter

- Enclose the TableAdapter's`Update` method in a `try`/`catch` block. The following example shows how to  update  the contents of the `Customers` table in `NorthwindDataSet` from within a `try`/`catch` block .

     [!code-csharp[VbRaddataSaving#9](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs#9)]
     [!code-vb[VbRaddataSaving#9](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb#9)]

## See Also
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
