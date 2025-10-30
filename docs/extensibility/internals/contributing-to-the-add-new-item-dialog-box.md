---
title: Contributing to the Add New Item Dialog Box
description: Learn how to contribute to the Add New Item dialog box in Visual Studio by registering Add Item templates under the Projects registry subkey.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Add New Item dialog box, contributing to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Contribute to the Add New Item dialog box

A project subtype can provide a complete new directory of items for the **Add New Item** dialog box by registering **Add Item** templates under the **Projects** registry subkey.

## Register Add New Item templates
 This section is located under **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects** in the registry. The registry entries below assume a Visual Studio project aggregated by a hypothetical project subtype. The entries for the Visual Studio project are listed below.

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

 The **AddItemTemplates\TemplateDirs** subkey contains registry entries with the path to the directory where items made available in the **Add New Item** dialog box are placed.

 The environment automatically loads all of the **AddItemTemplates** data under the **Projects** registry subkey. This data can include the data for base project implementations as well as the data for specific project subtype types. Each project subtype is identified by a project type **GUID**. The project subtype can specify that an alternate set of **Add Item** templates should be used for a particular flavored project instance by supporting the `VSHPROPID_ AddItemTemplatesGuid` enumeration from <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2> in <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> implementation to return the GUID value of the project subtype. If the `VSHPROPID_AddItemTemplatesGuid` property is not specified, the base project GUID is used.

 You can filter items in the **Add New Item** dialog box by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg> interface on the project subtype aggregator object. For example, a project subtype that implements a database project by aggregating a Visual Studio project, can filter the Visual Studio specific items from the **Add New Item** dialog box by implementing filtering, and in turn, can add database project-specific items by supporting `VSHPROPID_ AddItemTemplatesGuid` in <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A>. For more information on filtering and adding items to the **Add New Item** dialog box, see [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md).

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>
- [CATIDs for objects that are typically used to extend projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)
