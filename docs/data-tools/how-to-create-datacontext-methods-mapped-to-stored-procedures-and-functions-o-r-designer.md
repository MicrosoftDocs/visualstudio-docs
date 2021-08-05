---
title: Map DataContext methods to sprocs and functions
description: Learn to create DataContext methods that are mapped to stored procedures (sprocs) and functions using Object Relational Designer (O/R Designer).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: e7ca32f1-50b3-48af-ad92-ceafd749296a
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)

You can add stored procedures and functions to the **O/R Designer** as <xref:System.Data.Linq.DataContext> methods. Calling the method and passing in the required parameters runs the stored procedure or function on the database and returns the data in the return type of the <xref:System.Data.Linq.DataContext> method. For detailed information about <xref:System.Data.Linq.DataContext> methods, see [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md).

> [!NOTE]
> You can also use stored procedures to override the default [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] run-time behavior that performs Inserts, Updates, and Deletes when changes are saved from entity classes to a database. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md).

## Create DataContext methods

You can create <xref:System.Data.Linq.DataContext> methods by dragging stored procedures or functions from <strong>Server Explorer or **Database Explorer</strong> onto the **O/R Designer**.

> [!NOTE]
> The return type of the generated <xref:System.Data.Linq.DataContext> method differs depending on where you drop the stored procedure or function on the **O/R Designer**. Dropping items directly onto an existing entity class creates a <xref:System.Data.Linq.DataContext> method with the return type of the entity class. Dropping items onto an empty area of the **O/R Designer** creates a <xref:System.Data.Linq.DataContext> method that returns an automatically generated type. You can change the return type of a <xref:System.Data.Linq.DataContext> method after adding it to the **Methods** pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext> method, select it and inspect the **Return Type** property in the **Properties** window. For more information, see [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md).

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To create DataContext methods that return automatically generated types

1. In **Server Explorer** or **Database Explorer**, expand the **Stored Procedures** node of the database with which you are working.

2. Locate the desired stored procedure and drag it onto an empty area of the **O/R Designer**.

     The <xref:System.Data.Linq.DataContext> method is created with an automatically generated return type and appears in the **Methods** pane.

### To create DataContext methods that have the return type of an entity class

1. In **Server Explorer** or **Database Explorer**, expand the **Stored Procedures** node of the database with which you are working.

2. Locate the desired stored procedure and drag it onto an existing entity class in the **O/R Designer**.

     The <xref:System.Data.Linq.DataContext> method is created with the return type of the selected entity class and appears in the **Methods** pane.

> [!NOTE]
> For information about changing the return type of existing <xref:System.Data.Linq.DataContext> methods, see [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md).

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
- [Walkthrough: Creating LINQ to SQL classes](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [Introduction to LINQ in Visual Basic](/dotnet/visual-basic/programming-guide/language-features/linq/introduction-to-linq)
- [LINQ in C#](/dotnet/csharp/linq/linq-in-csharp)
