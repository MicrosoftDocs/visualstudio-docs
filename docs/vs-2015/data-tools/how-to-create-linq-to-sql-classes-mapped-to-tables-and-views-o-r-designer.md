---
title: "How to: Create LINQ to SQL classes mapped to tables and views (O-R Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 0fb78bbc-7a78-4ab4-b32f-85ece912e660
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create LINQ to SQL classes mapped to tables and views (O/R Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]
LINQ to SQL classes that are mapped to database tables and views are called *entity classes*. The entity class maps to a record, whereas the individual properties of an entity class map to the individual columns that make up a record. Create entity classes that are based on database tables or views by dragging tables or views from **Server Explorer**/**Database Explorer** onto the [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md). The [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] generates the classes and applies the specific [!LINQ to SQL attributes to enable [!LINQ to SQL functionality (the data communication and editing capabilities of the <xref:System.Data.Linq.DataContext>). For detailed information about [!LINQ to SQL classes, see [The LINQ to SQL Object Model](https://msdn.microsoft.com/library/81dd0c37-e2a4-4694-83b0-f2e49e693810).

> [!NOTE]
> The [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] is a simple object relational mapper because it supports only 1:1 mapping relationships. In other words, an entity class can have only a 1:1 mapping relationship with a database table or view. Complex mapping, such as mapping an entity class to multiple tables, is not supported. However, you can map an entity class to a view that joins multiple related tables.

## Create LINQ to SQL Classes That Are Mapped to Database Tables or Views
 Dragging tables or views from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] creates entity classes in addition to the <xref:System.Data.Linq.DataContext> methods that are used for performing updates.

 By default, the [!LINQ to SQL runtime creates logic to save changes from an updatable entity class back to the database. This logic is based on the schema of the table (the column definitions and primary key information). If you do not want this behavior, you can configure an entity class to use stored procedures to perform Inserts, Updates, and Deletes instead of using the default [!LINQ to SQL runtime behavior. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md).

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To create LINQ to SQL classes that are mapped to database tables or views

1. In **Server**/**Database Explorer**, expand **Tables** or **Views** and locate the database table or view that you want to use in your application.

2. Drag the table or view onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

     An entity class is created and appears on the design surface. The entity class has properties that map to the columns in the selected table or view.

## Create an Object Data Source and Display the Data on a Form
 After you create entity classes by using the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)], you can create an object data source and populate the [Data Sources Window](https://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992) with the entity classes.

#### To create an object data source based on LINQ to SQL entity classes

1. On the **Build** menu, click **Build Solution** to build your project.

2. On the **Data** menu, click **Show Data Sources**.

3. In the **Data Sources** window, click **Add New Data Source**.

4. Click **Object** on the **Choose a Data Source Type** page and then click **Next**.

5. Expand the nodes and locate and select your class.

    > [!NOTE]
    > If the **Customer** class is not available, cancel out of the wizard, build the project, and run the wizard again.

6. Click **Finish** to create the data source and add the **Customer** entity class to the **Data Sources** window.

7. Drag items from the **Data Sources** window onto a form.

## See also

- [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
- [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
- [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md)
- [The LINQ to SQL Object Model](https://msdn.microsoft.com/library/81dd0c37-e2a4-4694-83b0-f2e49e693810)
- [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../data-tools/walkthrough-customizing-the-insert-update-and-delete-behavior-of-entity-classes.md)
- [Walkthrough: Adding Validation to Entity Classes](https://msdn.microsoft.com/library/85b06a02-b2e3-4534-95b8-d077c8d4c1d7)
- [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)