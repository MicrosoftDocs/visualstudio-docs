---
title: Custom User Interface (Source Control VSPackage)
description: Learn how to create a custom user interface (UI) in Visual Studio by using a source control VSPackage to specify UI elements.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- user interface, source control packages
- source control packages, user interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Custom user interface (source control VSPackage)

A VSPackage declares its menu items and their default states through the Visual Studio command table (*.vsct*) file. The Visual Studio integrated development environment (IDE) displays the menu items in their default states until the VSPackage is loaded. Subsequently, the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method is called to enable or disable menu items.

 A VSPackage can set a registry key so the VSPackage can be automatically loaded depending on a command user interface (UI) context, although typically a source control VSPackage should load on demand instead of just switching to a particular UI context. For more information about the **AutoLoadPackages** registry key, see [Manage VSPackages](../../extensibility/managing-vspackages.md).

## VSPackage UI
 A source control package is implemented as a VSPackage and does not use any UI from Visual Studio. Each source control VSPackage must specify its own UI elements such as menu items, menu groups, tool windows, toolbars, and any required UI for setting options specific to the source control VSPackage. These UI elements can be enabled statically or dynamically. Static UI elements are defined in a *.vsct* file and are displayed whether the VSPackage is loaded or not. Dynamic UI elements may be visible depending on a particular command UI context, such as <xref:EnvDTE.Constants.vsContextNoSolution>, or as the result of a call to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method. The visibility of dynamic UI elements complies with the strategy for delayed loading of VSPackages.

## UI constraints on source control VSPackages
 Because the source control VSPackage cannot be removed from the IDE after it is loaded, the VSPackage must be able to enter an inactive state. When a VSPackage receives notification that it is no longer active, the VSPackage disables its UI and ignores any external IDE interaction. The VSPackage's implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method should hide commands when the VSPackage is not active.

 Every source control VSPackage must implement the `IVsSccProvider` interface. Two methods on the interface, <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider.SetActive%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider.SetInactive%2A>, must be implemented by the VSPackage.

 The source control VSPackage may have subscribed to various IDE events, which are implemented by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3>, <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2>, and so on. Also, the VSPackage may have implemented registry-enabled callback interfaces, such as the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence>. These interfaces must all be ignored when inactive.

 The following list shows the interfaces affected by the active state of a source control VSPackage:

- Track project documents events.

- Solution events.

- Solution persistence interfaces. When inactive, packages should not write to *.sln* and *.suo* files.

- Property extenders.

  The required <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2>, and also any optional interfaces associated with source control, are not called when the source control VSPackage is inactive.

  When the Visual Studio IDE starts, Visual Studio sets the command UI context to the ID of the current default source control VSPackage ID. This causes the static UI of the active source control VSPackage to appear in the IDE without actually loading the VSPackage. Visual Studio pauses for the VSPackage to register with Visual Studio through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterScciProvider> before it makes any calls to the VSPackage.

  The following table describes specific details about how the Visual Studio IDE hides different UI items.

| UI item | Description |
| - | - |
| Menus and toolbars | The source control package must set the initial menu and toolbar visibility states to the source control package ID in the [VisibilityConstraints](../../extensibility/visibilityconstraints-element.md) section of the *.vsct* file. This enables the Visual Studio IDE to set the state of the menu items appropriately without loading the VSPackage and calling an implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method. |
| Tool windows | The source control VSPackage hides any tool windows it owns when it is made inactive. |
| Source control VSPackage-specific options pages | The registry key **HKLM\SOFTWARE\Microsoft\VisualStudio\X.Y\ToolsOptionsPages\VisibilityCmdUIContexts** lets a VSPackage set the contexts in which it requires its options pages to be displayed. A registry entry under this key would have to be created by using the service ID (SID) of the source control service and assigning it a DWORD value of 1. Whenever a UI event occurs in a context the source control VSPackage is registered with, the VSPackage will be called if it is active. |

## Related content
- <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterScciProvider>
- <xref:EnvDTE.Constants.vsContextNoSolution>
- [Manage VSPackages](../../extensibility/managing-vspackages.md)
