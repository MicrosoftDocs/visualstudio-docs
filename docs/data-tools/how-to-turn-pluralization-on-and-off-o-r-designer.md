---
title: Turn pluralization on and off (O-R Designer)
description: Know how to turn pluralization on and off in Object Relational Designer (O/R Designer). The default setting converts plural names to singular.
ms.date: 10/24/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Turn pluralization on and off (O/R Designer)

By default, when you drag database objects that have names ending in "s" or "ies" from **Server Explorer** or **Database Explorer** onto the [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md), the names of the generated entity classes are changed from plural to singular. This is done to more accurately represent the fact that the instantiated entity class maps to a single record of data. For example, adding a `Customers` table to the **O/R Designer** results in an entity class named `Customer` because the class holds data for only a single customer.

> [!NOTE]
> Pluralization is on by default only in the English-language version of Visual Studio.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Prerequisites

- Visual Studio with the [LINQ to SQL tools](../data-tools/linq-to-sql-tools-in-visual-studio2.md). To install the tools, start the Visual Studio installer, and select **Modify**. On the **Individual Components** tab, search for and select **LINQ to SQL tools** under the **Code tools** category. Select **Modify** to update your installation.

## Toggle the pluralization setting

Follow these steps to turn the pluralization setting on and off:

:::moniker range="visualstudio"

1. Open the **Options** pane by selecting **Tools** > **Options**.

1. In the **Options** pane, expand **All Settings** > **Database Tools**.

1. In the right pane, select **O/R Designer**. The **Options** dialog opens.

1. In the **Options** dialog, apply pluralization rules to the class names of objects added to the **O/R Designer**. Set the **Pluralization of names** setting value **Enabled** = **True**.

1. Select **OK**.

:::moniker-end
:::moniker range="<=vs-2022"

1. On the **Tools** menu, select **Options**.

2. In the **Options** dialog box, expand **Database Tools**.

    > [!NOTE]
    > Select **Show all settings** if the **Database Tools** node isn't visible.

3. Select **O/R Designer**.

4. Set **Pluralization of names** to **Enabled** = **False** to set the **O/R Designer** so that it doesn't change class names.

5. Set **Pluralization of names** to **Enabled** = **True** to apply pluralization rules to the class names of objects added to the **O/R Designer**.

:::moniker-end

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
