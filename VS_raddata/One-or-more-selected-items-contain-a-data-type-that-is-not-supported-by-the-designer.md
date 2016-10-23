---
title: "One or more selected items contain a data type that is not supported by the designer"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 71dcd4f9-2946-42c5-9ce4-99c819ea2785
caps.latest.revision: 4
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
# One or more selected items contain a data type that is not supported by the designer
One or more of the items dragged from **Server Explorer**/**Database Explorer** onto the O/R Designer contains a data type that is not supported by the O/R Designer (for example, [CLR User-Defined Types](../Topic/CLR%20User-Defined%20Types.md)).  
  
### To correct this error  
  
1.  Create a view that is based on the desired table and that does not include the unsupported data type.  
  
2.  Drag the view from **Server Explorer**/**Database Explorer** onto the designer.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../VS_raddata/LINQ-to-SQL-Tools-in-Visual-Studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)