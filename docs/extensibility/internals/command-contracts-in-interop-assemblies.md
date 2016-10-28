---
title: "Command Contracts in Interop Assemblies"
ms.custom: ""
ms.date: "10/28/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "command handling with interop assemblies, command contracts"
  - "interop assemblies, command contracts"
ms.assetid: 57245708-f539-42dc-8963-2754a48f0189
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
# Command Contracts in Interop Assemblies
The basic contract for handling commands through the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface is that the environment calls the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus*> method to determine whether the command is supported and, if it is supported, to determine its state and text. Then, the environment calls the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec*> method to execute the command.  
  
 The <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus*> method is handled identically for all commands. Further communication, if required (for example, with drop-down lists), is managed by calling the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec*> method with appropriate parameters. The interpretation of these parameters depends on the command specified.  
  
 If the command target returns values in the output parameter, the caller is always responsible for freeing any resources that had been allocated. Because this parameter is a variant, clearing the variant frees the resources.  
  
 In cases where commands must operate within a hierarchy window, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface must be used. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface has a similar contract with similar methods: <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand*> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand*>.  
  
## See Also  
 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Command Routing in VSPackages](../../extensibility/internals/command-routing-in-vspackages.md)   
 [Implementation](../../extensibility/internals/command-implementation.md)