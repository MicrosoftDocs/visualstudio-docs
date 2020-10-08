---
title: "Contributing to the Add New Item Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Add New Item dialog box, contributing to"
ms.assetid: b2e53175-9372-4d17-8c2b-9264c9e51e9c
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Contributing to the Add New Item Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A project subtype can provide a complete new directory of items for the **Add New Item** dialog box by registering **Add Item** templates under the `Projects` registry subkey.  
  
## Registering Add New Item Templates  
 This section is located under **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects** in the registry. The registry entries below assume a [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] project aggregated by a hypothetical project subtype. The entries for the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] project are listed below.  
  
```  
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects\{F184B08F-C81C-45F6-A57F-5ABD9991F28F}]  
@="#2143"  
"DefaultProjectExtension"="vbproj"  
"PossibleProjectExtensions"="vbproj;vbp"  
"ProjectTemplatesDir"="visualStudioInstallPath\\Vb\\.\\VBProjects"  
  
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects\{F184B08F-C81C-45F6-A57F-5ABD9991F28F}\AddItemTemplates\TemplateDirs\{12345678-1234-1234-1122334455667788}\/1]  
@="#100"  
"TemplatesDir"="projectSubTypeTemplatesDir\\VBProjectItems"  
```  
  
 The `AddItemTemplates\TemplateDirs` subkey contains registry entries with the path to the directory where items made available in the **Add New Item** dialog box are placed.  
  
 The environment automatically loads all of the `AddItemTemplates` data under the `Projects` registry subkey. This can include the data for base project implementations as well as the data for specific project subtype types. Each project subtype is identified by a project type `GUID`. The project subtype can specify that an alternate set of `Add Item` templates should be used for a particular flavored project instance by supporting the `VSHPROPID_ AddItemTemplatesGuid` enumeration from <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2> in <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> implementation to return the GUID value of the project subtype. If `VSHPROPID_AddItemTemplatesGuid` property is not specified, the base project GUID is used.  
  
 You can filter items in the **Add New Item** dialog box by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg> interface on the project subtype aggregator object. For example, a project subtype that implements a database project by aggregating a [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] project, can filter the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] specific items from the **Add New Item** dialog box by implementing filtering, and in turn, can add database project specific items by supporting `VSHPROPID_ AddItemTemplatesGuid` in <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A>. For more information on filtering and adding items to the **Add New Item** dialog box, see [Adding Items to the Add New Item Dialog Boxes](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>   
 [CATIDs for Objects That Are Typically Used to Extend Projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)
