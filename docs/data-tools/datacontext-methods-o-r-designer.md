---
title: DataContext Methods (O-R Designer)
description: Understand DataContext methods in the context of the LINQ to SQL tools for Visual Studio. These methods run stored procedures and functions in a database.
ms.date: 11/04/2016
ms.topic: article
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# DataContext Methods (O/R Designer)

<xref:System.Data.Linq.DataContext> methods (in the context of the [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)) are methods of the <xref:System.Data.Linq.DataContext> class that run stored procedures and functions in a database.

The <xref:System.Data.Linq.DataContext> class is a LINQ to SQL class that acts as a conduit between a SQL Server database and the LINQ to SQL entity classes mapped to that database. The <xref:System.Data.Linq.DataContext> class contains the connection string information and the methods for connecting to a database and manipulating the data in the database. By default, the <xref:System.Data.Linq.DataContext> class contains several methods that you can call, such as the <xref:System.Data.Linq.DataContext.SubmitChanges%2A> method that sends updated data from LINQ to SQL classes to the database. You can also create additional <xref:System.Data.Linq.DataContext> methods that map to stored procedures and functions. In other words, calling these custom methods runs the stored procedure or function in the database to which the <xref:System.Data.Linq.DataContext> method is mapped. You can add new methods to the <xref:System.Data.Linq.DataContext> class just as you would add methods to extend any class. However, in discussions about <xref:System.Data.Linq.DataContext> methods in the context of the **O/R Designer**, it is the <xref:System.Data.Linq.DataContext> methods that map to stored procedures and functions that are being discussed.

## Methods pane

<xref:System.Data.Linq.DataContext> methods that map to stored procedures and functions are displayed in the **Methods** pane of the **O/R Designer**. The **Methods** pane is the pane along the side of the **Entities** pane (the main design surface). The **Methods** pane lists all <xref:System.Data.Linq.DataContext> methods that you created by using the **O/R Designer**. By default, the **Methods** pane is empty; drag stored procedures or functions from **Server Explorer** or **Database Explorer** onto the **O/R Designer** to create <xref:System.Data.Linq.DataContext> methods and populate the **Methods** pane. For more information, see [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md).

> [!NOTE]
> Open and close the methods pane by right-clicking the **O/R Designer** and then clicking **Hide Methods Pane** or **Show Methods Pane**, or use the keyboard shortcut **CTRL**+**1**.

## Two types of DataContext methods

DataContext methods are those methods that map to stored procedures and functions in the database. You can create and add DataContext methods on the **Methods** pane of the **O/R Designer**. There are two distinct types of <xref:System.Data.Linq.DataContext> methods; those that return one or more result sets, and those that do not:

- <xref:System.Data.Linq.DataContext> methods that return one or more result sets:

   Create this kind of <xref:System.Data.Linq.DataContext> method when your application just needs to run stored procedures and functions in the database and return the results. For more information, see [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md), System.Data.Linq.ISingleResult\<T>, and <xref:System.Data.Linq.IMultipleResults>.

- <xref:System.Data.Linq.DataContext> methods that do not return result sets: such as Inserts, Updates, and Deletes for a specific entity class.

   Create this kind of <xref:System.Data.Linq.DataContext> method when your application has to run stored procedures instead of using the default LINQ to SQL behavior for saving modified data between an entity class and the database. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md).

## Return Types of DataContext Methods

When you drag stored procedures and functions from **Server Explorer** or **Database Explorer** onto the **O/R Designer**, the return type of the generated <xref:System.Data.Linq.DataContext> method differs depending on where you drop the item. Dropping the items directly onto an existing entity class creates a <xref:System.Data.Linq.DataContext> method with the return type of the entity class; dropping items onto an empty area of the **O/R Designer** (in either pane) creates a <xref:System.Data.Linq.DataContext> method that returns an automatically generated type. The automatically generated type has the name that matches the stored procedure or function name and properties, which map to the fields returned by the stored procedure or function.

> [!NOTE]
> You can change the return type of a <xref:System.Data.Linq.DataContext> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext> method, select it and inspect the **Return Type** property in the **Properties** window. For more information, see [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md).

Objects you drag from the database onto the O/R Designer surface are named automatically, based on the name of the objects in the database. If you drag the same object more than once, a number is added to the end of the new name that differentiates the names. When database object names contain spaces, or characters not-supported in Visual Basic or C#, the space or invalid character is replaced with an underscore.

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [Stored procedures](/dotnet/framework/data/adonet/sql/linq/stored-procedures)
- [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md)
- [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md)
- [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../data-tools/walkthrough-customizing-the-insert-update-and-delete-behavior-of-entity-classes.md)
- [Walkthrough: Creating LINQ to SQL classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
