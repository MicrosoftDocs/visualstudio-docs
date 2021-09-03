---
title: Selected class cannot be deleted
description: The selected class cannot be deleted because it is used as a return type for one or more DataContext methods
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: error-reference
ms.assetid: d68254a0-f3a1-47e2-aed3-a83471e1d711
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# The selected class cannot be deleted because it is used as a return type for one or more DataContext methods

The return type of one or more <xref:System.Data.Linq.DataContext> methods is the selected entity class. Deleting an entity class that is used as the return type for a <xref:System.Data.Linq.DataContext> method causes the compilation of the project to fail. To delete the selected entity class, identify the <xref:System.Data.Linq.DataContext> methods that use it and set their return types to a different entity class.

To revert the return types of <xref:System.Data.Linq.DataContext> methods to their original auto-generated types, first delete the <xref:System.Data.Linq.DataContext> method from the **Methods** pane and then drag the object from **Server Explorer**/**Database Explorer** onto the **O/R Designer** again.

## To correct this error

1. Identify <xref:System.Data.Linq.DataContext> methods that use the entity class as a return type by selecting a <xref:System.Data.Linq.DataContext> method in the **Methods** pane and inspecting the **Return Type** property in the **Properties** window.

2. Set the **Return Type** to a different entity class or delete the <xref:System.Data.Linq.DataContext> method from the methods pane.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
