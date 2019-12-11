---
title: "Determining Command Status By Using Interop Assemblies | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "interop assemblies, determining command status"
  - "command handling with interop assemblies, status"
ms.assetid: 2f5104d1-7b4c-4ca0-a626-50530a8f7f5c
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Determining Command Status By Using Interop Assemblies
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A VSPackage must keep track of the state of the commands it can handle. The environment cannot determine when a command handled within your VSPackage becomes enabled or disabled. It is the responsibility of your VSPackage to inform the environment about command states, for example, the state of general commands such as **Cut**, **Copy**, and **Paste**.  
  
## Status Notification Sources  
 The environment receives information about commands through the VSPackages' <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method, which is part of the VSPackage's implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. The environment calls the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method of the VSPackage under two conditions:  
  
- When a user opens a main menu or a context menu (by right-clicking), the environment executes the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method on all of the commands on that menu to determine their state.  
  
- When the VSPackage requests that the environment update the current user interface (UI). This occurs as commands that are currently visible to the user, such as the **Cut**, **Copy**, and **Paste** grouping on the standard toolbar, become enabled and disabled in response to context and user actions.  
  
  Since the shell hosts multiple VSPackages, the shell's performance would unacceptably degrade if it were required to poll each VSPackage to determine command status. Instead, your VSPackage should actively notify the environment when its UI changes at the time of the change. For more information on update notification, see [Updating the User Interface](../../extensibility/updating-the-user-interface.md).  
  
## Status Notification Failure  
 Failure of your VSPackage to notify the environment of a command state change can place the UI in an inconsistent state. Remember that any of your menu or context menu commands can be placed on a toolbar by the user. Therefore, updating the UI only when a menu or context menu opens is not enough.  
  
## See Also  
 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Implementation](../../extensibility/internals/command-implementation.md)
