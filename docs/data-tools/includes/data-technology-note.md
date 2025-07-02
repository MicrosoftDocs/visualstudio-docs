---
title: Data technology note
author: ghogen
description: Note saying that ADO data technologies aren't recommended for new development.
ms.author: ghogen
ms.date: 07/02/2025
ms.subservice: data-tools
ms.topic: include
---
> [!NOTE]
> The <xref:System.Data.DataSet> class and related classes are legacy .NET Framework technologies from the early 2000s that enable applications to work with data in memory while the apps are disconnected from the database. The technologies are especially useful for apps that enable users to modify data and persist the changes back to the database. Although datasets are a proven successful technology, the recommended approach for new .NET applications is to use [Entity Framework Core](/ef/). Entity Framework provides a more natural way to work with tabular data as object models, and has a more simple programming interface.
