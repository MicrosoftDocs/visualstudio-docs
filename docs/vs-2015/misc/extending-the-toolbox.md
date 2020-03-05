---
title: "Extending the Toolbox | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "tools [Visual Studio], Toolbox"
  - "Toolbox [Visual Studio SDK]"
ms.assetid: bb84a79e-cd4c-4a58-8871-2513e7119b6e
caps.latest.revision: 38
manager: jillfra
---
# Extending the Toolbox
The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] **Toolbox** provides a collection of objects that provide functionality to editors and designers through the IDE's drag-and-drop mechanism.  
  
 There are two basic ways in which a VSPackage works with the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] **Toolbox**:  
  
- A VSPackage can add new data items and controls to the **Toolbox**.  
  
- A VSPackage can be a target or consumer of existing **Toolbox** functionality, supporting the drag-and-drop operations and configuring the **Toolbox**'s appearance.  
  
## In This Section  
 [How to: Create a Toolbox Control That Uses Windows Forms](../misc/how-to-create-a-toolbox-control-that-uses-windows-forms.md)  
 Describes out to create a Toolbox control by using the Windows Forms Toolbox Control template.  
  
 [Creating a WPF Toolbox Control](../extensibility/creating-a-wpf-toolbox-control.md)  
 Describes out to create a Toolbox control by using the WPF Toolbox Control template.  
  
 [Managing the Toolbox](../misc/managing-the-toolbox.md)  
 Describes how a VSPackage can manage the content and appearance of the **Toolbox**.  
  
## Related Sections  
 [How to: Manage the Toolbox Window](https://msdn.microsoft.com/a022c3fe-298c-4a59-a48f-b050da90ebc2)  
 Describes how to work with the **Toolbox** in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE).  
  
 [How to: Control the Toolbox](https://msdn.microsoft.com/library/c9d8a18a-d2bc-43d4-a803-601bfc6a6599)  
 Describes how to manage the **Toolbox** using the automation programming model.  
  
 [Extending Other Parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)  
 Explains how to use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] services to create UI elements that match the rest of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].