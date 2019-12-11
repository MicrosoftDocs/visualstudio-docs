---
title: Changing the return type of a DataContext method cannot be undone
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 76b161fc-5075-4192-8d94-f15b02e199e9
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Changing the return type of a DataContext method cannot be undone

Changing the return type of a DataContext method cannot be undone. To revert back to the automatically generated type, you must drag the item from **Server Explorer** or **Database Explorer** onto the O/R Designer again. Are you sure you want to change the return type?

The return type of a <xref:System.Data.Linq.DataContext> method differs depending on where you drop the item in the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]. If you drop an item directly onto an existing entity class, a <xref:System.Data.Linq.DataContext> method that has the return type of the entity class is created. If you drop an item onto an empty area of the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)], a <xref:System.Data.Linq.DataContext> method that returns an automatically generated type is created. You can change the return type of a <xref:System.Data.Linq.DataContext> method after you add it to the methods pane. To inspect or change the return type of a <xref:System.Data.Linq.DataContext> method, select it and click the **Return Type** property in the **Properties** window.

## To change the return type of a DataContext

- Click **Yes**.

## To exit the message box and leave the return type unchanged

- Click **No**.

## To revert to the original return type after changing the return type

1. Select the <xref:System.Data.Linq.DataContext> method on the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)] and delete it.

2. Locate the item in **Server Explorer/Database Explorer** and drag it onto the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)].

    A <xref:System.Data.Linq.DataContext> method is created with the original default return type.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)