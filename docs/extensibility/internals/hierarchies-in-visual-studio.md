---
title: "Hierarchies in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "hierarchies, Visual Studio IDE"
  - "IDE, hierarchies"
ms.assetid: 0a029a7c-79fd-4b54-bd63-bd0f21aa8d30
caps.latest.revision: 14
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Hierarchies in Visual Studio
The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) displays a project as a *hierarchy*. In the IDE, a hierarchy is a tree of nodes, where each node has a set of associated properties. A *project hierarchy* is a container that holds the project's items, the items' relationships, and the items' associated properties and commands.  
  
 In [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you manage project hierarchies by using the hierarchy interface, <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface redirects commands you invoke from project items to the appropriate hierarchy window instead of the standard command handler.  
  
## Project Hierarchies  
 Each project hierarchy contains items that you can view and edit. These items vary depending on project type. For example, a database project might contain stored procedures, database views, and database tables. A programming-language project, on the other hand, will likely include source files and resource files for bitmaps and dialog boxes. Hierarchies can be nested, which gives you some added flexibility when you create a project hierarchy.  
  
 When you create a new project type, the project type controls the complete set of items that can be edited in it. However, projects can contain items for which they do not have editing support. For example, Visual C++ projects can contain HTML files, even though Visual C++ does not provide any customized editor for the HTML file type.  
  
 Hierarchies manage the persistence of items they contain. The implementation of the hierarchy must control any special properties that affect the persistence of the items within the hierarchy. For example, if the items represent objects in a repository instead of files, the hierarchy implementation must control the persistence of those objects. The IDE itself directs the hierarchy to save the items in compliance with user input, but the IDE does not control any actions required to save those items. Instead, the project is in control.  
  
 When a user opens an item in an editor, the hierarchy that controls that item is selected and becomes the active hierarchy. The selected hierarchy determines the set of commands available to act on the item. Tracking user focus in this manner enables the hierarchy to reflect the user's current context.  
  
## See Also  
 [Project Types](../../extensibility/internals/project-types.md)   
 [Selection and Currency in the IDE](../../extensibility/internals/selection-and-currency-in-the-ide.md)   
 [VSSDK Samples](../../misc/vssdk-samples.md)