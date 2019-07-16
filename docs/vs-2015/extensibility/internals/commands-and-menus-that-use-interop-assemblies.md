---
title: "Commands and Menus That Use Interop Assemblies | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "menus, using interop assemblies"
  - "interop assemblies, using in commands and menus"
  - "commands, handling using interop assemblies"
  - "command handling with interop assemblies"
ms.assetid: 8f4af525-39e5-4e69-92c8-d3efabe80bb2
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Commands and Menus That Use Interop Assemblies
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A VSPackage that implements menu and toolbar commands by using interop assemblies must:  
  
- Inform the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] integrated development environment (IDE) about the commands it supports and whether they are currently enabled.  
  
- Adhere to the rules (contract) for handling commands.  
  
- Explicitly implement command handling by using either the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface.  
  
  The following describes how to do these tasks.  
  
## In This Section  
 [Determining Command Status By Using Interop Assemblies](../../extensibility/internals/determining-command-status-by-using-interop-assemblies.md)  
 Describes how a VSPackage notifies the IDE about which commands it supports and whether they are currently enabled.  
  
 [Command Contracts in Interop Assemblies](../../extensibility/internals/command-contracts-in-interop-assemblies.md)  
 Provides a definition of the basic command contract used by all VSPackages implementing commands using interop assemblies  
  
 [Implementation](../../extensibility/internals/command-implementation.md)  
 Provides an overview of how a VSPackage implements a command.  
  
 [Registering Interop Assembly Command Handlers](../../extensibility/internals/registering-interop-assembly-command-handlers.md)  
 Describes the registry entries required to notify the IDE that a VSPackage provides a command handler.  
  
## Related Sections  
 [Availability](../../extensibility/internals/command-availability.md)  
 Describes criteria that are used by the IDE to determine which VSPackage commands are available and what object handles them.  
  
 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)  
 Provides details about how to create a UI that uses [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] command support.  
  
 [Command Routing in VSPackages](../../extensibility/internals/command-routing-in-vspackages.md)  
 An overview of the process used to relate an object with the correct command request.
