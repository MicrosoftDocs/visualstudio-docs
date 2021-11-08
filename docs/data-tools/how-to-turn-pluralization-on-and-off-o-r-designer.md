---
title: 'How to: Turn pluralization on and off (O-R Designer)'
description: Know how to turn pluralization on and off in Object Relational Designer (O/R Designer). The default setting converts plural names to singular.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 9b693bc3-303a-40a9-97ee-9cef5ca3ae81
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Turn pluralization on and off (O/R Designer)
By default, when you drag database objects that have names ending in s or ies from **Server Explorer** or **Database Explorer** onto the [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md), the names of the generated entity classes are changed from plural to singular. This is done to more accurately represent the fact that the instantiated entity class maps to a single record of data. For example, adding a `Customers` table to the **O/R Designer** results in an entity class named `Customer` because the class will hold data for only a single customer.

> [!NOTE]
> Pluralization is on by default only in the English-language version of Visual Studio.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To turn pluralization on and off

1. On the **Tools** menu, click **Options**.

2. In the **Options** dialog box, expand **Database Tools**.

    > [!NOTE]
    > Select **Show all settings** if the **Database Tools** node is not visible.

3. Click **O/R Designer**.

4. Set **Pluralization of names** to **Enabled** = **False** to set the **O/R Designer** so that it does not change class names.

5. Set **Pluralization of names** to **Enabled** = **True** to apply pluralization rules to the class names of objects added to the **O/R Designer**.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
