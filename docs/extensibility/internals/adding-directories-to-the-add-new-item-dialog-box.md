---
title: Adding Directories to the Add New Item Dialog Box
description: Learn how to add directories to the Add New Item dialog box in Visual Studio by using a registry script to register the directories.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Add New Item dialog box, extending
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add directories to the Add New Item dialog box

The following code example demonstrates how to register a new set of directories for the **Add New Item** dialog box. Directories for the **Add New Item** dialog box are different for each project. Therefore, the directories are registered under the **Projects** subkey, found in **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\Projects**.

## Registry script

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

 The `%Template_Path%` value specifies the full path of the directory that contains the project templates. These templates can be either *.vsz* files or prototypical template files to be cloned.

 The `SortPriority` value specifies a sorting priority.

## Add items to an existing project
 You can also add items to an existing project. For example, for a Visual C# project, you can add items to the *\<root>\Program Files\Microsoft Visual Studio\VC#\CSharpProjectItems\LocalProjectItems* folder. In this case, `%GUID_Project%` is the GUID for a C# project ({FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}).

 You can also extend an existing project by programming a project subtype. With a project subtype, you can extend a project without writing a new project type. For more information about project subtypes, see [Project subtypes](../../extensibility/internals/project-subtypes.md).

## Related content
- [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md)
- [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)
- [Add directories to the New Project dialog box](../../extensibility/internals/adding-directories-to-the-new-project-dialog-box.md)
