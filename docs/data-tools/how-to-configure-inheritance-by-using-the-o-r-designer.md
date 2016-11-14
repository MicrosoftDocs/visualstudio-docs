---
title: "How to: Configure inheritance by using the O-R Designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e594af12-e777-434a-bc08-7dd2dac84cdc
caps.latest.revision: 4
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Configure inheritance by using the O/R Designer
The [!INCLUDE[vs_ordesigner_long](../data-tools/includes/vs_ordesigner_long_md.md)] ([!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]) supports the concept of single-table inheritance as it is often implemented in relational systems. In single-table inheritance, there is a single database table that contains fields for both parent information and child information. With relational data, a discriminator column contains the value that determines which class any record belongs to.  
  
 For example, consider a Persons table that contains everyone employed by a company. Some people are employees and some people are managers. The Persons table contains a column named `EmployeeType` that has a value of 1 for managers and a value of 2 for employees; this is the discriminator column. In this scenario, you can create a subclass of employees and populate the class with only records that have an `EmployeeType` value of 2. You can also remove columns that do not apply from each of the classes.  
  
 Creating an object model that uses inheritance (and corresponds to relational data) can be somewhat confusing. The following procedure outlines the steps required for configuring inheritance with the O/R Designer. Following generic steps without referring to an existing table and columns might be difficult, so a walkthrough that uses data has been provided. For detailed step-by-step directions for configuring inheritance by using the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)], see [Walkthrough: Creating LINQ to SQL Classes by Using Single-Table Inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md).  
  
### To create inherited data classes  
  
1.  Open the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] by adding a **LINQ to SQL Classes** item to an existing Visual Basic or C# project.  
  
2.  Drag the table you want to use as the base class onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
3.  Drag a second copy of the table onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] and rename it. This is the derived class, or subclass.  
  
4.  Click **Inheritance** in the **Object Relational Designer** tab of the **Toolbox**, and then click the subclass (the table you renamed) and connect it to the base class.  
  
    > [!NOTE]
    >  Click the **Inheritance** item in the **Toolbox** and release the mouse button, click the second copy of the class you created in step 3, and then click the first class you created in step 2. The arrow on the inheritance line will point to the first class.  
  
5.  In each class, delete any object properties that you do not want to appear and that are not used for associations. You will receive an error if you attempt to delete object properties used for associations: [The property \<property name> cannot be deleted because it is participating in the association \<association name>](../data-tools/the-property-property-name-cannot-be-deleted-because-it-is-participating-in-the-association-association-name.md).  
  
    > [!NOTE]
    >  Because a derived class inherits the properties defined in its base class, the same columns cannot be defined in each class. (Columns are implemented as properties.) You can enable the creation of columns in the derived class by setting the Inheritance Modifier on the property in the base class. For more information, see [NOT IN BUILD: Overriding Properties and Methods](http://msdn.microsoft.com/en-us/2167e8f5-1225-4b13-9ebd-02591ba90213).  
  
6.  Select the inheritance line in the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].  
  
7.  In the **Properties** window, set the **Discriminator Property** to the column name that is used to distinguish the records in your classes.  
  
8.  Set the **Derived Class Discriminator Value** property to the value in the database that designates the record as the inherited type. (This is the value that is stored in the discriminator column and that is used to designate the inherited class.)  
  
9. Set the **Base Class Discriminator Value** property to the value that designates the record as a base type. (This is the value that is stored in the discriminator column and that is used to designate the base class.)  
  
10. Optionally, you can also set the **Inheritance Default** property to designate a type in an inheritance hierarchy that is used when loading rows that do not match any defined inheritance code. In other words, if a record has a value in its discriminator column that does not match the value in either the **Derived Class Discriminator Value** or **Base Class Discriminator Value** properties, the record will load into the type designated as the **Inheritance Default**.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [PAVE What's New for Data Application Development in Visual Studio 2012](http://msdn.microsoft.com/en-us/3d50d68f-5f44-4915-842f-6d42fce793f1)   
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Walkthrough: Creating LINQ to SQL Classes by Using Single-Table Inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)   
 [NOT IN BUILD: Inheritance in Visual Basic](http://msdn.microsoft.com/en-us/e5e6e240-ed31-4657-820c-079b7c79313c)   
 [Inheritance](/dotnet/csharp/programming-guide/classes-and-structs/inheritance)