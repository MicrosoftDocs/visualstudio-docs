---
title: "Displaying Files By Using the Open With Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "project types, supporting Open With command"
  - "Open With command"
  - "persistence, supporting Open With command"
ms.assetid: 53794bc3-1b73-4d40-954e-cfade1abddcf
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Displaying Files By Using the Open With Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A project can ask the IDE to display the **Open With** dialog box. This request prompts the user to open a file that has a selection of standard editors. The following steps describe this process.  
  
1. The project calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A>, specifying a value of OSE_UseOpenWithDialog for the `OSEOpenDocEditor` parameter.  
  
2. Based on the document's file name extension, the IDE determines which editors listed in the Registry can open the specified document and displays this information in the **Open With** dialog box.  
  
    > [!NOTE]
    > Projects that have an intrinsic editor that must be included in the **Open With** dialog box must register an editor factory for each such editor. Intrinsic editors only function together with a particular type of project, which is enforced in the implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method. The IDE has a built-in editor factory for the core text editor and the binary editor. The IDE also creates an instance of an editor factory on behalf of each registered Windows file association. An example of such a file is Microsoft Word.  
  
3. As soon as the user selects an item from the **Open With** dialog box, the IDE then opens the document by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method. For more information, see [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md).  
  
## See Also  
 [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md)   
 [Displaying Files By Using the Open File Command](../../extensibility/internals/displaying-files-by-using-the-open-file-command.md)   
 [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md)
