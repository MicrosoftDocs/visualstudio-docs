---
title: "Changing the return type of a DataContext method cannot be undone"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 76b161fc-5075-4192-8d94-f15b02e199e9
caps.latest.revision: 3
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Changing the return type of a DataContext method cannot be undone
Changing the return type of a DataContext method cannot be undone. To revert back to the automatically generated type, you must drag the item from Server Explorer/Database Explorer onto the O/R Designer again. Are you sure you want to change the return type?  
  
 The return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method differs depending on where you drop the item in the O/R Designer. If you drop an item directly onto an existing entity class, a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that has the return type of the entity class is created. If you drop an item onto an empty area of the O/R Designer, a <xref:System.Data.Linq.DataContext?qualifyHint=False> method that returns an automatically generated type is created. You can change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext?qualifyHint=False> method, select it and click the **Return Type** property in the **Properties** window.  
  
### To change the return type of a DataContext  
  
-   Click **Yes**.  
  
### To exit the message box and leave the return type unchanged  
  
-   Click **No**.  
  
### To revert to the original return type after changing the return type  
  
1.  Select the <xref:System.Data.Linq.DataContext?qualifyHint=False> method on the O/R Designer and delete it.  
  
2.  Locate the item in **Server Explorer/Database Explorer** and drag it onto the O/R Designer.  
  
     A <xref:System.Data.Linq.DataContext?qualifyHint=False> method is created with the original default return type.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [DataContext Methods (O/R Designer)](../VS_raddata/DataContext-Methods--O-R-Designer-.md)   
 [How to: Create DataContext methods mapped to stored procedures and functions (O/R Designer)](../VS_raddata/How-to--Create-DataContext-methods-mapped-to-stored-procedures-and-functions--O-R-Designer-.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)