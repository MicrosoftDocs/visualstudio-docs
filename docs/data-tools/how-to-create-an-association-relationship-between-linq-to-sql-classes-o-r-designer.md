---
title: "How to: Create an association (relationship) between LINQ to SQL classes (O-R Designer) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 56133e65-81f3-44c3-bc28-ffdd0671a0d2
caps.latest.revision: 3
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
# How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)
Associations between entity classes in [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] are analogous to relationships between tables in a database. You can create associations between entity classes by using the **Association Editor** dialog box.  
  
 You must select a parent class and child class when you use the **Association Editor** dialog box to create an association. The parent class is the entity class that contains the primary key; the child class is the entity class that contains the foreign-key. For example, if entity classes were created that map to the Northwind Customers and Orders tables, the Customer class would be the parent class and the Order class would be the child class.  
  
> [!NOTE]
>  When you drag tables from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_long](../data-tools/includes/vs_ordesigner_long_md.md)] ([!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]), associations are automatically created based on the existing foreign-key relationships in the database.  
  
 After you create an association, when you select the association in the O/R Designer, there are some configurable properties in the **Properties** window. (The association is the line between the related classes.) The following table provides descriptions for the properties of an association.  
  
|Property|Description|  
|--------------|-----------------|  
|**Cardinality**|Controls whether the association is one-to-many or one-to-one.|  
|**Child Property**|Specifies whether to create a property on the parent that is a collection or reference to the child records on the foreign-key side of the association. For example, in the association between Customer and Order, if the **Child Property** is set to **True**, a property named Orders is created on the parent class.|  
|**Parent Property**|The property on the child class that references the associated parent class. For example, in the association between Customer and Order, a property named Customer that references the associated customer for an order is created on the Order class.|  
|**Participating Properties**|Displays the association properties and provides an **ellipsis** button (...) that re-opens the **Association Editor** dialog box.|  
|**Unique**|Specifies whether the foreign target columns have a uniqueness constraint.|  
  
### To create an association between entity classes  
  
1.  Right-click the entity class that represents the parent class in the association, point to **Add**, and then click **Association**.  
  
2.  Verify that the correct **Parent Class** is selected in the **Association Editor** dialog box.  
  
3.  Select the **Child Class** in the combo box.  
  
4.  Select the **Association Properties** that relate the classes. Typically, this maps to the foreign-key relationship defined in the database. For example, in the Customers and Orders association, the **Association Properties** are the CustomerID for each class.  
  
5.  Click **OK** to create the association.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)   
 [How to: Represent Primary Keys](../Topic/How%20to:%20Represent%20Primary%20Keys.md)