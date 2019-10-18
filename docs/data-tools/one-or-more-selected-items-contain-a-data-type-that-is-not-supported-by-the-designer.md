---
title: One or more selected items contain a data type that is not supported by the designer
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 71dcd4f9-2946-42c5-9ce4-99c819ea2785
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# One or more selected items contain a data type that is not supported by the designer

One or more of the items dragged from **Server Explorer** or **Database Explorer** onto the **O/R Designer** contains a data type that is not supported by the **O/R Designer**, for example, [CLR user-defined types](/dotnet/framework/data/adonet/sql/clr-user-defined-types).

## To correct this error

1. Create a view that is based on the desired table and that does not include the unsupported data type.

2. Drag the view from **Server Explorer** or **Database Explorer** onto the designer.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)