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
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# One or more selected items contain a data type that is not supported by the designer
One or more of the items dragged from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] contains a data type that is not supported by the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] for example, [CLR User-Defined Types](/dotnet/framework/data/adonet/sql/clr-user-defined-types).  
  
### To correct this error  
  
1.  Create a view that is based on the desired table and that does not include the unsupported data type.  
  
2.  Drag the view from **Server Explorer**/**Database Explorer** onto the designer.  
  
## See also
[O/R Designer messages](../data-tools/o-r-designer-messages.md)  
[LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)