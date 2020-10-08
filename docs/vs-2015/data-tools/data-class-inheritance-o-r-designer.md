---
title: "Data class inheritance (O-R Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: af32653c-f4e6-4217-8c5a-e32b322b4918
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# Data class inheritance (O/R Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Like other objects, [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] classes can use inheritance and be derived from other classes. In code, you can specify inheritance relationships between objects by declaring that one class inherits from another. In a database, inheritance relationships are created in several ways. The [!INCLUDE[vs_ordesigner_long](../includes/vs-ordesigner-long-md.md)] ([!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]) supports the concept of single-table inheritance as it is often implemented in relational systems.

 In single-table inheritance, there is a single database table that contains columns for both base and derived classes. With relational data, a discriminator column contains the value that determines which class any given record belongs to. For example, consider a Persons table that contains everyone employed by a company. Some people are employees and some people are managers. The Persons table contains a column named Type that has a value of 1 for managers and a value of 2 for employees. The Type column is the discriminator column. In this scenario, you can create a subclass of employees and populate the class with only records that have a Type value of 2.

 When you configure inheritance in entity classes by using the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)], drag the single table that contains the inheritance data onto the designer two times: one time for each class in the inheritance hierarchy. After you add the tables to the designer, connect them with an Inheritance item from the **Object Relational Designer** toolbox and then set the four inheritance properties in the **Properties** window.

## Inheritance Properties
 The following table lists the inheritance properties and their descriptions:

|Property|Description|
|--------------|-----------------|
|Discriminator Property|The property (mapped to the column) that determines which class the current record belongs to.|
|Base Class Discriminator Value|The value (in the column designated as the Discriminator Property) that determines that a record is of the base class.|
|Derived Class Discriminator Value|The value (in the property designated as the Discriminator Property) that determines that a record is of the derived class.|
|Inheritance Default|The class that should be populated when the value in the property designated as the **Discriminator Property** does not match either the **Base Class Discriminator Value** or the **Derived Class Discriminator Value**.|

 Creating an object model that uses inheritance and corresponds to relational data can be somewhat confusing. This topic provides information about the basic concepts and individual properties that are required for configuring inheritance. The following topics provide a clearer explanation of how to configure inheritance with the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

|Topic|Description|
|-----------|-----------------|
|[How to: Configure inheritance by using the O/R Designer](../data-tools/how-to-configure-inheritance-by-using-the-o-r-designer.md)|Describes how to configure entity classes that use single-table inheritance by using the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].|
|[Walkthrough: Creating LINQ to SQL Classes by Using Single-Table Inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)|Provides step-by-step instructions about how to configure entity classes that use single-table inheritance by using the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].|

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [Walkthrough: Creating LINQ to SQL Classes by Using Single-Table Inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)
 [Getting Started](https://msdn.microsoft.com/library/db8a557a-fef8-4f4f-bb91-8cff7250ee25)
