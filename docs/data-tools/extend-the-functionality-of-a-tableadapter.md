---
title: Extend the functionality of a TableAdapter in .NET Framework applications
description: Using Visual Studio, learn to extend the functionality of an ADO.NET TableAdapter in .NET Framework applications by adding code to the TableAdapter's partial class file.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- data [Visual Studio], TableAdapters
- data [Visual Studio], extending TableAdapters
- TableAdapters, adding functionality
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Extend the functionality of a TableAdapter in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

You can extend the functionality of a TableAdapter by adding code to the TableAdapter's partial class file.

The code that defines a TableAdapter is regenerated when any changes are made to the TableAdapter in the **Dataset Designer**, or when a wizard modifies the configuration of a TableAdapter. To prevent your code from being deleted during the regeneration of a TableAdapter, add code to the TableAdapter's partial class file.

Partial classes allow code for a specific class to be divided among multiple physical files. For more information, see [`Partial`](/dotnet/visual-basic/language-reference/modifiers/partial) or [`partial` (type)](/dotnet/csharp/language-reference/keywords/partial-type).

## Locate TableAdapters in code

While TableAdapters are designed with the **Dataset Designer**, the TableAdapter classes that are generated are not nested classes of <xref:System.Data.DataSet>. TableAdapters are located in a namespace based on the name of the TableAdapter's associated dataset. For example, if your application contains a dataset named `HRDataSet`, the TableAdapters would be located in the `HRDataSetTableAdapters` namespace. (The naming convention follows this pattern: *DatasetName* + `TableAdapters`).

The following example assumes a TableAdapter named `CustomersTableAdapter` is in a project with `NorthwindDataSet`.

### To create a partial class for a TableAdapter

1. Add a new class to your project by going to the **Project** menu and selecting **Add Class**.

2. Name the class `CustomersTableAdapterExtended`.

3. Select **Add**.

4. Replace the code with the correct namespace and partial class name for your project as follows:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataTableAdapters/CS/CustomersTableAdapterExtended.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataTableAdapters/VB/CustomersTableAdapterExtended.vb" id="Snippet2":::
     ---

## Related content

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
