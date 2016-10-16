---
title: "Commands and Menus That Use Interop Assemblies"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "menus, using interop assemblies"
  - "interop assemblies, using in commands and menus"
  - "commands, handling using interop assemblies"
  - "command handling with interop assemblies"
ms.assetid: 8f4af525-39e5-4e69-92c8-d3efabe80bb2
caps.latest.revision: 13
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
# Commands and Menus That Use Interop Assemblies
A VSPackage that implements menu and toolbar commands by using interop assemblies must:  
  
-   Inform the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] integrated development environment (IDE) about the commands it supports and whether they are currently enabled.  
  
-   Adhere to the rules (contract) for handling commands.  
  
-   Explicitly implement command handling by using either the \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> or \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface.  
  
 The following describes how to do these tasks.  
  
## In This Section  
 [Determining Command Status By Using Interop Assemblies](../extensibility/determining-command-status-by-using-interop-assemblies.md)  
 Describes how a VSPackage notifies the IDE about which commands it supports and whether they are currently enabled.  
  
 [Command Contracts in Interop Assemblies](../extensibility/command-contracts-in-interop-assemblies.md)  
 Provides a definition of the basic command contract used by all VSPackages implementing commands using interop assemblies  
  
 [Implementation](../extensibility/command-implementation.md)  
 Provides an overview of how a VSPackage implements a command.  
  
 [Registering Interop Assembly Command Handlers](../extensibility/registering-interop-assembly-command-handlers.md)  
 Describes the registry entries required to notify the IDE that a VSPackage provides a command handler.  
  
## Related Sections  
 [Availability](../extensibility/command-availability.md)  
 Describes criteria that are used by the IDE to determine which VSPackage commands are available and what object handles them.  
  
 [How VSPackages Add User Interface Elements](../extensibility/how-vspackages-add-user-interface-elements.md)  
 Provides details about how to create a UI that uses [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command support.  
  
 [Command Routing in VSPackages](../extensibility/command-routing-in-vspackages.md)  
 An overview of the process used to relate an object with the correct command request.