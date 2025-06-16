---
title: Running Document Table
description: Learn how the Visual Studio IDE maintains the running document table, which includes all open documents in memory. 
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- read locks
- running document table (RDT), IVsDocumentLockHolder interface
- running document table (RDT)
- running document table (RDT), edit locks
- document data objects, running document table
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Running Document Table

The IDE maintains the list of all currently open documents in an internal structure called the running document table (RDT). This list includes all open documents in memory, regardless of whether these documents are currently being edited. A document is any item that is persisted, including files in a project or the main project file (for example, a .vcxproj file).

## Elements of the Running Document Table
 The running document table contains the following entries.

|Element|Description|
|-------------|-----------------|
|Document moniker|A string that uniquely identifies the document data object. This would be the absolute file path for a project system that manages files (for example, C:\MyProject\MyFile). This string is also used for projects saved in stores other than file systems, such as stored procedures in a database. In this case, the project system can invent a unique string that it can recognize and possibly parse to determine how to store the document.|
|Hierarchy owner|The hierarchy object that owns the document, as represented by an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interface.|
|Item ID|Item identifier for a specific item within the hierarchy. This value is unique among all documents in the hierarchy that owns this document but this value is not guaranteed to be unique across different hierarchies.|
|Document data object|At the minimum, this is an `IUnknown`<br /><br /> object. The IDE does not require any particular interface beyond the `IUnknown` interface for a custom editor's document data object. However, for a standard editor, the editor's implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2> interface is required to handle file persistence calls from the project. For more information, see [Saving a Standard Document](../../extensibility/internals/saving-a-standard-document.md).|
|Flags|Flags that control whether the document is saved, whether a read or edit lock is applied, and so on, can be specified when entries are added to the RDT. For more information, see the <xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS> enumeration.|
|Edit Lock Count|Count of edit locks. An edit lock indicates that some editor has the document open for editing. When the count of edit locks transitions to zero, the user is prompted to save the document, if it has been modified. For example, every time you open a document in an editor using the **New Window** command, an edit lock is added for that document in the RDT. In order for an edit lock to be set, the document must have a hierarchy or item ID.|
|Read Lock Count|Count of read locks. A read lock indicates that the document is being read through some mechanism such as a wizard. A read lock holds a document alive in the RDT while indicating that the document cannot be edited. You can set a read lock even if the document does not have a hierarchy or item ID. This feature allows you to open a document in memory and enter it in the RDT without the document being owned by any hierarchy. This feature is rarely used.|
|Lock holder|An instance of an <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder> interface. The lock holder is implemented by features such as wizards that open and edit documents outside of an editor. A lock holder allows the feature to add an edit lock to the document to prevent the document from being closed while it is still being edited. Normally, edit locks are only added by document windows (that is, editors).|

 Each entry in the RDT has a unique hierarchy or item ID associated with it, which generally corresponds to one node in the project. All documents available for editing are typically owned by a hierarchy. Entries made in the RDT control which project, or—more accurately—which hierarchy, currently owns the document data object being edited. Using the information in the RDT, the IDE can prevent a document from being opened by more than one project at a time.

 The hierarchy also controls the persistence of data and uses the information in the RDT to update the **Save** and **Save As** dialog boxes. When users modify a document and then choose the **Exit** command from the **File** menu, the IDE prompts them with the **Save Changes** dialog box to show them all of the projects and project items that are currently modified. This allows users to choose which of the documents to save. The list of documents to save (that is, those documents that have changes) is generated from the RDT. Any items that you expect to see in the **Save Changes** dialog box upon exiting the application should have records in the RDT. The RDT coordinates which documents are saved and whether the user is prompted about a save operation using the values specified in the Flags entry for each document. For more information on the RDT flags, see the <xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS> enumeration.

## Edit Locks and Read Locks
 Edit locks and read locks reside in the RDT. The document window increments and decrements the edit lock. Thus, when a user opens a new document window, the edit lock count increments by one. When the number of edit locks reaches zero, the hierarchy is signaled to persist or save the data for the associated document. The hierarchy can then persist the data in any way, including persisting as a file or as an item in a repository. You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.LockDocument%2A> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable> interface to add edit locks and read locks, and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.UnlockDocument%2A> method to remove these locks.

 Normally, when the document window for an editor is instantiated, the window frame automatically adds an edit lock for the document in the RDT. However, if you create a custom view of a document that does not use a standard document window (that is, it does not implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> interface), then you need to set your own edit lock. For example, in a wizard, a document is edited without being opened in an editor. In order for document locks to be opened by wizards and similar entities, these entities must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder> interface. To register your document lock holder, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.RegisterDocumentLockHolder%2A> method, and pass in your <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder> implementation. Doing so adds your document lock holder to the RDT. Another scenario for implementing a document lock holder is if you open a document through a special tool window. In this instance, you are unable to have the tool window close the document. However, by registering as a document lock holder in the RDT, the IDE can call your implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder.CloseDocumentHolder%2A> method to prompt a close of the document.

## Other Uses of the Running Document Table
 Other entities in the IDE use the RDT to obtain information about documents. For example, the source control manager uses the RDT to tell the system to reload a document in the editor, after it obtains the newest version of the file. To do this, the source control manager looks up the files in the RDT to see if any of them are open. If they are, then the source control manager first checks to see that the hierarchy implements the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem%2A> method. If the project does not implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem%2A> method, then the source control manager checks for an implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2.ReloadDocData%2A> method on the document data object directly.

 The IDE also uses the RDT to resurface (bring to the front) an open document, if a user requests that document. For more information, see [Displaying Files By Using the Open File Command](../../extensibility/internals/displaying-files-by-using-the-open-file-command.md). To determine whether a file is open in the RDT, do one the following.

- Query for the document moniker (that is, the full document path) to find out if the item is open.

- Use the hierarchy or item ID to ask the project system for the full document path, and then look the item up in the RDT.

## See also
- [RDT_ReadLock Usage](../../extensibility/internals/rdt-readlock-usage.md)
- [Persistence and the Running Document Table](../../extensibility/internals/persistence-and-the-running-document-table.md)
