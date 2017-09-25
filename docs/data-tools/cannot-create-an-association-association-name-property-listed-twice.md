---
title: "Cannot create an association &lt;association name&gt; - property listed twice | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3ced8bda-210e-4caf-9d8f-96cdbba19251
caps.latest.revision: 2
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
ms.technology: "vs-data-tools"
---
# Cannot create an association &lt;association name&gt; - property listed twice
Cannot create an association \<association name>. The same property is listed more than once: \<property name>.  
  
 Associations are defined by the selected **Association Properties** in the **Association Editor** dialog box. Properties can be listed only one time for each class in the association.  
  
 The property in the message appears more than one time in either the Parent or Child class's **Association Properties**.  
  
### To resolve this condition  
  
-   Examine the message and note the property specified in the message.  
  
-   Click **OK** to dismiss the message box.  
  
-   Inspect the **Association Properties** and remove the duplicate entries.  
  
-   Click **OK**.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](linq-to-sql-tools-in-visual-studio2.md)   
 [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)   
 [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)