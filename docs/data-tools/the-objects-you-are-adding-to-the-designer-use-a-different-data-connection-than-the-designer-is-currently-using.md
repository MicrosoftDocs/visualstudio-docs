---
title: Objects added to designer use a different data connection
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 332ed2f3-3377-4d51-8e3b-fdb98231978e
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# The objects you are adding to the designer use a different data connection than the designer

The objects you are adding to the designer use a different data connection than the designer is currently using. Do you want to replace the connection used by the designer?

When you add items to the **Object Relational Designer** (**O/R Designer**), all items use one shared data connection. (The design surface represents the <xref:System.Data.Linq.DataContext>, which uses a single connection for all objects on the surface.) If you add an object to the designer that uses a data connection that differs from the data connection currently being used by the designer, this message appears. To resolve this error, you can choose to maintain the existing connection. If you make this choice, the selected object will not be added. Alternatively, you can choose to add the object and reset the <xref:System.Data.Linq.DataContext> connection to the new connection.

## Connection options

- To replace the existing connection with the connection used by the selected object, click **Yes**.

   The selected object is added to the **O/R Designer**, and the *DataContext.Connection* is set to the new connection.

   > [!NOTE]
   > If you click **Yes**, all entity classes on the **O/R Designer** are mapped to the new connection.

- To continue to use the existing connection and cancel adding the selected object, click **No**.

   The action is canceled. The *DataContext.Connection* remains set to the existing connection.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
