---
title: "Modifying the Isolated Shell By Using the .Vsct File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode%2C .vsct file"
ms.assetid: 6d147c2d-10e9-400e-b8ce-5566287b41ba
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Modifying the Isolated Shell By Using the .Vsct File
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The UI project for a Visual Studio isolated shell project contains a .vsct file that lets you specify which application groups and individual commands are available in the application. The following is an excerpt from an unmodified .vsct file.  
  
```  
<!-- <Define name="No_WindowListCommand"/> -->  
<!-- <Define name="No_MoreWindowsCommand"/> -->  
<!-- <Define name="No_PaneNextPaneCommand"/> -->  
<!-- <Define name="No_PanePrevPaneCommand"/> -->  
```  
  
 By default, most commands and command groups are included. To exclude a command or command group, simply uncomment that command or group.  
  
 For example, to remove the next pane and previous pane commands, uncomment the `No_PaneNextPaneCommand` and `No_PanePrevPaneCommand` entries:  
  
```  
  
<Define name="No_PaneNextPaneCommand"/> <Define name="No_PanePrevPaneCommand"/>  
  
```  
  
 For a more detailed example these customizations, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
## Referenced Files  
 The default .vsct file for an application references the following files. These files are located in the \VisualStudioIntegration\Common\Inc\ subdirectory of the Visual Studio SDK installation directory.  
  
|File|Description|  
|----------|-----------------|  
|wbids.h|UI identities for the Web Browse package.|  
|AppIDCmdUsed.vsct|Command table for primary Visual Studio UI elements.|  
|EmulatorCmdUsed.vsct|Command table for Emacs and Brief editor emulation UI elements.|  
|Vsdebugguids.h|Defines the GUIDs of the commands, options page, and other features of the Visual Studio debugger.|  
|VsDbgCmdUsed.vsct|Command table for the debugger.|  
  
 The AppIDCmdUsed.vsct file includes Visual Studio UI elements based on the symbols defined in the application .vsct file.  
  
 For more information, see [Designing XML Command Table (.Vsct) Files](../extensibility/internals/designing-xml-command-table-dot-vsct-files.md) and the [VSCT XML Schema Reference](../extensibility/vsct-xml-schema-reference.md).  
  
## See Also  
 [Visual Studio Isolated Shell](../extensibility/visual-studio-isolated-shell.md)
