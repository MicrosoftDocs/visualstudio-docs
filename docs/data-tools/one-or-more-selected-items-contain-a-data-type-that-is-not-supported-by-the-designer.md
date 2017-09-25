---
title: "One or more selected items contain a data type that is not supported by the designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 71dcd4f9-2946-42c5-9ce4-99c819ea2785
caps.latest.revision: 4
author: "gewarren"
ms.author: "gewarren"
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
ms.technology: "vs-data-tools"
---
# One or more selected items contain a data type that is not supported by the designer
One or more of the items dragged from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] contains a data type that is not supported by the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] (for example, [CLR User-Defined Types](http://msdn.microsoft.com/Library/9f70e0b0-3a0d-4eb1-b914-07a5d0c167c2)).  
  
### To correct this error  
  
1.  Create a view that is based on the desired table and that does not include the unsupported data type.  
  
2.  Drag the view from **Server Explorer**/**Database Explorer** onto the designer.  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)   
 [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)