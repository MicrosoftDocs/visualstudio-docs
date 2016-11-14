---
title: "Sequential Workflow Views (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "sequential workflow views"
  - "sequential workflows, views"
ms.assetid: 135f24b9-1b37-442b-9ef8-f0f2108a3212
caps.latest.revision: 7
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
# Sequential Workflow Views (Legacy)
[!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] provides a legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] that can be used to target the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 The [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] provides a way to graphically create [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications using the familiar [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] user interface. [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications are composed of workflow process steps called activities. To create a workflow, compose activities on the design surface by dragging their respective activity designers from **Toolbox** onto the design surface.  
  
 When you create a sequential workflow, which is a [SequentialWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65040), three views of the workflow are available. These views are accessible from the **Workflow** menu and from the context menu on the design surface.  
  
 The following table lists the name and description of each view.  
  
|Menu/Tab Option|Description|  
|----------------------|-----------------|  
|**View SequentialWorkflow**|Right-click the design surface and select the **View SequentialWorkflow** option from the context menu to display the **Sequential Workflow** view, which shows the activity-based graphical representation of the sequential workflow. Or select **View SequentialWorkflow** from the **Workflow** menu.|  
|**View Cancel Handler**|Right-click the design surface and select the **View Cancel Handler** option from the context menu to display the **Sequential Workflow** view, which shows the [CancellationHandlerActivity](http://go.microsoft.com/fwlink?LinkID=65050) activity associated with the workflow. Or select **View Cancel Handler** from the **Workflow** menu.|  
|**View Fault Handler**|Right-click the design surface and select the **View Fault Handler** option from the context menu to display the **Faults** view, which shows the [FaultHandlersActivity](http://go.microsoft.com/fwlink?LinkID=65055) activity associated with the workflow. Or select **View Fault Handler** from the **Workflow** menu.|  
  
 For more information about similar views, see [Activity Views (Legacy)](../workflow-designer/activity-views-legacy.md).  
  
## See Also  
 [Activity Views (Legacy)](../workflow-designer/activity-views-legacy.md)   
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)   
 [Workflow Authoring Modes](http://go.microsoft.com/fwlink?LinkID=65014)