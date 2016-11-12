---
title: "How to: Debug XAML with the Workflow Designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: d9305dbc-af62-4bdd-b03f-c54e3fe9ecc7
caps.latest.revision: 8
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
# How to: Debug XAML with the Workflow Designer
Workflows are defined in terms of XAML. The UI representation of workflow is built on top of the XAML tree defining the workflow. The debugging experience is similar to debugging workflows in the [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)]. For instance, while debugging XAML, the locals, watch, and threads windows work the same way as they do in [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] debugging. In addition, the call stack view during the XAML debugging is a line-based hierarchical view of the execution flow for the workflow.  
  
> [!NOTE]
>  If the XAML for a workflow is located in the same assembly as the activities, the assembly portion of the class names are not included. Without this portion of the class (activity) names, the XAML cannot be loaded at runtime. It is not recommended to define activities in the same namespace as the main project; otherwise, the XAML will need to be hand-edited after being edited in the designer.  
  
### To debug workflow XAML  
  
1.  Open a workflow or activity project in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
2.  Set a breakpoint on the activity or activities you want to debug as described in [How to: Set Breakpoints in Workflows](../workflow-designer/how-to-set-breakpoints-in-workflows.md).  
  
3.  Right-click the .xaml file that contains your workflow definition and select **View Code**. You will see a breakpoint displayed on the same line as the XAML element declaration of the activity that you set the breakpoint on in the design view.  
  
4.  Invoke the debugger as described in [How to: Invoke the Workflow Debugger](../workflow-designer/how-to-invoke-the-workflow-debugger.md).  
  
5.  When the code execution reaches one of your breakpoints, the XAML element associated with that breakpoint will be highlighted. To move to the next breakpoint, use the **F10** or **F11** key.  
  
## See Also  
 [How to: Set Breakpoints in Workflows](../workflow-designer/how-to-set-breakpoints-in-workflows.md)   
 [How to: Invoke the Workflow Debugger](../workflow-designer/how-to-invoke-the-workflow-debugger.md)