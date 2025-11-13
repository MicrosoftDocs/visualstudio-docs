---
title: Displaying Files By Using the Open With Command
description: Learn how a project can call the Open With command in the Visual Studio integrated development environment (IDE) to display files. 
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- project types, supporting Open With command
- Open With command
- persistence, supporting Open With command
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Display files by using the Open With command

A project can ask the IDE to display the **Open With** dialog box. This request prompts the user to open a file that has a selection of standard editors. The following steps describe this process:

1. The project calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A>, specifying a value of `OSE_UseOpenWithDialog` for the `OSEOpenDocEditor` parameter.

2. Based on the document's file name extension, the IDE determines which editors listed in the registry can open the specified document and displays this information in the **Open With** dialog box.

    > [!NOTE]
    > Projects that have an intrinsic editor that must be included in the **Open With** dialog box must register an editor factory for each such editor. Intrinsic editors only function together with a particular type of project, which is enforced in the implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method. The IDE has a built-in editor factory for the core text editor and the binary editor. The IDE also creates an instance of an editor factory on behalf of each registered Windows file association. An example of such a file is Microsoft Word.

3. As soon as the user selects an item from the **Open With** dialog box, the IDE then opens the document by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method. For more information, see [How to: Open standard editors](../../extensibility/how-to-open-standard-editors.md).

## Related content
- [Open and save project items](../../extensibility/internals/opening-and-saving-project-items.md)
- [Display files by using the Open File command](../../extensibility/internals/displaying-files-by-using-the-open-file-command.md)
- [How to: Open standard editors](../../extensibility/how-to-open-standard-editors.md)
