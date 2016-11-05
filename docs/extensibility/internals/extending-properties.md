---
title: "Extending Properties | Microsoft Docs"
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
  - "Properties window, providing support"
ms.assetid: 68e2cbd4-861c-453f-8c9f-4ab6afc80e67
caps.latest.revision: 18
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
# Extending Properties
The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] **Properties** window is a universal property browser for COM and COM+ components and supports all [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] products. The **Properties** window works with `ITypeInfo` type information and COM+ metadata to list the design-time properties for the currently selected object in any other window in the integrated development environment (IDE).  
  
 The **Properties** window, which can be opened by pressing F4 on the keyboard, or selecting **Properties Window** on the **View** menu, is used to view and edit configuration-independent, design-time properties and events of selected objects. Configuration-dependent properties, associated with solutions and projects, are displayed on [Property Pages](../../extensibility/internals/property-pages.md). For more information, see [NIB:Project Properties](http://msdn.microsoft.com/en-us/fb126574-24ad-4c96-9b2b-6e1f3879ba50), [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md), and [NIB:Item Management in Projects](http://msdn.microsoft.com/en-us/762e606b-7f44-4b66-97a1-e30a703654a0).  
  
 ![Properties Window Overview](../../extensibility/internals/media/vspropertieswindow.png "vsPropertiesWindow")  
Properties window  
  
 This section provides detailed information that relates to the individual areas of the **Properties** window and the interfaces that you must implement and call to populate the window.  
  
## In This Section  
 [Properties Window Overview](../../extensibility/internals/properties-window-overview.md)  
 Explains the purpose of the **Properties** window relative to the tool window and the document window.  
  
 [Template Policy and the Properties Window](../../extensibility/internals/template-policy-and-the-properties-window.md)  
 Discusses how a project is contained in an enterprise template project, and how that enterprise template project can enforce policy.  
  
 [Properties Window Fields and Interfaces](../../extensibility/internals/properties-window-fields-and-interfaces.md)  
 Explains the basis for selection that determines what information is displayed in the **Properties** window.  
  
 [Properties Window Object List](../../extensibility/internals/properties-window-object-list.md)  
 Describes the purpose of the **Properties** window object list, describing how, when a different object from this list triggers a call, the environment is informed that a new object has been selected.  
  
 [Properties Window Buttons](../../extensibility/internals/properties-window-buttons.md)  
 Explains the purpose of the four default buttons displayed on the **Properties** window toolbar.  
  
 [Properties Display Grid](../../extensibility/internals/properties-display-grid.md)  
 Explains where the property names and property values fields are found in the grid.  
  
 [Announcing Property Window Selection Tracking](../../misc/announcing-property-window-selection-tracking.md)  
 Describes selection tracking for the **Properties** window.  
  
 [Hiding Properties That Have Child Properties](../../misc/hiding-properties-that-have-child-properties.md)  
 Explains how to hide properties that have child properties by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing> interface.  
  
 [Providing a Custom Properties Window](../../misc/providing-a-custom-properties-window.md)  
 Details the steps for providing your own property browser.  
  
 [Getting Field Descriptions from the Properties Window](../../misc/getting-field-descriptions-from-the-properties-window.md)  
 Explains where to find the description area that displays information related to the selected property field.  
  
 [Updating Property Values in the Properties Window](../../misc/updating-property-values-in-the-properties-window.md)  
 Provides step-by-step instructions that show the two ways to keep the **Properties** window synchronized with property value changes.  
  
## Related Sections  
 [Project Types](../../extensibility/internals/project-types.md)  
 Discusses projects as the building blocks of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE.  
  
 [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)  
 Describes how you can use the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Platform for continuously testing and debugging applications as you build them.  
  
 [HTML Document Properties, Properties Window](../Topic/HTML%20Document%20Properties,%20Properties%20Window.md)  
 Provides instructions for editing an HTML document directly from the Properties window, and provides a table detailing the fields in an HTML document in the Properties window.  
  
 [IDispatch](http://msdn.microsoft.com/en-us/ebbff4bc-36b2-4861-9efa-ffa45e013eb5)  
 Describes the `IDispatch` interface, which was first designed to support automation, providing a late-bound mechanism to access and retrieve information about the methods and properties of an object.  
  
 [NIB: Introduction to Dynamic Properties (Visual Studio)](http://msdn.microsoft.com/en-us/f5102027-1431-4195-ae40-9b991de46d3a)  
 Provides an overview of dynamic properties that let you configure your application so that property values are stored in an external configuration file instead of the application's compiled code.  
  
 [NIB:Projects as Containers](http://msdn.microsoft.com/en-us/87d40f63-f487-4767-8963-64beec27ba1b)  
 Describes the role of the project as a container in a solution to logically manage, build, and debug the items that make up your application.  
  
 [NIB:Project Properties](http://msdn.microsoft.com/en-us/fb126574-24ad-4c96-9b2b-6e1f3879ba50)  
 Describes how the project manages settings that let you control properties that apply to the whole project and also properties that are limited to certain build configurations of the project.  
  
 [Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)  
 Explains how [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] efficiently manages the items such as references, data connections, folders, and files that are required by your development effort through solutions and projects.  
  
 [Extending Other Parts of Visual Studio](../../extensibility/extending-other-parts-of-visual-studio.md)  
 Explains how to use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] services to create UI elements that match the rest of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].