---
title: "How to: Change the Debug Stepping Option (Legacy)"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
helpviewer_keywords: 
  - "branch stepping"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "stepping, changing options"
  - "instance stepping"
ms.assetid: aedc06af-d58a-44d6-aee4-f397f1f923a0
caps.latest.revision: 5
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
This topic describes how to change the debug stepping option for [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] applications in the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] that have concurrent actions. Use the legacy [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)].  
  
 When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of two options to step through your code.  
  
 Follow these steps to change the debug stepping option in your legacy workflow project.  
  
## Procedures  
  
#### To change the debug stepping option  
  
1.  Start Visual Studio.  
  
2.  Open an existing legacy workflow project or create a new project that employs concurrent activities and that targets either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)].  
  
3.  On the **Workflow** menu in the legacy [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)], point to **Debug**, and then point to **Stepping Options**.  
  
4.  Select either **Instance** or **Branch**.  
  
## See Also  
 [Debugging Legacy Workflows](../workflowdesigner/debugging-legacy-workflows.md)   
 [Debug Stepping Options (Legacy)](../workflowdesigner/debug-stepping-options--legacy-.md)