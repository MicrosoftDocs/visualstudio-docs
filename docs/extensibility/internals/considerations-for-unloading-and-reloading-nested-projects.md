---
title: "Considerations for Unloading and Reloading Nested Projects | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "nested projects, unloading and reloading"
  - "projects [Visual Studio SDK], unloading and reloading nested"
ms.assetid: 06c3427e-c874-45b1-b9af-f68610ed016c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Considerations for unloading and reloading nested projects

When you implement nested project types, you must perform additional steps when you unload and reload the projects. To correctly notify listeners to solution events, you must correctly raise the `OnBeforeUnloadProject` and `OnAfterLoadProject` events.

One reason to raise these events is for source code control (SCC). You don't want SCC to delete the items from the server and then add them back as *new* if there's a `Get` operation from SCC. In that case, a new file would be loaded out of SCC. You'd have to unload and reload all the files in case they're different.

Source code control calls `ReloadItem`. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents> interface to call `OnBeforeUnloadProject` and `OnAfterLoadProject` to delete the project and re-create it. When you implement the interface in this way, SCC is informed that the project was temporarily deleted and added again. Therefore, SCC doesn't operate on the project as if the project was *actually* deleted and re-added.

## Reload projects

To support reloading of nested projects, you implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem%2A> method. In your implementation of `ReloadItem`, you close the nested projects and then re-create them.

Typically when a project is reloaded, the IDE raises the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnBeforeUnloadProject%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterLoadProject%2A> events. However, for nested projects that are deleted and reloaded, the parent project initiates the process, not the IDE. Because the parent project doesn't raise solution events, and the IDE has no information about the initialization of the process, the events aren't raised.

To handle this process, the parent project calls `QueryInterface` on the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents> interface. `IVsFireSolutionEvents` has functions that tell the IDE to raise the `OnBeforeUnloadProject` event to unload the nested project, and then raise the `OnAfterLoadProject` event to reload the same project.

## See also

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3>
- [Nest projects](../../extensibility/internals/nesting-projects.md)