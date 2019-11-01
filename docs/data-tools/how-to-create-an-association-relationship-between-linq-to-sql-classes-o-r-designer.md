---
title: Relationships between LINQ to SQL classes (O/R Designer)
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 56133e65-81f3-44c3-bc28-ffdd0671a0d2
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# How to: Create an association between LINQ to SQL classes (O/R Designer)
Associations between entity classes in [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] are analogous to relationships between tables in a database. You can create associations between entity classes by using the **Association Editor** dialog box.

You must select a parent class and child class when you use the **Association Editor** dialog box to create an association. The parent class is the entity class that contains the primary key; the child class is the entity class that contains the foreign-key. For example, if entity classes were created that map to the `Northwind Customers` and `Orders` tables, the `Customer` class would be the parent class and the `Order` class would be the child class.

> [!NOTE]
> When you drag tables from **Server Explorer** or **Database Explorer** onto the **Object Relational Designer** (**O/R Designer**), associations are automatically created based on the existing foreign-key relationships in the database.

## Association properties
After you create an association, when you select the association in the **O/R Designer**, there are some configurable properties in the **Properties** window. (The association is the line between the related classes.) The following table provides descriptions for the properties of an association.

|Property|Description|
|--------------|-----------------|
|**Cardinality**|Controls whether the association is one-to-many or one-to-one.|
|**Child Property**|Specifies whether to create a property on the parent that is a collection or reference to the child records on the foreign-key side of the association. For example, in the association between `Customer` and `Order`, if the **Child Property** is set to **True**, a property named `Orders` is created on the parent class.|
|**Parent Property**|The property on the child class that references the associated parent class. For example, in the association between `Customer` and `Order`, a property named `Customer` that references the associated customer for an order is created on the `Order` class.|
|**Participating Properties**|Displays the association properties and provides an **ellipsis** button (...) that re-opens the **Association Editor** dialog box.|
|**Unique**|Specifies whether the foreign target columns have a uniqueness constraint.|

## To create an association between entity classes

1. Right-click the entity class that represents the parent class in the association, point to **Add**, and then click **Association**.

2. Verify that the correct **Parent Class** is selected in the **Association Editor** dialog box.

3. Select the **Child Class** in the combo box.

4. Select the **Association Properties** that relate the classes. Typically, this maps to the foreign-key relationship defined in the database. For example, in the `Customers` and `Orders` association, the **Association Properties** are the `CustomerID` for each class.

5. Click **OK** to create the association.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [Walkthrough: Creating LINQ to SQL classes](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
- [How to: Represent primary keys](/dotnet/framework/data/adonet/sql/linq/how-to-represent-primary-keys)
