---
title: "Logical Operators in Search Expressions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Help Viewer 2.0, logical operators in search"
  - "logical operators in search [Help Viewer 2.0]"
ms.assetid: 0c38ae7d-3e20-4d47-a020-9677cd285916
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# Logical Operators in Search Expressions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using logical operators, you can refine your search for content by creating more complicated search expressions from simpler ones. As the following table shows, logical operators specify how multiple search terms should be combined in a search query.

> [!IMPORTANT]
> You must enter logical operators in all capital letters for the search engine to recognize them.

|To search for|Use|Example|Result|
|-------------------|---------|-------------|------------|
|Both terms in the same topic|AND|dib AND palette|Topics that contain both "dib" and "palette".|
|Either term in a topic|OR|raster OR vector|Topics that contain either "raster" or "vector".|
|First term without the second term in the same topic|NOT|"operating system" NOT DOS|Topics that contain "operating system" but not "DOS".|
|Both terms, close together in a topic|NEAR|user NEAR kernel|Topics that contain "user" within close proximity of "kernel".|

## See Also
 [Full-Text Search Tips](../ide/full-text-search-tips.md)
 [Locate Information](../ide/locate-information.md)
