---
title: Document Windows
description: Learn about document windows in Visual Studio, including how to implement them and how the Running document table (RDT) tracks their status.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Visual Studio SDK, document windows
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Document windows

In Visual Studio, a *document window* is a framed child window that is associated with a multiple-document interface (MDI) window. Document windows are typically used for the display and modification of source code or text, but they can also host other functional types. Document windows:

- Can be organized in separate horizontal or vertical tab groups in the parent MDI so that multiple files can be viewed at the same time.

- Can be docked in any order in the parent MDI.

- Can be floated freely.

- Are linked in tab order to other MDI windows.

  The commands for grouping, docking, and floating can be found on the shortcut menu for a document window tab.

  For more information about window behavior in Visual Studio, see [Customize window layouts](../../ide/customizing-window-layouts-in-visual-studio.md).

## Document window implementation
 Document windows are created by implementing an editor. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface creates document windows as part of instantiating an editor. For more information, see [Legacy interfaces in the editor](/previous-versions/visualstudio/visual-studio-2015/extensibility/legacy-interfaces-in-the-editor?preserve-view=true&view=vs-2015).

> [!NOTE]
> To provide backward and forward navigation points in a window, implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBackForwardNavigation> interface. The text editor uses text markers to identify navigation points in the document.

## The Running document table
 The IDE uses the Running document table (RDT) to track the status of every document window. The RDT is the mechanism through which document windows are notified of events, such as when a solution is closed or when a file has been edited. For more information, see [Running document table](../../extensibility/internals/running-document-table.md).

## See also
- [Delayed document loading](../../extensibility/internals/delayed-document-loading.md)
