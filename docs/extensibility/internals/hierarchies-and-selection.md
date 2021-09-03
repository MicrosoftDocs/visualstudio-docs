---
title: Hierarchies and Selection | Microsoft Docs
description: Learn how Visual Studio handles hierarchies such as projects, and how it uses selection context to determine what is displayed to the user.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Visual Studio, hierarchies
- selection
- hierarchies
ms.assetid: cad0a859-7a84-4ce5-b0a9-f7f64e5f8ebb
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Hierarchies and selection
When you customize [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you should understand how [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] handles hierarchies such as projects and how it uses selection context to determine what is displayed to the user. This section discusses the concepts of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] hierarchies and selection.

## In this section
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)

 Describes project hierarchies and the general concept of hierarchies.

- [Selection and currency in the IDE](../../extensibility/internals/selection-and-currency-in-the-ide.md)

 Describes how the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) maintains information about the user's currently active objects and lets VSPackages track currency.

- [Selection context objects](../../extensibility/internals/selection-context-objects.md)

 Discusses the model for how you can determine the user's selection context focus on a window.

- [Feedback to the user](../../extensibility/internals/feedback-to-the-user.md)

 Discusses how the available functionality in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is based on the user's current selection context and overall IDE context.

## Related sections
- [Project types architecture](../../extensibility/internals/project-types-architecture.md)

 Provides detailed technical information about project types.
