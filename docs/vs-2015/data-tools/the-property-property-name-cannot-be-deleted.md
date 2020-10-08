---
title: "The property &lt;property name&gt; cannot be deleted | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 55873f74-7834-4ec1-8815-eeeb65618d87
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# The property &lt;property name&gt; cannot be deleted
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The property \<property name> cannot be deleted because it is set as the Discriminator Property for the inheritance between \<class name> and \<class name>

 The selected property is set as the **Discriminator Property** for the inheritance between the classes indicated in the error message. Properties cannot be deleted if they are participating in the inheritance configuration between data classes.

 Set the **Discriminator Property** to a different property of the data class to enable successful deletion of the desired property.

### To correct this error

1. In the O/R Designer, select the inheritance line that connects the data classes indicated in the error message.

2. Set the **Discriminator** Property to a different property.

3. Try to delete the property again.

## See Also
 [How to: Configure inheritance by using the O/R Designer](../data-tools/how-to-configure-inheritance-by-using-the-o-r-designer.md)
 [Data class inheritance (O/R Designer)](../data-tools/data-class-inheritance-o-r-designer.md)
 [Walkthrough: Creating LINQ to SQL Classes by Using Single-Table Inheritance (O/R Designer)](../data-tools/walkthrough-creating-linq-to-sql-classes-by-using-single-table-inheritance-o-r-designer.md)
