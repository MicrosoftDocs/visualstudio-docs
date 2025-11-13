---
title: Command Routing Algorithm
description: Learn about the order of command resolution in Visual Studio as commands are handled by different components and routed from the innermost to the outermost context.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- commands, routing
- command routing
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command routing algorithm

In Visual Studio commands are handled by a number of different components. Commands are routed from the innermost context, which is based on the current selection, to the outermost (also known as global) context. For more information, see [Command availability](../../extensibility/internals/command-availability.md).

## Order of command resolution
 Commands are passed through the following levels of command context:

1. Add-ins: The environment first offers the command to any add-ins that are present.

2. Priority commands: These commands are registered by using <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterPriorityCommandTarget>. They are called for every command in Visual Studio, and are called in the order in which they were registered.

3. Context menu commands: A command located on a context menu is first offered to the command target that is provided to the context menu, and after that to the typical routing.

4. Toolbar set command targets: These command targets are registered when you call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell4.SetupToolbar2%2A>. The `pCmdTarget` parameter can be `null`. If it is not `null`, then this command target is used to update any commands located on the toolbar you are setting up. If the shell is setting up your toolbar, then it passes the window frame as the `pCmdTarget` so that all updates to the commands on your toolbar flow through the window frame, even when it is not in focus.

5. Tool window: Tool windows, which typically implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane> interface, should also implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface so that Visual Studio can get the command target when the tool window is the active window. However, if the tool window that has focus is the **Project** window, then the command is routed to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface that is the common parent of the selected items. If this selection spans multiple projects, the command is routed to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution> hierarchy. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface contains the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand%2A> methods that are analogous to the corresponding commands on the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface.

6. Document window: If the command has the `RouteToDocs` flag set in its *.vsct* file, Visual Studio looks for a command target on the document view object, which is either an instance of an <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane> interface or an instance of a document object (typically an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines> interface or a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> interface). If the document view object does not support the command, Visual Studio routes the command to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface that is returned. (This is an optional interface for document data objects.)

7. Current hierarchy: The current hierarchy can be the project that owns the active document window or the hierarchy that is selected in **Solution Explorer**. Visual Studio looks for the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface that is implemented on the current, or active, hierarchy. The hierarchy should support commands that are valid whenever the hierarchy is active, even if a document window of a project item has focus. However, commands that apply only when **Solution Explorer** has focus must be supported by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface and its <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand%2A> methods.

     **Cut**, **Copy**, **Paste**, **Delete**, **Rename**, **Enter**, and **DoubleClick** commands require special handling. For information about how to handle **Delete** and **Remove** commands in hierarchies, see the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDeleteHandler> interface.

8. Global: If a command has not been handled by the previously mentioned contexts, Visual Studio attempts to route it to the VSPackage that owns a command that implements the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. If the VSPackage has not been loaded already, it is not loaded when Visual Studio calls the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method. The VSPackage is loaded only when the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method is called.

## Related content
- [Command design](../../extensibility/internals/command-design.md)
