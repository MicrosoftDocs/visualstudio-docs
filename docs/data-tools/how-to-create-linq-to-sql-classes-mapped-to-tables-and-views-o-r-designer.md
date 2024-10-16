---
title: Map LINQ to SQL classes to tables/views (O-R Designer)
description: Understand how to create LINQ to SQL entity classes (classes that are mapped to tables and views) in Object Relational Designer (O/R Designer).
ms.date: 11/04/2016
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create LINQ to SQL classes mapped to tables and views (O/R Designer)

LINQ to SQL classes that are mapped to database tables and views are called *entity classes*. The entity class maps to a record, whereas the individual properties of an entity class map to the individual columns that make up a record. Create entity classes that are based on database tables or views by dragging tables or views from **Server Explorer** or **Database Explorer** onto the [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md). The **O/R Designer** generates the classes and applies the specific LINQ to SQL attributes to enable LINQ to SQL functionality (the data communication and editing capabilities of the <xref:System.Data.Linq.DataContext>). For detailed information about LINQ to SQL classes, see the [LINQ to SQL object model](/dotnet/framework/data/adonet/sql/linq/the-linq-to-sql-object-model).

> [!NOTE]
> The **O/R Designer** is a simple object relational mapper because it supports only 1:1 mapping relationships. In other words, an entity class can have only a 1:1 mapping relationship with a database table or view. Complex mapping, such as mapping an entity class to multiple tables, is not supported. However, you can map an entity class to a view that joins multiple related tables.

## Create LINQ to SQL classes that are mapped to database tables or views

Dragging tables or views from **Server Explorer** or **Database Explorer** onto the **O/R Designer** creates entity classes in addition to the <xref:System.Data.Linq.DataContext> methods that are used for performing updates.

By default, the LINQ to SQL runtime creates logic to save changes from an updatable entity class back to the database. This logic is based on the schema of the table (the column definitions and primary key information). If you do not want this behavior, you can configure an entity class to use stored procedures to perform inserts, updates, and deletes instead of using the default LINQ to SQL run-time behavior. For more information, see [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md).

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To create LINQ to SQL classes that are mapped to database tables or views

1. In **Server** or **Database Explorer**, expand **Tables** or **Views** and locate the database table or view that you want to use in your application.

2. Drag the table or view onto the **O/R Designer**.

     An entity class is created and appears on the design surface. The entity class has properties that map to the columns in the selected table or view.

## Create an object data source and display the data on a form

After you create entity classes by using the **O/R Designer**, you can create an object data source and populate the [Data Sources window](add-new-data-sources.md#work-with-data-sources-and-windows-forms) with the entity classes.

### To create an object data source based on LINQ to SQL entity classes

1. On the **Build** menu, click **Build Solution** to build your project.

2. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

3. In the **Data Sources** window, click **Add New Data Source**.

4. Click **Object** on the **Choose a Data Source Type** page, and then select **Next**.

5. Expand the nodes and locate and select your class.

    > [!NOTE]
    > If the **Customer** class is not available, cancel out of the wizard, build the project, and run the wizard again.

6. Click **Finish** to create the data source and add the **Customer** entity class to the **Data Sources** window.

7. Drag items from the **Data Sources** window onto a form.

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [Walkthrough: Creating LINQ to SQL classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
- [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
- [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../data-tools/how-to-create-datacontext-methods-mapped-to-stored-procedures-and-functions-o-r-designer.md)
- [LINQ to SQL object model](/dotnet/framework/data/adonet/sql/linq/the-linq-to-sql-object-model)
- [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../data-tools/walkthrough-customizing-the-insert-update-and-delete-behavior-of-entity-classes.md)
- [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)
