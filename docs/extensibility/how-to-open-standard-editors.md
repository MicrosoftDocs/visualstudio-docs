---
title: 'Open Standard Editors'
description: Learn how to implement the OpenItem method with a standard editor. The IDE determines a standard editor for a designated file type.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], opening
- projects [Visual Studio SDK], opening standard editors
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Open standard editors

When you open a standard editor, you let the IDE determine a standard editor for a designated file type, instead of specifying a project-specific editor for the file.

 Complete the following procedure to implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.OpenItem%2A> method. This will open a project file in a standard editor.

## To implement the OpenItem method with a standard editor

1. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable> (`RDT_EditLock`) to determine whether the document data object file is already open.

2. If the file is already open, resurface the file by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.IsDocumentOpen%2A> method, specifying a value of `IDO_ActivateIfOpen` for the `grfIDO` parameter.

     If the file is open and the document is owned by a different project than the calling project, your project receives a warning that the editor being opened is from another project. The file window is then surfaced.

3. If the document is not open or not in the running document table, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method (`OSE_ChooseBestStdEditor`) to open a standard editor for the file.

     When you call the method, the IDE performs the following tasks:

    1. The IDE scans the Editors/{guidEditorType}/Extensions subkey in the registry to determine which editor can open the file and has the highest priority for doing this.

    2. After the IDE has determined which editor can open the file, the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A>. The editor's implementation of this method returns information that is required for the IDE to call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.CreateDocumentWindow%2A> and site the newly opened document.

    3. Finally, the IDE loads the document by using the usual persistence interface, such as <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2>.

    4. If the IDE has previously determined that the hierarchy or hierarchy item is available, the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.GetItemContext%2A> method on the project to get a project-level context <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> pointer to pass back in with the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.CreateDocumentWindow%2A> method call.

4. Return an <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> pointer to the IDE when the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.GetItemContext%2A> on your project if you want to let the editor get context from your project.

     Performing this step lets the project offer additional services to the editor.

     If the document view or document view object was successfully sited in a window frame, the object is initialized with its data by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2.LoadDocData%2A>.

## Related content
- <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>
- [Open and save project items](../extensibility/internals/opening-and-saving-project-items.md)
- [How to: Open project-specific editors](../extensibility/how-to-open-project-specific-editors.md)
- [How to: Open editors for open documents](../extensibility/how-to-open-editors-for-open-documents.md)
- [Display files by using the Open File command](../extensibility/internals/displaying-files-by-using-the-open-file-command.md)
