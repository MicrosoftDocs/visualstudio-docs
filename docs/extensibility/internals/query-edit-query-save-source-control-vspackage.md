---
title: Query Edit Query Save (Source Control VSPackage)
description: Learn about the role of Query-Edit Query-Save events and how they are handled by the source control VSPackage.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- QEQS events
- Query Edit Query Save events
- source control packages, Query Edit Query Save events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Query Edit Query Save (Source Control VSPackage)

Visual Studio editors can broadcast Query Edit Query Save (QEQS) events. Visual Studio Source Control Stub implements the QEQS service, so that it is the recipient of QEQS events. These events are then delegated to the currently active source control VSPackage. The active source control VSPackage implements the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2> and its methods. The methods of the `IVsQueryEditQuerySave2` interface are typically called immediately before a document is edited for the first time and immediately before a document is saved.

## QueryEditQuerySave Events
 The source control VSPackage must handle the QEQS events by implementing the `IVsQueryEditQuerySave2` interface and the necessary methods. Below is a brief description of the two methods that the VSPackage must implement at a minimum. The actual implementation must be in accordance with the logic of the source control model.

### QueryEditFiles Method
 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> is called when any project or editor wants to modify a file. Ideally, this method is called *before* the file is modified and when a file is saved. When invoked, the `IVsQueryEditQuerySave2::QueryEditFiles` method checks whether the given files are under source control, whether they need to be checked out, and whether they can be reloaded. If circumstances prevent the files from being editable, the `IVsQueryEditQuerySave2::QueryEditFiles` method tells the calling program to cancel the edit. It is also possible for the caller to specify an invocation mode. In the "silent" mode, this method takes action only if it does not cause any UI to appear. If UI is unavoidable, a flag must be returned to indicate the problem.

 The method behaves in a transactional manner; that is, if the edit is cancelled on a single file, the edit is cancelled for all the files. Conversely, if the edit is allowed, it is allowed for all the files. If this method allows editing once for a given set of files, it must always allow editing on subsequent calls for the same set of files. The allow-edit loop continues until the files are closed, saved, and reloaded; until their attributes (properties) change; or until the source control package is changed. Cases to consider in implementing the `IVsQueryEditQuerySave2::QueryEditFiles` method include multiple files, special files, cancel from user, and in-memory edits.

### QuerySaveFiles Method
 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QuerySaveFiles%2A> is called when any project or editor needs to save a set of files. When invoked, the `IVsQueryEditQuerySave2::QuerySaveFiles` method checks if the given files are read-only and whether they are under source control. If the files need to be checked out, the call is delegated to the source control package. If circumstances prevent the files from being saved, the `IVsQueryEditQuerySave2::QuerySaveFiles` method must tell the editor to cancel the save. As with the `IVsQueryEditQuerySave2::QueryEditFiles` method, it is possible for the caller to specify an invocation mode. In the "silent" mode, this method takes action only if it does not cause any UI to appear. If UI is unavoidable, a flag must be returned to indicate the problem.

 This method must behave in a transactional manner; that is, if the save is cancelled on a single file, the save is cancelled for all the files. Conversely, if the save is allowed, it must be allowed for all the files. As with the `IVsQueryEditQuerySave2::QueryEditFiles` method, cases to consider in implementing the `IVsQueryEditQuerySave2::QuerySaveFiles` method include multiple files, special files, cancel from user, and in-memory edits.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>
