---
title: "The designer cannot be modified while debugging | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 487dafe4-d57c-4be1-9e3a-bb0a8699b2fa
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# The designer cannot be modified while debugging
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This message appears when an attempt is made to modify items on the O/R Designer when the application is running in debug mode. When the application is running in debug mode, the O/R Designer is read-only.

### To correct this error

- Click **Stop Debugging** on the **Debug** menu.

     The application stops debugging, and items in the O/R Designer can be modified.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
