---
title: "Cannot create an association &lt;association name&gt; - property listed twice | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 3ced8bda-210e-4caf-9d8f-96cdbba19251
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Cannot create an association &lt;association name&gt; - property listed twice
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Cannot create an association \<association name>. The same property is listed more than once: \<property name>.

 Associations are defined by the selected **Association Properties** in the **Association Editor** dialog box. Properties can be listed only one time for each class in the association.

 The property in the message appears more than one time in either the Parent or Child class's **Association Properties**.

### To resolve this condition

- Examine the message and note the property specified in the message.

- Click **OK** to dismiss the message box.

- Inspect the **Association Properties** and remove the duplicate entries.

- Click **OK**.

## See Also
 [LINQ to SQL Tools in Visual Studio](https://msdn.microsoft.com/library/a57e82d5-f7e4-4894-8add-3d9ba4fce186)
 [How to: Create an association (relationship) between LINQ to SQL classes (O/R Designer)](../data-tools/how-to-create-an-association-relationship-between-linq-to-sql-classes-o-r-designer.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
