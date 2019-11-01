---
title: "The selected class cannot be deleted because it is used as a return type for one or more DataContext methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: d68254a0-f3a1-47e2-aed3-a83471e1d711
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# The selected class cannot be deleted because it is used as a return type for one or more DataContext methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The return type of one or more <xref:System.Data.Linq.DataContext> methods is the selected entity class. Deleting an entity class that is used as the return type for a <xref:System.Data.Linq.DataContext> method will cause the compilation of the project to fail. To delete the selected entity class, identify the <xref:System.Data.Linq.DataContext> methods that use it and set their return types to a different entity class.

 To revert the return types of <xref:System.Data.Linq.DataContext> methods to their original auto-generated types, first delete the <xref:System.Data.Linq.DataContext> method from the methods pane and then drag the object from **Server Explorer**/**Database Explorer** onto the O/R Designer again.

### To correct this error

1. Identify <xref:System.Data.Linq.DataContext> methods that use the entity class as a return type by selecting a <xref:System.Data.Linq.DataContext> method in the methods pane and inspecting the **Return Type** property in the **Properties** window.

2. Set the **Return Type** to a different entity class or delete the <xref:System.Data.Linq.DataContext> method from the methods pane.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
 [How to: Change the return type of a DataContext method (O/R Designer)](../data-tools/how-to-change-the-return-type-of-a-datacontext-method-o-r-designer.md)
