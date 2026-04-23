---
title: RDT_ReadLock Usage
description: Learn about the _VSRDTFLAGS.RDT_ReadLock flag, which provides logic for locking a document in the Running Document Table.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- RDT_ReadLock
- visible
- RDT_EditLock
- invisible
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# RDT_ReadLock Usage

[_VSRDTFLAGS.RDT_ReadLock](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS.RDT_ReadLock>) is a flag that provides logic for locking a document in the Running Document Table (RDT), which is the list of all the documents that are currently open in the Visual Studio IDE. This flag determines when documents are opened, and whether a document is visible in the user interface or held invisibly in memory.

Generally, you use [_VSRDTFLAGS.RDT_ReadLock](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS.RDT_ReadLock>) when one of the following is true:

- You want to open a document invisibly and read-only, but it is not yet established which <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> should own it.

- You want the user to be prompted to save a document that was invisibly opened before the user displayed it in the UI and then attempted to close it.

## How to Manage Visible and Invisible Documents

When a user opens a document in the UI, an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> owner for the document must be established and a [_VSRDTFLAGS.RDT_EditLock](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS.RDT_EditLock>) flag must be set. If no <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> owner can be established, then the document will not be saved when the user clicks **Save All** or closes the IDE. This means if a document is open invisibly where it is modified in memory, and the user is prompted to save the document on shutdown or saved if **Save All** is chosen, then an `RDT_ReadLock` cannot be used. Instead, you must use an `RDT_EditLock` and register a <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder> when a [__VSREGDOCLOCKHOLDER.RDLH_WeakLockHolder](<xref:Microsoft.VisualStudio.Shell.Interop.__VSREGDOCLOCKHOLDER.RDLH_WeakLockHolder>) flag.

## RDT_EditLock and Document Modification

The previous flag mentioned indicates that the invisible opening of the document will yield its `RDT_EditLock` when the document is opened by the user into a visible **DocumentWindow**. When this occurs, the user is presented with a **Save** prompt when the visible **DocumentWindow** is closed. `Microsoft.VisualStudio.Package.Automation.OAProject.CodeModel` implementations that use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsInvisibleEditorManager> service initially work when only an `RDT_ReadLock` is taken (i.e., when the document is opened invisibly to parse information). Later, if the document must be modified, then the lock is upgraded to a weak **RDT_EditLock**. If the user then opens the document in a visible **DocumentWindow**, the `CodeModel`'s weak `RDT_EditLock` is released.

If the user then closes the **DocumentWindow** and chooses **No** when prompted to save the open document, then the `CodeModel` implementation disposes of all information in the document and reopens the document from disk invisibly the next time more information is required for the document. The subtlety of this behavior is an instance where the user opens the **DocumentWindow** of the invisible open document, modifies it, closes it, and then chooses **No** when prompted to save the document. In this case, if the document has an `RDT_ReadLock`, then the document will not actually be closed and the modified document will stay open invisibly in memory, even though the user chose not to save the document.

If the invisible opening of the document uses a weak `RDT_EditLock`, then it yields its lock when the user opens the document visibly and no other locks are held. When the user closes the **DocumentWindow** and chooses **No** when prompted to save the document, then the document must be closed from memory. This means the invisible client must listen for RDT events to track this occurrence. The next time the document is required, the document must be reopened.
