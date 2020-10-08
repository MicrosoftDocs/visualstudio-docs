---
title: "Wizard Support for Nested Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Add Item wizard"
  - "nested projects, wizard support"
  - "New Project wizard"
ms.assetid: 1b496acc-b326-4cdb-bb48-e3b5c6f12e05
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Wizard Support for Nested Projects
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The IDE runs two wizards that the parent project for nested projects can implement: the **New Project** wizard and the **Add Item** wizard.  
  
 If a user starts the **New Project** wizard by selecting **Add Project** and clicking **New Project** on the File menu or by selecting **Add** and right-clicking **New Project** in Solution Explorer, the IDE runs the **AddProject** command and the parent project's implementation of the **AddProject** command either returns a template project file, or a wizard (.vsz) file that has a set of context parameters.  
  
 Similarly, a parent project's implementation of **AddItem** wizards returns a .vsz file that has a different set of context parameters.  
  
 For more information about wizards, see [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md), [Context Parameters](../../extensibility/internals/context-parameters.md) and [Registering Project and Item Templates](../../extensibility/internals/registering-project-and-item-templates.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy>   
 [Nesting Projects](../../extensibility/internals/nesting-projects.md)
