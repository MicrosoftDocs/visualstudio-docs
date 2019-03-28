---
title: "Adding Project and Project Item Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "projects [Visual Studio SDK], adding"
  - "project items [Visual Studio], adding"
ms.assetid: 8c59217f-56e5-4540-a73b-cd10de189373
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Adding Project and Project Item Templates
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

When you create your own project types, you must provide support for adding new projects and project items by using the standard [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] integrated development environment (IDE) dialog boxes. The following topics discuss different techniques for adding projects and project items.  
  
## In This Section  
 [Project Context](../../extensibility/internals/project-context.md)  
 Explains that the project provides most of the context information for what transpires in the environment.  
  
 [Project Priority](../../extensibility/internals/project-priority.md)  
 Explains that a project item is usually a member of one project to help avoid ambiguity about which project is used to open the item.  
  
 [Miscellaneous Files Project](../../extensibility/internals/miscellaneous-files-project.md)  
 Provides information about the two types of editors that can be used to open files in a project and the role the project plays in determining which editor to use when a project item is opened.  
  
 [Registering Project and Item Templates](../../extensibility/internals/registering-project-and-item-templates.md)  
 Explains what occurs when a [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] project is created.  
  
 [Adding Items to the Add New Item Dialog Boxes](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)  
 Explains the process for adding items to the **Add New Item** dialog box.  
  
 [Adding Directories to the New Project Dialog Box](../../extensibility/internals/adding-directories-to-the-new-project-dialog-box.md)  
 Provides an example of registering a new directory that contains custom templates made available by a VSPackage.  
  
 [Adding Directories to the Add New Item Dialog Box](../../extensibility/internals/adding-directories-to-the-add-new-item-dialog-box.md)  
 Provides an example of registering a new set of directories for the **Add New Item** dialog box.  
  
 [IDE-Defined Commands for Extending Project Systems](../../extensibility/internals/ide-defined-commands-for-extending-project-systems.md)  
 Lists different types of command items used for extending project systems.  
  
 [CATIDs for Objects That Are Typically Used to Extend Projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)  
 Lists CATIDs for objects that are used to extend [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)], [!INCLUDE[csprcs](../../includes/csprcs-md.md)], and [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] project systems.  
  
## Related Sections  
 [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md)  
 Provides step-by-step instructions for opening an item intrinsically bound to a specific editor for a project.  
  
 [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md)  
 Provides step-by-step instructions for opening a standard editor.  
  
 [Project Subtypes](../../extensibility/internals/project-subtypes.md)  
 Provides links to project subtype conceptual topics. Project subtypes extend existing [!INCLUDE[csprcs](../../includes/csprcs-md.md)] and [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] projects.  
  
 [Project Types](../../extensibility/internals/project-types.md)  
 Provides links to additional topics that offer information about how to design new project types.
