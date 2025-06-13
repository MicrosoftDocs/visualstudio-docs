---
title: 'Open Editors for Open Documents'
description: Learn how to open a file in a standard or project-specific editor. When a project opens a document window, it must determine whether the file is already open.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], opening for open documents
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Open editors for open documents

Before a project opens a document window, the project first must determine whether the file is already open in the document window for another editor. The file can be either open in a project-specific editor, or one of the standard editors registered with Visual Studio.

## Open a project-specific editor
 Use the following procedure to open a project-specific editor for a file that is already open.

### To open a project-specific editor for an open file

1. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.IsDocumentOpen%2A> method.

    This call returns pointers to the document's hierarchy, hierarchy item, and window frame, if appropriate.

2. If the document is open, the project must check to see whether only a document data object exists, or if a document view object is also present.

   - If a document view object exists, and this view is for a different hierarchy or hierarchy item, the project uses the pointer to the view's window frame to resurface the existing window.

   - If a document view object exists, and this view is for the same hierarchy and hierarchy item, the project can open a second view if it can attach to the underlying document data object. Otherwise, the project should use the pointer to the view's window frame to resurface the existing window.

   - If only the document data object exists, the project should determine whether it can use the document data object for its view. If the document data object is compatible, complete the steps discussed in [Open a project-specific editor](../extensibility/how-to-open-project-specific-editors.md).

     If the document data object is not compatible, an error should be displayed to the user that indicates that the file is currently in use. This error should only be displayed in transient cases, such as when a file is being compiled at the same time the user is trying to open the file by using an editor other than the Visual Studio core text editor. The core text editor can share document data object with the compiler.

3. If the document is not open because there is no document data object or document view object, complete the steps in [Open a project-specific editor](../extensibility/how-to-open-project-specific-editors.md).

## Open a standard editor
 Use the following procedure to open a standard editor for a file that is already open.

### To open a standard editor for an open file

1. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A>.

     This method first verifies that the document is not already open by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.IsDocumentOpen%2A>. If the document is already open, then its editor window is resurfaced.

2. If the document is not open, then complete the steps in [How to: Open standard editors](../extensibility/how-to-open-standard-editors.md).

## Related content
- [Open and Save project items](../extensibility/internals/opening-and-saving-project-items.md)
- [How to: Open project-specific editors](../extensibility/how-to-open-project-specific-editors.md)
- [How to: Open standard editors](../extensibility/how-to-open-standard-editors.md)
