---
title: "The property &lt;property name&gt; cannot be deleted because it is participating in the association &lt;association name&gt; | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 389873cc-92dd-48da-bfca-0f6c8e0ae3c2
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# The property &lt;property name&gt; cannot be deleted because it is participating in the association &lt;association name&gt;
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The selected property is set as the **Association Property** for the association between the classes indicated in the error message. Properties cannot be deleted if they are participating in an association between data classes.

 Set the **Association Property** to a different property of the data class to enable successful deletion of the desired property.

### To correct this error

1. Select the association line on the O/R Designer that connects the data classes indicated in the error message.

2. Double-click the line to open the **Association Editor** dialog box.

3. Remove the property from the **Association Properties**.

4. Try to delete the property again.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
