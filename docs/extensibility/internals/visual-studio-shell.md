---
title: Visual Studio Shell
description: The Visual Studio shell is the primary agent of integration in Visual Studio and provides basic functionality and supports cross-communication among VSPackages.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- shell, Visual Studio
- Visual Studio, shell
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Visual Studio Shell

The Visual Studio shell is the primary agent of integration in Visual Studio. The shell provides necessary functionality to enable VSPackages to share common services. Because the architectural goal of Visual Studio is to vest primary functionality in the VSPackages, the shell is a framework to provide basic functionality and support cross-communication among its component VSPackages.

## Shell Responsibilities
 The shell has the following key responsibilities:

- Supporting (through COM interfaces) basic elements of the user interface (UI). These include default menus and toolbars, document window frames or multi-document interface (MDI) child windows, and tool window frames, and docking support.

- Maintaining a running list of all currently open documents in a running document table (RDT) in order to coordinate the persistence of documents and to guarantee that one document cannot be opened in more than one way, or in incompatible ways.

- Supporting the command-routing and command-handling interface, `IOleCommandTarget`.

- Loading VSPackages at appropriate times. Delay-loading a VSPackage is necessary to improving performance of the shell.

- Managing certain shared services, such as <xref:Microsoft.VisualStudio.Shell.Interop.SVsShell>, which provides basic shell functionality, and <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>, which supplies basic windowing functionality.

- Managing the solution (.sln) files. Solutions contain groups of related projects, similar to workspace (.dsw) files in Visual C++ 6.0.

- Tracking shell-wide selection, context, and currency. The shell tracks the following types of items:

  - The current project

  - The current project item or ItemID the current <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>

  - The current selection for the **Properties** window or `SelectionContainer`

  - The UI context IDs or CmdUIGuids that control the visibility of commands, menus, and toolbars

  - The currently active elements such as the active window, document, and undo manager

  - The User Context attributes that drive Dynamic Help

  The shell also mediates communication among installed VSPackages and current services. It supports the core features of the shell and makes them available to all VSPackages integrated in Visual Studio. These core features include the following items:

- **About** dialog box and splash screen

- **Add New and Add Existing Item** dialog boxes

- **Class View** window and **Object Browser**

- **References** dialog box

- **Document Outline** window

- **Dynamic Help** window

- **Find** and **Replace**

- **Open Project** and **Open File** dialog boxes on the **New** menu

- **Options** dialog box on the **Tools** menu

- **Properties** window

- **Solution Explorer**

- **Task List** window

- **Toolbox**

## Related content
- <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>
- <xref:Microsoft.VisualStudio.Shell.Interop.SVsShell>
- <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>
- [VSPackages](../../extensibility/internals/vspackages.md)
