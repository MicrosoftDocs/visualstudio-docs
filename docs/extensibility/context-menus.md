---
title: "Context Menus | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - context menus"
ms.assetid: 44fd9e6a-6d42-4aba-80ba-f37fa0070f1d
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# Context menus
Context menus are displayed when a user right-clicks in an active region of the client area and clear when the right mouse button is released.

## Editor context menus
 By intercepting `ECMD_SHOWCONTEXTMENU`, your language service can control the context menus that will display in the editor. To display your own context menu, handle this command when it is passed into your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowContextMenu%2A>. If you do not handle this command, then the IDE displays a standard context menu provided for the editor. You can also control the content of the context menu on a per-marker basis. For more information about this, see [Use text markers with the legacy API](../extensibility/using-text-markers-with-the-legacy-api.md) and [Intercept legacy language service commands](../extensibility/internals/intercepting-legacy-language-service-commands.md).

## See also
- [Develop a legacy language service](../extensibility/internals/developing-a-legacy-language-service.md)
- [Extend menus and commands](../extensibility/extending-menus-and-commands.md)