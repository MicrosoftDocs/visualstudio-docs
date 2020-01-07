---
title: "Debugging Workflows from a Remote Computer (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, debugging remotely"
  - "debugging workflows, remotely"
  - "remote debugging, workflows"
  - "debugging, remote"
ms.assetid: 44eaec8f-9959-4ae7-a374-670946f933c1
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Debugging Workflows from a Remote Computer (Legacy)
This topic describes how to debug remote legacy [!INCLUDE[wf](../includes/wf-md.md)] applications that are built with the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when your application needs to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 When you install [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)], one of the component installation options is to install the [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)] Debugger for [!INCLUDE[wf](../includes/wf-md.md)]. This installs the remote debugging components. These remote debugging components must be installed on the computer that you are targeting for remote workflow debugging.

 Additionally, the assembly that contains the workflow definition of the legacy workflow that you are debugging on a remote computer must be installed in the global assembly cache (GAC) of the local computer that you are debugging from. For example, if a legacy workflow is running on a remote computer A, and you are debugging it from local computer B, the workflow definition must be present in the GAC of computer B. This enables the designer to deserialize and display on computer B the workflow markup of the workflow that is running remotely on computer A. For more information about the global assembly cache, see the MSDN Library.

 [!INCLUDE[wf2](../includes/wf2-md.md)] remote debugging functions the same as remote debugging for other [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] components. For more information, see [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)] Remote Debugging in the MSDN Library.

## See Also
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)