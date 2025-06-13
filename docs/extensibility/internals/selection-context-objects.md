---
title: Selection Context Objects
description: Learn about the internals of how the Visual Studio IDE uses a global selection context object to determine what should be displayed in the IDE. 
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- selection, tracking
- selection, context objects
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Selection Context Objects

The Visual Studio integrated development environment (IDE) uses a global selection context object to determine what should be displayed in the IDE. Each window in the IDE can have its own selection context object pushed to the global selection context. The IDE updates the global selection context with values from a window when that window has the focus. For more information, see [Feedback to the User](../../extensibility/internals/feedback-to-the-user.md).

 Each window frame or site in the IDE has a service called <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection>. The object created by your VSPackage that is sited in the window frame must call the `QueryService` method to get a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection> interface.

 Frame windows can keep portions of their selection context information from being propagated to the global selection context when they are started. This ability is useful for tool windows that may have to start with an empty selection.

 Modifying the global selection context triggers events that VSPackages can monitor. VSPackages can perform the following tasks by implementing `IVsTrackSelectionEx` and <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection> interfaces:

- Update the currently active file in a hierarchy.

- Monitor changes to certain types of elements. For example, if your VSPackage uses a special **Properties** window, you can monitor changes in the active **Properties** window and restart yours when required.

  The following sequence shows the typical course of selection tracking.

1. The IDE retrieves the selection context from the newly opened window and puts it in the global selection context. If the selection context uses HIERARCHY_DONTPROPAGATE or SELCONTAINER_DONTPROPAGATE, that information is not propagated to the global context. For more information, see [Feedback to the User](../../extensibility/internals/feedback-to-the-user.md).

2. Notification events are broadcast to any VSPackage that requested them.

3. The VSPackage acts on the events it receives by performing activities such as updating a hierarchy, reactivating a tool, or other similar tasks.

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection>
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)
- [Selection and Currency in the IDE](../../extensibility/internals/selection-and-currency-in-the-ide.md)
- [Project Types](../../extensibility/internals/project-types.md)
