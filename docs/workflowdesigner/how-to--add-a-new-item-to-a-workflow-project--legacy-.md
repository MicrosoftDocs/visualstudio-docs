---
title: "How to: Add a New Item to a Workflow Project (Legacy)"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
helpviewer_keywords: 
  - "sequential workflows, adding to workflow projects"
  - "workflows, adding new items"
  - "state machine workflows, adding to workflow projects"
  - "activities, adding to workflow projects"
ms.assetid: 130cd83d-942d-437b-bbb5-8088ec0a6d79
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
# How to: Add a New Item to a Workflow Project (Legacy)
After you have created a workflow project using the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] provided by [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)] that targets either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)], you can add [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] items and other familiar [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] items to your project.  
  
 The following table lists the [!INCLUDE[wf2](../workflowdesigner/includes/wf2_md.md)] items that you can add to a workflow project.  
  
|Item|Description|  
|----------|-----------------|  
|Activity|An activity with the activity definition in a designer code file and user code in a separate code file.|  
|Activity (with code separation)|An activity definition expressed as workflow markup and user code in a separate code file.|  
|Sequential Workflow (code)|A sequential workflow with the workflow definition in a designer code file and user code in a separate code file.|  
|Sequential Workflow (with code separation)|A sequential workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|  
|State Machine Workflow (code)|A state machine workflow with the workflow definition in a designer code file and user code in a separate code file.|  
|State Machine Workflow (with code separation)|A state machine workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|  
  
### To add a new item to a workflow project  
  
1.  On the **Project** menu, click **Add a New Item**.  
  
     The **Add a New Item** dialog box opens.  
  
2.  Select an item.  
  
     The previous table lists the available Windows Workflow Foundation selections.  
  
3.  Click **Add** to add the item to the workflow project.  
  
## See Also  
 [Creating Legacy Workflow Projects](../workflowdesigner/creating-legacy-workflow-projects.md)