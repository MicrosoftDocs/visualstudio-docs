---
title: "The objects you are adding to the designer use a different data connection than the designer is currently using | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 332ed2f3-3377-4d51-8e3b-fdb98231978e
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# The objects you are adding to the designer use a different data connection than the designer is currently using
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The objects you are adding to the designer use a different data connection than the designer is currently using. Do you want to replace the connection used by the designer?

 When you add items to the [!INCLUDE[vs_ordesigner_long](../includes/vs-ordesigner-long-md.md)] ([!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]), all items use one shared data connection. (The design surface represents the <xref:System.Data.Linq.DataContext>, which uses a single connection for all objects on the surface.) If you add an object to the designer that uses a data connection that differs from the data connection currently being used by the designer, this message appears. To resolve this error, you can choose to maintain the existing connection. If you make this choice, the selected object will not be added. Alternatively, you can choose to add the object and reset the <xref:System.Data.Linq.DataContext> connection to the new connection.

> [!NOTE]
> If you click **Yes**, all entity classes on the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] are mapped to the new connection.

### To replace the existing connection with the connection used by the selected object

- Click **Yes**.

     The selected object is added to the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)], and the DataContext.Connection is set to the new connection.

### To continue to use the existing connection and cancel adding the selected object

- Click **No**.

     The action is canceled. The DataContext.Connection remains set to the existing connection.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)