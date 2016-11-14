---
title: "How to: Change the Debug Stepping Option (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "branch stepping"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "stepping, changing options"
  - "instance stepping"
ms.assetid: aedc06af-d58a-44d6-aee4-f397f1f923a0
caps.latest.revision: 5
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
# How to: Change the Debug Stepping Option (Legacy)
This topic describes how to change the debug stepping option for [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications in the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] that have concurrent actions. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of two options to step through your code.  
  
 Follow these steps to change the debug stepping option in your legacy workflow project.  
  
## Procedures  
  
#### To change the debug stepping option  
  
1.  Start Visual Studio.  
  
2.  Open an existing legacy workflow project or create a new project that employs concurrent activities and that targets either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
3.  On the **Workflow** menu in the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)], point to **Debug**, and then point to **Stepping Options**.  
  
4.  Select either **Instance** or **Branch**.  
  
## See Also  
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)   
 [Debug Stepping Options (Legacy)](../workflow-designer/debug-stepping-options-legacy.md)