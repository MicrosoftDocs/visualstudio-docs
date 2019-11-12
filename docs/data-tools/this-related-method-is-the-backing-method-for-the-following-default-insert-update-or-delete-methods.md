---
title: This related method is the backing method for the following default insert, update, or delete methods
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 62afa6da-97cf-48b9-8de3-33e4d72a0377
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# This related method is the backing method for the following default insert, update, or delete methods

This related method is the backing method for the following default `Insert`, `Update`, or `Delete` methods. If it is deleted, these methods will be deleted as well. Do you wish to continue?

The selected `DataContext` method is currently used as one of the `Insert`, `Update`, or `Delete` methods for one of the entity classes on the **O/R Designer**. Deleting the selected method causes the entity class that was using this method to revert to the default run-time behavior for performing the insert, update, or delete during an update.

## Selected method options

- To delete the selected method, causing the entity class to use runtime updates, click **Yes**.

   The selected method is deleted and any classes that used this method for overriding update behavior are reverted to using the default LINQ to SQL run-time behavior.

- To close the message box, leaving the selected method unchanged, click **No**.

   The message box closes and no changes are made.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)