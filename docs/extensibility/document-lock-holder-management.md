---
title: Document Lock Holder Management
description: Learn how to place an edit lock on a document in the running document table without the user seeing an open document in a document window.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- editors [Visual Studio SDK], custom - document locking
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Document lock holder management

The running document table (RDT) maintains a count of open documents and any edit locks they have. You can place an edit lock on a document in the RDT when it is programmatically edited in the background without the user seeing an open document in a document window. This functionality is often used by designers that modify multiple files through a graphical user interface.

## Document lock holder scenarios

### File "a" has a dependence on file "b"

Consider a situation where you implement a standard editor "A" for file type "a", and each file of type "a" has a reference to (or dependence on) a file of type "b". A standard editor "B" exists for files of type "b". When editor "A" opens file "a" it retrieves the reference to the corresponding file "b". File "b" is not displayed, but editor "A" can modify it. Editor "A" obtains a reference to the document data of file "b" from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.FindAndLockDocument%2A> method and also maintains an edit lock on file "b". After editor "A" is done modifying file "b" you can decrement the edit lock count on file "b" by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.UnlockDocument%2A> method. You can omit this step if you had called the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.FindAndLockDocument%2A> method with the parameter `dwRDTLockType` set to [_VSRDTFLAGS.RDT_NoLock](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS.RDT_NoLock>).

### File "b" is opened by a different editor

In the event that the file "b" is already opened by editor "B" when editor "A" tries to open it, there are two separate scenarios to handle:

- If file "b" is open in a compatible editor, you must have editor "A" register a document edit lock on file "b" using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.RegisterDocumentLockHolder%2A> method. After your editor "A" is done modifying file "b", un-register the document edit lock using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.UnregisterDocumentLockHolder%2A> method.

- If file "b" is open in an incompatible way, you can either let the attempted opening of file "b" by editor "A" fail, or you can let the view associated with editor "A" partially open and display an appropriate error message. The error message should instruct the user to close file "b" in the incompatible editor and then re-open file "a" using editor "A". You can also implement the Visual Studio SDK method <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable2.QueryCloseRunningDocument%2A> to prompt the user to close file "b" that is open in the incompatible editor. If the user closes file "b", the opening of file "a" in editor "A" continues normally.

## Additional document edit lock considerations

You get different behavior if editor "A" is the only editor that has a document edit lock on file "b" than you would if editor "B" also holds a document edit lock on file "b". In Visual Studio, **Class Designer** is an example of a visual designer that does not hold an edit lock on the associated code file. That is, if the user has a class diagram open in design view and the associated code file open simultaneously, and if the user modifies the code file but does not save the changes, the changes are also lost to the class diagram (.cd) file. If the **Class Designer** has the only document edit lock on the code file, the user is not asked to save the changes when closing the code file. The IDE asks the user to save the changes only after the user closes the **Class Designer**. The saved changes are reflected in both files. If both the **Class Designer** and the code file editor held document edit locks on the code file, then the user is prompted to save when closing either the code file or the form. At that point the saved changes are reflected in both the form and the code file. For more information on class diagrams, see [Work with class diagrams (Class Designer)](../ide/class-designer/designing-and-viewing-classes-and-types.md).

Note that if you need to place an edit lock on a document for a non-editor, you must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocumentLockHolder> interface.

Many times a UI designer that modifies code files programmatically makes changes to more than one file. In such cases the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell2.SaveItemsViaDlg%2A> method handles the saving of one or more documents by means of the **Do you want to save changes to the following items?** dialog box.

## Related content

- [Running document table](../extensibility/internals/running-document-table.md)
- [Persistence and the running document table](../extensibility/internals/persistence-and-the-running-document-table.md)
