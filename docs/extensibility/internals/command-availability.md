---
title: Command Availability
description: Learn how command context, which changes based on the current project, current editor, and other factors, determines which commands are available in Visual Studio.
ms.date: 03/22/2018
ms.topic: how-to
helpviewer_keywords:
- commands, context
- menu items, visibility contexts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command availability

The Visual Studio context determines which commands are available. The context can change depending on the current project, the current editor, the VSPackages that are loaded, and other aspects of the integrated development environment (IDE).

## Command contexts

The following command contexts are the most common:

- IDE: Commands provided by the IDE are always available.

- VSPackage: VSPackages can define when commands are to be displayed or hidden.

- Project: Project commands appear only for the currently selected project.

- Editor: Only one editor can be active at a time. Commands from the active editor are available. An editor works closely with a language service. The language service must process its commands in the context of the associated editor.

- File type: An editor can load more than one type of file. The available commands can change depending on the file type.

- Active window: The last active document window sets the user interface (UI) context for key bindings. However, a tool window that has a key-binding table that resembles the internal web browser could also set the UI context. For multi-tabbed document windows such as the HTML editor, every tab has a different command context GUID. After a tool window is registered, it is always available on the **View** menu.

- UI context: UI contexts are identified by the values of the <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT> class, for example, <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionBuilding_guid> when the solution is being built, or <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.Debugging_guid> when the debugger is active. Multiple UI contexts can be active at the same time.

## Define custom context GUIDs

If an appropriate command context GUID is not already defined, you can define one in your VSPackage and then program it to be active or inactive as required to control the visibility of your commands:

1. Register context GUIDs by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.GetCmdUIContextCookie%2A> method.

2. Get the state of a context GUID by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.IsCmdUIContextActive%2A> method.

3. Turn context GUIDs on and off by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.SetCmdUIContext%2A> method.

> [!CAUTION]
> Make sure that your VSPackage does not affect any existing context GUIDs because other VSPackages may depend on them.

## Related content

- [Selection context objects](../../extensibility/internals/selection-context-objects.md)
- [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
