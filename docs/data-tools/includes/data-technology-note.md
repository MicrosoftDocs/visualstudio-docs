---
title: Data technology note
author: ghogen
description: Note saying that ADO data technologies aren't recommended for new development.
ms.author: ghogen
ms.date: 08/26/2024
ms.subservice: data-tools
ms.topic: include
---
> [!NOTE]
> Datasets and related classes are legacy .NET Framework technologies from the early 2000s that enable applications to work with data in memory while the applications are disconnected from the database. The technologies are especially useful for applications that enable users to modify data and persist the changes back to the database. Although datasets have proven to be a very successful technology, we recommend that new .NET applications use [Entity Framework Core](/ef/). Entity Framework provides a more natural way to work with tabular data as object models, and it has a simpler programming interface.
