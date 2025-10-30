---
title: Model for Source Control Packages
description: This model represents a source control implementation. The article shows the names of the classes to make it easier to see how source control is carried out.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- source control [Visual Studio SDK], model
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Model for Source Control Packages

The following model represents an example of a source control implementation. In the model, you see the interfaces that you must implement and the environment services that you must call. Like all services, you actually call the methods of a particular interface that you obtain by way of the service. The names of the classes are identified to make it easier to see how source control is carried out.

![SCC&#95;TUP Examples](../../extensibility/internals/media/scc_tup.gif "SCC_TUP")
 
Example Source Control Project

## Interfaces
 You can implement source control for your new project types in Visual Studio using the list of interfaces shown in the following table.

|Interface|Use|
|---------------|---------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>|Called by projects and editors before they save or change (dirty) files. This interface is accessed using the <xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave> service.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2>|Called by projects to request permission to add, remove, or rename a file or directory. This interface is also called by projects to inform the environment when an approved add, remove, or rename action is complete. It is accessed using the <xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackProjectDocuments> service.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2>|Implemented by any entity that registers to be notified when projects add, rename, or remove a file or directory. To register for event notification, call <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2.AdviseTrackProjectDocumentsEvents%2A>.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2>|Called by projects to register with the source control package and to obtain information on source control status. This interface is accessed using the <xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager> service.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2>|Implemented by the project to respond to source control requests for information about files and to obtain the source control settings required for the project file.|

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2.AdviseTrackProjectDocumentsEvents%2A>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2>
- [Supporting Source Control](../../extensibility/internals/supporting-source-control.md)
