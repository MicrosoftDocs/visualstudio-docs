---
title: "Cannot create an association &lt;association name&gt; - property types do not match | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 97ec5a04-6e23-45a2-9226-d77ead854392
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Cannot create an association &lt;association name&gt; - property types do not match
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Cannot create an association \<association name> - property types do not match. Properties do not have matching types: \<property names>.

 Associations are defined by the selected **Association Properties** in the **Association Editor** dialog box. Properties on each side of the association must be of the same data type.

 The properties listed in the message do not have the same data types.

### To correct this error

1. Examine the message and note the properties called out in the message.

2. Click **OK** to dismiss the dialog box.

3. Inspect the **Association Properties** and select properties of the same data type.

4. Click **OK**.

## See Also
 [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
