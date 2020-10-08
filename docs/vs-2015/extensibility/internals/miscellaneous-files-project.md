---
title: "Miscellaneous Files Project | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "files, adding existing files to solutions"
  - "Miscellaneous Files project"
  - "Solution Items folder"
  - "files, opening with Miscellaneous Files project"
ms.assetid: 93a278a8-d4f4-400b-8945-4f1b0a2b5bac
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Miscellaneous Files Project
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

When a user opens project items, the IDE assigns to the Miscellaneous Files project any items that are not members of any projects in a solution.  
  
 Projects play a significant role in determining which editor is used when a user opens a project item. A project can be designed to open certain files by using a project-specific editor or a standard editor.  
  
 A project-specific editor typically requires that the user have special knowledge or use special interfaces from the project. For more information, see [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md).  
  
 A standard editor can open any file of a specific extension in any project. The user can customize some standard editors, such as the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] text editor, for projects but still retain their public character. Standard editors are created by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method.  
  
 If no project in the solution responds that it can open a project item, the IDE provides a special project called the Miscellaneous Files project that opens any file.  
  
 This special project provides for opening of a file outside the context of a project. During the processing of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenDocumentViaProject%2A> method, the Miscellaneous Files project always responds with a very low priority. Therefore, the Miscellaneous Files project always yields to any higher-priority project that can open files.  
  
 The Miscellaneous Files project does not require the user to explicitly create it with the **New Project** dialog box. Also, the Miscellaneous Files project does not permanently manage a list of project members. It uses an optional feature to record a list of most recently used files for each user.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument>   
 <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY>   
 [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md)   
 [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md)   
 [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)   
 [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
