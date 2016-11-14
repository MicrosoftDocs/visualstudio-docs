---
title: "Debugging Workflows from a Remote Computer (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "workflows, debugging remotely"
  - "debugging workflows, remotely"
  - "remote debugging, workflows"
  - "debugging, remote"
ms.assetid: 44eaec8f-9959-4ae7-a374-670946f933c1
caps.latest.revision: 6
author: "ErikRe"
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
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
# Debugging Workflows from a Remote Computer (Legacy)
This topic describes how to debug remote legacy [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that are built with the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when your application needs to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 When you install [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)], one of the component installation options is to install the [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)] Debugger for [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)]. This installs the remote debugging components. These remote debugging components must be installed on the computer that you are targeting for remote workflow debugging.  
  
 Additionally, the assembly that contains the workflow definition of the legacy workflow that you are debugging on a remote computer must be installed in the global assembly cache (GAC) of the local computer that you are debugging from. For example, if a legacy workflow is running on a remote computer A, and you are debugging it from local computer B, the workflow definition must be present in the GAC of computer B. This enables the designer to deserialize and display on computer B the workflow markup of the workflow that is running remotely on computer A. For more information about the global assembly cache, see the MSDN Library.  
  
 [!INCLUDE[wf2](../workflow-designer/includes/wf2_md.md)] remote debugging functions the same as remote debugging for other [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] components. For more information, see [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)] Remote Debugging in the MSDN Library.  
  
## See Also  
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)