---
title: "Adding Items to the Add New Item Dialog Boxes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Add New Item dialog box, adding items"
ms.assetid: 2f70863b-425b-4e65-86b4-d6a898e29dc7
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Adding Items to the Add New Item Dialog Boxes
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The process for adding items to the **Add New Item** dialog box starts with the registry keys. As shown in the following registry entries, the AddItemTemplates section contains the path of and name of the directory in which items made available in the **Add New Item** dialog box are put.  
  
> [!NOTE]
> The table immediately following the code segment contains additional information about the registry entry.  
  
 This section is located under [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\14.0Exp\Projects].  
  
 The first GUID is the CLSID for projects of this type; the second GUID indicates the registered project type for the Add Items templates.  
  
 \\{C061DB26-5833-11D2-96F5-000000000000}\AddItemTemplates\TemplateDirs\ {ACEF4EB2-57CF-11D2-96F4-000000000000}\1  
  
 @="#6"  
  
 "TemplatesDir"="\<Visual Studio SDK installation path\\\VSIntegration\\\SomeFolder\\\SomePackage\\\SomeProject\\\SomeProjectItems"  
  
 "SortPriority"=dword:00000064  
  
|Name|Type|Data (from .rgs file)|Description|  
|----------|----------|-----------------------------|-----------------|  
|@ (Default)|REG_SZ|#%IDS_ADDITEM_TEMPLATES_ENTRY%|Resource ID for **Add Item** templates.|  
|Val TemplatesDir|REG_SZ|%TEMPLATE_PATH%\ SomeProjectItems|Path of the project items displayed in the dialog for the **Add New Item** wizard.|  
|Val SortPriority|REG_DWORD|100 ([!INCLUDE[vcprx64](../../includes/vcprx64-md.md)])|Determines the sort order in the tree node of files displayed in the **Add New Item** dialog box.|  
  
> [!NOTE]
> The GUIDS for the Visual C# and Visual Basic project types are as follows:[!INCLUDE[csprcs](../../includes/csprcs-md.md)]: {FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}[!INCLUDE[vbprvb](../../includes/vbprvb-md.md)]: {F184B08F-C81C-45F6-A57F-5ABD9991F28F}  
  
 The directory listed for TemplateDirs, which is %TEMPLATE_PATH%\SomeProjectItems, is the node on the left side of the **Add New Item** dialog box tree. Additional elements in the tree are based on the subdirectory within that root directory. The files available to be added to the project are the items in the right pane of the **Add New Item** dialog box.  
  
 Typically, this folder will contain the template files for your project such as a template HTML or .cpp file, and any .vsz files for starting wizards. To control how the items are displayed, you can also include .vsdir files for localizing directory names and icons. The localized string is the caption that appears in the dialog box that represents this node in the Add New Item dialog tree.  
  
 However, you do not have to have everything in one .vsdir file. You can have one .vsdir file for every item in the directory. For more information, see [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md) and [Template Directory Description (.Vsdir) Files](../../extensibility/internals/template-directory-description-dot-vsdir-files.md).  
  
> [!NOTE]
> The .vsdir files in the template directories are optional. If you just want to put a project element in the directory and display it in the **Add New Item** dialog box, you can put that file in the templates directory specified in the TemplatesDir statement. The file will then be displayed in the right pane of the **Add New Item** dialog box for that project. However, if you want to display a localized caption for the file or an icon, you must include at least one .vsdir file in the templates directory.  
  
## Grouping Project Items  
 If you want to contain template groups in folders in the **Add New Item** dialog box tree, you must have subdirectories under the root template directory with the items in them. When the **Add New Item** dialog box is displayed to users, they will also see the subfolders and be able to select project elements from them.  
  
 The sort priority in the code segment determines where this template directory will be created in the tree relative to other elements of the tree node. For the **Add New Item** dialog box, the sort priority is all that you must include so that your items will be displayed in the correct location in the dialog box.  
  
 You can also implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2> interface to filter what is displayed in the **Add New Item** dialog box. By implementing this interface, you can set up one template directory on disk that contains, for example, 50 template and wizard files. In that way, you can have different project types with 20 files that belong to one project type, the other 30 files that belong to another project type, and all the files available in a general type of project. In this manner, depending on which project template is created, you can display a different set of template files.  
  
 For example, in a Visual Basic project, you might have Web projects and client projects. Web forms are not useful items to add to a client project, and windows forms are not useful items to add to a Web server project. Therefore, you can create one template directory that contains all the files for both types of project. Then by implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>, you can hide items that should not be displayed based on the type of project or project settings in the project.  
  
## Filtering Project Items  
 `IVsFilterAddProjectItemDlg2` provides for filtering of elements in the tree (left pane) and project files (right pane) in the following ways:  
  
- By the localized names (captions displayed in the dialog box that is contained in the .vsdir file) provided by `IVsFilterAddProjectItemDlg`.  
  
- By the actual names of the files and folders on disk (non-localized — no .vsdir file) provided by `IVsFilterAddProjectItemDlg`.  
  
- By category, provided by `IVsFilterAddProjectItemDlg2`.  
  
  To filter by category, provide a category string to an item in the .vsdir file, such as "Web form" or "Client item" in Visual Basic. The dialog box code then retrieves the category classification from the .vsdir file and passes it to you. You can then pass that information to your implementation of `IVsFilterAddProjectItemDlg2` to filter the **Add New Item** dialog box by categories. You can also filter items for Web pages or as client Win32 application cases. Additionally, you can identify [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] tagged items as Microsoft Foundation Classes (MFC) or active template library (ATL) items. When you identify these items, the project system can define its own classifications so that the system can be filtered based on categories and classifications.  
  
  If you implement this filter functionality, you do not have to map a table of every item that should be hidden. You can simply classify items into types and put the classifications in the .vsdir file or files. Then you can hide any of the items that have a specific classification by implementing the interface. In this way, you can make the items in the **Add New Item** dialog box dynamic based on the state within the project.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>   
 [Registering Project and Item Templates](../../extensibility/internals/registering-project-and-item-templates.md)   
 [CATIDs for Objects That Are Typically Used to Extend Projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)   
 [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)   
 [Template Directory Description (.Vsdir) Files](../../extensibility/internals/template-directory-description-dot-vsdir-files.md)   
 [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)
