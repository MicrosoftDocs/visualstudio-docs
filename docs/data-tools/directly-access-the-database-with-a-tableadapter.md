---
title: Directly access the database with a TableAdapter in .NET Framework applications
description: Directly access a database with an ADO .NET TableAdapter in .NET Framework applications with Visual Studio, using methods such as Insert, Update, and Delete to manipulate data directly in the database.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- databases [Visual Basic], accessing with a TableAdapter
- DBDirect methods
- datasets [Visual Basic], adding to projects
- data [Visual Studio], saving
- TableAdapter.Delete method
- GenerateDbDirectMethods property
- TableAdapter.Insert method
- TableAdapter.GenerateDBDirectMethods property
- TableAdapter.Update method
- saving data
- TableAdapters
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Directly access the database with a TableAdapter in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

In addition to the `InsertCommand`, `UpdateCommand`, and `DeleteCommand`, TableAdapters are created with methods that can be run directly against the database. You can call these methods (`TableAdapter.Insert`, `TableAdapter.Update`, and `TableAdapter.Delete`) to manipulate data directly in the database.

If you don't want to create these direct methods, set the TableAdapter's `GenerateDbDirectMethods` property to `false` in the **Properties** window. If any queries are added to a TableAdapter in addition to the TableAdapter's main query, they are standalone queries that don't generate these `DbDirect` methods.

## Send commands directly to a database

Call the TableAdapter `DbDirect` method that performs the task you are trying to accomplish.

### To insert new records directly into a database

- Call the TableAdapter's `Insert` method, passing in the values for each column as parameters. The following procedure uses the `Region` table in the Northwind database as an example.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet15":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet15":::
     ---

### To update records directly in a database

- Call the TableAdapter's `Update` method, passing in the new and original values for each column as parameters.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet18":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet18":::
     ---

### To delete records directly from a database

- Call the TableAdapter's `Delete` method, passing in the values for each column as parameters of the `Delete` method. The following procedure uses the `Region` table in the Northwind database as an example.

    > [!NOTE]
    > If you do not have an instance available, instantiate the TableAdapter that you want to use.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet21":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet21":::
     ---

## Related content

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
