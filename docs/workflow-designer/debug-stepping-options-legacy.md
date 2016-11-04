---
title: "Debug Stepping Options (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "branch stepping"
  - "stepping, options in workflow debugging"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "instance stepping"
ms.assetid: 3e9e3041-68c7-4f16-9bd6-da5e5144744b
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
# Debug Stepping Options (Legacy)
This topic describes how to debug [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that have concurrent activities in the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of the following two options to step through your code.  
  
-   **Branch stepping.** This mode of stepping enables you to step through and debug a particular branch of a composite activity, such as the **ParallelActivity** or the **ConditionalActivityGroup** activity. When you use this option to debug, you will not notice that a change in control occurs due to concurrent execution of other activities in the workflow. The debugger only steps through the activities in the currently selected branch while other activities in the workflow may be executing concurrently. For example, by default, the leftmost branch in a **ParallelActivity** activity and the first child activity of a **ConditionedActivityGroup** activity are used for stepping. If the user is interested in debugging any other branch or child activity, an explicit breakpoint must be placed on that branch or child activity. Stepping continues in that branch when the breakpoint is triggered.  
  
-   **Instance stepping.** This mode of stepping enables you to step through and debug concurrently executing activities in the workflow. With this option, you will notice that a change in control occurs when concurrently executing activities run within the workflow.  
  
 By default, the branch stepping option is selected, and users can switch between the two options while debugging a legacy workflow.  
  
 You should select the instance stepping option when debugging legacy state machine workflows.  
  
## See Also  
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)   
 [How to: Change the Debug Stepping Option (Legacy)](../workflow-designer/how-to-change-the-debug-stepping-option-legacy.md)