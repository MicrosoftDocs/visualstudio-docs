---
title: 'Open Project-Specific Editors'
description: Learn how to implement the OpenItem method with a project-specific editor so that a project can open a file bound to an editor for that project.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- project types, opening a project-specific editor
- editors [Visual Studio SDK], opening project-specific editors
- projects [Visual Studio SDK], opening folders
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Open project-specific editors

If an item file being opened by a project is intrinsically bound to the particular editor for that project, the project must open the file by using a project-specific editor. The file cannot be delegated down to the IDE's mechanism for selecting an editor. For example, instead of using a standard bitmap editor, you can use this project-specific editor option to specify a specific bitmap editor that recognizes information in the file that is unique to your project.

 The IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.OpenItem%2A> method when it determines that a file should be opened by a specific project. For more information, see [Display files by using the Open File command](../extensibility/internals/displaying-files-by-using-the-open-file-command.md). Use the following guidelines to implement the `OpenItem` method to have your project open a file by using a project-specific editor.

## To implement the OpenItem method with a project-specific editor

1. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.FindAndLockDocument%2A> method (`RDT_EditLock`) to determine whether the file (document data object) is already open.

    > [!NOTE]
    > For more information about document data and document view objects, see [Document data and document view in custom editors](../extensibility/document-data-and-document-view-in-custom-editors.md).

2. If the file is already open, resurface the file by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.IsDocumentOpen%2A> method and specifying a value of IDO_ActivateIfOpen for the `grfIDO` parameter.

     If the file is open and the document is owned by a project other than the calling project, a warning will be displayed to the user that the editor being opened is from another project. The file window is then surfaced.

3. If your text buffer (document data object) is already open and you want to attach another view to it, you are responsible for hooking up that view. The recommended approach to instantiating a view (document view object) from the project, is as follows:

    1. Call `QueryService` on the <xref:Microsoft.VisualStudio.Shell.Interop.SLocalRegistry> service to get a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2> interface.

    2. Call the <xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2.CreateInstance%2A> method to create an instance of the document view class.

4. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.CreateDocumentWindow%2A> method, specifying your document view object.

     This method sites the document view object in a document window.

5. Perform the appropriate calls to either the <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat.InitNew%2A> or the <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat.Load%2A> methods.

     At this point, the view should be fully initialized and ready to be opened.

6. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A> method to show and open the view.

## Related content
- [Open and Save project items](../extensibility/internals/opening-and-saving-project-items.md)
- [How to: Open standard editors](../extensibility/how-to-open-standard-editors.md)
- [How to: Open editors for open documents](../extensibility/how-to-open-editors-for-open-documents.md)
