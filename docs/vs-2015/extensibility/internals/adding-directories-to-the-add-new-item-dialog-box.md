---
title: "Adding Directories to the Add New Item Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Add New Item dialog box, extending"
ms.assetid: 67ae8af6-3752-49e8-8ce3-007aca5f7982
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# Adding Directories to the Add New Item Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following code example demonstrates how to register a new set of directories for the **Add New Item** dialog box. Directories for the **Add New Item** dialog box are different for each project. Therefore, the directories are registered under the Projects subkey, found in \<HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\Projects>:  
  
## The Registry Script  
  
```  
NoRemove Projects  
{  
  NoRemove %GUID_Project%  
  {  
    NoRemove AddItemTemplates  
    {  
      NoRemove TemplateDirs  
      {  
        ForceRemove %CLSID_Package%  
        {  
      ForceRemove /1 = s '#%Folder_Label_ResID%'  
          {  
            val TemplatesDir = s '%Template_Path%'     
            val SortPriority = d 2000  
          }  
        }  
      }  
    }  
  }  
}  
```  
  
 The Template_Path value specifies the full path of the directory that contains the project templates. These templates can be either .vsz files or prototypical template files to be cloned.  
  
 The SortPriority value specifies a sorting priority.  
  
## Adding Items to an Existing Project  
 You can also add items to an existing project. For example, for a [!INCLUDE[csprcs](../../includes/csprcs-md.md)] project, you can add items to the \<root>\Program Files\Microsoft Visual Studio \VC#\CSharpProjectItems\LocalProjectItems folder. In this case the `%GUID_Project%` is the GUID for a C# project ({FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}).  
  
 You can also extend an existing project by programming a project subtype. With a project subtype, you can extend a project without writing a new project type. For more information about project subtypes, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).  
  
## See Also  
 [Registering Project and Item Templates](../../extensibility/internals/registering-project-and-item-templates.md)   
 [Adding Items to the Add New Item Dialog Boxes](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)   
 [Adding Directories to the New Project Dialog Box](../../extensibility/internals/adding-directories-to-the-new-project-dialog-box.md)
