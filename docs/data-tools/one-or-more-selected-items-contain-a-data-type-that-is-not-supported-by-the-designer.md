---
title: Unsupported data type
description: One or more selected items contain a data type that is not supported by the designer. View information about this Visual Studio O/R Designer message.
ms.date: 11/04/2016
ms.topic: error-reference
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# One or more selected items contain a data type that is not supported by the designer

One or more of the items dragged from **Server Explorer** or **Database Explorer** onto the **O/R Designer** contains a data type that is not supported by the **O/R Designer**, for example, [CLR user-defined types](/dotnet/framework/data/adonet/sql/clr-user-defined-types).

## To correct this error

1. Create a view that is based on the desired table and that does not include the unsupported data type.

2. Drag the view from **Server Explorer** or **Database Explorer** onto the designer.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
