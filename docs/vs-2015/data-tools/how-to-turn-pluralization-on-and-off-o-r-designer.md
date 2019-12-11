---
title: "How to: Turn pluralization on and off (O-R Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 9b693bc3-303a-40a9-97ee-9cef5ca3ae81
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Turn pluralization on and off (O/R Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, when you drag database objects that have names ending in s or ies from **Server Explorer**/**Database Explorer** onto the [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md), the names of the generated entity classes are changed from plural to singular. This is done to more accurately represent the fact that the instantiated entity class maps to a single record of data. For example, adding a Customers table to the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] results in an entity class named Customer because the class will hold data for only a single customer.

> [!NOTE]
> Pluralization is on by default only in the English-language version of Visual Studio.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

### To turn pluralization on and off

1. On the **Tools** menu, click **Options**.

2. In the **Options** dialog box, expand **Database Tools**.

> [!NOTE]
> Select **Show all settings** if the **Database Tools** node is not visible.

1. Click **O/R Designer**.

2. Set **Pluralization of names** to **Enabled** = **False** to set the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] so that it does not change class names.

3. Set **Pluralization of names** to **Enabled** = **True** to apply pluralization rules to the class names of objects added to the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
