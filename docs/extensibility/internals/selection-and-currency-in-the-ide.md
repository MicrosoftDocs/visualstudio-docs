---
title: Selection and Currency in the IDE | Microsoft Docs
description: Learn how VSPackages take part in currency tracking. The Visual Studio IDE maintains information about currently selected objects by using selection context.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- currency, Visual Studio IDE
- IDE, selection
- selection, Visual Studio IDE
- IDE, currency
ms.assetid: 2f6f18d1-acd8-454d-a856-9a4d81155052
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Selection and Currency in the IDE
The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) maintains information about users' currently selected objects by using selection *context*. With selection context, VSPackages can take part in currency tracking in two ways:

- By propagating currency information about the VSPackages to the IDE.

- By monitoring users' currently active selections within the IDE.

## Selection Context
 The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE globally keeps track of IDE currency in its own global selection context object. The following table shows the elements that make up the selection context.

|Element|Description|
|-------------|-----------------|
|Current hierarchy|Typically the current project; a NULL current hierarchy indicates that the solution as a whole is current.|
|Current ItemID|The selected item within the current hierarchy; when there are multiple selections in a project window, there can be multiple current items.|
|Current `SelectionContainer`|Holds the one or more objects for which the Properties window should display properties.|

 Additionally, the environment maintains two global lists:

- A list of active UI command identifiers

- A list of currently active element types.

### Window Types and Selection
 The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE organizes windows into two general types:

- Hierarchy-type windows

- Frame windows, such as tool and document windows

  The IDE tracks currency differently for each of these window types.

  The most common project-type window is the solution explorer, which the IDE controls. A project-type window tracks the global hierarchy and ItemID of the global selection context, and the window relies on the user's selection to determine the current hierarchy. For project-type windows, the environment provides the global service <xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection>, through which VSPackages can monitor the current values for open elements. Property browsing in the environment is driven by this global service.

  Frame windows, on the other hand, use the DocObject within the frame window to push the SelectionContext value (the hierarchy/ItemID/SelectionContainer trio). . Frame windows use the service <xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection> for this purpose. The DocObject can push only values for the selection container, leaving the local values for hierarchy and ItemID unchanged, as is typical for MDI child documents.

### Events and Currency
 Two types of events might occur that affect the environment's notion of currency:

- Events that are propagated to the global level and change the window frame selection context. Examples of this kind of event include an MDI Child window being opened, a global tool window being opened, or a project-type tool window being opened.

- Events that change the elements traced within the window frame selection context. Examples include changing selection within a DocObject or changing selection in a project-type window.

## See also
- [Selection Context Objects](../../extensibility/internals/selection-context-objects.md)
- [Feedback to the User](../../extensibility/internals/feedback-to-the-user.md)
