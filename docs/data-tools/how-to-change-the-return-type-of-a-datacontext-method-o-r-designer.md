---
title: Change return type of DataContext method
description: Know how to change the return type of a DataContext method when you drop a stored procedure or function in the Object Relational Designer (O/R Designer).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: c5b66bff-6dbb-43c0-bffa-317133ca5b9e
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Change the return type of a DataContext method (O/R Designer)
The return type of a <xref:System.Data.Linq.DataContext> method (created based on a stored procedure or function) differs depending on where you drop the stored procedure or function in the **O/R Designer**. If you drop an item directly onto an existing entity class, a <xref:System.Data.Linq.DataContext> method that has the return type of the entity class is created (if the schema of the data returned by the stored procedure or function matches the shape of the entity class). If you drop an item onto an empty area of the **O/R Designer**, a <xref:System.Data.Linq.DataContext> method that returns an automatically generated type is created. You can change the return type of a <xref:System.Data.Linq.DataContext> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext> method, select it and click the **Return Type** property in the **Properties** window.

> [!NOTE]
> You cannot revert <xref:System.Data.Linq.DataContext> methods that have a return type set to an entity class to return the auto-generated type by using the **Properties** window. To revert a <xref:System.Data.Linq.DataContext> method to return an auto-generated type, you must drag the original database object onto the **O/R Designer** again.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## To change the return type of a DataContext method from the auto-generated type to an entity class

1. Select the <xref:System.Data.Linq.DataContext> method in the methods pane.

2. Select **Return Type** in the **Properties** window and then select an available entity class in the **Return Type** list. If the desired entity class is not in the list, add it to or create it in the **O/R Designer** to add it to the list.

3. Save the *.dbml* file.

## To change the return type of a DataContext method from an entity class back to the auto-generated type

1. Select the <xref:System.Data.Linq.DataContext> method in the **Methods** pane and delete it.

2. Drag the database object from **Server Explorer** or **Database Explorer** onto an empty area of the **O/R Designer**.

3. Save the *.dbml* file.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
- [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md)
