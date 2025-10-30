---
title: Data class inheritance (O-R Designer)
description: Work with data class inheritance in Object Relational Designer (O/R Designer), a LINQ to SQL class tool in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Data class inheritance (O/R Designer)

Like other objects, LINQ to SQL classes can use inheritance and be derived from other classes. In code, you can specify inheritance relationships between objects by declaring that one class inherits from another. In a database, inheritance relationships are created in several ways. The **Object Relational Designer** (**O/R Designer**) supports the concept of single-table inheritance as it is often implemented in relational systems.

In single-table inheritance, there is a single database table that contains columns for both base and derived classes. With relational data, a discriminator column contains the value that determines which class any given record belongs to. For example, consider a `Persons` table that contains everyone employed by a company. Some people are employees and some people are managers. The `Persons` table contains a column named `Type` that has a value of 1 for managers and a value of 2 for employees. The `Type` column is the discriminator column. In this scenario, you can create a subclass of employees and populate the class with only records that have a `Type` value of 2.

When you configure inheritance in entity classes by using the O/R Designer, drag the single table that contains the inheritance data onto the designer two times: one time for each class in the inheritance hierarchy. After you add the tables to the designer, connect them with an Inheritance item from the **Object Relational Designer** toolbox and then set the four inheritance properties in the **Properties** window.

## Inheritance properties

The following table lists the inheritance properties and their descriptions:

|Property|Description|
|--------------|-----------------|
|**Discriminator Property**|The property (mapped to the column) that determines which class the current record belongs to.|
|**Base Class Discriminator Value**|The value (in the column designated as the **Discriminator Property**) that determines that a record is of the base class.|
|**Derived Class Discriminator Value**|The value (in the property designated as the **Discriminator Property**) that determines that a record is of the derived class.|
|**Inheritance Default**|The class that is populated when the value in the property designated as the **Discriminator Property** does not match either the **Base Class Discriminator Value** or the **Derived Class Discriminator Value**.|

Creating an object model that uses inheritance and corresponds to relational data can be somewhat confusing. This topic provides information about the basic concepts and individual properties that are required for configuring inheritance. The following topics provide a clearer explanation of how to configure inheritance with the **O/R Designer**.

|Topic|Description|
|-----------|-----------------|
|[How to: Configure inheritance by using the O/R Designer](../data-tools/how-to-configure-inheritance-by-using-the-o-r-designer.md)|Describes how to configure entity classes that use single-table inheritance by using the **O/R Designer**.|
|[Walkthrough: Creating LINQ to SQL classes by using single-table inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)|Provides step-by-step instructions on how to configure entity classes that use single-table inheritance by using the **O/R Designer**.|

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [Walkthrough: Creating LINQ to SQL classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
- [Walkthrough: Creating LINQ to SQL classes by using single-table inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)
- [Getting started](/dotnet/framework/data/adonet/sql/linq/getting-started)
