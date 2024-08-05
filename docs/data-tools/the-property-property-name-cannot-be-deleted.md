---
title: The property cannot be deleted
description: The property cannot be deleted. View information about this Visual Studio Object Relational Designer (O/R Designer) message.
ms.date: 11/04/2016
ms.topic: error-reference
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# The property `<property name>` cannot be deleted

The property \<property name> cannot be deleted because it is set as the **Discriminator Property** for the inheritance between \<class name> and \<class name>

The selected property is set as the **Discriminator Property** for the inheritance between the classes indicated in the error message. Properties cannot be deleted if they are participating in the inheritance configuration between data classes.

Set the **Discriminator Property** to a different property of the data class to enable successful deletion of the desired property.

## To correct this error

1. In the **O/R Designer**, select the inheritance line that connects the data classes indicated in the error message.

2. Set the **Discriminator** Property to a different property.

3. Try to delete the property again.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
