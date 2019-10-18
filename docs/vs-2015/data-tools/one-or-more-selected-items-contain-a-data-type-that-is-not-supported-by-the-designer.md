---
title: "One or more selected items contain a data type that is not supported by the designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 71dcd4f9-2946-42c5-9ce4-99c819ea2785
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# One or more selected items contain a data type that is not supported by the designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

One or more of the items dragged from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] contains a data type that is not supported by the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] (for example, [CLR User-Defined Types](https://msdn.microsoft.com/library/9f70e0b0-3a0d-4eb1-b914-07a5d0c167c2)).

### To correct this error

1. Create a view that is based on the desired table and that does not include the unsupported data type.

2. Drag the view from **Server Explorer**/**Database Explorer** onto the designer.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
