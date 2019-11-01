---
title: "How to: Create an association (relationship) between LINQ to SQL classes (O-R Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 56133e65-81f3-44c3-bc28-ffdd0671a0d2
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Associations between entity classes in [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] are analogous to relationships between tables in a database. You can create associations between entity classes by using the **Association Editor** dialog box.

 You must select a parent class and child class when you use the **Association Editor** dialog box to create an association. The parent class is the entity class that contains the primary key; the child class is the entity class that contains the foreign-key. For example, if entity classes were created that map to the Northwind Customers and Orders tables, the Customer class would be the parent class and the Order class would be the child class.

> [!NOTE]
> When you drag tables from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_long](../includes/vs-ordesigner-long-md.md)] ([!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]), associations are automatically created based on the existing foreign-key relationships in the database.

 After you create an association, when you select the association in the O/R Designer, there are some configurable properties in the **Properties** window. (The association is the line between the related classes.) The following table provides descriptions for the properties of an association.

|Property|Description|
|--------------|-----------------|
|**Cardinality**|Controls whether the association is one-to-many or one-to-one.|
|**Child Property**|Specifies whether to create a property on the parent that is a collection or reference to the child records on the foreign-key side of the association. For example, in the association between Customer and Order, if the **Child Property** is set to **True**, a property named Orders is created on the parent class.|
|**Parent Property**|The property on the child class that references the associated parent class. For example, in the association between Customer and Order, a property named Customer that references the associated customer for an order is created on the Order class.|
|**Participating Properties**|Displays the association properties and provides an **ellipsis** button (...) that re-opens the **Association Editor** dialog box.|
|**Unique**|Specifies whether the foreign target columns have a uniqueness constraint.|

### To create an association between entity classes

1. Right-click the entity class that represents the parent class in the association, point to **Add**, and then click **Association**.

2. Verify that the correct **Parent Class** is selected in the **Association Editor** dialog box.

3. Select the **Child Class** in the combo box.

4. Select the **Association Properties** that relate the classes. Typically, this maps to the foreign-key relationship defined in the database. For example, in the Customers and Orders association, the **Association Properties** are the CustomerID for each class.

5. Click **OK** to create the association.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
 [How to: Represent Primary Keys](https://msdn.microsoft.com/library/63c65289-6539-42b2-8493-891c232018fa)
