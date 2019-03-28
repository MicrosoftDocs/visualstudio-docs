---
title: "How to: Create a Work Item for a Managed Code Defect"
ms.date: 11/04/2016
ms.topic: "conceptual"
helpviewer_keywords:
  - "managed code, creating work items for code defects"
  - "code analysis, creating work items"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Create a Work Item for a Managed Code Defect

You can use the work item tracking feature to log work item from within Visual Studio. To use this feature, your project must be part of an Azure DevOps project in [!INCLUDE[esprfound](../code-quality/includes/esprfound_md.md)].

## To create a work item for managed code defect

1. In the **Code Analysis** window, select  the warning.

2. Choose **Actions**, then choose **Create Work Item** and choose the type of work item to create.

     A new work item is created for you to specify the defect information.

## To create a work item for multiple managed code defects

1. In the **Error List**, select multiple warnings, and then right-click the warnings.

2. Point to **Create Work Item** and click the type of work item to create.

     A single work item is created for all the selected warnings for you to specify the bug information.