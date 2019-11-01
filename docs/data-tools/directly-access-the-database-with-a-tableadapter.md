---
title: Directly access the database with a TableAdapter
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "databases [Visual Basic], accessing with a TableAdapter"
  - "DBDirect methods"
  - "datasets [Visual Basic], adding to projects"
  - "data [Visual Studio], saving"
  - "TableAdapter.Delete method"
  - "GenerateDbDirectMethods property"
  - "TableAdapter.Insert method"
  - "TableAdapter.GenerateDBDirectMethods property"
  - "TableAdapter.Update method"
  - "saving data"
  - "TableAdapters"
ms.assetid: 012c5924-91f7-4790-b2a6-f51402b7014b
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Directly access the database with a TableAdapter

In addition to the `InsertCommand`, `UpdateCommand`, and `DeleteCommand`, TableAdapters are created with methods that can be run directly against the database. You can call these methods (`TableAdapter.Insert`, `TableAdapter.Update`, and `TableAdapter.Delete`) to manipulate data directly in the database.

If you don't want to create these direct methods, set the TableAdapter's `GenerateDbDirectMethods` property to `false` in the **Properties** window. If any queries are added to a TableAdapter in addition to the TableAdapter's main query, they are standalone queries that don't generate these `DbDirect` methods.

## Send commands directly to a database

Call the TableAdapter `DbDirect` method that performs the task you are trying to accomplish.

### To insert new records directly into a database

- Call the TableAdapter's `Insert` method, passing in the values for each column as parameters. The following procedure uses the `Region` table in the Northwind database as an example.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     [!code-vb[VbRaddataSaving#15](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_1.vb)]
     [!code-csharp[VbRaddataSaving#15](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_1.cs)]

### To update records directly in a database

- Call the TableAdapter's `Update` method, passing in the new and original values for each column as parameters.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     [!code-vb[VbRaddataSaving#18](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_2.vb)]
     [!code-csharp[VbRaddataSaving#18](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_2.cs)]

### To delete records directly from a database

- Call the TableAdapter's `Delete` method, passing in the values for each column as parameters of the `Delete` method. The following procedure uses the `Region` table in the Northwind database as an example.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     [!code-vb[VbRaddataSaving#21](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_3.vb)]
     [!code-csharp[VbRaddataSaving#21](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_3.cs)]

## See also

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)