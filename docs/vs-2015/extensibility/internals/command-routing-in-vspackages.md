---
title: "Command Routing in VSPackages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "commands, routing"
  - "command routing, Visual Studio SDK"
ms.assetid: a9c7f9ae-3594-4557-a314-8cf76f5f8772
caps.latest.revision: 25
ms.author: gregvanl
manager: jillfra
---
# Command Routing in VSPackages
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A command is routed in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] based on the context in which it is executed. It is routed from the initial context outward to the global context.  
  
## In This Section  
 [Routing Algorithm](../../extensibility/internals/command-routing-algorithm.md)  
 Describes the order of command routing resolution.  
  
 [Availability](../../extensibility/internals/command-availability.md)  
 Discusses command routing.  
  
 [Commands and Menus That Use Interop Assemblies](../../extensibility/internals/commands-and-menus-that-use-interop-assemblies.md)  
 Discusses considerations in routing commands between managed code and COM.  
  
## Related Sections  
 [Selection Context Objects](../../extensibility/internals/selection-context-objects.md)  
 Discusses the model for how you can determine the user's selection context focus on a window.  
  
 [Commands, Menus, and Toolbars](../../extensibility/internals/commands-menus-and-toolbars.md)  
 Explains how to create a UI that includes menus, toolbars, and command combo boxes.
