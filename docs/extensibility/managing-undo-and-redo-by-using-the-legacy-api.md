---
title: "Managing Undo and Redo by Using the Legacy API | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - undo management"
ms.assetid: 838c0ddf-fdf3-4df1-8d21-79610b8ba0b1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Manage undo and redo by using the legacy API
Editors must support undo operations that let users reverse their recent changes when they modify code. Most editors implemented under [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the .NET Framework can have undo support automatically provided by the integrated development environment (IDE).

## In this section
- [How to: Implement undo management](../extensibility/how-to-implement-undo-management.md)
 Provides undo capability for editors with single or multiple views.

- [How to: Clear the undo stack](../extensibility/how-to-clear-the-undo-stack.md)
 Describes how to clear an undo stack.

- [How to: Use linked undo management](../extensibility/how-to-use-linked-undo-management.md)
 Incorporates linked undo management into your editor.

## Reference
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager>
 Provides undo management for an editor that supports multiple views.
