---
title: Troubleshoot snippets
ms.date: 11/04/2016
ms.topic: troubleshooting
helpviewer_keywords:
  - "IntelliSense Code Snippets, troubleshooting"
  - "troubleshooting IntelliSense Code Snippets"
  - "troubleshooting Visual Basic, IntelliSense Code Snippets"
ms.assetid: 7b6dd40e-2f78-4b50-8e68-41fac1bcb81e
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Troubleshoot snippets

Problems with IntelliSense code snippets are typically caused by two problems: a corrupt snippet file or bad content in the snippet file.

## The snippet cannot be dragged from File Explorer to a Visual Studio source file

- The XML in the snippet file may be corrupt. The **XML Editor** in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] can locate problems in the XML structure.

- The snippet file may not conform to the snippet schema. The **XML Editor** in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] can locate problems in the XML structure.

## The code has compiler errors that are not highlighted

- You may be missing a project reference. Examine the documentation about the snippet. If the reference is not found on the computer, you will need to install it. Inserting a snippet should add to the project any references needed. If the snippet is missing the reference information, that can be reported to the snippet creator as an error.

- A variable may be undefined. Undefined variables in a snippet should be highlighted. If not, that can be reported to the snippet creator as an error.

## See also

- [Code snippets](../ide/code-snippets.md)
